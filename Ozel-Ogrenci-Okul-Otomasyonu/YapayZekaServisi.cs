using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ozel_Ogrenci_Okul_Otomasyonu.DAL
{
    public class YapayZekaServisi
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> DersProgramiOlustur()
        {
            // 1. API Anahtarını Veritabanından Çek ve TEMİZLE
            string apiKey = "";
            DataTable dtAyarlar = SqlYardimcisi.VeriGetir("SELECT ApiKey FROM Tbl_Ayarlar WHERE ID=1");
            if (dtAyarlar.Rows.Count > 0 && dtAyarlar.Rows[0]["ApiKey"] != DBNull.Value)
            {
                // .Trim() komutu baştaki ve sondaki görünmez boşlukları siler.
                apiKey = dtAyarlar.Rows[0]["ApiKey"].ToString().Trim();
            }
            else
            {
                return "HATA: API Anahtarı bulunamadı. Lütfen Ayarlar sayfasından anahtarınızı girin.";
            }

            // 2. Sütun İsimlerini Otomatik Bul (Hata vermemesi için)
            string sqlSorgusu = "";
            DataTable dtSema = SqlYardimcisi.VeriGetir("SELECT TOP 0 * FROM Tbl_Ogretmenler");

            if (dtSema.Columns.Contains("OgretmenAdSoyad"))
                sqlSorgusu = "SELECT OgretmenAdSoyad, Brans FROM Tbl_Ogretmenler";
            else if (dtSema.Columns.Contains("AdSoyad"))
                sqlSorgusu = "SELECT AdSoyad AS OgretmenAdSoyad, Brans FROM Tbl_Ogretmenler";
            else if (dtSema.Columns.Contains("OgretmenAd") && dtSema.Columns.Contains("OgretmenSoyad"))
                sqlSorgusu = "SELECT (OgretmenAd + ' ' + OgretmenSoyad) AS OgretmenAdSoyad, Brans FROM Tbl_Ogretmenler";
            else if (dtSema.Columns.Contains("Ad") && dtSema.Columns.Contains("Soyad"))
                sqlSorgusu = "SELECT (Ad + ' ' + Soyad) AS OgretmenAdSoyad, Brans FROM Tbl_Ogretmenler";
            else
                return "HATA: Veritabanında öğretmen isim sütunu bulunamadı.";

            // 3. Verileri Hazırla
            StringBuilder veriSeti = new StringBuilder();
            veriSeti.AppendLine("Sen bir okul müdürüsün. Aşağıdaki öğretmen listesine göre 5 günlük (Hafta içi), günde 8 saatlik bir ders programı taslağı oluştur.");
            veriSeti.AppendLine("ÖNEMLİ: Çıktıyı JSON formatında DEĞİL, anlaşılır bir tablo veya liste formatında ver.\n");

            DataTable dtHocalar = SqlYardimcisi.VeriGetir(sqlSorgusu);

            if (dtHocalar.Rows.Count > 0)
            {
                veriSeti.AppendLine("ÖĞRETMENLER:");
                foreach (DataRow row in dtHocalar.Rows)
                {
                    string brans = dtHocalar.Columns.Contains("Brans") ? row["Brans"].ToString() : "Genel";
                    veriSeti.AppendLine($"- {row["OgretmenAdSoyad"]} ({brans})");
                }
            }
            else
            {
                return "HATA: Öğretmen listesi boş. Lütfen sisteme öğretmen ekleyin.";
            }

            // 4. GOOGLE GEMINI İSTEĞİ (EN GÜNCEL MODEL: gemini-1.5-flash)
            try
            {
                // Model ismini 'gemini-1.5-flash' olarak güncelledik.
                string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key={apiKey}";

                var requestBody = new
                {
                    contents = new[]
                    {
                        new { parts = new[] { new { text = veriSeti.ToString() } } }
                    }
                };

                string jsonBody = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);

                    if (jsonResponse.candidates != null && jsonResponse.candidates.Count > 0)
                    {
                        return jsonResponse.candidates[0].content.parts[0].text;
                    }
                    else
                    {
                        return "HATA: Yapay zeka boş cevap döndürdü. (Model yanıt vermedi)";
                    }
                }
                else
                {
                    // Hata detayını göster
                    string hataDetayi = await response.Content.ReadAsStringAsync();
                    return $"HATA: Bağlantı sorunu.\nKod: {response.StatusCode}\nDetay: {hataDetayi}";
                }
            }
            catch (Exception ex)
            {
                return "KRİTİK HATA: " + ex.Message;
            }
        }
    }
}