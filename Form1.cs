using DevExpress.XtraBars.Ribbon;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            LoadStudents();
        }

        private void LoadStudents()
        {
            string sorgu = "SELECT * FROM Tbl_Ogrenciler";
            DataTable dt = SqlYardimcisi.VeriGetir(sorgu);

            
            gridControl1.DataSource = dt;
        
    }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnYeniOgrenci_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 1. Yeni Öğrenci Formunu Oluştur
            FormAddStudent fr = new FormAddStudent();

            // 2. Formu Aç (Ana ekranı kilitleyerek açar)
            fr.ShowDialog();

            // 3. Form kapanınca listeyi yenile (ki yeni eklediğimiz kişiyi görelim)
            LoadStudents();
        }

        private void btnogrenciSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var secilenID = gridView1.GetFocusedRowCellValue("OgrenciID");

            if (secilenID == null)
            {
                MessageBox.Show("Lütfen silinecek öğrenciyi listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kullanıcıya son bir kez soralım (Yanlışlıkla basmış olabilir)
            DialogResult onay = MessageBox.Show("Bu öğrenciyi silmek istediğinize emin misiniz?\nBu işlem geri alınamaz!",
                                                "Silme Onayı",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    // 3. SQL Silme Sorgusu
                    string sorgu = "DELETE FROM Tbl_Ogrenciler WHERE OgrenciID = @p1";

                    // 4. Parametre (ID'yi gönderiyoruz)
                    SqlParameter[] parametreler = { new SqlParameter("@p1", secilenID) };

                    // 5. Komutu Çalıştır
                    int sonuc = SqlYardimcisi.KomutCalistir(sorgu, parametreler);

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Öğrenci başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 6. Listeyi Yenile (Silinen kişi ekrandan gitsin)
                        LoadStudents();
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 1. Seçili satırın ID'sini alıyoruz
            // (DevExpress'te seçili satırın hücresini okuma komutu budur)
            var secilenID = gridView1.GetFocusedRowCellValue("OgrenciID");

            // Eğer kimse seçilmediyse uyaralım
            if (secilenID == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğrenciyi seçiniz.", "Uyarı");
                return;
            }

            // 2. Formu oluşturuyoruz
            FormAddStudent fr = new FormAddStudent();

            // 3. EN ÖNEMLİ KISIM: Formun içindeki 'id' değişkenine seçilen ID'yi gönderiyoruz!
            // Form bunu görünce "Haa, demek ki güncelleme yapacağım" diyecek.
            fr.id = Convert.ToInt32(secilenID);

            // 4. Formu aç
            fr.ShowDialog();

            // 5. Form kapanınca listeyi yenile (Değişikliği görelim)
            LoadStudents();
        }
    }
}
