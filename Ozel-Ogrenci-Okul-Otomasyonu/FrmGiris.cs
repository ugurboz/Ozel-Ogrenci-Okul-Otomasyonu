using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        // Giriş yapan hocanın ID'sini tüm programda kullanmak için Static yaptık
        public static int GirisYapanOgretmenID = 0;

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            // Form açılınca ortada dursun ve şık görünsün
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; // Sadece Kapat butonu olsun
            this.Text = "Rehabilitasyon Merkezi Giriş";
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // ... (Boşluk kontrolleri vs aynı kalsın) ...

            if (tglGirisTuru.IsOn)
            {
                // --- YÖNETİCİ GİRİŞİ ---
                string sorgu = "SELECT * FROM Tbl_Yoneticiler WHERE KullaniciAdi=@p1 AND Sifre=@p2";
                SqlParameter[] p = { new SqlParameter("@p1", txtKullanici.Text), new SqlParameter("@p2", txtSifre.Text) };
                DataTable dt = SqlYardimcisi.VeriGetir(sorgu, p);

                if (dt.Rows.Count > 0)
                {
                    Form1 fr = new Form1();

                    // FORM1'E BİLGİ GÖNDERİYORUZ:
                    fr.IsAdmin = true; // Bu bir YÖNETİCİ

                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş!");
                }
            }
            else
            {
                // --- ÖĞRETMEN GİRİŞİ ---
                string sorgu = "SELECT * FROM Tbl_Ogretmenler WHERE TCNo=@p1 AND Sifre=@p2";
                SqlParameter[] p = { new SqlParameter("@p1", txtKullanici.Text), new SqlParameter("@p2", txtSifre.Text) };
                DataTable dt = SqlYardimcisi.VeriGetir(sorgu, p);

                if (dt.Rows.Count > 0)
                {
                    Form1 fr = new Form1();

                    // FORM1'E BİLGİ GÖNDERİYORUZ:
                    fr.IsAdmin = false; // Bu bir yönetici DEĞİL
                    fr.OgretmenID = Convert.ToInt32(dt.Rows[0]["OgretmenID"]); // ID'yi verelim

                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş!");
                }
                
            }
        }

        private void lblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttum fr = new FrmSifremiUnuttum();
            fr.ShowDialog(); // ShowDialog: Bu pencere kapanmadan arkadakine tıklatmaz
        }
    }
}