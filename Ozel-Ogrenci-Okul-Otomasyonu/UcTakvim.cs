using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraScheduler; // Scheduler kütüphanesi
using Ozel_Ogrenci_Okul_Otomasyonu.DAL; // SQL Yardımcın

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class UcTakvim : DevExpress.XtraEditors.XtraUserControl
    {
        public UcTakvim()
        {
            InitializeComponent();
        }

        // Giriş yapan öğretmenin ID'sini buraya göndereceğiz
        public int OgretmenID = 0;

        private void UcTakvim_Load(object sender, EventArgs e)
        {
            TakvimiDoldur();
        }

        void TakvimiDoldur()
        {
            if (OgretmenID == 0) return;

            try
            {
                // GÜNCELLEME 1: Sorguya "SeansID" eklendi (Hangi ders olduğunu bilmek için şart)
                string sorgu = @"
            SELECT 
                S.SeansID,
                S.Tarih, 
                S.Saat, 
                O.AdSoyad 
            FROM Tbl_Seanslar S
            INNER JOIN Tbl_Ogrenciler O ON S.OgrenciID = O.OgrenciID
            WHERE S.OgretmenID = " + OgretmenID;

                System.Data.DataTable dt = SqlYardimcisi.VeriGetir(sorgu);

                schedulerDataStorage1.Appointments.Clear();

                foreach (System.Data.DataRow dr in dt.Rows)
                {
                    DateTime tarih = Convert.ToDateTime(dr["Tarih"]);
                    string saatStr = dr["Saat"].ToString().Replace('.', ':');

                    TimeSpan saat;
                    if (TimeSpan.TryParse(saatStr, out saat))
                    {
                        DateTime baslangic = tarih.Add(saat);
                        DateTime bitis = baslangic.AddHours(1);

                        DevExpress.XtraScheduler.Appointment randevu = schedulerDataStorage1.CreateAppointment(DevExpress.XtraScheduler.AppointmentType.Normal);

                        randevu.Subject = dr["AdSoyad"].ToString();
                        randevu.Start = baslangic;
                        randevu.End = bitis;
                        randevu.Description = "Özel Ders";

                        // GÜNCELLEME 2: ID'yi randevunun "Tag" (Etiket) özelliğine gizledik
                        randevu.CustomFields["SeansID"] = dr["SeansID"];

                        schedulerDataStorage1.Appointments.Add(randevu);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda sessiz kalabiliriz
            }
        }

        private void schedulerControl1_AppointmentDrop(object sender, DevExpress.XtraScheduler.AppointmentDragEventArgs e)
        {
            try
            {
                DevExpress.XtraScheduler.Appointment randevu = e.EditedAppointment;

                // ID'yi al
                // (Eğer hata alırsan null kontrolü ekleyelim)
                if (randevu.CustomFields["SeansID"] == null) return;

                int id = Convert.ToInt32(randevu.CustomFields["SeansID"]);

                // Yeni Tarih ve Saati al
                DateTime yeniTarih = randevu.Start;
                string tarihStr = yeniTarih.ToString("yyyy-MM-dd");
                string saatStr = yeniTarih.ToString("HH:mm");

                // Veritabanını Güncelle
                string sorgu = "UPDATE Tbl_Seanslar SET Tarih=@p1, Saat=@p2 WHERE SeansID=@p3";

                System.Data.SqlClient.SqlParameter[] p = {
            new System.Data.SqlClient.SqlParameter("@p1", tarihStr),
            new System.Data.SqlClient.SqlParameter("@p2", saatStr),
            new System.Data.SqlClient.SqlParameter("@p3", id)
        };

                SqlYardimcisi.KomutCalistir(sorgu, p);

                // --- SİHİRLİ DOKUNUŞ BURADA ---
                // İşlem tamamen bitince Takvimi sıfırdan doldur ki ID'ler tazelensin.
                // BeginInvoke: "Bu olay bitince çalıştır" demektir, hata almanı önler.
                this.BeginInvoke(new MethodInvoker(TakvimiDoldur));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);
            }
        }
    }
}
    