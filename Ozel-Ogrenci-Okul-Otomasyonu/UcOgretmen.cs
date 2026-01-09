using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class UcOgretmen : DevExpress.XtraEditors.XtraUserControl
    {
        // Güncelleme işlemi için ID
        int secilenOgrtId = 0;

        public UcOgretmen()
        {
            InitializeComponent();
        }

        private void UcOgretmen_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        // --- 1. LİSTELEME ---
        void Listele()
        {
            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ogretmenler");
                gridControlOgretmen.DataSource = dt;

                // Grid Görünüm Ayarları
                gridViewOgretmen.BestFitColumns();
                gridViewOgretmen.OptionsBehavior.Editable = false; // Listede elle değiştirmesinler

                // Fotograf kolonunu küçük göster
                if (gridViewOgretmen.Columns["Fotograf"] != null)
                {
                    var fotografKolon = gridViewOgretmen.Columns["Fotograf"];
                    fotografKolon.Width = 50;
                    fotografKolon.MaxWidth = 50;

                    // Resmi küçük thumbnail olarak göster
                    var repoPicture = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
                    repoPicture.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
                    gridControlOgretmen.RepositoryItems.Add(repoPicture);
                    fotografKolon.ColumnEdit = repoPicture;
                }

                // Satır yüksekliğini sabit tut
                gridViewOgretmen.RowHeight = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }

        // --- 2. BRANŞA GÖRE DERS LİSTESİ (Rehabilitasyon) ---
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenBrans = cmbBrans.Text;
            listDersler.Items.Clear(); // Önce temizle

            List<string> gelenDersler = new List<string>();

            switch (secilenBrans)
            {
                case "Zihinsel Engelliler Öğretmeni":
                    gelenDersler.AddRange(new string[] { "Öz Bakım", "Günlük Yaşam", "Toplumsal Uyum", "Okuma-Yazma", "Kavram Öğretimi" });
                    break;
                case "Fizyoterapist":
                    gelenDersler.AddRange(new string[] { "Kaba Motor", "İnce Motor", "Denge-Koordinasyon", "Kas Güçlendirme", "Yürüme Eğitimi" });
                    break;
                case "Dil ve Konuşma Terapisti":
                    gelenDersler.AddRange(new string[] { "Ses Farkındalığı", "Akıcı Konuşma", "Dil Bozuklukları", "Yutma Bozuklukları" });
                    break;
                case "Psikolog / Rehberlik":
                    gelenDersler.AddRange(new string[] { "Aile Eğitimi", "Davranış Problemleri", "Sosyal Beceri", "Mahremiyet Eğitimi" });
                    break;
                case "Ergoterapist":
                    gelenDersler.AddRange(new string[] { "Duyu Bütünleme", "El-Göz Koordinasyonu", "Dikkat ve Odaklanma" });
                    break;
                case "Okul Öncesi":
                    gelenDersler.AddRange(new string[] { "Oyun Terapisi", "Boyama ve Çizim", "Grup Etkinlikleri" });
                    break;
                default:
                    gelenDersler.Add("Genel Rehabilitasyon");
                    break;
            }

            // Listeye Ekle
            foreach (string ders in gelenDersler)
            {
                listDersler.Items.Add(ders);
            }
        }

        // --- 3. KAYDET / GÜNCELLE ---
        private void btnOgrtKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrtAd.Text))
            {
                MessageBox.Show("Lütfen Ad Soyad giriniz.");
                return;
            }

            // Seçilen dersleri virgüllü metne çevir
            string secilenDersler = "";
            foreach (object item in listDersler.CheckedItems)
            {
                secilenDersler += item.ToString() + ", ";
            }
            if (secilenDersler.Length > 2) secilenDersler = secilenDersler.Substring(0, secilenDersler.Length - 2);

            try
            {
                string sorgu = "";
                // Şifre kutusu boşsa varsayılan olarak TC Kimlik No ata, o da yoksa 1234
                string sifre = string.IsNullOrEmpty(txtOgrtSifre.Text) ? (string.IsNullOrEmpty(txtOgrtTc.Text) ? "1234" : txtOgrtTc.Text) : txtOgrtSifre.Text;

                if (secilenOgrtId == 0) // YENİ KAYIT
                {
                    sorgu = @"INSERT INTO Tbl_Ogretmenler 
                              (AdSoyad, TCNo, Telefon, Mail, Brans, GirebilecegiDersler, Sifre) 
                              VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                }
                else // GÜNCELLEME
                {
                    sorgu = @"UPDATE Tbl_Ogretmenler SET 
                              AdSoyad=@p1, TCNo=@p2, Telefon=@p3, Mail=@p4, Brans=@p5, GirebilecegiDersler=@p6, Sifre=@p7 
                              WHERE OgretmenID=" + secilenOgrtId;
                }

                SqlParameter[] p = {
                    new SqlParameter("@p1", txtOgrtAd.Text),
                    new SqlParameter("@p2", txtOgrtTc.Text),
                    new SqlParameter("@p3", txtOgrtTel.Text),
                    new SqlParameter("@p4", txtOgrtMail.Text),
                    new SqlParameter("@p5", cmbBrans.Text),
                    new SqlParameter("@p6", secilenDersler),
                    new SqlParameter("@p7", sifre) // Şifreyi de ekledim
                };

                SqlYardimcisi.KomutCalistir(sorgu, p);
                MessageBox.Show("İşlem Başarılı!");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- 4. SİL ---
        private void btnOgrtSil_Click(object sender, EventArgs e)
        {
            if (secilenOgrtId == 0) return;

            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlYardimcisi.KomutCalistir("DELETE FROM Tbl_Ogretmenler WHERE OgretmenID=" + secilenOgrtId);
                Listele();
                Temizle();
            }
        }

        // --- 5. TEMİZLE ---
        private void btnOgrtTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            txtOgrtAd.Text = "";
            txtOgrtTc.Text = "";
            txtOgrtTel.Text = "";
            txtOgrtMail.Text = "";
            txtOgrtSifre.Text = "";
            cmbBrans.Text = "";
            listDersler.Items.Clear();
            secilenOgrtId = 0;
            btnOgrtKaydet.Text = "KAYDET";
        }

        // --- 6. GRİD SEÇİMİ (BİLGİLERİ DOLDUR) ---
        private void gridViewOgretmen_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewOgretmen.GetDataRow(gridViewOgretmen.FocusedRowHandle);
            if (dr != null)
            {
                try
                {
                    secilenOgrtId = Convert.ToInt32(dr["OgretmenID"]);
                    txtOgrtAd.Text = dr["AdSoyad"].ToString();
                    txtOgrtTc.Text = dr["TCNo"].ToString();

                    if (dr.Table.Columns.Contains("Telefon")) txtOgrtTel.Text = dr["Telefon"].ToString();
                    if (dr.Table.Columns.Contains("Mail")) txtOgrtMail.Text = dr["Mail"].ToString();
                    if (dr.Table.Columns.Contains("Sifre")) txtOgrtSifre.Text = dr["Sifre"].ToString();

                    // Branşı seçince listDersler otomatik dolar (SelectedIndexChanged sayesinde)
                    if (dr.Table.Columns.Contains("Brans")) cmbBrans.Text = dr["Brans"].ToString();

                    // --- CHECKBOX İŞARETLEME MANTIĞI ---
                    if (dr.Table.Columns.Contains("GirebilecegiDersler"))
                    {
                        string kayitliDersler = dr["GirebilecegiDersler"].ToString();
                        string[] dersDizisi = kayitliDersler.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        // Listede bu dersleri bul ve tik at
                        for (int i = 0; i < listDersler.Items.Count; i++)
                        {
                            string listedeki = listDersler.Items[i].ToString().Trim();
                            foreach (string dbDers in dersDizisi)
                            {
                                if (listedeki == dbDers.Trim())
                                {
                                    listDersler.SetItemChecked(i, true);
                                }
                            }
                        }
                    }

                    btnOgrtKaydet.Text = "GÜNCELLE";
                }
                catch { }
            }
        }


    }
}