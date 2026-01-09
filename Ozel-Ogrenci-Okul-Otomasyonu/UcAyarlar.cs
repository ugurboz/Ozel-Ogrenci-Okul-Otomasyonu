using System;
using System.Data;
using System.Data.SqlClient; // SqlParameter için gerekli
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL; // SqlYardimcisi'nin olduğu yer

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class UcAyarlar : DevExpress.XtraEditors.XtraUserControl
    {
        // Giriş yapan öğretmenin ID'si (Login ekranından buraya set edilmeli)
        public int OgretmenID { get; set; }
        public bool IsAdmin { get; set; } = true; // Varsayılan: Admin
        private bool _isLoading = false; // Yükleme sırasında uyarıları engelle

        public UcAyarlar()
        {
            InitializeComponent();
        }

        // Form/UserControl yüklendiğinde çalışır
        private void UcAyarlar_Load(object sender, EventArgs e)
        {
            // Tasarım modunda veritabanı çekmeye çalışıp hata vermemesi için kontrol
            if (!this.DesignMode)
            {
                _isLoading = true;

                // ============================================
                // ÖĞRETMEN YETKİ KONTROLÜ
                // ============================================
                if (!IsAdmin)
                {
                    // Öğretmenler için API ve Mesai ayarlarını gizle
                    groupControl1.Visible = false; // Okul/Ders Ayarları (Mesai saatleri)
                    groupControl2.Visible = false; // Yapay Zeka (API Ayarları)
                }

                AyarlariGetir();
                _isLoading = false;
            }
        }

        // --- 1. VERİTABANINDAN MEVCUT AYARLARI ÇEKME ---
        void AyarlariGetir()
        {
            try
            {
                // SqlYardimcisi STATIC olduğu için direkt sınıf ismiyle çağırıyoruz. Newlemeye gerek yok.
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ayarlar WHERE ID=1");

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    // Mesai Saatleri
                    if (dr["MesaiBaslama"] != DBNull.Value)
                        dateMesaiBaslama.EditValue = dr["MesaiBaslama"]; // Veritabanında string ise TimeEdit bunu anlar

                    if (dr["MesaiBitis"] != DBNull.Value)
                        dateMesaiBitis.EditValue = dr["MesaiBitis"];

                    // Ders Süresi
                    if (dr["DersSuresi"] != DBNull.Value)
                        textEdit1.Text = dr["DersSuresi"].ToString();

                    // Log Ayarları
                    if (dr["GunlukLogTut"] != DBNull.Value)
                        chkGunlukLog.Checked = Convert.ToBoolean(dr["GunlukLogTut"]);

                    if (dr["LogDosyaYolu"] != DBNull.Value)
                        txtDosyaYolu.Text = dr["LogDosyaYolu"].ToString();
                    // ... diğer kodların altına ...
                    // API Key
                    if (dt.Columns.Contains("ApiKey") && dr["ApiKey"] != DBNull.Value)
                    {
                        txtApiKey.Text = dr["ApiKey"].ToString();
                    }

                    // API Sağlayıcı seçimi
                    if (dt.Columns.Contains("ApiProvider") && dr["ApiProvider"] != DBNull.Value)
                    {
                        string provider = dr["ApiProvider"].ToString();
                        cmbApiProvider.SelectedItem = provider;
                    }
                    else
                    {
                        cmbApiProvider.SelectedIndex = 0; // Varsayılan: Gemini
                    }
                }
            }
            catch (Exception ex)
            {
                // Kullanıcıyı korkutmamak için yükleme hatalarını sessiz geçebilir veya konsola yazabiliriz
                Console.WriteLine("Ayarlar yüklenirken hata: " + ex.Message);
            }
        }

        // --- 2. DOSYA YOLU SEÇME VE AÇMA ---
        private void simpleButton2_Click(object sender, EventArgs e) // Dosya Seç Butonu
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Log dosyalarının kaydedileceği klasörü seçiniz.";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDosyaYolu.Text = fbd.SelectedPath;

                // Klasörü anında aç
                try
                {
                    Process.Start("explorer.exe", fbd.SelectedPath);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Klasör açılırken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- 3. OKUL VE DERS AYARLARINI KAYDETME (UPDATE) ---
        private void simpleButton1_Click(object sender, EventArgs e) // Mesai Kaydet Butonu
        {
            try
            {
                string sorgu = "UPDATE Tbl_Ayarlar SET MesaiBaslama=@p1, MesaiBitis=@p2, DersSuresi=@p3 WHERE ID=1";

                SqlParameter[] p = {
                    new SqlParameter("@p1", dateMesaiBaslama.Time.ToString("HH:mm")),
                    new SqlParameter("@p2", dateMesaiBitis.Time.ToString("HH:mm")),
                    new SqlParameter("@p3", textEdit1.Text)
                };

                int sonuc = SqlYardimcisi.KomutCalistir(sorgu, p);

                if (sonuc > 0)
                {
                    XtraMessageBox.Show("Okul ve ders saati ayarları başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GunlukIslemLogla("AYAR", "Mesai ve ders süreleri değiştirildi.");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kaydetme hatası: " + ex.Message, "Hata");
            }
        }

        // --- 4. LOG AYARLARINI KAYDETME (UPDATE) ---
        private void simpleButton4_Click(object sender, EventArgs e) // Log Ayarları Kaydet Butonu
        {
            try
            {
                string sorgu = "UPDATE Tbl_Ayarlar SET LogDosyaYolu=@p1, GunlukLogTut=@p2 WHERE ID=1";

                SqlParameter[] p = {
                    new SqlParameter("@p1", txtDosyaYolu.Text),
                    new SqlParameter("@p2", chkGunlukLog.Checked) // SQL bit tipine bool otomatik çevrilir
                };

                int sonuc = SqlYardimcisi.KomutCalistir(sorgu, p);

                if (sonuc > 0)
                {
                    XtraMessageBox.Show("Loglama ayarları başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GunlukIslemLogla("SİSTEM", "Log ayarları güncellendi.");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- 5. FOTOĞRAF YÜKLEME ---
        private void simpleButton5_Click(object sender, EventArgs e) // Fotoğraf Yükle Butonu
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Profil Fotoğrafınızı Seçin";
            ofd.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = ofd.FileName;

                try
                {
                    // Resmi byte dizisine çevir (Database'e binary kaydetmek için)
                    byte[] resimBytes = File.ReadAllBytes(dosyaYolu);

                    string sorgu = "UPDATE Tbl_Ogretmenler SET Fotograf=@p1 WHERE OgretmenID=@p2";

                    SqlParameter pFoto = new SqlParameter("@p1", System.Data.SqlDbType.VarBinary, -1);
                    pFoto.Value = resimBytes;
                    SqlParameter pId = new SqlParameter("@p2", this.OgretmenID);
                    SqlParameter[] p = { pFoto, pId };

                    int sonuc = SqlYardimcisi.KomutCalistir(sorgu, p);

                    if (sonuc > 0)
                    {
                        XtraMessageBox.Show("Profil fotoğrafı başarıyla yüklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GunlukIslemLogla("PROFİL", "Kullanıcı fotoğrafını değiştirdi.");

                        // Form1'deki fotoğrafı da güncelle - Application.OpenForms ile bul
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form is Form1 frm)
                            {
                                frm.OgretmenFoto = resimBytes;
                                frm.GuncelleKullaniciBilgisi();
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Fotoğraf yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- 6. ŞİFRE DEĞİŞTİRME ---
        private void simpleButton6_Click(object sender, EventArgs e) // Şifre Değiştir Butonu
        {
            string eskiSifre = textEdit2.Text;
            string yeniSifre = textEdit3.Text;
            string yeniSifreTekrar = textEdit4.Text;

            if (string.IsNullOrEmpty(eskiSifre) || string.IsNullOrEmpty(yeniSifre))
            {
                XtraMessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı");
                return;
            }

            if (yeniSifre != yeniSifreTekrar)
            {
                XtraMessageBox.Show("Yeni şifreler birbiriyle uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Önce eski şifreyi kontrol edelim
                string kontrolSorgu = "SELECT Sifre FROM Tbl_Ogretmenler WHERE OgretmenID=@p1";
                SqlParameter[] pKontrol = { new SqlParameter("@p1", this.OgretmenID) };

                DataTable dt = SqlYardimcisi.VeriGetir(kontrolSorgu, pKontrol);

                if (dt.Rows.Count > 0)
                {
                    string dbSifre = dt.Rows[0]["Sifre"].ToString();
                    if (dbSifre != eskiSifre)
                    {
                        XtraMessageBox.Show("Eski şifrenizi yanlış girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Eski şifre doğruysa, yenisini kaydet
                string updateSorgu = "UPDATE Tbl_Ogretmenler SET Sifre=@p1 WHERE OgretmenID=@p2";
                SqlParameter[] pUpdate = {
                    new SqlParameter("@p1", yeniSifre),
                    new SqlParameter("@p2", this.OgretmenID)
                };

                int sonuc = SqlYardimcisi.KomutCalistir(updateSorgu, pUpdate);

                if (sonuc > 0)
                {
                    XtraMessageBox.Show("Şifreniz başarıyla güncellendi.", "Bilgi");
                    GunlukIslemLogla("GÜVENLİK", "Şifre değişikliği yapıldı.");
                    textEdit2.Text = "";
                    textEdit3.Text = "";
                    textEdit4.Text = "";


                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Şifre değiştirme hatası: " + ex.Message);
            }
        }

        // --- 7. GÜNLÜK LOGLAMA MEKANİZMASI ---
        public void GunlukIslemLogla(string islemTuru, string detay)
        {
            // Veritabanına sormadan, o anki UI durumuna göre karar veriyoruz (Hız için)
            if (chkGunlukLog.Checked == false) return;
            if (string.IsNullOrEmpty(txtDosyaYolu.Text)) return;

            try
            {
                string tarih = DateTime.Now.ToString("dd.MM.yyyy");
                string dosyaAdi = tarih + "_GunlukKayit.txt";
                string tamYol = Path.Combine(txtDosyaYolu.Text, dosyaAdi);

                string logSatiri = string.Format("[{0}] [Öğretmen ID: {1}] [{2}] {3}",
                    DateTime.Now.ToString("HH:mm:ss"),
                    this.OgretmenID,
                    islemTuru.ToUpper(),
                    detay);

                // Dosyaya ekle (Append)
                using (StreamWriter sw = File.AppendText(tamYol))
                {
                    sw.WriteLine(logSatiri);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Log Hatası: " + ex.Message);
            }
        }

        // --- API KEY KAYDETME ---
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // API Key kontrolü
            if (string.IsNullOrEmpty(txtApiKey.Text))
            {
                XtraMessageBox.Show("Lütfen API Key giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedProvider = cmbApiProvider.SelectedItem?.ToString() ?? "Gemini";

            try
            {
                string sorgu = "UPDATE Tbl_Ayarlar SET ApiKey=@p1, ApiProvider=@p2 WHERE ID=1";
                SqlParameter[] p = {
                    new SqlParameter("@p1", txtApiKey.Text.Trim()),
                    new SqlParameter("@p2", selectedProvider)
                };

                int sonuc = SqlYardimcisi.KomutCalistir(sorgu, p);

                if (sonuc > 0)
                {
                    XtraMessageBox.Show($"{selectedProvider} API anahtarı başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GunlukIslemLogla("AYAR", $"{selectedProvider} API anahtarı güncellendi.");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("API Key kaydedilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (XtraMessageBox.Show("Ders programını şimdi oluşturmak ister misiniz?", "Ders Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Async metodu UI thread'de çağırmak için basit yöntem:
                System.Threading.Tasks.Task.Run(async () =>
                {
                    string sonuc = await Ozel_Ogrenci_Okul_Otomasyonu.DAL.YapayZekaServisi.DersProgramiOlustur();

                    // Sonucu UI'da göstermek için Invoke kullanmalıyız
                    this.Invoke((MethodInvoker)delegate
                    {
                        // Hata varsa göster
                        if (sonuc.StartsWith("HATA") || sonuc.StartsWith("KRİTİK"))
                        {
                            XtraMessageBox.Show(sonuc, "Yapay Zeka Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Onay formunu aç
                        FrmDersProgramiOnay onayForm = new FrmDersProgramiOnay(sonuc);
                        DialogResult result = onayForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            GunlukIslemLogla("YAPAY ZEKA", "Ders programı onaylandı ve kaydedildi.");
                        }
                        else
                        {
                            GunlukIslemLogla("YAPAY ZEKA", "Ders programı önerisi reddedildi.");
                        }
                    });
                });
            }
        }

        // --- API SAĞLAYICI DEĞİŞTİĞİNDE ---
        private void cmbApiProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçim değiştiğinde API key alanını temizle (kullanıcı yeni key girecek)
            // Opsiyonel: txtApiKey.Text = "";
        }

        // --- DERS PROGRAMI OLUŞTUR BUTONU ---
        private void btnDersProgramiEkle_Click(object sender, EventArgs e)
        {
            // API key kontrolü
            if (string.IsNullOrEmpty(txtApiKey.Text))
            {
                XtraMessageBox.Show("Önce API Key'i girin ve kaydedin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ders programı oluşturma dialogunu aç
            FrmDersProgramiOlustur dialog = new FrmDersProgramiOlustur();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen verilerle programı oluştur
                System.Threading.Tasks.Task.Run(async () =>
                {
                    string sonuc = await Ozel_Ogrenci_Okul_Otomasyonu.DAL.YapayZekaServisi.DersProgramiOlusturFiltreli(
                        dialog.SecilenOgrenciler,
                        dialog.SecilenOgretmenler,
                        dialog.BaslangicTarihi,
                        dialog.BitisTarihi
                    );

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (sonuc.StartsWith("HATA") || sonuc.StartsWith("KRİTİK"))
                        {
                            XtraMessageBox.Show(sonuc, "Yapay Zeka Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        FrmDersProgramiOnay onayForm = new FrmDersProgramiOnay(sonuc);
                        if (onayForm.ShowDialog() == DialogResult.OK)
                        {
                            GunlukIslemLogla("YAPAY ZEKA", "Ders programı onaylandı ve takvime eklendi.");
                        }
                    });
                });
            }
        }

        // --- CHECKBOX KONTROLÜ ---
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // CheckBox Adını Designer'dan kontrol et: checkBoxGunlukLog
        {
            // Yükleme sırasında uyarı verme
            if (_isLoading) return;

            // Kullanıcı loglamayı açtı ama yol seçmediyse uyar
            if (chkGunlukLog.Checked && string.IsNullOrEmpty(txtDosyaYolu.Text))
            {
                XtraMessageBox.Show("Lütfen önce bir dosya konumu seçiniz!", "Uyarı");
                chkGunlukLog.Checked = false;
            }
        }

        // Boş Butonlar (Excel/PDF)
        // --- LOGLARI EXCEL VE PDF ALMA ---

        // Yardımcı Metot: Klasördeki tüm TXT dosyalarını okuyup sanal bir tabloya doldurur ve export eder.
        private void LoglariDisariAktar(string format)
        {
            // 1. Dosya yolu kontrolü
            string yol = txtDosyaYolu.Text;
            if (string.IsNullOrEmpty(yol) || !Directory.Exists(yol))
            {
                XtraMessageBox.Show("Log klasörü bulunamadı veya seçilmedi!", "Hata");
                return;
            }

            // 2. Klasördeki "GunlukKayit" ile biten tüm dosyaları bul
            string[] dosyalar = Directory.GetFiles(yol, "*_GunlukKayit.txt");
            if (dosyalar.Length == 0)
            {
                XtraMessageBox.Show("Klasörde hiç log dosyası bulunamadı.", "Uyarı");
                return;
            }

            // 3. Geçici bir GridControl oluşturuyoruz (Ekranda görünmeyecek, hafızada çalışacak)
            DevExpress.XtraGrid.GridControl gc = new DevExpress.XtraGrid.GridControl();
            DevExpress.XtraGrid.Views.Grid.GridView gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            gc.MainView = gv;
            gc.ViewCollection.Add(gv);
            gc.BindingContext = new System.Windows.Forms.BindingContext();

            // 4. Verileri dolduracağımız tablo
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Tarih_Saat");
            dt.Columns.Add("Log_Detayi");

            try
            {
                // Tüm dosyaları tek tek oku
                foreach (string dosya in dosyalar)
                {
                    string[] satirlar = File.ReadAllLines(dosya);
                    foreach (string satir in satirlar)
                    {
                        // Satırı parçalayabiliriz veya direkt ekleyebiliriz.
                        // Senin formatın: [14:00] [ID] [TUR] Detay...
                        // Basit olsun diye direkt ekliyorum, istersen parçalayabilirsin.

                        // Dosya adından tarihi alalım (Örn: 21.12.2025_GunlukKayit.txt -> 21.12.2025)
                        string dosyaAdi = Path.GetFileName(dosya);
                        string tarihKismi = dosyaAdi.Split('_')[0];

                        dt.Rows.Add(tarihKismi, satir);
                    }
                }

                // Grid'e veriyi bağla
                gc.DataSource = dt;
                gc.ForceInitialize(); // Grid'i çalışmaya zorla

                // 5. Çıktı Alma İşlemi
                SaveFileDialog sfd = new SaveFileDialog();

                if (format == "Excel")
                {
                    sfd.Filter = "Excel Dosyası|*.xlsx";
                    sfd.FileName = "Tum_Log_Kayitlari.xlsx";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        gv.ExportToXlsx(sfd.FileName);
                        if (XtraMessageBox.Show("Excel dosyası oluşturuldu. Açmak ister misiniz?", "Başarılı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Process.Start(sfd.FileName);
                        }
                    }
                }
                else if (format == "Pdf")
                {
                    sfd.Filter = "PDF Dosyası|*.pdf";
                    sfd.FileName = "Tum_Log_Kayitlari.pdf";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        gv.ExportToPdf(sfd.FileName);
                        if (XtraMessageBox.Show("PDF dosyası oluşturuldu. Açmak ister misiniz?", "Başarılı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Process.Start(sfd.FileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Rapor alınırken hata oluştu: " + ex.Message, "Hata");
            }
            finally
            {
                // Hafızayı temizle
                gc.Dispose();
                gv.Dispose();
                dt.Dispose();
            }
        }

        // --- BUTONLARA TIKLANINCA ÇALIŞACAK KISIMLAR ---

        private void btnExcelAl_Click(object sender, EventArgs e)
        {
            LoglariDisariAktar("Excel");
        }

        private void btnPdfAl_Click(object sender, EventArgs e)
        {
            LoglariDisariAktar("Pdf");
        }

    }
}