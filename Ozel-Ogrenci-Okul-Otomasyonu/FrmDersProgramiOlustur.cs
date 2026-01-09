using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class FrmDersProgramiOlustur : Form
    {
        public DateTime BaslangicTarihi { get; private set; }
        public DateTime BitisTarihi { get; private set; }
        public List<int> SecilenOgrenciler { get; private set; } = new List<int>();
        public List<int> SecilenOgretmenler { get; private set; } = new List<int>();

        public FrmDersProgramiOlustur()
        {
            InitializeComponent();
        }

        private void FrmDersProgramiOlustur_Load(object sender, EventArgs e)
        {
            // Varsayılan tarihler: Gelecek haftanın Pazartesi - Cuma
            DateTime bugun = DateTime.Now;
            int gunFarki = ((int)DayOfWeek.Monday - (int)bugun.DayOfWeek + 7) % 7;
            if (gunFarki == 0) gunFarki = 7;
            DateTime pazartesi = bugun.AddDays(gunFarki);

            dateBaslangic.DateTime = pazartesi;
            dateBitis.DateTime = pazartesi.AddDays(4); // Cuma

            // Öğrencileri yükle
            YukleOgrenciler();

            // Öğretmenleri yükle
            YukleOgretmenler();
        }

        private void YukleOgrenciler()
        {
            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT OgrenciID, AdSoyad FROM Tbl_Ogrenciler");

                chkListOgrenciler.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["OgrenciID"]);
                    string ad = row["AdSoyad"]?.ToString() ?? "";
                    chkListOgrenciler.Items.Add(id, ad, CheckState.Checked, true);
                }
            }
            catch { }
        }

        private void YukleOgretmenler()
        {
            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT OgretmenID, AdSoyad FROM Tbl_Ogretmenler");

                chkListOgretmenler.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["OgretmenID"]);
                    string ad = row["AdSoyad"]?.ToString() ?? "";
                    chkListOgretmenler.Items.Add(id, ad, CheckState.Checked, true);
                }
            }
            catch { }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            // Tarih kontrolü
            if (dateBaslangic.DateTime == DateTime.MinValue || dateBitis.DateTime == DateTime.MinValue)
            {
                XtraMessageBox.Show("Lütfen tarih aralığını seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateBitis.DateTime < dateBaslangic.DateTime)
            {
                XtraMessageBox.Show("Bitiş tarihi başlangıç tarihinden önce olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen öğrencileri al
            SecilenOgrenciler.Clear();
            foreach (var item in chkListOgrenciler.CheckedItems)
            {
                if (item is DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedItem)
                {
                    SecilenOgrenciler.Add((int)checkedItem.Value);
                }
            }

            if (SecilenOgrenciler.Count == 0)
            {
                XtraMessageBox.Show("En az bir öğrenci seçmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen öğretmenleri al
            SecilenOgretmenler.Clear();
            foreach (var item in chkListOgretmenler.CheckedItems)
            {
                if (item is DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedItem)
                {
                    SecilenOgretmenler.Add((int)checkedItem.Value);
                }
            }

            if (SecilenOgretmenler.Count == 0)
            {
                XtraMessageBox.Show("En az bir öğretmen seçmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tarihleri kaydet
            BaslangicTarihi = dateBaslangic.DateTime;
            BitisTarihi = dateBitis.DateTime;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
