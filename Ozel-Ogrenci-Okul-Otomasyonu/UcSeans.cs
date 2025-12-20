using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL; // Senin SQL Yardımcın

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class UcSeans : DevExpress.XtraEditors.XtraUserControl
    {
        public UcSeans()
        {
            InitializeComponent();
        }

        private void UcSeans_Load(object sender, EventArgs e)
        {
            // Sayfa açılınca Kutuları Doldur ve Listeyi Getir
            OgrencileriYukle();
            OgretmenleriYukle();
            SeanslariListele();

          
            dateTarih.DateTime = DateTime.Now;
            gridControlSeans.ContextMenuStrip = cmsSeans;
        }

        // --- 1. LİSTELEME (JOIN İLE) ---
        void SeanslariListele()
        {
            try
            {
                // BURASI ÇOK ÖNEMLİ:
                // Tabloda sadece ID'ler (1, 2) var. İsimleri görmek için diğer tablolarla birleştiriyoruz (JOIN).
                string sorgu = @"
                    SELECT 
                        S.SeansID,
                        O.AdSoyad AS 'Öğrenci',
                        T.AdSoyad AS 'Öğretmen',
                        T.Brans AS 'Branş',
                        S.Tarih,
                        S.Saat,
                        S.YoklamaDurumu
                    FROM Tbl_Seanslar S
                    INNER JOIN Tbl_Ogrenciler O ON S.OgrenciID = O.OgrenciID
                    INNER JOIN Tbl_Ogretmenler T ON S.OgretmenID = T.OgretmenID
                    ORDER BY S.Tarih DESC";

                DataTable dt = SqlYardimcisi.VeriGetir(sorgu);
                gridControlSeans.DataSource = dt;
                gridViewSeans.BestFitColumns(); // Sütunları sığdır
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }

        // --- 2. LOOKUPEDIT DOLDURMA (ÖĞRENCİLER) ---
        void OgrencileriYukle()
        {
            // Sadece ID ve İsim çekiyoruz
            DataTable dt = SqlYardimcisi.VeriGetir("SELECT OgrenciID, AdSoyad FROM Tbl_Ogrenciler");

            lueOgrenci.Properties.ValueMember = "OgrenciID"; // Arka planda tutulacak değer (ID)
            lueOgrenci.Properties.DisplayMember = "AdSoyad"; // Ekranda görünecek değer (İsim)
            lueOgrenci.Properties.DataSource = dt;
            lueOgrenci.Properties.NullText = "Öğrenci Seçiniz";
        }

        // --- 3. LOOKUPEDIT DOLDURMA (ÖĞRETMENLER) ---
        void OgretmenleriYukle()
        {
            DataTable dt = SqlYardimcisi.VeriGetir("SELECT OgretmenID, AdSoyad FROM Tbl_Ogretmenler");

            lueOgretmen.Properties.ValueMember = "OgretmenID";
            lueOgretmen.Properties.DisplayMember = "AdSoyad";
            lueOgretmen.Properties.DataSource = dt;
            lueOgretmen.Properties.NullText = "Öğretmen Seçiniz";
        }

        // --- 4. KAYDETME ---
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Seçim yapılmış mı kontrol et (EditValue null ise seçilmemiştir)
            if (lueOgrenci.EditValue == null || lueOgretmen.EditValue == null)
            {
                MessageBox.Show("Lütfen öğrenci ve öğretmen seçiniz.");
                return;
            }

            try
            {
                string sorgu = "INSERT INTO Tbl_Seanslar (OgrenciID, OgretmenID, Tarih, Saat, Durum) VALUES (@p1, @p2, @p3, @p4, 1)";

                SqlParameter[] p = {
                    new SqlParameter("@p1", lueOgrenci.EditValue), // Seçilenin ID'sini alır!
                    new SqlParameter("@p2", lueOgretmen.EditValue), // Seçilenin ID'sini alır!
                    new SqlParameter("@p3", dateTarih.DateTime.ToString("yyyy-MM-dd")),
                    new SqlParameter("@p4", timeSaat.Text)
                };

                SqlYardimcisi.KomutCalistir(sorgu, p);
                MessageBox.Show("Seans başarıyla oluşturuldu!");

                SeanslariListele(); // Listeyi güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme Hatası: " + ex.Message);
            }
        }

        // --- 5. SİLME (İSTEĞE BAĞLI) ---
        // Silme butonu koyarsan bu kodu kullanabilirsin
        private void btnSil_Click(object sender, EventArgs e)
        {
            // Grid'den seçilen satırın ID'sini alıp DELETE sorgusu atabilirsin.
            // Yapmak istersen söyle, ekleyelim.
        }

        // --- SAĞ TIK: ÖĞRENCİ GELDİ ---
        private void öğrenciGeldiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoklamaGuncelle(true); // TRUE = Geldi
        }

        // --- SAĞ TIK: GELMEDİ / İPTAL ---
        private void gelmediİptalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YoklamaGuncelle(false); // FALSE = Gelmedi
        }

        // --- ORTAK GÜNCELLEME METODU ---
        void YoklamaGuncelle(bool durum)
        {
            // Seçili satırın ID'sini al
            DataRow dr = gridViewSeans.GetDataRow(gridViewSeans.FocusedRowHandle);
            if (dr == null) return;

            int id = Convert.ToInt32(dr["SeansID"]); // ID'yi yakaladık

            // Veritabanını Güncelle
            // 1 (True) -> Geldi, 0 (False) -> Gelmedi
            string sqlDurum = durum ? "1" : "0";

            SqlYardimcisi.KomutCalistir($"UPDATE Tbl_Seanslar SET YoklamaDurumu={sqlDurum} WHERE SeansID=" + id);

            // Kullanıcıya bilgi verip listeyi yenile
            MessageBox.Show(durum ? "Öğrenci GELDİ olarak işaretlendi." : "Öğrenci GELMEDİ olarak işaretlendi.");
            SeanslariListele();
        }

        // GridView -> Events (Şimşek) -> RowStyle olayına bağla!
        private void gridViewSeans_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                object durum = gridViewSeans.GetRowCellValue(e.RowHandle, "YoklamaDurumu");

                if (durum != null && durum != DBNull.Value)
                {
                    bool geldiMi = Convert.ToBoolean(durum);

                    // --- KRİTİK AYARLAR ---
                    e.HighPriority = true; // 1. Temayı Ez!
                    e.Appearance.Options.UseBackColor = true; // 2. Arka plan rengini kullanmayı aç!

                    if (geldiMi)
                        e.Appearance.BackColor = System.Drawing.Color.LightGreen;
                    else
                        e.Appearance.BackColor = System.Drawing.Color.Salmon;
                }
            }
        }

       
    }
}