using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraBars;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL; // SQL Yardımcın

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        // Yetki Değişkenleri
        public bool IsAdmin = true;
        public int OgretmenID = 0;

        // --- SAYFALAR (UserControls) ---
        UcSeans _ucSeans;       
        UcOgretmen _ucOgretmen;
        UcTakvim _ucTakvim;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Başlangıçta Dashboard (Panel) açık olsun
            pnlDashboard.Visible = true;
            pnlDashboard.Dock = DockStyle.Fill;

            // Öğrenci paneli gizli başlasın
            pnlOgrenciler.Visible = false;

            // 2. Yetki ve Başlık Ayarı
            if (IsAdmin)
            {
                this.Text = "OKUL OTOMASYONU - YÖNETİCİ PANELİ";
            }
            else
            {
                this.Text = "OKUL OTOMASYONU - ÖĞRETMEN PANELİ";
                // Öğretmen ise Öğretmenler butonunu gizleyelim
                ribbonPageGroup2.Visible = false;
            }

            // 3. Öğrenci Listesini Getir (Paneldeki Grid için)
            Listele();

            if (IsAdmin)
            {
                this.Text = "OKUL OTOMASYONU - YÖNETİCİ PANELİ";
                // Yöneticiye takvim açmaya gerek yok, o dashboard görsün
            }
            else
            {
                this.Text = "OKUL OTOMASYONU - ÖĞRETMEN PANELİ";
                ribbonPageGroup2.Visible = false; // Öğretmen yönetimini gizle

                // --- YENİ KISIM: ÖĞRETMEN GİRER GİRMEZ TAKVİM AÇILSIN ---
                pnlDashboard.Visible = false; // Admin dashboard'ı kapat

                if (_ucTakvim == null)
                {
                    _ucTakvim = new UcTakvim();
                    _ucTakvim.Dock = DockStyle.Fill;
                    _ucTakvim.OgretmenID = this.OgretmenID; // Giriş yapan hocanın ID'sini gönder!
                    this.Controls.Add(_ucTakvim);
                }
                _ucTakvim.Visible = true;
                _ucTakvim.BringToFront();
            }
        }

        // ==========================================
        //         NAVİGASYON (BUTONLAR)
        // ==========================================

        // 1. ANASAYFA
        private void btnAnasayfa_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlDashboard.Visible = true;
            pnlDashboard.BringToFront();

            // Diğerlerini Gizle
            pnlOgrenciler.Visible = false;
            if (_ucSeans != null) _ucSeans.Visible = false;
            if (_ucOgretmen != null) _ucOgretmen.Visible = false;
            if (_ucTakvim != null) _ucTakvim.Visible = false;
        }

        // 2. ÖĞRENCİLER
        private void btnOgrenciler_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Diğerlerini Gizle
            pnlDashboard.Visible = false;
            if (_ucSeans != null) _ucSeans.Visible = false;
            if (_ucOgretmen != null) _ucOgretmen.Visible = false;
            if (_ucTakvim != null) _ucTakvim.Visible = false;
            // Öğrenci Panelini Aç
            pnlOgrenciler.Visible = true;
            pnlOgrenciler.Dock = DockStyle.Fill;
            pnlOgrenciler.BringToFront();
        }

        // 3. SEANSLAR
        private void btnSeanslar_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Diğerlerini Gizle
            pnlDashboard.Visible = false;
            pnlOgrenciler.Visible = false;
            if (_ucOgretmen != null) _ucOgretmen.Visible = false;
            if (_ucTakvim != null) _ucTakvim.Visible = false;
            // Seans UserControl'ünü Aç
            if (_ucSeans == null || _ucSeans.IsDisposed)
            {
                _ucSeans = new UcSeans();
                _ucSeans.Dock = DockStyle.Fill;
                this.Controls.Add(_ucSeans);
            }
            _ucSeans.Visible = true;
            _ucSeans.BringToFront();
        }

        // 4. ÖĞRETMENLER (DÜZELTİLDİ - ARTIK ÇALIŞIYOR)
        private void btnOgretmen_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Diğerlerini Gizle
            pnlDashboard.Visible = false;
            pnlOgrenciler.Visible = false;
            if (_ucSeans != null) _ucSeans.Visible = false;
            if (_ucTakvim != null) _ucTakvim.Visible = false;
            // Öğretmen UserControl'ünü Aç
            if (_ucOgretmen == null || _ucOgretmen.IsDisposed)
            {
                _ucOgretmen = new UcOgretmen();
                _ucOgretmen.Dock = DockStyle.Fill;
                this.Controls.Add(_ucOgretmen);
            }
            _ucOgretmen.Visible = true;
            _ucOgretmen.BringToFront();
        }

        private void btnTakvim_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 1. Diğer tüm pencereleri gizle
            pnlDashboard.Visible = false;
            pnlOgrenciler.Visible = false;
            if (_ucSeans != null) _ucSeans.Visible = false;
            if (_ucOgretmen != null) _ucOgretmen.Visible = false;

            // 2. Takvim (UcTakvim) sayfasını aç
            if (_ucTakvim == null || _ucTakvim.IsDisposed)
            {
                _ucTakvim = new UcTakvim();
                _ucTakvim.Dock = DockStyle.Fill;
                _ucTakvim.OgretmenID = this.OgretmenID; // Giriş yapan hocanın ID'sini gönder
                this.Controls.Add(_ucTakvim);
            }

            _ucTakvim.Visible = true;
            _ucTakvim.BringToFront();
        }

        // ==========================================
        //      ÖĞRENCİ İŞLEMLERİ (Senin Panelin)
        // ==========================================

        void Listele()
        {
            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ogrenciler");
                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hata durumunda sessiz kal veya logla
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // NOT: Veritabanında EngelTuru, EngelOrani, DogumTarihi sütunları olmalı
                string sorgu = "INSERT INTO Tbl_Ogrenciler (AdSoyad, TCNo, DogumTarihi, EngelTuru, EngelOrani) VALUES (@p1, @p2, @p3, @p4, @p5)";

                SqlParameter[] p = {
                    new SqlParameter("@p1", textAd.Text),
                    new SqlParameter("@p2", textTc.Text),
                    new SqlParameter("@p3", dateDogum.DateTime.ToString("yyyy-MM-dd")),
                    new SqlParameter("@p4", cmbEngel.Text),
                    new SqlParameter("@p5", textEngelOrani.Text)
                };

                SqlYardimcisi.KomutCalistir(sorgu, p);
                MessageBox.Show("Öğrenci Başarıyla Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme Hatası: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    string id = dr["OgrenciID"].ToString();
                    DialogResult onay = MessageBox.Show("Bu öğrenciyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (onay == DialogResult.Yes)
                    {
                        SqlYardimcisi.KomutCalistir("DELETE FROM Tbl_Ogrenciler WHERE OgrenciID=" + id);
                        MessageBox.Show("Öğrenci Silindi.");
                        Listele();
                        Temizle();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek öğrenciyi listeden seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme Hatası: " + ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            textAd.Text = "";
            textTc.Text = "";
            textEngelOrani.Text = "";
            cmbEngel.Text = "";
            dateDogum.Text = "";
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    textAd.Text = dr["AdSoyad"].ToString();
                    textTc.Text = dr["TCNo"].ToString();

                    if (dr.Table.Columns.Contains("EngelTuru"))
                        cmbEngel.Text = dr["EngelTuru"].ToString();

                    if (dr.Table.Columns.Contains("EngelOrani"))
                        textEngelOrani.Text = dr["EngelOrani"].ToString();

                    if (dr["DogumTarihi"] != DBNull.Value)
                    {
                        dateDogum.DateTime = Convert.ToDateTime(dr["DogumTarihi"]);
                    }
                }
            }
            catch { }
        }

       
    }
}