using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ozel_Ogrenci_Okul_Otomasyonu.DAL
{
    public class SqlYardimcisi
    {
        // Bağlantı Adresi
        private static string BaglantiAdresi
        {
            get
            {
                return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OzelOgrenciOkulOtomasyonDb;Integrated Security=True;Encrypt=False";
            }
        }

        // Veri Çekme Metodu
        public static DataTable VeriGetir(string sorgu)
        {
            DataTable dt = new DataTable();
            using (SqlConnection baglanti = new SqlConnection(BaglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı Hatası: " + ex.Message);
                }
            }
            return dt;
        }

        // GÜNCELLENMİŞ KOMUT METODU (Hatanı Çözecek Kısım Burası)
        public static int KomutCalistir(string komutMetni, SqlParameter[] parametreler = null)
        {
            int sonuc = 0;
            using (SqlConnection baglanti = new SqlConnection(BaglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    using (SqlCommand cmd = new SqlCommand(komutMetni, baglanti))
                    {
                        if (parametreler != null)
                        {
                            cmd.Parameters.AddRange(parametreler);
                        }
                        sonuc = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem Hatası: " + ex.Message);
                }
            }
            return sonuc;
        }
    }
}