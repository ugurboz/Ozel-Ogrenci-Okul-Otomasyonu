using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class FrmDersProgramiOnay : Form
    {
        public bool OnaylandiMi { get; private set; } = false;
        public string Program { get; set; } = "";
        private List<DersProgramiItem> parsedDersler = new List<DersProgramiItem>();
        private Dictionary<int, string> ogretmenAdlari = new Dictionary<int, string>();
        private Dictionary<int, string> ogrenciAdlari = new Dictionary<int, string>();

        public FrmDersProgramiOnay()
        {
            InitializeComponent();
        }

        public FrmDersProgramiOnay(string program) : this()
        {
            Program = program;
            LoadIsimler();
            ParseVeGoster();
        }

        private void LoadIsimler()
        {
            // Öğretmen isimlerini yükle
            try
            {
                DataTable dtOgretmen = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ogretmenler");
                foreach (DataRow row in dtOgretmen.Rows)
                {
                    int id = Convert.ToInt32(row["OgretmenID"]);
                    string ad = "";
                    if (dtOgretmen.Columns.Contains("AdSoyad"))
                        ad = row["AdSoyad"]?.ToString() ?? "";
                    else if (dtOgretmen.Columns.Contains("OgretmenAdSoyad"))
                        ad = row["OgretmenAdSoyad"]?.ToString() ?? "";

                    if (!ogretmenAdlari.ContainsKey(id))
                        ogretmenAdlari.Add(id, ad);
                }
            }
            catch { }

            // Öğrenci isimlerini yükle
            try
            {
                DataTable dtOgrenci = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ogrenciler");
                foreach (DataRow row in dtOgrenci.Rows)
                {
                    int id = Convert.ToInt32(row["OgrenciID"]);
                    string ad = "";
                    if (dtOgrenci.Columns.Contains("AdSoyad"))
                        ad = row["AdSoyad"]?.ToString() ?? "";
                    else if (dtOgrenci.Columns.Contains("OgrenciAdSoyad"))
                        ad = row["OgrenciAdSoyad"]?.ToString() ?? "";

                    if (!ogrenciAdlari.ContainsKey(id))
                        ogrenciAdlari.Add(id, ad);
                }
            }
            catch { }
        }

        private void ParseVeGoster()
        {
            try
            {
                // JSON array'i bul
                string jsonMatch = ExtractJsonArray(Program);

                if (!string.IsNullOrEmpty(jsonMatch))
                {
                    parsedDersler = JsonConvert.DeserializeObject<List<DersProgramiItem>>(jsonMatch);
                }

                // DataTable oluştur
                DataTable dt = new DataTable();
                dt.Columns.Add("Gün", typeof(string));
                dt.Columns.Add("Saat", typeof(string));
                dt.Columns.Add("Öğrenci", typeof(string));
                dt.Columns.Add("Öğretmen", typeof(string));

                if (parsedDersler != null && parsedDersler.Count > 0)
                {
                    foreach (var ders in parsedDersler)
                    {
                        string ogrenciAd = ogrenciAdlari.ContainsKey(ders.ogrenci_id)
                            ? ogrenciAdlari[ders.ogrenci_id]
                            : $"ID: {ders.ogrenci_id}";

                        string ogretmenAd = ogretmenAdlari.ContainsKey(ders.ogretmen_id)
                            ? ogretmenAdlari[ders.ogretmen_id]
                            : $"ID: {ders.ogretmen_id}";

                        dt.Rows.Add(ders.gun, ders.saat, ogrenciAd, ogretmenAd);
                    }
                }
                else
                {
                    // JSON parse edilemezse ham metni göster
                    dt.Rows.Add("Veri", "yüklenemedi", "JSON formatı", "bulunamadı");
                }

                gridControl1.DataSource = dt;
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {
                // Hata durumunda basit tablo göster
                DataTable dt = new DataTable();
                dt.Columns.Add("Hata", typeof(string));
                dt.Rows.Add("JSON parse hatası: " + ex.Message);
                gridControl1.DataSource = dt;
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (parsedDersler == null || parsedDersler.Count == 0)
                {
                    XtraMessageBox.Show("Ders programı verisi bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // JSON'u parse et ve takvime ekle
                int eklenenSeans = TakvimeEkle();

                if (eklenenSeans > 0)
                {
                    OnaylandiMi = true;
                    XtraMessageBox.Show(
                        $"Ders programı onaylandı!\n\n{eklenenSeans} adet seans takvime eklendi.",
                        "Başarılı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show(
                        "Seanslar takvime eklenemedi!",
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("İşlem Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            OnaylandiMi = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private int TakvimeEkle()
        {
            int eklenenSayisi = 0;

            try
            {
                // Gün-tarih eşleştirmesi (gelecek haftanın günleri)
                Dictionary<string, DateTime> gunTarih = GetGelecekHaftaninGunleri();

                // ---------------------------------------------------------
                // 1. ADIM: O HAFTANIN DERSLERİNİ TEMİZLE (Kullanıcı İsteği)
                // ---------------------------------------------------------
                if (gunTarih.ContainsKey("Pazartesi"))
                {
                    DateTime baslangic = gunTarih["Pazartesi"];
                    DateTime bitis = baslangic.AddDays(6); // Pazar gününe kadar sil

                    // Haftalık temizlik sorgusu
                    string silSorgu = "DELETE FROM Tbl_Seanslar WHERE Tarih >= @pStart AND Tarih <= @pEnd";
                    SqlParameter[] pSil = {
                        new SqlParameter("@pStart", baslangic.ToString("yyyy-MM-dd")),
                        new SqlParameter("@pEnd", bitis.ToString("yyyy-MM-dd"))
                    };
                    SqlYardimcisi.KomutCalistir(silSorgu, pSil);
                }
                // ---------------------------------------------------------

                foreach (var ders in parsedDersler)
                {
                    try
                    {
                        // Günü tarihe çevir
                        DateTime tarih = gunTarih.ContainsKey(ders.gun) ? gunTarih[ders.gun] : DateTime.Now.AddDays(1);

                        string sorgu = "INSERT INTO Tbl_Seanslar (OgrenciID, OgretmenID, Tarih, Saat, Durum) VALUES (@p1, @p2, @p3, @p4, 1)";
                        SqlParameter[] p = {
                            new SqlParameter("@p1", ders.ogrenci_id),
                            new SqlParameter("@p2", ders.ogretmen_id),
                            new SqlParameter("@p3", tarih.ToString("yyyy-MM-dd")),
                            new SqlParameter("@p4", ders.saat)
                        };

                        SqlYardimcisi.KomutCalistir(sorgu, p);
                        eklenenSayisi++;
                    }
                    catch
                    {
                        continue;
                    }
                }

                // Programı da kaydet
                if (eklenenSayisi > 0)
                {
                    DersProgramiKaydet();
                }
            }
            catch { }

            return eklenenSayisi;
        }

        private string ExtractJsonArray(string text)
        {
            var match = Regex.Match(text, @"\[[\s\S]*\]");
            return match.Success ? match.Value : null;
        }

        private Dictionary<string, DateTime> GetGelecekHaftaninGunleri()
        {
            var gunler = new Dictionary<string, DateTime>();

            // Gelecek haftanın pazartesisini bul
            DateTime bugun = DateTime.Now;
            int gunFarki = ((int)DayOfWeek.Monday - (int)bugun.DayOfWeek + 7) % 7;
            if (gunFarki == 0) gunFarki = 7; // Bu gün pazartesiyse gelecek pazartesi
            DateTime pazartesi = bugun.AddDays(gunFarki);

            gunler["Pazartesi"] = pazartesi;
            gunler["Salı"] = pazartesi.AddDays(1);
            gunler["Çarşamba"] = pazartesi.AddDays(2);
            gunler["Perşembe"] = pazartesi.AddDays(3);
            gunler["Cuma"] = pazartesi.AddDays(4);

            return gunler;
        }

        private void DersProgramiKaydet()
        {
            string tabloOlustur = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tbl_DersProgramlari')
                BEGIN
                    CREATE TABLE Tbl_DersProgramlari (
                        ID INT PRIMARY KEY IDENTITY(1,1),
                        Program NVARCHAR(MAX),
                        OlusturmaTarihi DATETIME DEFAULT GETDATE()
                    )
                END";

            SqlYardimcisi.KomutCalistir(tabloOlustur);

            string kaydetSorgu = "INSERT INTO Tbl_DersProgramlari (Program) VALUES (@p1)";
            SqlParameter[] p = { new SqlParameter("@p1", Program) };
            SqlYardimcisi.KomutCalistir(kaydetSorgu, p);
        }
    }

    public class DersProgramiItem
    {
        public string gun { get; set; }
        public string saat { get; set; }
        public int ogrenci_id { get; set; }
        public int ogretmen_id { get; set; }
    }
}
