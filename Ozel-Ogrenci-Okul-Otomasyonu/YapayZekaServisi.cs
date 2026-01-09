using System;
using System.Data;
using System.Data.SqlClient;
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
            // 1. API Anahtarını Veritabanından Çek
            string apiKey = "";
            string apiProvider = "Gemini"; // Varsayılan

            try
            {
                // Önce sadece ApiKey'i çek (ApiProvider kolonu yoksa hata almamak için)
                DataTable dtAyarlar = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ayarlar WHERE ID=1");

                if (dtAyarlar.Rows.Count > 0)
                {
                    DataRow dr = dtAyarlar.Rows[0];

                    if (dtAyarlar.Columns.Contains("ApiKey") && dr["ApiKey"] != DBNull.Value)
                        apiKey = dr["ApiKey"].ToString().Trim();

                    // ApiProvider kolonu varsa oku, yoksa varsayılan kullan
                    if (dtAyarlar.Columns.Contains("ApiProvider") && dr["ApiProvider"] != DBNull.Value)
                        apiProvider = dr["ApiProvider"].ToString();
                }
            }
            catch (Exception ex)
            {
                return $"HATA: Ayarlar okunamadı - {ex.Message}";
            }

            // API key kontrolü
            if (string.IsNullOrEmpty(apiKey))
            {
                return $"HATA: {apiProvider} API Anahtarı bulunamadı. Lütfen Ayarlar sayfasından anahtarınızı girin.";
            }

            // 2. Öğretmen ve Öğrenci ID'lerini Çek
            StringBuilder veriSeti = new StringBuilder();
            veriSeti.AppendLine("Sen bir özel eğitim okulu müdürüsün. Aşağıdaki öğretmen ve öğrenci bilgilerine göre HAFTALIK ders programı oluştur.");
            veriSeti.AppendLine("");
            veriSeti.AppendLine("ÇIKTI FORMATI: JSON array olarak ver. Her ders için şu formatı kullan:");
            veriSeti.AppendLine("[");
            veriSeti.AppendLine("  {\"gun\": \"Pazartesi\", \"saat\": \"09:00\", \"ogrenci_id\": 1, \"ogretmen_id\": 1},");
            veriSeti.AppendLine("  {\"gun\": \"Pazartesi\", \"saat\": \"10:00\", \"ogrenci_id\": 2, \"ogretmen_id\": 1},");
            veriSeti.AppendLine("  ...");
            veriSeti.AppendLine("]");
            veriSeti.AppendLine("");
            veriSeti.AppendLine("KURALLAR:");
            veriSeti.AppendLine("- Günler: Pazartesi, Salı, Çarşamba, Perşembe, Cuma");
            veriSeti.AppendLine("- Saatler: 09:00, 10:00, 11:00, 13:00, 14:00, 15:00, 16:00");
            veriSeti.AppendLine("- Her öğrenci için haftada EN AZ 3 ders planla");
            veriSeti.AppendLine("- SADECE JSON array döndür, başka açıklama yazma!");
            veriSeti.AppendLine("");

            // Öğretmenler
            try
            {
                DataTable dtOgretmen = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ogretmenler");

                if (dtOgretmen.Rows.Count > 0)
                {
                    veriSeti.AppendLine("=== ÖĞRETMENLER ===");
                    foreach (DataRow row in dtOgretmen.Rows)
                    {
                        int id = 0;
                        string ad = "";
                        string brans = "";

                        // ID'yi al
                        if (dtOgretmen.Columns.Contains("OgretmenID"))
                            id = Convert.ToInt32(row["OgretmenID"]);

                        // Ad alanını bul
                        if (dtOgretmen.Columns.Contains("OgretmenAdSoyad"))
                            ad = row["OgretmenAdSoyad"]?.ToString() ?? "";
                        else if (dtOgretmen.Columns.Contains("AdSoyad"))
                            ad = row["AdSoyad"]?.ToString() ?? "";
                        else if (dtOgretmen.Columns.Contains("OgretmenAd"))
                            ad = row["OgretmenAd"]?.ToString() ?? "";

                        // Branş alanını bul
                        if (dtOgretmen.Columns.Contains("Brans"))
                            brans = row["Brans"]?.ToString() ?? "Genel";

                        veriSeti.AppendLine($"- ID:{id} | {ad} (Branş: {brans})");
                    }
                    veriSeti.AppendLine();
                }
                else
                {
                    return "HATA: Öğretmen listesi boş. Lütfen sisteme öğretmen ekleyin.";
                }
            }
            catch (Exception ex)
            {
                return $"HATA: Öğretmen bilgileri okunamadı - {ex.Message}";
            }

            // 3. Öğrenci Bilgilerini Çek
            try
            {
                DataTable dtOgrenci = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ogrenciler");

                if (dtOgrenci.Rows.Count > 0)
                {
                    veriSeti.AppendLine("=== ÖĞRENCİLER ===");
                    foreach (DataRow row in dtOgrenci.Rows)
                    {
                        int id = 0;
                        string ad = "";
                        string engelTuru = "";

                        // ID'yi al
                        if (dtOgrenci.Columns.Contains("OgrenciID"))
                            id = Convert.ToInt32(row["OgrenciID"]);

                        // Ad alanını bul
                        if (dtOgrenci.Columns.Contains("AdSoyad"))
                            ad = row["AdSoyad"]?.ToString() ?? "";
                        else if (dtOgrenci.Columns.Contains("OgrenciAdSoyad"))
                            ad = row["OgrenciAdSoyad"]?.ToString() ?? "";

                        // Engel türünü bul
                        if (dtOgrenci.Columns.Contains("EngelTuru"))
                            engelTuru = row["EngelTuru"]?.ToString() ?? "";

                        veriSeti.AppendLine($"- ID:{id} | {ad} (Engel Türü: {engelTuru})");
                    }
                    veriSeti.AppendLine();
                }
            }
            catch
            {
                // Öğrenci tablosu boşsa devam et
            }

            // 4. API'ye göre istek gönder
            try
            {
                string sonuc;
                if (apiProvider == "ChatGPT")
                {
                    sonuc = await ChatGptIstekGonder(apiKey, veriSeti.ToString());
                }
                else // Gemini (varsayılan)
                {
                    sonuc = await GeminiIstekGonder(apiKey, veriSeti.ToString());
                }

                // Sonucu döndür - kaydetme işlemi onay formunda yapılacak
                return sonuc;
            }
            catch (Exception ex)
            {
                return "KRİTİK HATA: " + ex.Message;
            }
        }

        // --- FİLTRELİ DERS PROGRAMI OLUŞTUR ---
        public static async Task<string> DersProgramiOlusturFiltreli(
            List<int> secilenOgrenciler,
            List<int> secilenOgretmenler,
            DateTime baslangic,
            DateTime bitis)
        {
            // API Ayarlarını Çek
            string apiKey = "";
            string apiProvider = "Gemini";

            try
            {
                DataTable dtAyarlar = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ayarlar WHERE ID=1");
                if (dtAyarlar.Rows.Count > 0)
                {
                    DataRow dr = dtAyarlar.Rows[0];
                    if (dtAyarlar.Columns.Contains("ApiKey") && dr["ApiKey"] != DBNull.Value)
                        apiKey = dr["ApiKey"].ToString().Trim();
                    if (dtAyarlar.Columns.Contains("ApiProvider") && dr["ApiProvider"] != DBNull.Value)
                        apiProvider = dr["ApiProvider"].ToString();
                }
            }
            catch (Exception ex)
            {
                return $"HATA: Ayarlar okunamadı - {ex.Message}";
            }

            if (string.IsNullOrEmpty(apiKey))
            {
                return $"HATA: {apiProvider} API Anahtarı bulunamadı.";
            }

            // Prompt oluştur
            StringBuilder veriSeti = new StringBuilder();
            veriSeti.AppendLine($"Tarih aralığı: {baslangic:dd.MM.yyyy} - {bitis:dd.MM.yyyy}");
            veriSeti.AppendLine("Bu tarihler arasındaki hafta içi günler için ders programı oluştur.");
            veriSeti.AppendLine("");
            veriSeti.AppendLine("ÇIKTI FORMATI: JSON array. Her ders için:");
            veriSeti.AppendLine("[{\"gun\": \"Pazartesi\", \"saat\": \"09:00\", \"ogrenci_id\": 1, \"ogretmen_id\": 1}, ...]");
            veriSeti.AppendLine("SADECE JSON döndür!");
            veriSeti.AppendLine("");

            // Seçilen öğretmenler
            string ogretmenIds = string.Join(",", secilenOgretmenler);
            DataTable dtOgretmen = SqlYardimcisi.VeriGetir($"SELECT OgretmenID, AdSoyad, Brans FROM Tbl_Ogretmenler WHERE OgretmenID IN ({ogretmenIds})");
            veriSeti.AppendLine("ÖĞRETMENLER:");
            foreach (DataRow row in dtOgretmen.Rows)
            {
                veriSeti.AppendLine($"- ID:{row["OgretmenID"]} | {row["AdSoyad"]} ({row["Brans"]})");
            }
            veriSeti.AppendLine("");

            // Seçilen öğrenciler
            string ogrenciIds = string.Join(",", secilenOgrenciler);
            DataTable dtOgrenci = SqlYardimcisi.VeriGetir($"SELECT OgrenciID, AdSoyad, EngelTuru FROM Tbl_Ogrenciler WHERE OgrenciID IN ({ogrenciIds})");
            veriSeti.AppendLine("ÖĞRENCİLER:");
            foreach (DataRow row in dtOgrenci.Rows)
            {
                veriSeti.AppendLine($"- ID:{row["OgrenciID"]} | {row["AdSoyad"]} ({row["EngelTuru"]})");
            }

            // API çağrısı
            try
            {
                if (apiProvider == "ChatGPT")
                    return await ChatGptIstekGonder(apiKey, veriSeti.ToString());
                else
                    return await GeminiIstekGonder(apiKey, veriSeti.ToString());
            }
            catch (Exception ex)
            {
                return "KRİTİK HATA: " + ex.Message;
            }
        }

        // --- DERS PROGRAMINI VERİTABANINA KAYDET ---
        private static async Task DersProgramiKaydet(string program, string apiProvider)
        {
            try
            {
                // Tablo yoksa oluştur
                string tabloKontrol = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tbl_DersProgramlari')
                    BEGIN
                        CREATE TABLE Tbl_DersProgramlari (
                            ID INT PRIMARY KEY IDENTITY(1,1),
                            Program NVARCHAR(MAX),
                            OlusturmaTarihi DATETIME DEFAULT GETDATE(),
                            ApiProvider NVARCHAR(50)
                        )
                    END";

                SqlYardimcisi.KomutCalistir(tabloKontrol);

                // Programı kaydet
                string kaydetSorgu = "INSERT INTO Tbl_DersProgramlari (Program, ApiProvider) VALUES (@p1, @p2)";
                SqlParameter[] p = {
                    new SqlParameter("@p1", program),
                    new SqlParameter("@p2", apiProvider)
                };

                SqlYardimcisi.KomutCalistir(kaydetSorgu, p);
            }
            catch
            {
                // Kayıt başarısız olsa bile ana işlemi engelleme
            }
        }

        // --- SON OLUŞTURULAN PROGRAMI GETİR ---
        public static string SonProgramiGetir()
        {
            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT TOP 1 * FROM Tbl_DersProgramlari ORDER BY OlusturmaTarihi DESC");
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["Program"]?.ToString() ?? "";
                }
            }
            catch { }
            return "";
        }

        // --- GEMINI API ---
        private static async Task<string> GeminiIstekGonder(string apiKey, string prompt)
        {
            // Güncel model: gemini-2.0-flash-exp veya gemini-pro
            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash-exp:generateContent?key={apiKey}";

            var requestBody = new
            {
                contents = new[]
                {
                    new { parts = new[] { new { text = prompt } } }
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
                    return "HATA: Gemini boş cevap döndürdü.";
                }
            }
            else
            {
                string hataDetayi = await response.Content.ReadAsStringAsync();
                return $"HATA (Gemini): Bağlantı sorunu.\nKod: {response.StatusCode}\nDetay: {hataDetayi}";
            }
        }

        // --- CHATGPT (OpenAI) API ---
        private static async Task<string> ChatGptIstekGonder(string apiKey, string prompt)
        {
            string url = "https://api.openai.com/v1/chat/completions";

            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                    new { role = "user", content = prompt }
                },
                max_tokens = 2000
            };

            string jsonBody = JsonConvert.SerializeObject(requestBody);

            using (var request = new HttpRequestMessage(HttpMethod.Post, url))
            {
                request.Headers.Add("Authorization", $"Bearer {apiKey}");
                request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);

                    if (jsonResponse.choices != null && jsonResponse.choices.Count > 0)
                    {
                        return jsonResponse.choices[0].message.content;
                    }
                    else
                    {
                        return "HATA: ChatGPT boş cevap döndürdü.";
                    }
                }
                else
                {
                    string hataDetayi = await response.Content.ReadAsStringAsync();
                    return $"HATA (ChatGPT): Bağlantı sorunu.\nKod: {response.StatusCode}\nDetay: {hataDetayi}";
                }
            }
        }
    }
}