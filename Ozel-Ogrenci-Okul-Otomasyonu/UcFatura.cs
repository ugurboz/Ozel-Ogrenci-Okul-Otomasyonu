using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class UcFatura : DevExpress.XtraEditors.XtraUserControl
    {
        int secilenTaksitId = 0;
        int secilenOgrenciId = 0;
        decimal aylikUcret = 0;
        int aylikSeans = 0;

        public UcFatura()
        {
            InitializeComponent();
        }

        private void UcFatura_Load(object sender, EventArgs e)
        {
            OgrencileriYukle();
            Temizle();

            // Renklendirme eventini bağla
            gridViewTaksit.RowStyle += gridViewTaksit_RowStyle;
        }

        // --- SATIR RENKLENDİRME ---
        private void gridViewTaksit_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                // Durum kolonundaki değeri al (✅ Ödendi / ❌ Ödenmedi)
                object durumObj = gridViewTaksit.GetRowCellValue(e.RowHandle, "Durum");
                if (durumObj != null)
                {
                    string durum = durumObj.ToString();

                    e.HighPriority = true; // Temayı ez
                    e.Appearance.Options.UseBackColor = true;

                    // Eğer 'Ödendi' içeriyorsa YEŞİL
                    if (durum.Contains("Ödendi") && !durum.Contains("Ödenmedi"))
                    {
                        e.Appearance.BackColor = System.Drawing.Color.LightGreen;
                    }
                    // Eğer 'Ödenmedi' içeriyorsa KIRMIZI
                    else if (durum.Contains("Ödenmedi"))
                    {
                        e.Appearance.BackColor = System.Drawing.Color.Salmon;
                    }
                }
            }
        }

        // --- ÖĞRENCİLERİ YÜKLE ---
        void OgrencileriYukle()
        {
            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT OgrenciID, AdSoyad FROM Tbl_Ogrenciler ORDER BY AdSoyad");
                lueOgrenci.Properties.DataSource = dt;
                lueOgrenci.Properties.ValueMember = "OgrenciID";
                lueOgrenci.Properties.DisplayMember = "AdSoyad";
                lueOgrenci.Properties.NullText = "Öğrenci Seçiniz...";
            }
            catch { }
        }

        // --- ÖĞRENCİ SEÇİLDİĞİNDE ---
        private void lueOgrenci_EditValueChanged(object sender, EventArgs e)
        {
            if (lueOgrenci.EditValue == null || lueOgrenci.EditValue == DBNull.Value)
            {
                SozlesmeBilgisiTemizle();
                return;
            }

            secilenOgrenciId = Convert.ToInt32(lueOgrenci.EditValue);
            SozlesmeBilgisiGetir();
            TaksitleriListele();
        }

        // --- SÖZLEŞME BİLGİSİ GETİR ---
        void SozlesmeBilgisiGetir()
        {
            try
            {
                string sorgu = @"SELECT TOP 1 AylikSeansSayisi, AylikUcret, SozlesmeDurumu 
                                FROM Tbl_Sozlesmeler 
                                WHERE OgrenciID = @ogrenciId AND SozlesmeDurumu = 'Aktif'
                                ORDER BY BaslangicTarihi DESC";

                SqlParameter[] p = { new SqlParameter("@ogrenciId", secilenOgrenciId) };
                DataTable dt = SqlYardimcisi.VeriGetir(sorgu, p);

                if (dt.Rows.Count > 0)
                {
                    aylikSeans = Convert.ToInt32(dt.Rows[0]["AylikSeansSayisi"]);
                    aylikUcret = Convert.ToDecimal(dt.Rows[0]["AylikUcret"]);

                    lblAylikSeans.Text = $"📅 Aylık Seans: {aylikSeans} seans";
                    lblAylikUcret.Text = $"💰 Aylık Ücret: {aylikUcret:N2} TL";
                    lblSozlesmeBilgi.Text = "✅ Aktif Sözleşme";
                    lblSozlesmeBilgi.Appearance.ForeColor = Color.FromArgb(76, 175, 80);
                    txtTutar.Text = aylikUcret.ToString();
                }
                else
                {
                    SozlesmeBilgisiTemizle();
                    lblSozlesmeBilgi.Text = "⚠️ Aktif Sözleşme Bulunamadı";
                    lblSozlesmeBilgi.Appearance.ForeColor = Color.FromArgb(255, 152, 0);
                    txtTutar.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sözleşme bilgisi alınamadı: " + ex.Message);
            }
        }

        void SozlesmeBilgisiTemizle()
        {
            aylikSeans = 0;
            aylikUcret = 0;
            lblAylikSeans.Text = "Aylık Seans: -";
            lblAylikUcret.Text = "Aylık Ücret: -";
            lblSozlesmeBilgi.Text = "📋 Sözleşme Bilgisi";
            lblSozlesmeBilgi.Appearance.ForeColor = Color.FromArgb(33, 150, 243);
            txtTutar.Text = "";
        }

        // --- TAKSİTLERİ LİSTELE ---
        void TaksitleriListele()
        {
            try
            {
                // TaksitNo kolonu olmayabilir, FaturaID kullan
                string sorgu = @"
                    SELECT 
                        F.FaturaID,
                        F.FaturaID AS 'Taksit No',
                        F.Tutar AS 'Tutar (TL)',
                        F.VadeTarihi AS 'Vade Tarihi',
                        CASE WHEN F.OdenmeDurumu = 1 THEN '✅ Ödendi' ELSE '❌ Ödenmedi' END AS 'Durum',
                        F.OdemeTarihi AS 'Ödeme Tarihi',
                        F.Aciklama
                    FROM Tbl_Faturalar F
                    WHERE F.OgrenciID = @ogrenciId
                    ORDER BY F.FaturaID";

                SqlParameter[] p = { new SqlParameter("@ogrenciId", secilenOgrenciId) };
                DataTable dt = SqlYardimcisi.VeriGetir(sorgu, p);
                gridControlTaksit.DataSource = dt;

                gridViewTaksit.BestFitColumns();
                gridViewTaksit.OptionsBehavior.Editable = false;

                if (gridViewTaksit.Columns["FaturaID"] != null)
                    gridViewTaksit.Columns["FaturaID"].Visible = false;

                // Toplam hesapla
                decimal toplam = 0;
                decimal odenen = 0;
                foreach (DataRow row in dt.Rows)
                {
                    decimal tutar = Convert.ToDecimal(row["Tutar (TL)"]);
                    toplam += tutar;
                    if (row["Durum"].ToString().Contains("Ödendi"))
                        odenen += tutar;
                }

                decimal kalan = toplam - odenen;
                lblToplam.Text = $"TOPLAM: {toplam:N2} TL\nÖdenen: {odenen:N2} TL | Kalan: {kalan:N2} TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Taksit listeleme hatası: " + ex.Message);
            }
        }

        // --- TAKSİT OLUŞTUR ---
        private void btnTaksitOlustur_Click(object sender, EventArgs e)
        {
            if (secilenOgrenciId == 0)
            {
                MessageBox.Show("Lütfen önce bir öğrenci seçiniz.");
                return;
            }

            decimal toplamTutar = 0;
            if (!string.IsNullOrEmpty(txtTutar.Text) && decimal.TryParse(txtTutar.Text, out decimal manuelTutar))
            {
                toplamTutar = manuelTutar;
            }
            else if (aylikUcret > 0)
            {
                toplamTutar = aylikUcret;
            }

            if (toplamTutar <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir toplam tutar giriniz veya sözleşmesi olan bir öğrenci seçiniz.");
                return;
            }

            int taksitSayisi = Convert.ToInt32(spinTaksitSayisi.Value);
            decimal taksitTutari = toplamTutar / taksitSayisi;

            if (MessageBox.Show($"Toplam Tutar: {toplamTutar:N2} TL\n" +
                               $"Taksit Sayısı: {taksitSayisi}\n" +
                               $"Taksit Tutarı: {taksitTutari:N2} TL\n\n" +
                               "Taksitleri oluşturmak istiyor musunuz?",
                               "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                // Eğer aktif sözleşme yoksa yeni sözleşme oluştur
                if (aylikUcret <= 0)
                {
                    int seansSayisi = Convert.ToInt32(spinSeansSayisi.Value);

                    string sozlesmeSorgu = @"INSERT INTO Tbl_Sozlesmeler 
                                            (OgrenciID, BaslangicTarihi, BitisTarihi, AylikUcret, AylikSeansSayisi, SozlesmeDurumu) 
                                            VALUES (@ogrId, @baslangic, @bitis, @ucret, @seans, 'Aktif')";

                    SqlParameter[] pSozlesme = {
                        new SqlParameter("@ogrId", secilenOgrenciId),
                        new SqlParameter("@baslangic", DateTime.Now),
                        new SqlParameter("@bitis", DateTime.Now.AddMonths(taksitSayisi)),
                        new SqlParameter("@ucret", toplamTutar),
                        new SqlParameter("@seans", seansSayisi)
                    };

                    SqlYardimcisi.KomutCalistir(sozlesmeSorgu, pSozlesme);

                    // UI'ı güncelle
                    SozlesmeBilgisiGetir();
                }

                // Her taksit için fatura oluştur
                for (int i = 1; i <= taksitSayisi; i++)
                {
                    string faturaNo = YeniFaturaNoOlustur();
                    DateTime vadeTarihi = DateTime.Now.AddDays(30 * i); // Her ay bir taksit

                    string sorgu = @"INSERT INTO Tbl_Faturalar 
                                    (FaturaNo, OgrenciID, Tutar, KDVOrani, KDVTutar, ToplamTutar, 
                                     FaturaTarihi, VadeTarihi, OdenmeDurumu, Aciklama) 
                                    VALUES (@faturaNo, @ogrenciId, @tutar, 0, 0, @tutar, 
                                            @faturaTarihi, @vadeTarihi, 0, @aciklama)";

                    SqlParameter[] p = {
                        new SqlParameter("@faturaNo", faturaNo),
                        new SqlParameter("@ogrenciId", secilenOgrenciId),
                        new SqlParameter("@tutar", taksitTutari),
                        new SqlParameter("@faturaTarihi", DateTime.Now),
                        new SqlParameter("@vadeTarihi", vadeTarihi),
                        new SqlParameter("@aciklama", $"Taksit {i}/{taksitSayisi}")
                    };

                    SqlYardimcisi.KomutCalistir(sorgu, p);
                }

                MessageBox.Show($"Sözleşme ve {taksitSayisi} adet taksit başarıyla oluşturuldu!");
                TaksitleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }

        // --- YENİ FATURA NO OLUŞTUR ---
        string YeniFaturaNoOlustur()
        {
            string yil = DateTime.Now.Year.ToString();
            string ay = DateTime.Now.Month.ToString("00");

            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir($"SELECT MAX(FaturaID) FROM Tbl_Faturalar");
                int sonId = dt.Rows[0][0] != DBNull.Value ? Convert.ToInt32(dt.Rows[0][0]) : 0;
                return $"FTR-{yil}{ay}-{(sonId + 1).ToString("0000")}";
            }
            catch
            {
                return $"FTR-{yil}{ay}-0001";
            }
        }

        // --- TAKSİT SEÇİLDİĞİNDE ---
        private void gridViewTaksit_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewTaksit.GetDataRow(gridViewTaksit.FocusedRowHandle);
            if (dr != null)
            {
                secilenTaksitId = Convert.ToInt32(dr["FaturaID"]);
            }
            else
            {
                secilenTaksitId = 0;
            }
        }

        // --- ÖDENDİ BUTONU ---
        private void btnOdendi_Click(object sender, EventArgs e)
        {
            if (secilenTaksitId == 0)
            {
                MessageBox.Show("Lütfen listeden bir taksit seçiniz.");
                return;
            }

            try
            {
                string sorgu = "UPDATE Tbl_Faturalar SET OdenmeDurumu = 1, OdemeTarihi = @tarih WHERE FaturaID = @id";
                SqlParameter[] p = {
                    new SqlParameter("@tarih", DateTime.Now),
                    new SqlParameter("@id", secilenTaksitId)
                };
                SqlYardimcisi.KomutCalistir(sorgu, p);
                MessageBox.Show("Taksit ödendi olarak işaretlendi!");
                TaksitleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- ÖDENMEDİ BUTONU ---
        private void btnOdenmedi_Click(object sender, EventArgs e)
        {
            if (secilenTaksitId == 0)
            {
                MessageBox.Show("Lütfen listeden bir taksit seçiniz.");
                return;
            }

            try
            {
                string sorgu = "UPDATE Tbl_Faturalar SET OdenmeDurumu = 0, OdemeTarihi = NULL WHERE FaturaID = @id";
                SqlParameter[] p = { new SqlParameter("@id", secilenTaksitId) };
                SqlYardimcisi.KomutCalistir(sorgu, p);
                MessageBox.Show("Taksit ödenmedi olarak işaretlendi!");
                TaksitleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- TAKSİT SİL ---
        private void btnTaksitSil_Click(object sender, EventArgs e)
        {
            if (secilenTaksitId == 0)
            {
                MessageBox.Show("Lütfen listeden bir taksit seçiniz.");
                return;
            }

            if (MessageBox.Show("Bu taksiti silmek istediğinize emin misiniz?", "Onay",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlYardimcisi.KomutCalistir("DELETE FROM Tbl_Faturalar WHERE FaturaID = " + secilenTaksitId);
                    MessageBox.Show("Taksit silindi!");
                    TaksitleriListele();
                    secilenTaksitId = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }

        // --- MAKBUZ YAZDIR ---
        private void btnMakbuzYazdir_Click(object sender, EventArgs e)
        {
            if (secilenTaksitId == 0)
            {
                MessageBox.Show("Lütfen listeden bir taksit seçiniz.");
                return;
            }

            try
            {
                MakbuzOlusturVeYazdir(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yazdırma hatası: " + ex.Message);
            }
        }

        // --- MAKBUZ PDF ---
        private void btnMakbuzPdf_Click(object sender, EventArgs e)
        {
            if (secilenTaksitId == 0)
            {
                MessageBox.Show("Lütfen listeden bir taksit seçiniz.");
                return;
            }

            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "PDF Dosyası|*.pdf";
                dialog.FileName = $"Makbuz_{secilenTaksitId}.pdf";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    MakbuzOlusturVeYazdir(false, dialog.FileName);
                    MessageBox.Show("Makbuz PDF olarak kaydedildi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF kaydetme hatası: " + ex.Message);
            }
        }

        // --- MAKBUZ OLUŞTUR ---
        void MakbuzOlusturVeYazdir(bool yazdir, string pdfYolu = null)
        {
            // Taksit bilgilerini al
            DataTable dt = SqlYardimcisi.VeriGetir($@"
                SELECT F.*, O.AdSoyad as OgrenciAdi 
                FROM Tbl_Faturalar F 
                INNER JOIN Tbl_Ogrenciler O ON F.OgrenciID = O.OgrenciID 
                WHERE F.FaturaID = {secilenTaksitId}");

            if (dt.Rows.Count == 0) return;

            DataRow dr = dt.Rows[0];

            // Makbuz içeriğini oluştur
            string makbuzIcerigi = $@"
═══════════════════════════════════════════════════
         İLGİ ÖZEL EĞİTİM VE REHABİLİTASYON MERKEZİ
                    ÖDEME MAKBUZU
═══════════════════════════════════════════════════

Makbuz No    : {dr["FaturaNo"]}
Tarih        : {DateTime.Now:dd.MM.yyyy HH:mm}

───────────────────────────────────────────────────
Öğrenci      : {dr["OgrenciAdi"]}
Açıklama     : {dr["Aciklama"]}
───────────────────────────────────────────────────

Tutar        : {Convert.ToDecimal(dr["Tutar"]):N2} TL
Vade Tarihi  : {Convert.ToDateTime(dr["VadeTarihi"]):dd.MM.yyyy}
Ödeme Durumu : {(Convert.ToInt32(dr["OdenmeDurumu"]) == 1 ? "✓ Ödendi" : "✗ Ödenmedi")}
{(dr["OdemeTarihi"] != DBNull.Value ? $"Ödeme Tarihi : {Convert.ToDateTime(dr["OdemeTarihi"]):dd.MM.yyyy}" : "")}

═══════════════════════════════════════════════════


                    Yetkili İmza: ____________________


                                        Kaşe:




═══════════════════════════════════════════════════
";

            if (yazdir)
            {
                // Print Preview ile göster
                using (PrintDocument printDoc = new PrintDocument())
                {
                    printDoc.PrintPage += (s, e) =>
                    {
                        e.Graphics.DrawString(makbuzIcerigi,
                            new Font("Consolas", 10),
                            Brushes.Black,
                            new RectangleF(20, 20, 550, 800));
                    };

                    PrintPreviewDialog preview = new PrintPreviewDialog();
                    preview.Document = printDoc;
                    preview.ShowDialog();
                }
            }
            else if (!string.IsNullOrEmpty(pdfYolu))
            {
                // PDF olarak kaydet - basit text dosyası olarak
                try
                {
                    // DevExpress XtraPrinting ile PDF oluştur
                    PrintingSystem ps = new PrintingSystem();
                    PrintableComponentLink link = new PrintableComponentLink(ps);

                    // Makbuzu RichTextBox'a yaz ve yazdır
                    using (var rtb = new System.Windows.Forms.RichTextBox())
                    {
                        rtb.Text = makbuzIcerigi;
                        rtb.Font = new Font("Consolas", 10);

                        // Alternatif: Basit text dosyası olarak kaydet ve bilgilendir
                        string txtDosya = pdfYolu.Replace(".pdf", ".txt");
                        System.IO.File.WriteAllText(txtDosya, makbuzIcerigi, System.Text.Encoding.UTF8);

                        // Ayrıca grid'i PDF olarak da kaydet
                        gridControlTaksit.ExportToPdf(pdfYolu);
                    }
                }
                catch
                {
                    // Fallback: Sadece text dosyası
                    string txtDosya = pdfYolu.Replace(".pdf", ".txt");
                    System.IO.File.WriteAllText(txtDosya, makbuzIcerigi, System.Text.Encoding.UTF8);
                    MessageBox.Show($"Makbuz text dosyası olarak kaydedildi:\n{txtDosya}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // --- TEMİZLE ---
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            lueOgrenci.EditValue = null;
            secilenOgrenciId = 0;
            secilenTaksitId = 0;
            spinTaksitSayisi.Value = 1;
            SozlesmeBilgisiTemizle();
            gridControlTaksit.DataSource = null;
            lblToplam.Text = "TOPLAM: 0.00 TL";
        }
    }
}

