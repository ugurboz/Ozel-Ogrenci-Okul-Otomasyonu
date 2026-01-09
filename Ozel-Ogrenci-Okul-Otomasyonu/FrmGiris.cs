using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DevExpress.XtraEditors;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class FrmGiris : XtraForm
    {
        public FrmGiris()
        {
            InitializeComponent();
            ApplyModernStyle();
        }

        private void ApplyModernStyle()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Renk paleti Form1 ile uyumlu olacak (Designer'da set edeceğiz ama burada da dursun)
        }

        // Giriş yapan hocanın ID'sini tüm programda kullanmak için Static yaptık
        public static int GirisYapanOgretmenID = 0;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Boşluk kontrolü
            if (string.IsNullOrWhiteSpace(txtKullanici.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkYonetici.Checked)
            {
                // --- YÖNETİCİ GİRİŞİ ---
                string sorgu = "SELECT * FROM Tbl_Yoneticiler WHERE KullaniciAdi=@p1 AND Sifre=@p2";
                SqlParameter[] p = { new SqlParameter("@p1", txtKullanici.Text), new SqlParameter("@p2", txtSifre.Text) };
                DataTable dt = SqlYardimcisi.VeriGetir(sorgu, p);

                if (dt.Rows.Count > 0)
                {
                    Form1 fr = new Form1();
                    fr.IsAdmin = true;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    fr.IsAdmin = false;
                    fr.OgretmenID = Convert.ToInt32(dt.Rows[0]["OgretmenID"]);

                    // Öğretmen ad soyad bilgisini aktar
                    if (dt.Rows[0]["AdSoyad"] != DBNull.Value)
                        fr.OgretmenAdSoyad = dt.Rows[0]["AdSoyad"].ToString();

                    // Öğretmen fotoğrafını aktar
                    if (dt.Rows[0]["Fotograf"] != DBNull.Value)
                        fr.OgretmenFoto = (byte[])dt.Rows[0]["Fotograf"];

                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı TC No veya şifre!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifremiUnuttum fr = new FrmSifremiUnuttum();
            fr.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Window Drag Logic
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void FrmGiris_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FrmGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void FrmGiris_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}