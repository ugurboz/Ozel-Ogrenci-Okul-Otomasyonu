using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL; // SQL Yardımcısı Sınıfın

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class UcOgretmen : DevExpress.XtraEditors.XtraUserControl
    {
        // Güncelleme işlemi için ID'yi hafızada tutuyoruz
        int secilenOgrtId = 0;

        public UcOgretmen()
        {
            InitializeComponent();
        }

        // --- SAYFA YÜKLENİNCE ---
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
                // Tablo adının Tbl_Ogretmenler olduğundan emin ol
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ogretmenler");
                gridControlOgretmen.DataSource = dt;

                // Grid ayarları (Sütunları otomatik ayarla)
                gridViewOgretmen.PopulateColumns();
                gridViewOgretmen.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }

        // --- 2. BRANŞ SEÇİLİNCE DERSLERİ GETİR (Rehabilitasyon Formatı) ---
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenBrans = cmbBrans.Text;

            // Listeyi temizle (Önceki öğretmenden kalanlar silinsin)
            listDersler.Items.Clear();

            // API SİMÜLASYONU: Branşa Göre Eğitim/Terapi Listesi
            List<string> gelenDersler = new List<string>();

            switch (secilenBrans)
            {
                case "Zihinsel Engelliler Öğretmeni":
                    gelenDersler.AddRange(new string[] {
                        "Öz Bakım Becerileri",
                        "Günlük Yaşam Becerileri",
                        "Toplumsal Uyum",
                        "Okuma-Yazma Hazırlık",
                        "Kavram Öğretimi"
                    });
                    break;

                case "Fizyoterapist":
                    gelenDersler.AddRange(new string[] {
                        "Kaba Motor Becerileri",
                        "İnce Motor Becerileri",
                        "Denge ve Koordinasyon",
                        "Kas Güçlendirme",
                        "Yürüme Eğitimi"
                    });
                    break;

                case "Dil ve Konuşma Terapisti":
                    gelenDersler.AddRange(new string[] {
                        "Ses Farkındalığı",
                        "Akıcı Konuşma",
                        "Dil Bozuklukları Terapisi",
                        "Alternatif İletişim",
                        "Yutma Bozuklukları"
                    });
                    break;

                case "Psikolog / Rehberlik":
                    gelenDersler.AddRange(new string[] {
                        "Aile Eğitimi ve Danışmanlığı",
                        "Davranış Problemleri",
                        "Sosyal Beceri Eğitimi",
                        "Mahremiyet Eğitimi"
                    });
                    break;

                case "Ergoterapist":
                    gelenDersler.AddRange(new string[] {
                        "Duyu Bütünleme",
                        "El-Göz Koordinasyonu",
                        "Bağımsız Yaşam Becerileri",
                        "Dikkat ve Odaklanma"
                    });
                    break;

                case "Okul Öncesi":
                    gelenDersler.AddRange(new string[] {
                        "Oyun Terapisi",
                        "Boyama ve Çizim",
                        "Grup Etkinlikleri"
                    });
                    break;

                default:
                    gelenDersler.Add("Genel Rehabilitasyon");
                    break;
            }

            // Listbox'a doldur
            foreach (string ders in gelenDersler)
            {
                listDersler.Items.Add(ders);
            }
        }

        // --- 3. KAYDET / GÜNCELLE BUTONU ---
        private void btnOgrtKaydet_Click(object sender, EventArgs e)
        {
            // İsim boşsa kaydetme
            if (string.IsNullOrEmpty(txtOgrtAd.Text)) return;

            // Seçilen dersleri tek bir metne çevir (Örn: "Denge, Yürüme Eğitimi")
            string secilenDersler = "";
            foreach (object item in listDersler.CheckedItems)
            {
                secilenDersler += item.ToString() + ", ";
            }
            // Sondaki virgülü temizle
            if (secilenDersler.Length > 2) secilenDersler = secilenDersler.Substring(0, secilenDersler.Length - 2);

            try
            {
                string sorgu = "";

                // ID 0 ise YENİ KAYIT
                if (secilenOgrtId == 0)
                {
                    sorgu = "INSERT INTO Tbl_Ogretmenler (AdSoyad, TCNo, Telefon, Mail, Brans, GirebilecegiDersler) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
                }
                // ID doluysa GÜNCELLEME
                else
                {
                    sorgu = "UPDATE Tbl_Ogretmenler SET AdSoyad=@p1, TCNo=@p2, Telefon=@p3, Mail=@p4, Brans=@p5, GirebilecegiDersler=@p6 WHERE OgretmenID=" + secilenOgrtId;
                }

                SqlParameter[] p = {
                    new SqlParameter("@p1", txtOgrtAd.Text),
                    new SqlParameter("@p2", txtOgrtTc.Text),
                    new SqlParameter("@p3", txtOgrtTel.Text),
                    new SqlParameter("@p4", txtOgrtMail.Text),
                    new SqlParameter("@p5", cmbBrans.Text),
                    new SqlParameter("@p6", secilenDersler) // Metne çevirdiğimiz dersler
                };

                SqlYardimcisi.KomutCalistir(sorgu, p);
                MessageBox.Show("Öğretmen Başarıyla Kaydedildi!");

                Listele(); // Listeyi yenile
                Temizle(); // Kutuları boşalt
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme Hatası: " + ex.Message);
            }
        }

        // --- 4. SİL BUTONU ---
        private void btnOgrtSil_Click(object sender, EventArgs e)
        {
            if (secilenOgrtId == 0) return;

            if (MessageBox.Show("Bu öğretmeni silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlYardimcisi.KomutCalistir("DELETE FROM Tbl_Ogretmenler WHERE OgretmenID=" + secilenOgrtId);
                Listele();
                Temizle();
            }
        }

        // --- 5. TEMİZLE BUTONU ---
        private void btnOgrtTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        // Formu temizleyen yardımcı metot
        void Temizle()
        {
            txtOgrtAd.Text = "";
            txtOgrtTc.Text = "";
            txtOgrtTel.Text = "";
            txtOgrtMail.Text = "";
            cmbBrans.Text = "";
            listDersler.Items.Clear(); // Ders listesini de boşalt
            secilenOgrtId = 0;
            btnOgrtKaydet.Text = "KAYDET";
        }

        // --- 6. GRİD TIKLAMA (Verileri Geri Yükle) ---
        private void gridViewOgretmen_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewOgretmen.GetDataRow(gridViewOgretmen.FocusedRowHandle);

            if (dr != null)
            {
                secilenOgrtId = Convert.ToInt32(dr["OgretmenID"]);
                txtOgrtAd.Text = dr["AdSoyad"].ToString();
                txtOgrtTc.Text = dr["TCNo"].ToString();
                txtOgrtTel.Text = dr["Telefon"].ToString();

                // Mail sütunu yoksa hata vermesin diye try-catch içinde
                try { txtOgrtMail.Text = dr["Mail"].ToString(); } catch { }

                // Branşı yükleyince otomatik olarak cmbBrans_SelectedIndexChanged çalışır ve ders listesi dolar
                cmbBrans.Text = dr["Brans"].ToString();

                // Şimdi kayıtlı olan dersleri listede "Tikli" (Checked) yapalım
                try
                {
                    string kayitliDersler = dr["GirebilecegiDersler"].ToString(); // "Denge, Yürüme"
                    string[] dersDizisi = kayitliDersler.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    // Listeyi gez, veritabanında olanları işaretle
                    for (int i = 0; i < listDersler.Items.Count; i++)
                    {
                        string listedekiDers = listDersler.Items[i].ToString();

                        foreach (string dbDers in dersDizisi)
                        {
                            // Boşlukları temizleyip karşılaştır
                            if (listedekiDers.Trim() == dbDers.Trim())
                            {
                                listDersler.SetItemChecked(i, true);
                            }
                        }
                    }
                }
                catch { }

                btnOgrtKaydet.Text = "GÜNCELLE"; // Modu değiştir
            }
        }

      
    }
}