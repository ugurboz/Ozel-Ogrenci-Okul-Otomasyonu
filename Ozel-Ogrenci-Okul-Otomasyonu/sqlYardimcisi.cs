using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ozel_Ogrenci_Okul_Otomasyonu.DAL
{
    internal class SqlYardimcisi
    {
        private static string BaglantiAdresi = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OkulOtomasyonuDb;Integrated Security=True;Encrypt=False";

        // SELECT işlemleri için (Veri Getir)
        public static DataTable VeriGetir(string sorgu, SqlParameter[] p = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection baglanti = new SqlConnection(BaglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti))
                    {
                        if (p != null) da.SelectCommand.Parameters.AddRange(p);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Veri Çekme Hatası: " + ex.Message); }
            }
            return dt;
        }

        // INSERT, UPDATE, DELETE işlemleri için (Komut Çalıştır)
        public static int KomutCalistir(string sorgu, SqlParameter[] p = null)
        {
            int sonuc = 0;
            using (SqlConnection baglanti = new SqlConnection(BaglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                    {
                        if (p != null) cmd.Parameters.AddRange(p);
                        sonuc = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { MessageBox.Show("İşlem Hatası: " + ex.Message); }
            }
            return sonuc;
        }
    }
}
