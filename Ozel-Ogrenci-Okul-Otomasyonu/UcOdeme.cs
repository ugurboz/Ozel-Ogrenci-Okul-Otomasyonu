using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class UcOdeme : DevExpress.XtraEditors.XtraUserControl
    {
        // GÜNCELLEME İÇİN KRİTİK DEĞİŞKEN
        int secilenOdemeId = 0;

        public UcOdeme()
        {
            InitializeComponent();
        }

        private void UcOdeme_Load(object sender, EventArgs e)
        {
            OdemeleriListele();
            OgrencileriDoldur();
            Temizle(); // Başlangıçta her şey sıfır olsun
        }

        // --- 1. LİSTELEME ---
        void OdemeleriListele()
        {
            try
            {
                string sorgu = @"
                    SELECT 
                        Ode.OdemeID,
                        Ode.OgrenciID, 
                        Ogr.AdSoyad,
                        Ode.Tutar,
                        Ode.Tarih,
                        Ode.Aciklama
                    FROM Tbl_Odemeler Ode
                    INNER JOIN Tbl_Ogrenciler Ogr ON Ode.OgrenciID = Ogr.OgrenciID";

                DataTable dt = SqlYardimcisi.VeriGetir(sorgu);
                gridControlOdeme.DataSource = dt;

                gridViewOdeme.PopulateColumns();
                gridViewOdeme.Columns["OdemeID"].Visible = false;
                gridViewOdeme.Columns["OgrenciID"].Visible = false;
                gridViewOdeme.BestFitColumns();

                // Kullanıcı listede elle değişiklik yapamasın
                gridViewOdeme.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }

        // --- 2. ÖĞRENCİLERİ DOLDUR ---
        void OgrencileriDoldur()
        {
            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT OgrenciID, AdSoyad FROM Tbl_Ogrenciler");
                lueOgrenci.Properties.DataSource = dt;
                lueOgrenci.Properties.ValueMember = "OgrenciID";
                lueOgrenci.Properties.DisplayMember = "AdSoyad";
                lueOgrenci.Properties.PopulateColumns();
                lueOgrenci.Properties.Columns["OgrenciID"].Visible = false;
                lueOgrenci.Properties.NullText = "Öğrenci Seçiniz...";
            }
            catch { }
        }

        // --- 3. KAYDET / GÜNCELLE BUTONU (Zeka Burada) ---
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lueOgrenci.EditValue == null)
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz.");
                return;
            }

            try
            {
                decimal tutar = 0;
                decimal.TryParse(txtTutar.Text, out tutar);

                string sorgu = "";

                // EĞER ID 0 İSE -> YENİ KAYIT (INSERT)
                if (secilenOdemeId == 0)
                {
                    sorgu = "INSERT INTO Tbl_Odemeler (OgrenciID, Tutar, Tarih, Aciklama) VALUES (@p1, @p2, @p3, @p4)";
                }
                // EĞER ID VARSA -> GÜNCELLEME (UPDATE)
                else
                {
                    sorgu = "UPDATE Tbl_Odemeler SET OgrenciID=@p1, Tutar=@p2, Tarih=@p3, Aciklama=@p4 WHERE OdemeID=" + secilenOdemeId;
                }

                SqlParameter[] p = {
                    new SqlParameter("@p1", lueOgrenci.EditValue),
                    new SqlParameter("@p2", tutar),
                    new SqlParameter("@p3", dateTarih.DateTime.ToString("yyyy-MM-dd")),
                    new SqlParameter("@p4", memAciklama.Text)
                };

                SqlYardimcisi.KomutCalistir(sorgu, p);

                if (secilenOdemeId == 0)
                    MessageBox.Show("Ödeme Eklendi!");
                else
                    MessageBox.Show("Ödeme Güncellendi!");

                OdemeleriListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- 4. SİL ---
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenOdemeId == 0)
            {
                MessageBox.Show("Lütfen listeden silinecek ödemeyi seçiniz.");
                return;
            }

            if (MessageBox.Show("Bu ödemeyi silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlYardimcisi.KomutCalistir("DELETE FROM Tbl_Odemeler WHERE OdemeID=" + secilenOdemeId);
                OdemeleriListele();
                Temizle();
            }
        }

        // --- 5. TEMİZLE ---
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            lueOgrenci.EditValue = null;
            txtTutar.Text = "";
            memAciklama.Text = "";
            dateTarih.DateTime = DateTime.Now;

            // ID'yi sıfırla ki program yeni kayıt moduna geçsin
            secilenOdemeId = 0;
            btnKaydet.Text = "KAYDET"; // Buton yazısı düzelsin
        }

        // --- 6. SEÇİNCE BİLGİLERİ DOLDUR VE ID'Yİ KAP ---
        private void gridViewOdeme_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewOdeme.GetDataRow(gridViewOdeme.FocusedRowHandle);
            if (dr != null)
            {
                try
                {
                    // ID'yi hafızaya al (En önemli kısım burası)
                    secilenOdemeId = Convert.ToInt32(dr["OdemeID"]);

                    if (dr["OgrenciID"] != DBNull.Value)
                        lueOgrenci.EditValue = dr["OgrenciID"];

                    txtTutar.Text = dr["Tutar"].ToString();

                    if (dr["Tarih"] != DBNull.Value)
                        dateTarih.DateTime = Convert.ToDateTime(dr["Tarih"]);

                    memAciklama.Text = dr["Aciklama"].ToString();

                    // Kullanıcı anlasın diye butonu güncelle
                    btnKaydet.Text = "GÜNCELLE";
                }
                catch { }
            }
        }
    }
}