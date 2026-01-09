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
        // Yetki Özellikleri
        public bool IsAdmin { get; set; } = true;
        public int OgretmenID { get; set; }

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
            // Context menü kaldırıldı

            // ============================================
            // ÖĞRETMEN YETKİ KONTROLÜ
            // ============================================
            if (!IsAdmin)
            {
                // Öğretmen seçim kutusunu devre dışı bırak ve sadece kendini göster
                lueOgretmen.Enabled = false;
                lueOgretmen.EditValue = this.OgretmenID;
            }
        }

        // --- 1. LİSTELEME (JOIN İLE) ---
        void SeanslariListele()
        {
            try
            {
                // Temel sorgu
                string sorgu = @"
                    SELECT 
                        S.SeansID,
                        S.OgrenciID,
                        O.AdSoyad AS 'Öğrenci',
                        S.OgretmenID,
                        T.AdSoyad AS 'Öğretmen',
                        T.Brans AS 'Branş',
                        S.Tarih,
                        S.Saat
                    FROM Tbl_Seanslar S
                    INNER JOIN Tbl_Ogrenciler O ON S.OgrenciID = O.OgrenciID
                    INNER JOIN Tbl_Ogretmenler T ON S.OgretmenID = T.OgretmenID";

                // Öğretmen ise sadece kendi seanslarını görsün
                if (!IsAdmin && OgretmenID > 0)
                {
                    sorgu += $" WHERE S.OgretmenID = {OgretmenID}";
                }

                sorgu += " ORDER BY S.Tarih DESC";

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

        // --- SAĞ TIK MENÜSÜ KALDIRILDI ---


        // GridView -> Events (Şimşek) -> RowStyle olayına bağla!
        // Renklendirme kaldırıldı
        private void gridViewSeans_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            // Renklendirme kapatıldı
        }

        // Satır seçilince form alanlarını doldur
        private void gridViewSeans_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;

            DataRow dr = gridViewSeans.GetDataRow(e.FocusedRowHandle);
            if (dr == null) return;

            // LookUpEdit'lere ID değerlerini ata
            if (dr["OgrenciID"] != DBNull.Value)
                lueOgrenci.EditValue = dr["OgrenciID"];

            if (dr["OgretmenID"] != DBNull.Value)
                lueOgretmen.EditValue = dr["OgretmenID"];

            // Tarih ve saat doldur
            if (dr["Tarih"] != DBNull.Value)
                dateTarih.DateTime = Convert.ToDateTime(dr["Tarih"]);

            if (dr["Saat"] != DBNull.Value)
                timeSaat.Text = dr["Saat"].ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
    }
}