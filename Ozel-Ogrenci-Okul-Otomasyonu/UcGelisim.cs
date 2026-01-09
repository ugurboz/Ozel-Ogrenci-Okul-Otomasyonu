using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using Ozel_Ogrenci_Okul_Otomasyonu.DAL;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    public partial class UcGelisim : DevExpress.XtraEditors.XtraUserControl
    {
        int secilenGelisimId = 0;

        public UcGelisim()
        {
            InitializeComponent();
        }

        private void UcGelisim_Load(object sender, EventArgs e)
        {
            OgrencileriYukle();
            Temizle();
            // Başlangıçta liste boş, öğrenci seçince dolacak
            gridControlGelisim.DataSource = null;
        }

        // --- 1. LİSTELEME (Seçilen öğrenciye göre) ---
        void RaporlariListele(int ogrenciId)
        {
            try
            {
                if (ogrenciId == 0)
                {
                    gridControlGelisim.DataSource = null;
                    return;
                }

                string sorgu = @"
                    SELECT 
                        G.GelisimID,
                        G.OgrenciID,
                        O.AdSoyad AS 'Öğrenci',
                        G.Baslik,
                        G.RaporTarihi AS 'Tarih',
                        G.GenelDurum AS 'Genel',
                        G.FizikselGelisim AS 'Fiziksel',
                        G.ZihinselGelisim AS 'Zihinsel',
                        G.SosyalGelisim AS 'Sosyal',
                        G.DilGelisimi AS 'Dil'
                    FROM Tbl_GelisimRaporlari G
                    INNER JOIN Tbl_Ogrenciler O ON G.OgrenciID = O.OgrenciID
                    WHERE G.OgrenciID = @ogrenciId
                    ORDER BY G.RaporTarihi DESC";

                SqlParameter[] p = { new SqlParameter("@ogrenciId", ogrenciId) };
                DataTable dt = SqlYardimcisi.VeriGetir(sorgu, p);
                gridControlGelisim.DataSource = dt;

                gridViewGelisim.BestFitColumns();
                gridViewGelisim.OptionsBehavior.Editable = false;

                if (gridViewGelisim.Columns["GelisimID"] != null)
                    gridViewGelisim.Columns["GelisimID"].Visible = false;
                if (gridViewGelisim.Columns["OgrenciID"] != null)
                    gridViewGelisim.Columns["OgrenciID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }

        // --- 2. ÖĞRENCİLERİ YÜKLE ---
        void OgrencileriYukle()
        {
            try
            {
                DataTable dt = SqlYardimcisi.VeriGetir("SELECT OgrenciID, AdSoyad FROM Tbl_Ogrenciler");
                lueOgrenci.Properties.DataSource = dt;
                lueOgrenci.Properties.ValueMember = "OgrenciID";
                lueOgrenci.Properties.DisplayMember = "AdSoyad";
                lueOgrenci.Properties.NullText = "Öğrenci Seçiniz...";
            }
            catch { }
        }

        // --- 3. GRAFİĞİ GÜNCELLE ---
        void GrafikGuncelle()
        {
            if (lueOgrenci.EditValue == null) return;

            try
            {
                int ogrenciId = Convert.ToInt32(lueOgrenci.EditValue);

                string sorgu = $@"SELECT TOP 10 RaporTarihi, GenelDurum, FizikselGelisim, ZihinselGelisim, SosyalGelisim, DilGelisimi 
                                  FROM Tbl_GelisimRaporlari 
                                  WHERE OgrenciID = {ogrenciId} 
                                  ORDER BY RaporTarihi ASC";

                DataTable dt = SqlYardimcisi.VeriGetir(sorgu);

                chartControl1.Series.Clear();

                // Genel Durum serisi
                Series seriGenel = new Series("Genel", ViewType.Line);
                Series seriFiziksel = new Series("Fiziksel", ViewType.Line);
                Series seriZihinsel = new Series("Zihinsel", ViewType.Line);
                Series seriSosyal = new Series("Sosyal", ViewType.Line);
                Series seriDil = new Series("Dil", ViewType.Line);

                foreach (DataRow dr in dt.Rows)
                {
                    DateTime tarih = Convert.ToDateTime(dr["RaporTarihi"]);
                    string tarihStr = tarih.ToString("dd/MM");

                    seriGenel.Points.Add(new SeriesPoint(tarihStr, dr["GenelDurum"]));
                    seriFiziksel.Points.Add(new SeriesPoint(tarihStr, dr["FizikselGelisim"]));
                    seriZihinsel.Points.Add(new SeriesPoint(tarihStr, dr["ZihinselGelisim"]));
                    seriSosyal.Points.Add(new SeriesPoint(tarihStr, dr["SosyalGelisim"]));
                    seriDil.Points.Add(new SeriesPoint(tarihStr, dr["DilGelisimi"]));
                }

                chartControl1.Series.Add(seriGenel);
                chartControl1.Series.Add(seriFiziksel);
                chartControl1.Series.Add(seriZihinsel);
                chartControl1.Series.Add(seriSosyal);
                chartControl1.Series.Add(seriDil);

                // Grafik ayarları
                chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            }
            catch { }
        }

        // --- 4. KAYDET / GÜNCELLE ---
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lueOgrenci.EditValue == null)
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz.");
                return;
            }

            try
            {
                string sorgu = "";

                if (secilenGelisimId == 0)
                {
                    sorgu = @"INSERT INTO Tbl_GelisimRaporlari 
                              (OgrenciID, RaporTarihi, Baslik, Aciklama, GenelDurum, FizikselGelisim, ZihinselGelisim, SosyalGelisim, DilGelisimi) 
                              VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";
                }
                else
                {
                    sorgu = @"UPDATE Tbl_GelisimRaporlari SET 
                              OgrenciID=@p1, RaporTarihi=@p2, Baslik=@p3, Aciklama=@p4, GenelDurum=@p5, 
                              FizikselGelisim=@p6, ZihinselGelisim=@p7, SosyalGelisim=@p8, DilGelisimi=@p9 
                              WHERE GelisimID=" + secilenGelisimId;
                }

                SqlParameter[] p = {
                    new SqlParameter("@p1", lueOgrenci.EditValue),
                    new SqlParameter("@p2", dateRapor.DateTime.ToString("yyyy-MM-dd")),
                    new SqlParameter("@p3", txtBaslik.Text),
                    new SqlParameter("@p4", memAciklama.Text),
                    new SqlParameter("@p5", Convert.ToInt32(trackGenel.Value)),
                    new SqlParameter("@p6", Convert.ToInt32(trackFiziksel.Value)),
                    new SqlParameter("@p7", Convert.ToInt32(trackZihinsel.Value)),
                    new SqlParameter("@p8", Convert.ToInt32(trackSosyal.Value)),
                    new SqlParameter("@p9", Convert.ToInt32(trackDil.Value))
                };

                SqlYardimcisi.KomutCalistir(sorgu, p);
                MessageBox.Show("Gelişim raporu başarıyla kaydedildi!");

                // Kaydedilen öğrencinin ID'sini al ve listeyi güncelle
                int kaydedilenOgrenciId = Convert.ToInt32(lueOgrenci.EditValue);
                RaporlariListele(kaydedilenOgrenciId);
                GrafikGuncelle();
                Temizle();

                // Öğrenciyi tekrar seç ki liste görünsün
                lueOgrenci.EditValue = kaydedilenOgrenciId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- 5. SİL ---
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenGelisimId == 0) return;

            if (MessageBox.Show("Bu raporu silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlYardimcisi.KomutCalistir("DELETE FROM Tbl_GelisimRaporlari WHERE GelisimID=" + secilenGelisimId);

                // Mevcut öğrencinin listesini güncelle
                if (lueOgrenci.EditValue != null)
                {
                    int mevcutOgrenciId = Convert.ToInt32(lueOgrenci.EditValue);
                    RaporlariListele(mevcutOgrenciId);
                }
                GrafikGuncelle();
                Temizle();
            }
        }

        // --- 6. TEMİZLE ---
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            // lueOgrenci.EditValue = null; // Öğrenci seçimi kalsın ki yeni kayıt eklenebilsin
            // Eğer bunu null yaparsak kullanıcı tekrar seçince Grid'in ilk satırı otomatik seçilip güncelleme moduna geçer.
            dateRapor.DateTime = DateTime.Now;
            txtBaslik.Text = "";
            memAciklama.Text = "";
            trackGenel.Value = 5;
            trackFiziksel.Value = 5;
            trackZihinsel.Value = 5;
            trackSosyal.Value = 5;
            trackDil.Value = 5;
            secilenGelisimId = 0;
            btnKaydet.Text = "KAYDET";
        }

        // --- 7. SEÇİNCE DOLDUR ---
        private void gridViewGelisim_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewGelisim.GetDataRow(gridViewGelisim.FocusedRowHandle);
            if (dr != null)
            {
                try
                {
                    secilenGelisimId = Convert.ToInt32(dr["GelisimID"]);

                    if (dr.Table.Columns.Contains("OgrenciID"))
                        lueOgrenci.EditValue = dr["OgrenciID"];
                    if (dr.Table.Columns.Contains("Baslik"))
                        txtBaslik.Text = dr["Baslik"].ToString();
                    if (dr.Table.Columns.Contains("Tarih") && dr["Tarih"] != DBNull.Value)
                        dateRapor.DateTime = Convert.ToDateTime(dr["Tarih"]);
                    if (dr.Table.Columns.Contains("Genel"))
                        trackGenel.Value = Convert.ToInt32(dr["Genel"]);
                    if (dr.Table.Columns.Contains("Fiziksel"))
                        trackFiziksel.Value = Convert.ToInt32(dr["Fiziksel"]);
                    if (dr.Table.Columns.Contains("Zihinsel"))
                        trackZihinsel.Value = Convert.ToInt32(dr["Zihinsel"]);
                    if (dr.Table.Columns.Contains("Sosyal"))
                        trackSosyal.Value = Convert.ToInt32(dr["Sosyal"]);
                    if (dr.Table.Columns.Contains("Dil"))
                        trackDil.Value = Convert.ToInt32(dr["Dil"]);

                    GrafikGuncelle();
                    btnKaydet.Text = "GÜNCELLE";
                }
                catch { }
            }
        }

        // --- 8. ÖĞRENCİ SEÇİNCE LİSTEYİ VE GRAFİĞİ GÜNCELLE ---
        private void lueOgrenci_EditValueChanged(object sender, EventArgs e)
        {
            if (lueOgrenci.EditValue != null)
            {
                int secilenOgrenciId = Convert.ToInt32(lueOgrenci.EditValue);
                RaporlariListele(secilenOgrenciId);
            }
            else
            {
                gridControlGelisim.DataSource = null;
            }
            GrafikGuncelle();
        }

        // --- 9. PDF'YE AKTAR ---
        private void btnPdfAktar_Click(object sender, EventArgs e)
        {
            if (lueOgrenci.EditValue == null)
            {
                MessageBox.Show("Lütfen önce bir öğrenci seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gridViewGelisim.RowCount == 0)
            {
                MessageBox.Show("PDF'ye aktarılacak rapor bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Öğrenci adını al
                string ogrenciAdi = lueOgrenci.Text;
                string dosyaAdi = $"Gelisim_Raporu_{ogrenciAdi.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Dosyası (*.pdf)|*.pdf";
                    sfd.FileName = dosyaAdi;
                    sfd.Title = "Gelişim Raporunu PDF Olarak Kaydet";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // Sayfa boyutları (A4 Landscape - piksel olarak 96 DPI)
                        int pageWidth = 1123;  // A4 landscape width
                        int pageHeight = 794;  // A4 landscape height
                        int margin = 40;
                        int headerHeight = 80;
                        int spacing = 20;

                        // Bitmap oluştur
                        using (Bitmap bitmap = new Bitmap(pageWidth, pageHeight))
                        {
                            using (Graphics g = Graphics.FromImage(bitmap))
                            {
                                g.Clear(Color.White);
                                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                                // Başlık
                                using (Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold))
                                using (Font subFont = new Font("Segoe UI", 11, FontStyle.Regular))
                                using (Brush titleBrush = new SolidBrush(Color.FromArgb(33, 150, 243)))
                                using (Brush blackBrush = new SolidBrush(Color.Black))
                                using (Brush grayBrush = new SolidBrush(Color.Gray))
                                {
                                    StringFormat centerFormat = new StringFormat { Alignment = StringAlignment.Center };
                                    g.DrawString("Gelişim Takibi Raporu", titleFont, titleBrush, new RectangleF(0, margin, pageWidth, 30), centerFormat);
                                    g.DrawString($"Öğrenci: {ogrenciAdi}", subFont, blackBrush, new RectangleF(0, margin + 35, pageWidth, 20), centerFormat);
                                    g.DrawString($"Tarih: {DateTime.Now:dd.MM.yyyy HH:mm}", subFont, grayBrush, new RectangleF(0, margin + 55, pageWidth, 20), centerFormat);
                                }

                                int contentY = margin + headerHeight;
                                int contentWidth = pageWidth - (2 * margin);
                                int availableHeight = pageHeight - contentY - margin;

                                // Grid ve Grafik için alan hesapla (yarı yarıya)
                                int chartHeight = availableHeight / 2 - spacing;
                                int gridHeight = availableHeight / 2 - spacing;

                                // Grafik görüntüsünü al
                                using (Bitmap chartBitmap = new Bitmap(chartControl1.Width, chartControl1.Height))
                                {
                                    chartControl1.DrawToBitmap(chartBitmap, new System.Drawing.Rectangle(0, 0, chartControl1.Width, chartControl1.Height));

                                    // Grafik başlığı
                                    using (Font chartTitleFont = new Font("Segoe UI", 12, FontStyle.Bold))
                                    using (Brush titleBrush = new SolidBrush(Color.FromArgb(33, 150, 243)))
                                    {
                                        g.DrawString("Gelişim Grafiği", chartTitleFont, titleBrush, new PointF(margin, contentY));
                                    }

                                    // Grafiği çiz
                                    g.DrawImage(chartBitmap, new System.Drawing.Rectangle(margin, contentY + 25, contentWidth, chartHeight - 25));
                                }

                                // Grid görüntüsünü al
                                int gridY = contentY + chartHeight + spacing;
                                using (Bitmap gridBitmap = new Bitmap(gridControlGelisim.Width, gridControlGelisim.Height))
                                {
                                    gridControlGelisim.DrawToBitmap(gridBitmap, new System.Drawing.Rectangle(0, 0, gridControlGelisim.Width, gridControlGelisim.Height));

                                    // Tablo başlığı
                                    using (Font tableTitleFont = new Font("Segoe UI", 12, FontStyle.Bold))
                                    using (Brush titleBrush = new SolidBrush(Color.FromArgb(33, 150, 243)))
                                    {
                                        g.DrawString("Gelişim Raporları Tablosu", tableTitleFont, titleBrush, new PointF(margin, gridY));
                                    }

                                    // Grid'i çiz
                                    g.DrawImage(gridBitmap, new System.Drawing.Rectangle(margin, gridY + 25, contentWidth, gridHeight - 25));
                                }
                            }

                            // Bitmap'i PDF'e dönüştür
                            PrintingSystem ps = new PrintingSystem();
                            ImageBrick imageBrick = new ImageBrick();
                            imageBrick.Image = bitmap;
                            imageBrick.Rect = new RectangleF(0, 0, pageWidth, pageHeight);

                            Link link = new Link(ps);
                            link.CreateDetailArea += (s, args) =>
                            {
                                args.Graph.DrawImage((Image)bitmap.Clone(), new RectangleF(0, 0, pageWidth, pageHeight));
                            };

                            ps.PageSettings.Landscape = true;
                            ps.PageSettings.LeftMargin = 0;
                            ps.PageSettings.RightMargin = 0;
                            ps.PageSettings.TopMargin = 0;
                            ps.PageSettings.BottomMargin = 0;

                            link.CreateDocument();

                            PdfExportOptions pdfOptions = new PdfExportOptions();
                            pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;

                            ps.ExportToPdf(sfd.FileName, pdfOptions);

                            MessageBox.Show($"PDF başarıyla kaydedildi:\n{sfd.FileName}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF oluşturma hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
