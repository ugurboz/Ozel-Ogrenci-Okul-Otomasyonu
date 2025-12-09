using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class Form1 : RibbonForm
    {
        // GÜNCELLEME İÇİN ID TUTUCU
        int secilenId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // --- PROGRAM AÇILINCA ---
        private void Form1_Load(object sender, EventArgs e)
        {
            // Başlangıçta SADECE Hoşgeldiniz ekranı açık olsun
            pnlDashboard.Visible = true;
            pnlOgrenciler.Visible = false;
        }

        // --- SAHNE DEĞİŞTİRME MEKANİZMASI ---
        void SahneDegistir(PanelControl acilacakPanel)
        {
            // 1. Tüm sahneleri gizle
            pnlDashboard.Visible = false;
            pnlOgrenciler.Visible = false;

            // 2. İsteneni aç
            acilacakPanel.Visible = true;
            acilacakPanel.Dock = DockStyle.Fill;
            acilacakPanel.BringToFront();
        }

        // --- BUTON TIKLAMALARI (MENÜ) ---

        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SahneDegistir(pnlDashboard);
        }

        private void btnOgrenciler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SahneDegistir(pnlOgrenciler);
            Listele(); // Listeyi taze verilerle doldur
        }

        private void btnOgretmen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Öğretmen paneli eklendiğinde burası açılacak
            // SahneDegistir(pnlOgretmenler);
        }

        // --- CRUD İŞLEMLERİ ---

        // LİSTELEME
        void Listele()
        {
            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ogrenciler");
                gridControl1.DataSource = dt;

                // Grid ayarları (Otomatik sütun oluştur ve sığdır)
                gridView1.PopulateColumns();
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }

        // TEMİZLEME
        void Temizle()
        {
            textTc.Text = "";
            textAd.Text = "";
            dateDogum.EditValue = null;
            cmbEngel.Text = "";
            textEngelOrani.Text = "";
            secilenId = 0;
            btnKaydet.Text = "KAYDET";
        }

        // KAYDET BUTONU (Ekleme ve Güncelleme)
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAd.Text))
            {
                MessageBox.Show("Lütfen en azından Ad Soyad giriniz.");
                return;
            }

            try
            {
                string sorgu = "";

                if (secilenId == 0) // YENİ KAYIT
                {
                    sorgu = "INSERT INTO Tbl_Ogrenciler (TCKimlikNo, AdSoyad, DogumTarihi, EngelTuru, EngelOrani) VALUES (@p1, @p2, @p3, @p4, @p5)";
                }
                else // GÜNCELLEME
                {
                    sorgu = "UPDATE Tbl_Ogrenciler SET TCKimlikNo=@p1, AdSoyad=@p2, DogumTarihi=@p3, EngelTuru=@p4, EngelOrani=@p5 WHERE OgrenciID=" + secilenId;
                }

                SqlParameter[] p = {
                    new SqlParameter("@p1", textTc.Text),
                    new SqlParameter("@p2", textAd.Text),
                    new SqlParameter("@p3", dateDogum.DateTime), // Tarih verisi
                    new SqlParameter("@p4", cmbEngel.Text),
                    new SqlParameter("@p5", textEngelOrani.Text)
                };

                SqlYardimcisi.KomutCalistir(sorgu, p);
                MessageBox.Show("İşlem Başarılı!");

                Listele(); // Listeyi yenile
                Temizle(); // Kutuları temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme Hatası: " + ex.Message);
            }
        }

        // SİL BUTONU
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Lütfen listeden silinecek kaydı seçiniz.");
                return;
            }

            if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlYardimcisi.KomutCalistir("DELETE FROM Tbl_Ogrenciler WHERE OgrenciID=" + secilenId);
                    MessageBox.Show("Kayıt Silindi.");
                    Listele();
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme Hatası: " + ex.Message);
                }
            }
        }

        // TEMİZLE BUTONU
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        // GRID TIKLAMA OLAYI (Seçileni Kutulara Doldur)
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                secilenId = Convert.ToInt32(dr["OgrenciID"]);
                textTc.Text = dr["TCKimlikNo"].ToString();
                textAd.Text = dr["AdSoyad"].ToString();
                cmbEngel.Text = dr["EngelTuru"].ToString();
                textEngelOrani.Text = dr["EngelOrani"].ToString();

                if (dr["DogumTarihi"] != DBNull.Value)
                {
                    dateDogum.DateTime = Convert.ToDateTime(dr["DogumTarihi"]);
                }
                else
                {
                    dateDogum.EditValue = null;
                }

                btnKaydet.Text = "GÜNCELLE"; // Modu değiştir
            }
        }

        // --- GEREKSİZ AMA HATA VERMESİN DİYE DURAN METOTLAR ---
        private void gridControl1_Click(object sender, EventArgs e) { }
        private void dateDogum_EditValueChanged(object sender, EventArgs e) { }
        private void pnlOgrenciler_Paint(object sender, PaintEventArgs e) { }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e) { }
    }
}