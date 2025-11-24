using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL Parametreleri için EKLEMEK ZORUNDAYIZ
using Ozel_Ogrenci_Okul_Otomasyonu.DAL; // SqlYardimcisi için EKLEMEK ZORUNDAYIZ

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class FormAddStudent : DevExpress.XtraEditors.XtraForm
    {
        public int id = 0;
        public FormAddStudent()
        {
            InitializeComponent();
        }

        // Form Yüklendiğinde çalışacak kodlar (Şimdilik boş kalabilir)
        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                this.Text = "Öğrenci Bilgilerini Güncelle"; // Formun başlığını değiştir

                // NOT: Butonun text'ini değiştirmek istersek buton ismine ihtiyacımız var.
                // Senin kodunda butonun adı 'btnKaydet' mi yoksa 'addname' mi? 
                // Eğer 'btnKaydet' ise şu satırı aç:
                // btnKaydet.Text = "GÜNCELLE"; 

                // Veriyi çek
                string sorgu = "SELECT * FROM Tbl_Ogrenciler WHERE OgrenciID = " + id;
                DataTable dt = SqlYardimcisi.VeriGetir(sorgu);

                if (dt.Rows.Count > 0)
                {
                    // Veritabanından gelenleri kutulara doldur (Senin verdiğin isimlere göre)
                    DataRow satir = dt.Rows[0];

                    tcno.Text = satir["TCKimlikNo"].ToString();
                    txtadsoyad.Text = satir["AdSoyad"].ToString();

                    // Tarih boş gelebilir, kontrol edelim
                    if (satir["DogumTarihi"] != DBNull.Value)
                    {
                        dogumtarih.DateTime = Convert.ToDateTime(satir["DogumTarihi"]);
                    }

                    engelturu.Text = satir["EngelTuru"].ToString();
                    engelorani.Text = satir["EngelOrani"].ToString();
                }
            }
        
        }

        // KAYDET BUTONU (Senin kodunda adı 'addname' kalmış)

        private void addname_Click(object sender, EventArgs e)
        {
            // 1. KONTROL (Test Amaçlı)
            // Bu satır sayesinde ID'nin kaç geldiğini göreceğiz. 
            // Güncelleme yaparken ekrana "ID Değeri: 5" gibi bir şey gelmeli.
            // "ID Değeri: 0" geliyorsa sorun başka yerdedir.
            // (Test ettikten sonra bu satırı silebilirsin)
            // MessageBox.Show("Şu anki İşlem ID'si: " + id.ToString());

            // 2. Boş Alan Kontrolü
            if (string.IsNullOrEmpty(txtadsoyad.Text) || string.IsNullOrEmpty(tcno.Text))
            {
                MessageBox.Show("Ad Soyad ve TC Kimlik boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sorgu = "";

                // 3. KARAR ANI: Ekleme mi, Güncelleme mi?
                if (id == 0)
                {
                    // --- INSERT (YENİ KAYIT) ---
                    sorgu = "INSERT INTO Tbl_Ogrenciler (TCKimlikNo, AdSoyad, DogumTarihi, EngelTuru, EngelOrani, KayitTarihi) " +
                            "VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
                }
                else
                {
                    // --- UPDATE (GÜNCELLEME) ---
                    // DİKKAT: WHERE OgrenciID = " + id kısmı çok önemli!
                    sorgu = "UPDATE Tbl_Ogrenciler SET TCKimlikNo=@p1, AdSoyad=@p2, DogumTarihi=@p3, EngelTuru=@p4, EngelOrani=@p5 " +
                            "WHERE OgrenciID=" + id;
                }

                // 4. Parametreler (Verileri kutulardan al)
                SqlParameter[] parametreler = {
            new SqlParameter("@p1", tcno.Text),
            new SqlParameter("@p2", txtadsoyad.Text),
            new SqlParameter("@p3", dogumtarih.DateTime),
            new SqlParameter("@p4", engelturu.Text),
            new SqlParameter("@p5", engelorani.Text), // Buranın 'txtEngelOrani' değil 'engelorani' olduğunu senin kodundan gördüm
            new SqlParameter("@p6", DateTime.Now)
        };

                // 5. Komutu Gönder
                int sonuc = SqlYardimcisi.KomutCalistir(sorgu, parametreler);

                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem Başarılı! ✅", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Formu kapat
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız ❌", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        // Diğer boş tıklamalar (Bunlar şimdilik önemsiz, durabilir)
        private void labelControl2_Click(object sender, EventArgs e) { }
        private void textEdit2_EditValueChanged(object sender, EventArgs e) { }
        private void tcno_EditValueChanged(object sender, EventArgs e) { }
        private void dogumtarih_EditValueChanged(object sender, EventArgs e) { }
        private void engelturu_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtadsoyad_EditValueChanged(object sender, EventArgs e) { }
        private void labelControl1_Click(object sender, EventArgs e) { }
        private void labelControl3_Click(object sender, EventArgs e) { }
        private void labelControl4_Click(object sender, EventArgs e) { }
    }
}