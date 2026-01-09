using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class UcTakvim : DevExpress.XtraEditors.XtraUserControl
    {
        public int OgretmenID = 0; // 0 ise Yönetici
        DataTable dtTakvim;

        // Varsayılan Mesai Saatleri
        int mesaiBaslangic = 9;
        int mesaiBitis = 19;

        public UcTakvim()
        {
            InitializeComponent();
        }

        private void UcTakvim_Load(object sender, EventArgs e)
        {
            // Renklendirme Eventini Bağla
            gridViewTakvim.RowCellStyle += GridViewTakvim_RowCellStyle;

            // Hücre seçim renginin bizim rengimizi ezmemesi için
            gridViewTakvim.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewTakvim.OptionsSelection.EnableAppearanceFocusedRow = false;

            // Mesai Saatlerini Çek
            AyarlariGetir();

            // Eğer tarih seçili değilse bugünü seç (Bu işlem EditValueChanged tetikler ve doldurur)
            if (dateTarih.EditValue == null)
                dateTarih.DateTime = DateTime.Now;
        }

        void AyarlariGetir()
        {
            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT MesaiBaslama, MesaiBitis FROM Tbl_Ayarlar WHERE ID=1");
                if (dt.Rows.Count > 0)
                {
                    string baslama = dt.Rows[0]["MesaiBaslama"].ToString(); // Örn: "09:00"
                    string bitis = dt.Rows[0]["MesaiBitis"].ToString();     // Örn: "18:00"

                    if (!string.IsNullOrEmpty(baslama))
                    {
                        if (baslama.Contains(":"))
                            mesaiBaslangic = Convert.ToInt32(baslama.Split(':')[0]);
                        else
                            mesaiBaslangic = Convert.ToInt32(baslama);
                    }

                    if (!string.IsNullOrEmpty(bitis))
                    {
                        if (bitis.Contains(":"))
                            mesaiBitis = Convert.ToInt32(bitis.Split(':')[0]);
                        else
                            mesaiBitis = Convert.ToInt32(bitis);
                    }
                }
            }
            catch { }
        }

        // --- RENKLENDİRME ---
        private void GridViewTakvim_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            // Sadece gün kolonlarını (Saat hariç) kontrol et
            if (e.Column.FieldName != "Saat")
            {
                string veri = e.CellValue?.ToString();
                if (!string.IsNullOrEmpty(veri))
                {
                    // Dolu hücreleri renklendir
                    e.Appearance.BackColor = Color.FromArgb(209, 232, 255); // Açık Mavi
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        void TabloYapisiOlustur()
        {
            dtTakvim = new DataTable();
            dtTakvim.Columns.Add("Saat");
            dtTakvim.Columns.Add("Pazartesi");
            dtTakvim.Columns.Add("Salı");
            dtTakvim.Columns.Add("Çarşamba");
            dtTakvim.Columns.Add("Perşembe");
            dtTakvim.Columns.Add("Cuma");
            dtTakvim.Columns.Add("Cumartesi");
            dtTakvim.Columns.Add("Pazar");

            // Dinamik Saat Satırları (Mesai Aralığına Göre)
            for (int i = mesaiBaslangic; i <= mesaiBitis; i++)
            {
                dtTakvim.Rows.Add($"{i:00}:00", "", "", "", "", "", "", "");
            }

            gridControlTakvim.DataSource = dtTakvim;

            // Grid ayarları
            gridViewTakvim.BestFitColumns();
            if (gridViewTakvim.Columns["Saat"] != null)
                gridViewTakvim.Columns["Saat"].Width = 60;
        }

        void TakvimiDoldur()
        {
            TabloYapisiOlustur();

            DateTime secilenTarih = dateTarih.DateTime;

            // Haftanın Pazartesi gününü bul (Pazartesi=1 ... Pazar=7)
            int gunDegeri = (int)secilenTarih.DayOfWeek;
            if (gunDegeri == 0) gunDegeri = 7;

            DateTime baslangic = secilenTarih.AddDays(-(gunDegeri - 1)).Date;
            DateTime bitis = baslangic.AddDays(6).Date;

            lblHaftaBilgi.Text = $"{baslangic:dd MMMM} - {bitis:dd MMMM} Haftası";

            try
            {
                string sorgu = @"
                    SELECT 
                        S.Tarih, 
                        S.Saat, 
                        O.AdSoyad AS Ogrenci,
                        Og.AdSoyad AS Ogretmen
                    FROM Tbl_Seanslar S
                    INNER JOIN Tbl_Ogrenciler O ON S.OgrenciID = O.OgrenciID
                    INNER JOIN Tbl_Ogretmenler Og ON S.OgretmenID = Og.OgretmenID
                    WHERE S.Tarih BETWEEN @baslangic AND @bitis";

                if (OgretmenID > 0)
                {
                    sorgu += " AND S.OgretmenID = " + OgretmenID;
                }

                SqlParameter[] p = {
                    new SqlParameter("@baslangic", baslangic.ToString("yyyy-MM-dd")),
                    new SqlParameter("@bitis", bitis.ToString("yyyy-MM-dd"))
                };

                DataTable dtVeri = SqlYardimcisi.VeriGetir(sorgu, p);

                foreach (DataRow dr in dtVeri.Rows)
                {
                    DateTime dersTarih = Convert.ToDateTime(dr["Tarih"]);
                    string saat = dr["Saat"].ToString();
                    string ogrenci = dr["Ogrenci"].ToString();
                    string ogretmen = dr["Ogretmen"].ToString();

                    string metin = OgretmenID > 0 ? ogrenci : $"{ogrenci}\n({ogretmen})";
                    string kolonAdi = GunBul(dersTarih.DayOfWeek);

                    int saatInt = 0;
                    try
                    {
                        if (saat.Contains(":"))
                            saatInt = Convert.ToInt32(saat.Split(':')[0]);
                        else
                            saatInt = Convert.ToInt32(saat);
                    }
                    catch { continue; }

                    // SATIR INDEX HESABI (Mesai başlangıcına göre)
                    int satirIndex = saatInt - mesaiBaslangic;

                    // Eğer ders mesai saatleri içindeyse göster
                    if (satirIndex >= 0 && satirIndex < dtTakvim.Rows.Count && !string.IsNullOrEmpty(kolonAdi))
                    {
                        string mevcut = dtTakvim.Rows[satirIndex][kolonAdi].ToString();
                        if (!string.IsNullOrEmpty(mevcut))
                            metin = mevcut + "\n---\n" + metin;

                        dtTakvim.Rows[satirIndex][kolonAdi] = metin;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
        }

        string GunBul(DayOfWeek gun)
        {
            switch (gun)
            {
                case DayOfWeek.Monday: return "Pazartesi";
                case DayOfWeek.Tuesday: return "Salı";
                case DayOfWeek.Wednesday: return "Çarşamba";
                case DayOfWeek.Thursday: return "Perşembe";
                case DayOfWeek.Friday: return "Cuma";
                case DayOfWeek.Saturday: return "Cumartesi";
                case DayOfWeek.Sunday: return "Pazar";
                default: return "";
            }
        }

        private void dateTarih_EditValueChanged(object sender, EventArgs e)
        {
            if (dateTarih.EditValue != null)
                TakvimiDoldur();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            dateTarih.DateTime = dateTarih.DateTime.AddDays(-7);
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            dateTarih.DateTime = dateTarih.DateTime.AddDays(7);
        }
    }
}
