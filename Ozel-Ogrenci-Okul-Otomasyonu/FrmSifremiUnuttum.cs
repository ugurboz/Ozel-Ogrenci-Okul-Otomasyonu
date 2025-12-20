using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL; // SQL Yardımcın

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            this.Text = "Şifre Kurtarma";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTc.Text) || string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Lütfen bilgileri doldurunuz.");
                return;
            }

            // 1. Veritabanında Bu Öğretmen Var mı?
            string sorgu = "SELECT * FROM Tbl_Ogretmenler WHERE TCNo=@p1 AND Mail=@p2";
            SqlParameter[] p = {
                new SqlParameter("@p1", txtTc.Text),
                new SqlParameter("@p2", txtMail.Text)
            };

            System.Data.DataTable dt = SqlYardimcisi.VeriGetir(sorgu, p);

            if (dt.Rows.Count > 0)
            {
                string adSoyad = dt.Rows[0]["AdSoyad"].ToString();
                string sifre = dt.Rows[0]["Sifre"].ToString(); // Şifreyi Çektik

                // 2. Mail Gönderme İşlemi
                try
                {
                    MailGonder(txtMail.Text, adSoyad, sifre);
                    MessageBox.Show("Şifreniz mail adresinize gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Pencereyi kapat
                }
                catch (Exception)
                {
                    // Mail ayarları yapılmadığı için şimdilik ekranda gösterelim (Test Amaçlı)
                    MessageBox.Show("Mail sunucusu şu an yanıt vermiyor.\n\nGeçici Olarak Şifreniz: " + sifre, "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu TC ve Mail adresiyle eşleşen bir kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- MAIL GÖNDERME METODU ---
        void MailGonder(string aliciMail, string aliciAd, string sifre)
        {
            // BURAYA KENDİ GMAIL BİLGİLERİNİ GİRMEN GEREKİR
            // Eğer hata alırsan Google hesabından "Uygulama Şifresi" oluşturman lazım.

            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();

            istemci.Credentials = new System.Net.NetworkCredential("uboz174@gmail.com", "pphv wfct mtza ycvo");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;

            mesaj.To.Add(aliciMail);
            mesaj.From = new MailAddress("uboz174@gmail.com");
            mesaj.Subject = "Okul Otomasyonu - Şifre Hatırlatma";
            mesaj.Body = $"Sayın {aliciAd},\n\nUnuttuğunuz Şifreniz: {sifre}\n\nİyi çalışmalar dileriz.";

            istemci.Send(mesaj);
        }

       
    }
}