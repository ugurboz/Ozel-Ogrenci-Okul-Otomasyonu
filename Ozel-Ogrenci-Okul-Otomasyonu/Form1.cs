using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using DevExpress.LookAndFeel;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class Form1 : XtraForm
    {
        // Yetki Değişkenleri
        public bool IsAdmin = true;
        public int OgretmenID = 0;
        public string OgretmenAdSoyad = "";
        public byte[] OgretmenFoto = null;

        // --- SAYFALAR (UserControls) ---
        UcSeans _ucSeans;
        UcOgretmen _ucOgretmen;
        UcTakvim _ucTakvim;
        UcAyarlar _ucAyarlar;
        UcFatura _ucFatura;
        UcGelisim _ucGelisim;

        // --- SÖZLEŞME ALANLARI (Dinamik) ---
        LabelControl lblSozlesmeBaslik;
        LabelControl lblSozBaslangic;
        LabelControl lblSozBitis;
        LabelControl lblSozSeans;
        LabelControl lblSozUcret;
        DateEdit dateSozBaslangic;
        DateEdit dateSozBitis;
        TextEdit txtSozSeansSayisi;
        TextEdit txtSozUcret;

        // Modern UI Renk Paleti
        private readonly Color PRIMARY_DARK = Color.FromArgb(15, 15, 35);
        private readonly Color SECONDARY_DARK = Color.FromArgb(25, 25, 55);
        private readonly Color ACCENT_BLUE = Color.FromArgb(0, 150, 255);
        private readonly Color ACCENT_CYAN = Color.FromArgb(0, 255, 255);
        private readonly Color ACCENT_PURPLE = Color.FromArgb(138, 43, 226);
        private readonly Color NEON_GREEN = Color.FromArgb(0, 255, 136);
        private readonly Color TEXT_PRIMARY = Color.White;
        private readonly Color TEXT_SECONDARY = Color.FromArgb(180, 180, 200);
        private readonly Color SIDEBAR_HOVER = Color.FromArgb(40, 40, 80);
        private readonly Color SIDEBAR_SELECTED = Color.FromArgb(0, 120, 215);

        public Form1()
        {
            InitializeComponent();
            ApplyModernTheme();
            SetupSidebarNavigation();
        }

        private void ApplyModernTheme()
        {
            // DevExpress Dark Theme uygula
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2019Black);

            // Form ayarları
            this.BackColor = PRIMARY_DARK;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
        }

        private void SetupSidebarNavigation()
        {
            // Sidebar butonlarına hover efektleri ekle
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is SimpleButton btn)
                {
                    btn.MouseEnter += (s, e) =>
                    {
                        btn.BackColor = SIDEBAR_HOVER;
                        btn.Cursor = Cursors.Hand;
                    };
                    btn.MouseLeave += (s, e) =>
                    {
                        if (btn.Tag?.ToString() != "selected")
                            btn.BackColor = Color.Transparent;
                    };
                }
            }
        }

        private void SelectSidebarButton(SimpleButton selectedBtn)
        {
            // Tüm butonların seçimini kaldır
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is SimpleButton btn)
                {
                    btn.Tag = null;
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = TEXT_SECONDARY;
                }
            }

            // Seçili butonu vurgula
            selectedBtn.Tag = "selected";
            selectedBtn.BackColor = SIDEBAR_SELECTED;
            selectedBtn.ForeColor = TEXT_PRIMARY;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Başlangıçta Dashboard (Panel) açık olsun
            pnlDashboard.Visible = true;
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.BringToFront();

            // Öğrenci paneli gizli başlasın
            pnlOgrenciler.Visible = false;
            DashboardGuncelle();

            // 2. Öğrenci Listesini Getir (Paneldeki Grid için)
            Listele();

            // 3. Yetki ve Başlık Ayarı
            if (IsAdmin)
            {
                lblFormTitle.Text = "İLGİ ÖZEL EĞİTİM - YÖNETİCİ PANELİ";
                SelectSidebarButton(btnNavAnasayfa);
            }
            else
            {
                lblFormTitle.Text = "İLGİ ÖZEL EĞİTİM - ÖĞRETMEN PANELİ";

                // ============================================
                // ÖĞRETMEN YETKİLERİ - GİZLENECEK BUTONLAR
                // ============================================
                btnNavAnasayfa.Visible = false;
                btnNavOgretmenler.Visible = false;
                btnNavMuhasebe.Visible = false;

                // Sol paneli gizle (Düzenleme yapılamasın & Tam ekran liste)
                groupControl1.Visible = false;
                gridView1.OptionsBehavior.Editable = false;

                // ============================================
                // ÖĞRETMEN GİRİŞİNDE TAKVİM AÇILSIN
                // ============================================
                pnlDashboard.Visible = false;

                if (_ucTakvim == null)
                {
                    _ucTakvim = new UcTakvim();
                    _ucTakvim.Dock = DockStyle.Fill;
                    _ucTakvim.OgretmenID = this.OgretmenID;
                    pnlContent.Controls.Add(_ucTakvim);
                }
                _ucTakvim.Visible = true;
                _ucTakvim.BringToFront();
                SelectSidebarButton(btnNavTakvim);
            }

            // Header bilgilerini güncelle
            UpdateHeaderInfo();

            // Timer başlat
            timerSaat.Start();

            // Profil fotoğrafını yükle
            if (OgretmenFoto != null && OgretmenFoto.Length > 0)
            {
                try
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(OgretmenFoto);
                    picUserAvatar.Image = Image.FromStream(ms);
                }
                catch { }
            }
        }

        // ==========================================
        //         HEADER BİLGİLERİ GÜNCELLE
        // ==========================================
        private void UpdateHeaderInfo()
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
            lblTarih.Text = DateTime.Now.ToString("dd MMMM yyyy, dddd");

            if (IsAdmin)
            {
                lblKullanici.Text = "Yönetici";
            }
            else if (!string.IsNullOrEmpty(OgretmenAdSoyad))
            {
                lblKullanici.Text = OgretmenAdSoyad;
            }
            else
            {
                lblKullanici.Text = "Öğretmen";
            }
        }

        // Timer - Her Saniye Saati Güncelle
        private void timerSaat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // ==========================================
        //         NAVİGASYON (SIDEBAR BUTONLARI)
        // ==========================================

        // 1. ANASAYFA
        private void btnNavAnasayfa_Click(object sender, EventArgs e)
        {
            SelectSidebarButton(btnNavAnasayfa);
            DigerleriniGizle();

            pnlDashboard.Visible = true;
            pnlDashboard.BringToFront();
            DashboardGuncelle();
        }

        // 2. ÖĞRENCİLER
        private void btnNavOgrenciler_Click(object sender, EventArgs e)
        {
            SelectSidebarButton(btnNavOgrenciler);
            DigerleriniGizle();

            pnlOgrenciler.Visible = true;
            pnlOgrenciler.Dock = DockStyle.Fill;
            pnlOgrenciler.BringToFront();
        }

        // 3. ÖĞRETMENLER
        private void btnNavOgretmenler_Click(object sender, EventArgs e)
        {
            SelectSidebarButton(btnNavOgretmenler);
            DigerleriniGizle();

            if (_ucOgretmen == null || _ucOgretmen.IsDisposed)
            {
                _ucOgretmen = new UcOgretmen();
                _ucOgretmen.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(_ucOgretmen);
            }
            _ucOgretmen.Visible = true;
            _ucOgretmen.BringToFront();
        }

        // 4. GELİŞİM TAKİBİ
        private void btnNavGelisim_Click(object sender, EventArgs e)
        {
            SelectSidebarButton(btnNavGelisim);
            DigerleriniGizle();

            if (_ucGelisim == null || _ucGelisim.IsDisposed)
            {
                _ucGelisim = new UcGelisim();
                _ucGelisim.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(_ucGelisim);
            }
            _ucGelisim.Visible = true;
            _ucGelisim.BringToFront();
        }

        // 5. SEANSLAR
        private void btnNavSeanslar_Click(object sender, EventArgs e)
        {
            SelectSidebarButton(btnNavSeanslar);
            DigerleriniGizle();

            if (_ucSeans == null || _ucSeans.IsDisposed)
            {
                _ucSeans = new UcSeans();
                _ucSeans.Dock = DockStyle.Fill;
                _ucSeans.IsAdmin = this.IsAdmin;
                _ucSeans.OgretmenID = this.OgretmenID;
                pnlContent.Controls.Add(_ucSeans);
            }
            _ucSeans.Visible = true;
            _ucSeans.BringToFront();
        }

        // 6. TAKVİM
        private void btnNavTakvim_Click(object sender, EventArgs e)
        {
            SelectSidebarButton(btnNavTakvim);
            DigerleriniGizle();

            if (_ucTakvim == null || _ucTakvim.IsDisposed)
            {
                _ucTakvim = new UcTakvim();
                _ucTakvim.Dock = DockStyle.Fill;
                _ucTakvim.OgretmenID = this.OgretmenID;
                pnlContent.Controls.Add(_ucTakvim);
            }
            _ucTakvim.Visible = true;
            _ucTakvim.BringToFront();
        }

        // 7. MUHASEBE/FATURA
        private void btnNavMuhasebe_Click(object sender, EventArgs e)
        {
            SelectSidebarButton(btnNavMuhasebe);
            DigerleriniGizle();

            if (_ucFatura == null || _ucFatura.IsDisposed)
            {
                _ucFatura = new UcFatura();
                _ucFatura.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(_ucFatura);
            }
            _ucFatura.Visible = true;
            _ucFatura.BringToFront();
        }

        // 8. AYARLAR
        private void btnNavAyarlar_Click(object sender, EventArgs e)
        {
            SelectSidebarButton(btnNavAyarlar);
            DigerleriniGizle();

            if (_ucAyarlar == null || _ucAyarlar.IsDisposed)
            {
                _ucAyarlar = new UcAyarlar();
                _ucAyarlar.Dock = DockStyle.Fill;
                _ucAyarlar.OgretmenID = this.OgretmenID;
                _ucAyarlar.IsAdmin = this.IsAdmin;
                pnlContent.Controls.Add(_ucAyarlar);
            }
            _ucAyarlar.Visible = true;
            _ucAyarlar.BringToFront();
        }

        // ÇIKIŞ BUTONU
        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(
                "Çıkış yapmak istediğinize emin misiniz?",
                "Çıkış",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                FrmGiris frmGiris = new FrmGiris();
                frmGiris.Show();
                this.Close();
            }
        }

        // MİNİMİZE BUTONU
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // MAKSİMİZE/RESTORE BUTONU
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        // KAPAT BUTONU
        private void btnClose_Click(object sender, EventArgs e)
        {
            GunSonuLogOlustur();
            Application.Exit();
        }

        // Header sürükle
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // Yardımcı metod: Tüm sayfaları gizle
        void DigerleriniGizle()
        {
            pnlDashboard.Visible = false;
            pnlOgrenciler.Visible = false;
            if (_ucSeans != null) _ucSeans.Visible = false;
            if (_ucOgretmen != null) _ucOgretmen.Visible = false;
            if (_ucTakvim != null) _ucTakvim.Visible = false;
            if (_ucAyarlar != null) _ucAyarlar.Visible = false;
            if (_ucFatura != null) _ucFatura.Visible = false;
            if (_ucGelisim != null) _ucGelisim.Visible = false;
        }

        // ==========================================
        //      DASHBOARD GÜNCELLE
        // ==========================================
        void DashboardGuncelle()
        {
            try
            {
                // 1. ÖĞRENCİ SAYISI
                DataTable dtOgrenci = SqlYardimcisi.VeriGetir("SELECT COUNT(*) FROM Tbl_Ogrenciler");
                tileItem1.Text = "Öğrenci Sayısı\n" + dtOgrenci.Rows[0][0].ToString();

                // 2. ÖĞRETMEN SAYISI
                DataTable dtOgretmen = SqlYardimcisi.VeriGetir("SELECT COUNT(*) FROM Tbl_Ogretmenler");
                tileItem2.Text = "Öğretmen Sayısı\n" + dtOgretmen.Rows[0][0].ToString();

                // 3. BUGÜNKÜ DERSLER
                string bugun = DateTime.Now.ToString("yyyy-MM-dd");
                DataTable dtDers = SqlYardimcisi.VeriGetir("SELECT COUNT(*) FROM Tbl_Seanslar WHERE Tarih='" + bugun + "'");
                tileItem3.Text = "Bugünkü Dersler\n" + dtDers.Rows[0][0].ToString();

                // --- FATURA TOPLAMI ---
                DataTable dtKasa = SqlYardimcisi.VeriGetir("SELECT ISNULL(SUM(ToplamTutar), 0) FROM Tbl_Faturalar WHERE OdenmeDurumu = 1");
                string toplamPara = dtKasa.Rows[0][0].ToString();
                if (string.IsNullOrEmpty(toplamPara)) toplamPara = "0";
                tileItem4.Text = "TOPLAM KAZANÇ\n" + toplamPara + " TL";

                // 4. GRAFİK (CHART) GÜNCELLEME
                chartControl1.Series.Clear();
                DevExpress.XtraCharts.Series seri = new DevExpress.XtraCharts.Series("Engel Türleri", DevExpress.XtraCharts.ViewType.Pie);

                DataTable dtGrafik = SqlYardimcisi.VeriGetir("SELECT EngelTuru, COUNT(*) as Sayi FROM Tbl_Ogrenciler GROUP BY EngelTuru");

                foreach (DataRow dr in dtGrafik.Rows)
                {
                    seri.Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr["EngelTuru"].ToString(), dr["Sayi"]));
                }
                chartControl1.Series.Add(seri);
                seri.Label.TextPattern = "{A}: {VP:P0}";
            }
            catch (Exception ex)
            {
                // Hata olursa program patlamasın
            }
        }

        // ==========================================
        //      ÖĞRENCİ İŞLEMLERİ
        // ==========================================

        void Listele()
        {
            try
            {
                string sorgu = @"
                    SELECT 
                        O.OgrenciID,
                        O.AdSoyad AS 'Öğrenci',
                        O.TCKimlikNo AS 'TC Kimlik No',
                        O.DogumTarihi AS 'Doğum Tarihi',
                        O.EngelTuru AS 'Engel Türü',
                        O.EngelOrani AS 'Engel Oranı',
                        V.AdSoyad AS 'Veli',
                        V.Telefon AS 'Veli Tel',
                        V.Yakinlik AS 'Yakınlık'
                    FROM Tbl_Ogrenciler O
                    LEFT JOIN Tbl_OgrenciVeli OV ON O.OgrenciID = OV.OgrenciID
                    LEFT JOIN Tbl_Veliler V ON OV.VeliID = V.VeliID
                    ORDER BY O.AdSoyad";

                DataTable dt = SqlYardimcisi.VeriGetir(sorgu);
                gridControl1.DataSource = dt;

                if (gridView1.Columns["OgrenciID"] != null)
                    gridView1.Columns["OgrenciID"].Visible = false;

                gridView1.BestFitColumns();
            }
            catch
            {
                try
                {
                    DataTable dt = SqlYardimcisi.VeriGetir("SELECT * FROM Tbl_Ogrenciler");
                    gridControl1.DataSource = dt;
                }
                catch { }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textAd.Text))
            {
                MessageBox.Show("Lütfen Ad Soyad giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRow secilenRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                int ogrenciId = 0;
                bool guncelleme = false;

                if (secilenRow != null && secilenRow.Table.Columns.Contains("OgrenciID"))
                {
                    ogrenciId = Convert.ToInt32(secilenRow["OgrenciID"]);
                    guncelleme = true;
                }

                if (guncelleme)
                {
                    string updateSorgu = @"UPDATE Tbl_Ogrenciler 
                                           SET AdSoyad=@p1, TCKimlikNo=@p2, DogumTarihi=@p3, EngelTuru=@p4, EngelOrani=@p5 
                                           WHERE OgrenciID=@id";

                    SqlParameter[] updateParams = {
                        new SqlParameter("@p1", textAd.Text),
                        new SqlParameter("@p2", textTc.Text),
                        new SqlParameter("@p3", dateDogum.DateTime.ToString("yyyy-MM-dd")),
                        new SqlParameter("@p4", cmbEngel.Text),
                        new SqlParameter("@p5", textEngelOrani.Text),
                        new SqlParameter("@id", ogrenciId)
                    };

                    SqlYardimcisi.KomutCalistir(updateSorgu, updateParams);

                    // Veli güncelle veya ekle
                    if (!string.IsNullOrWhiteSpace(txtVeliAd.Text))
                    {
                        string veliKontrol = "SELECT VeliID FROM Tbl_OgrenciVeli WHERE OgrenciID=@oid";
                        DataTable dtVeliKontrol = SqlYardimcisi.VeriGetir(veliKontrol, new SqlParameter[] { new SqlParameter("@oid", ogrenciId) });

                        if (dtVeliKontrol.Rows.Count > 0)
                        {
                            int veliId = Convert.ToInt32(dtVeliKontrol.Rows[0][0]);
                            string veliUpdate = "UPDATE Tbl_Veliler SET AdSoyad=@v1, Telefon=@v2, Yakinlik=@v3 WHERE VeliID=@vid";
                            SqlYardimcisi.KomutCalistir(veliUpdate, new SqlParameter[] {
                                new SqlParameter("@v1", txtVeliAd.Text),
                                new SqlParameter("@v2", txtVeliTel.Text),
                                new SqlParameter("@v3", cmbVeliYakinlik.Text ?? "Vasi"),
                                new SqlParameter("@vid", veliId)
                            });
                        }
                        else
                        {
                            string veliInsert = @"INSERT INTO Tbl_Veliler (AdSoyad, Telefon, Yakinlik) VALUES (@v1, @v2, @v3); SELECT SCOPE_IDENTITY();";
                            DataTable dtVeli = SqlYardimcisi.VeriGetir(veliInsert, new SqlParameter[] {
                                new SqlParameter("@v1", txtVeliAd.Text),
                                new SqlParameter("@v2", txtVeliTel.Text),
                                new SqlParameter("@v3", cmbVeliYakinlik.Text ?? "Vasi")
                            });
                            int yeniVeliId = Convert.ToInt32(dtVeli.Rows[0][0]);
                            SqlYardimcisi.KomutCalistir("INSERT INTO Tbl_OgrenciVeli (OgrenciID, VeliID, AcilIletisim) VALUES (@i1, @i2, 1)",
                                new SqlParameter[] { new SqlParameter("@i1", ogrenciId), new SqlParameter("@i2", yeniVeliId) });
                        }
                    }

                    MessageBox.Show("Öğrenci ve Veli Bilgileri Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string ogrenciSorgu = @"INSERT INTO Tbl_Ogrenciler (AdSoyad, TCKimlikNo, DogumTarihi, EngelTuru, EngelOrani) 
                                            VALUES (@p1, @p2, @p3, @p4, @p5); SELECT SCOPE_IDENTITY();";

                    SqlParameter[] ogrenciParams = {
                        new SqlParameter("@p1", textAd.Text),
                        new SqlParameter("@p2", textTc.Text),
                        new SqlParameter("@p3", dateDogum.DateTime.ToString("yyyy-MM-dd")),
                        new SqlParameter("@p4", cmbEngel.Text),
                        new SqlParameter("@p5", textEngelOrani.Text)
                    };

                    DataTable dtOgrenci = SqlYardimcisi.VeriGetir(ogrenciSorgu, ogrenciParams);
                    int yeniOgrenciId = Convert.ToInt32(dtOgrenci.Rows[0][0]);

                    // Sözleşme kaydet
                    decimal ucret = 0;
                    decimal.TryParse(txtSozUcret?.Text ?? "0", out ucret);
                    int seansSayisi = 8;
                    int.TryParse(txtSozSeansSayisi?.Text ?? "8", out seansSayisi);

                    string sozlesmeSorgu = @"INSERT INTO Tbl_Sozlesmeler 
                                             (OgrenciID, BaslangicTarihi, BitisTarihi, AylikSeansSayisi, AylikUcret, SozlesmeDurumu) 
                                             VALUES (@s1, @s2, @s3, @s4, @s5, @s6)";
                    SqlYardimcisi.KomutCalistir(sozlesmeSorgu, new SqlParameter[] {
                        new SqlParameter("@s1", yeniOgrenciId),
                        new SqlParameter("@s2", dateSozBaslangic?.DateTime.ToString("yyyy-MM-dd") ?? DateTime.Now.ToString("yyyy-MM-dd")),
                        new SqlParameter("@s3", dateSozBitis?.DateTime.ToString("yyyy-MM-dd") ?? DateTime.Now.AddMonths(12).ToString("yyyy-MM-dd")),
                        new SqlParameter("@s4", seansSayisi),
                        new SqlParameter("@s5", ucret),
                        new SqlParameter("@s6", "Aktif")
                    });

                    // Veli kaydet
                    if (!string.IsNullOrWhiteSpace(txtVeliAd.Text))
                    {
                        string veliSorgu = @"INSERT INTO Tbl_Veliler (AdSoyad, Telefon, Yakinlik) VALUES (@v1, @v2, @v3); SELECT SCOPE_IDENTITY();";
                        DataTable dtVeli = SqlYardimcisi.VeriGetir(veliSorgu, new SqlParameter[] {
                            new SqlParameter("@v1", txtVeliAd.Text),
                            new SqlParameter("@v2", txtVeliTel.Text),
                            new SqlParameter("@v3", cmbVeliYakinlik.Text ?? "Vasi")
                        });
                        int yeniVeliId = Convert.ToInt32(dtVeli.Rows[0][0]);
                        SqlYardimcisi.KomutCalistir("INSERT INTO Tbl_OgrenciVeli (OgrenciID, VeliID, AcilIletisim) VALUES (@i1, @i2, 1)",
                            new SqlParameter[] { new SqlParameter("@i1", yeniOgrenciId), new SqlParameter("@i2", yeniVeliId) });
                    }

                    MessageBox.Show("Öğrenci, Sözleşme ve Veli Başarıyla Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Listele();
                Temizle();
                SozlesmeTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    string id = dr["OgrenciID"].ToString();
                    DialogResult onay = MessageBox.Show("Bu öğrenciyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (onay == DialogResult.Yes)
                    {
                        SqlYardimcisi.KomutCalistir("DELETE FROM Tbl_Ogrenciler WHERE OgrenciID=" + id);
                        MessageBox.Show("Öğrenci Silindi.");
                        Listele();
                        Temizle();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek öğrenciyi listeden seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme Hatası: " + ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            textAd.Text = "";
            textTc.Text = "";
            textEngelOrani.Text = "";
            cmbEngel.Text = "";
            dateDogum.Text = "";
            txtVeliAd.Text = "";
            txtVeliTel.Text = "";
            cmbVeliYakinlik.SelectedIndex = -1;
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    if (dr.Table.Columns.Contains("Öğrenci"))
                        textAd.Text = dr["Öğrenci"].ToString();
                    else if (dr.Table.Columns.Contains("AdSoyad"))
                        textAd.Text = dr["AdSoyad"].ToString();

                    if (dr.Table.Columns.Contains("TC Kimlik No"))
                        textTc.Text = dr["TC Kimlik No"].ToString();
                    else if (dr.Table.Columns.Contains("TCKimlikNo"))
                        textTc.Text = dr["TCKimlikNo"].ToString();

                    if (dr.Table.Columns.Contains("Engel Türü"))
                        cmbEngel.Text = dr["Engel Türü"].ToString();
                    else if (dr.Table.Columns.Contains("EngelTuru"))
                        cmbEngel.Text = dr["EngelTuru"].ToString();

                    if (dr.Table.Columns.Contains("Engel Oranı"))
                        textEngelOrani.Text = dr["Engel Oranı"].ToString();
                    else if (dr.Table.Columns.Contains("EngelOrani"))
                        textEngelOrani.Text = dr["EngelOrani"].ToString();

                    string dogumCol = dr.Table.Columns.Contains("Doğum Tarihi") ? "Doğum Tarihi" : "DogumTarihi";
                    if (dr.Table.Columns.Contains(dogumCol) && dr[dogumCol] != DBNull.Value)
                    {
                        dateDogum.DateTime = Convert.ToDateTime(dr[dogumCol]);
                    }

                    if (dateSozBaslangic != null && txtSozSeansSayisi != null && txtSozUcret != null)
                    {
                        if (dr.Table.Columns.Contains("Aylık Seans") && dr["Aylık Seans"] != DBNull.Value)
                            txtSozSeansSayisi.Text = dr["Aylık Seans"].ToString();
                        if (dr.Table.Columns.Contains("Aylık Ücret") && dr["Aylık Ücret"] != DBNull.Value)
                            txtSozUcret.Text = dr["Aylık Ücret"].ToString();
                    }

                    if (dr.Table.Columns.Contains("Veli") && dr["Veli"] != DBNull.Value)
                        txtVeliAd.Text = dr["Veli"].ToString();
                    else
                        txtVeliAd.Text = "";

                    if (dr.Table.Columns.Contains("Veli Tel") && dr["Veli Tel"] != DBNull.Value)
                        txtVeliTel.Text = dr["Veli Tel"].ToString();
                    else
                        txtVeliTel.Text = "";

                    if (dr.Table.Columns.Contains("Yakınlık") && dr["Yakınlık"] != DBNull.Value)
                        cmbVeliYakinlik.Text = dr["Yakınlık"].ToString();
                    else
                        cmbVeliYakinlik.SelectedIndex = -1;
                }
            }
            catch { }
        }

        private void btnExcelAl_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel Dosyası|*.xlsx";
            dialog.FileName = "Ogrenci_Listesi.xlsx";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);

                if (MessageBox.Show("Dosya başarıyla oluşturuldu! Açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(dialog.FileName);
                }
            }
        }

        private void btnPdfAl_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF Dosyası|*.pdf";
            dialog.FileName = "Ogrenci_Listesi.pdf";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                gridControl1.ExportToPdf(dialog.FileName);

                if (MessageBox.Show("Dosya başarıyla oluşturuldu! Açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(dialog.FileName);
                }
            }
        }

        // Form Kapanırken Log Kaydet
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GunSonuLogOlustur();
        }

        private void GunSonuLogOlustur()
        {
            try
            {
                string sorgu = "SELECT LogDosyaYolu, GunlukLogTut FROM Tbl_Ayarlar WHERE ID = 1";
                DataTable dt = SqlYardimcisi.VeriGetir(sorgu, null);

                if (dt.Rows.Count == 0) return;

                bool logAktif = dt.Rows[0]["GunlukLogTut"] != DBNull.Value && Convert.ToBoolean(dt.Rows[0]["GunlukLogTut"]);
                string dosyaYolu = dt.Rows[0]["LogDosyaYolu"]?.ToString();

                if (!logAktif || string.IsNullOrEmpty(dosyaYolu)) return;

                string tarih = DateTime.Now.ToString("dd.MM.yyyy");
                string dosyaAdi = tarih + "_GunlukKayit.txt";

                if (!System.IO.Directory.Exists(dosyaYolu))
                    System.IO.Directory.CreateDirectory(dosyaYolu);

                string tamYol = System.IO.Path.Combine(dosyaYolu, dosyaAdi);

                string logSatiri = string.Format("[{0}] [Öğretmen ID: {1}] [SİSTEM] Gün sonu kapanışı yapıldı. Program kapatıldı.",
                    DateTime.Now.ToString("HH:mm:ss"),
                    this.OgretmenID);

                using (System.IO.StreamWriter sw = System.IO.File.AppendText(tamYol))
                {
                    sw.WriteLine(logSatiri);
                }
            }
            catch { }
        }

        void SozlesmeTemizle()
        {
            if (dateSozBaslangic != null) dateSozBaslangic.DateTime = DateTime.Now;
            if (dateSozBitis != null) dateSozBitis.DateTime = DateTime.Now.AddMonths(12);
            if (txtSozSeansSayisi != null) txtSozSeansSayisi.Text = "8";
            if (txtSozUcret != null) txtSozUcret.Text = "5000";
        }

        // Eski Ribbon metodları için uyumluluk
        public void RibbonKullaniciBilgisiGuncelle()
        {
            UpdateHeaderInfo();
        }

        public void GuncelleKullaniciBilgisi()
        {
            UpdateHeaderInfo();
        }
    }
}