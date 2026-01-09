
namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();

            this.pnlSidebar = new DevExpress.XtraEditors.PanelControl();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnNavCikis = new DevExpress.XtraEditors.SimpleButton();
            this.btnNavAyarlar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNavMuhasebe = new DevExpress.XtraEditors.SimpleButton();
            this.btnNavTakvim = new DevExpress.XtraEditors.SimpleButton();
            this.btnNavSeanslar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNavGelisim = new DevExpress.XtraEditors.SimpleButton();
            this.btnNavOgrenciler = new DevExpress.XtraEditors.SimpleButton();
            this.btnNavOgretmenler = new DevExpress.XtraEditors.SimpleButton();
            this.btnNavAnasayfa = new DevExpress.XtraEditors.SimpleButton();

            this.pnlHeader = new DevExpress.XtraEditors.PanelControl();
            this.picUserAvatar = new DevExpress.XtraEditors.PictureEdit();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnMaximize = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinimize = new DevExpress.XtraEditors.SimpleButton();

            this.pnlContent = new DevExpress.XtraEditors.PanelControl();
            this.pnlDashboard = new DevExpress.XtraEditors.PanelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup6 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup7 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup8 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();

            this.pnlOgrenciler = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPdfAl = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcelAl = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.lblVeliYakinlik = new DevExpress.XtraEditors.LabelControl();
            this.cmbVeliYakinlik = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtVeliTel = new DevExpress.XtraEditors.TextEdit();
            this.lblVeliTel = new DevExpress.XtraEditors.LabelControl();
            this.txtVeliAd = new DevExpress.XtraEditors.TextEdit();
            this.lblVeliAd = new DevExpress.XtraEditors.LabelControl();
            this.lblVeliBaslik = new DevExpress.XtraEditors.LabelControl();
            this.textEngelOrani = new DevExpress.XtraEditors.TextEdit();
            this.cmbEngel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateDogum = new DevExpress.XtraEditors.DateEdit();
            this.textTc = new DevExpress.XtraEditors.TextEdit();
            this.textAd = new DevExpress.XtraEditors.TextEdit();
            this.lblEngelOran = new DevExpress.XtraEditors.LabelControl();
            this.lblEngel = new DevExpress.XtraEditors.LabelControl();
            this.lblDogum = new DevExpress.XtraEditors.LabelControl();
            this.lblTc = new DevExpress.XtraEditors.LabelControl();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();

            this.timerSaat = new System.Windows.Forms.Timer(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.pnlSidebar)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDashboard)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOgrenciler)).BeginInit();
            this.pnlOgrenciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVeliYakinlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVeliTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVeliAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEngelOrani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEngel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogum.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAd.Properties)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.pnlSidebar.Appearance.Options.UseBackColor = true;
            this.pnlSidebar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSidebar.Controls.Add(this.btnNavCikis);
            this.pnlSidebar.Controls.Add(this.btnNavAyarlar);
            this.pnlSidebar.Controls.Add(this.btnNavMuhasebe);
            this.pnlSidebar.Controls.Add(this.btnNavTakvim);
            this.pnlSidebar.Controls.Add(this.btnNavSeanslar);
            this.pnlSidebar.Controls.Add(this.btnNavGelisim);
            this.pnlSidebar.Controls.Add(this.btnNavOgrenciler);
            this.pnlSidebar.Controls.Add(this.btnNavOgretmenler);
            this.pnlSidebar.Controls.Add(this.btnNavAnasayfa);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 718);
            this.pnlSidebar.TabIndex = 0;

            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 80);
            this.pnlLogo.TabIndex = 0;

            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "⚡ İLGİ\nÖZEL EĞİTİM";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // NAV BUTONLARI
            // 
            this.btnNavAnasayfa.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavAnasayfa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnNavAnasayfa.Appearance.Options.UseFont = true;
            this.btnNavAnasayfa.Appearance.Options.UseForeColor = true;
            this.btnNavAnasayfa.Appearance.Options.UseTextOptions = true;
            this.btnNavAnasayfa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnNavAnasayfa.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnNavAnasayfa.AppearanceHovered.Options.UseBackColor = true;
            this.btnNavAnasayfa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNavAnasayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAnasayfa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAnasayfa.ImageOptions.SvgImage"))); // Mevcut resource'dan al ya da boş geç
            this.btnNavAnasayfa.Location = new System.Drawing.Point(0, 80);
            this.btnNavAnasayfa.Name = "btnNavAnasayfa";
            this.btnNavAnasayfa.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavAnasayfa.Size = new System.Drawing.Size(220, 50);
            this.btnNavAnasayfa.TabIndex = 1;
            this.btnNavAnasayfa.Text = "Ana Sayfa";
            this.btnNavAnasayfa.Click += new System.EventHandler(this.btnNavAnasayfa_Click);

            this.btnNavOgretmenler.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavOgretmenler.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnNavOgretmenler.Appearance.Options.UseFont = true;
            this.btnNavOgretmenler.Appearance.Options.UseForeColor = true;
            this.btnNavOgretmenler.Appearance.Options.UseTextOptions = true;
            this.btnNavOgretmenler.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnNavOgretmenler.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNavOgretmenler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavOgretmenler.Location = new System.Drawing.Point(0, 130);
            this.btnNavOgretmenler.Name = "btnNavOgretmenler";
            this.btnNavOgretmenler.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavOgretmenler.Size = new System.Drawing.Size(220, 50);
            this.btnNavOgretmenler.TabIndex = 2;
            this.btnNavOgretmenler.Text = "Öğretmenler";
            this.btnNavOgretmenler.Click += new System.EventHandler(this.btnNavOgretmenler_Click);

            this.btnNavOgrenciler.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavOgrenciler.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnNavOgrenciler.Appearance.Options.UseFont = true;
            this.btnNavOgrenciler.Appearance.Options.UseForeColor = true;
            this.btnNavOgrenciler.Appearance.Options.UseTextOptions = true;
            this.btnNavOgrenciler.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnNavOgrenciler.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNavOgrenciler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavOgrenciler.Location = new System.Drawing.Point(0, 180);
            this.btnNavOgrenciler.Name = "btnNavOgrenciler";
            this.btnNavOgrenciler.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavOgrenciler.Size = new System.Drawing.Size(220, 50);
            this.btnNavOgrenciler.TabIndex = 3;
            this.btnNavOgrenciler.Text = "Öğrenciler";
            this.btnNavOgrenciler.Click += new System.EventHandler(this.btnNavOgrenciler_Click);

            this.btnNavGelisim.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavGelisim.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnNavGelisim.Appearance.Options.UseFont = true;
            this.btnNavGelisim.Appearance.Options.UseForeColor = true;
            this.btnNavGelisim.Appearance.Options.UseTextOptions = true;
            this.btnNavGelisim.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnNavGelisim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNavGelisim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavGelisim.Location = new System.Drawing.Point(0, 230);
            this.btnNavGelisim.Name = "btnNavGelisim";
            this.btnNavGelisim.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavGelisim.Size = new System.Drawing.Size(220, 50);
            this.btnNavGelisim.TabIndex = 4;
            this.btnNavGelisim.Text = "Gelişim Takibi";
            this.btnNavGelisim.Click += new System.EventHandler(this.btnNavGelisim_Click);

            this.btnNavSeanslar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavSeanslar.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnNavSeanslar.Appearance.Options.UseFont = true;
            this.btnNavSeanslar.Appearance.Options.UseForeColor = true;
            this.btnNavSeanslar.Appearance.Options.UseTextOptions = true;
            this.btnNavSeanslar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnNavSeanslar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNavSeanslar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavSeanslar.Location = new System.Drawing.Point(0, 280);
            this.btnNavSeanslar.Name = "btnNavSeanslar";
            this.btnNavSeanslar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavSeanslar.Size = new System.Drawing.Size(220, 50);
            this.btnNavSeanslar.TabIndex = 5;
            this.btnNavSeanslar.Text = "Seans Yönetimi";
            this.btnNavSeanslar.Click += new System.EventHandler(this.btnNavSeanslar_Click);

            this.btnNavTakvim.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavTakvim.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnNavTakvim.Appearance.Options.UseFont = true;
            this.btnNavTakvim.Appearance.Options.UseForeColor = true;
            this.btnNavTakvim.Appearance.Options.UseTextOptions = true;
            this.btnNavTakvim.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnNavTakvim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNavTakvim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTakvim.Location = new System.Drawing.Point(0, 330);
            this.btnNavTakvim.Name = "btnNavTakvim";
            this.btnNavTakvim.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavTakvim.Size = new System.Drawing.Size(220, 50);
            this.btnNavTakvim.TabIndex = 6;
            this.btnNavTakvim.Text = "Takvim";
            this.btnNavTakvim.Click += new System.EventHandler(this.btnNavTakvim_Click);

            this.btnNavMuhasebe.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavMuhasebe.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnNavMuhasebe.Appearance.Options.UseFont = true;
            this.btnNavMuhasebe.Appearance.Options.UseForeColor = true;
            this.btnNavMuhasebe.Appearance.Options.UseTextOptions = true;
            this.btnNavMuhasebe.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnNavMuhasebe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNavMuhasebe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavMuhasebe.Location = new System.Drawing.Point(0, 380);
            this.btnNavMuhasebe.Name = "btnNavMuhasebe";
            this.btnNavMuhasebe.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavMuhasebe.Size = new System.Drawing.Size(220, 50);
            this.btnNavMuhasebe.TabIndex = 7;
            this.btnNavMuhasebe.Text = "Ödemeler/Muhasebe";
            this.btnNavMuhasebe.Click += new System.EventHandler(this.btnNavMuhasebe_Click);

            this.btnNavAyarlar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavAyarlar.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnNavAyarlar.Appearance.Options.UseFont = true;
            this.btnNavAyarlar.Appearance.Options.UseForeColor = true;
            this.btnNavAyarlar.Appearance.Options.UseTextOptions = true;
            this.btnNavAyarlar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnNavAyarlar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNavAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAyarlar.Location = new System.Drawing.Point(0, 430);
            this.btnNavAyarlar.Name = "btnNavAyarlar";
            this.btnNavAyarlar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavAyarlar.Size = new System.Drawing.Size(220, 50);
            this.btnNavAyarlar.TabIndex = 8;
            this.btnNavAyarlar.Text = "Ayarlar";
            this.btnNavAyarlar.Click += new System.EventHandler(this.btnNavAyarlar_Click);

            this.btnNavCikis.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavCikis.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.btnNavCikis.Appearance.Options.UseFont = true;
            this.btnNavCikis.Appearance.Options.UseForeColor = true;
            this.btnNavCikis.Appearance.Options.UseTextOptions = true;
            this.btnNavCikis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnNavCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNavCikis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNavCikis.Location = new System.Drawing.Point(0, 668);
            this.btnNavCikis.Name = "btnNavCikis";
            this.btnNavCikis.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavCikis.Size = new System.Drawing.Size(220, 50);
            this.btnNavCikis.TabIndex = 9;
            this.btnNavCikis.Text = "Çıkış Yap";
            this.btnNavCikis.Click += new System.EventHandler(this.btnCikis_Click);

            // 
            // pnlHeader
            // 
            this.pnlHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.pnlHeader.Appearance.Options.UseBackColor = true;
            this.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlHeader.Controls.Add(this.picUserAvatar);
            this.pnlHeader.Controls.Add(this.lblKullanici);
            this.pnlHeader.Controls.Add(this.lblTarih);
            this.pnlHeader.Controls.Add(this.lblSaat);
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnMaximize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1260, 60);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);

            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(1220, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 60);
            this.btnClose.Text = "X";
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClose.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Location = new System.Drawing.Point(1180, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 60);
            this.btnMaximize.Text = "⬜";
            this.btnMaximize.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnMaximize.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);

            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Location = new System.Drawing.Point(1140, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 60);
            this.btnMinimize.Text = "_";
            this.btnMinimize.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnMinimize.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);

            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(20, 18);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(150, 21);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Form Başlığı";

            this.lblSaat.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaat.Size = new System.Drawing.Size(100, 60);
            this.lblSaat.Location = new System.Drawing.Point(1040, 0);

            this.lblTarih.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTarih.Size = new System.Drawing.Size(150, 60);
            this.lblTarih.Location = new System.Drawing.Point(890, 0);

            this.lblKullanici.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.lblKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKullanici.Size = new System.Drawing.Size(150, 60);
            this.lblKullanici.Location = new System.Drawing.Point(740, 0);

            this.picUserAvatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picUserAvatar.Location = new System.Drawing.Point(680, 0);
            this.picUserAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picUserAvatar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picUserAvatar.Size = new System.Drawing.Size(60, 60);

            // 
            // pnlContent
            // 
            this.pnlContent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContent.Controls.Add(this.pnlOgrenciler);
            this.pnlContent.Controls.Add(this.pnlDashboard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1260, 658);
            this.pnlContent.TabIndex = 2;

            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.chartControl1);
            this.pnlDashboard.Controls.Add(this.tileControl1);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1260, 658);
            this.pnlDashboard.TabIndex = 1;
            this.pnlDashboard.Visible = false;

            // chartControl1 ve tileControl1 konfigürasyonları...
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(2, 202);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] { series1 };
            this.chartControl1.Size = new System.Drawing.Size(1256, 454);

            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileControl1.Groups.Add(this.tileGroup4);
            this.tileControl1.Groups.Add(this.tileGroup6);
            this.tileControl1.Groups.Add(this.tileGroup7);
            this.tileControl1.Groups.Add(this.tileGroup8);
            this.tileControl1.Location = new System.Drawing.Point(2, 2);
            this.tileControl1.Size = new System.Drawing.Size(1256, 200);

            // Tile configs
            this.tileGroup4.Items.Add(this.tileItem1);
            this.tileGroup6.Items.Add(this.tileItem2);
            this.tileGroup7.Items.Add(this.tileItem3);
            this.tileGroup8.Items.Add(this.tileItem4);

            // tileItem1-4 appearance settings (kept from original but simplified)
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.tileItem1.Text = "Öğrenci Sayısı";
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.tileItem2.Text = "Öğretmen Sayısı";
            this.tileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.tileItem3.Text = "Bugünkü Dersler";
            this.tileItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(230, 81, 0);
            this.tileItem4.Text = "Toplam Kazanç";

            // 
            // pnlOgrenciler
            // 
            this.pnlOgrenciler.Controls.Add(this.gridControl1);
            this.pnlOgrenciler.Controls.Add(this.groupControl1);
            this.pnlOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOgrenciler.Location = new System.Drawing.Point(0, 0);
            this.pnlOgrenciler.Name = "pnlOgrenciler";
            this.pnlOgrenciler.Size = new System.Drawing.Size(1260, 658);
            this.pnlOgrenciler.TabIndex = 2;
            this.pnlOgrenciler.Visible = false;

            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Location = new System.Drawing.Point(350, 2);
            this.gridControl1.Size = new System.Drawing.Size(908, 654);

            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridView1_FocusedRowChanged);

            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Width = 350;
            this.groupControl1.Text = "Öğrenci Bilgileri";
            // GroupControl içindeki kontrolleri ekle

            this.groupControl1.Controls.Add(this.btnPdfAl);
            this.groupControl1.Controls.Add(this.btnExcelAl);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.cmbVeliYakinlik);
            this.groupControl1.Controls.Add(this.txtVeliTel);
            this.groupControl1.Controls.Add(this.txtVeliAd);
            this.groupControl1.Controls.Add(this.lblVeliYakinlik);
            this.groupControl1.Controls.Add(this.lblVeliTel);
            this.groupControl1.Controls.Add(this.lblVeliAd);
            this.groupControl1.Controls.Add(this.lblVeliBaslik);
            this.groupControl1.Controls.Add(this.textEngelOrani);
            this.groupControl1.Controls.Add(this.cmbEngel);
            this.groupControl1.Controls.Add(this.dateDogum);
            this.groupControl1.Controls.Add(this.textTc);
            this.groupControl1.Controls.Add(this.textAd);
            this.groupControl1.Controls.Add(this.lblEngelOran);
            this.groupControl1.Controls.Add(this.lblEngel);
            this.groupControl1.Controls.Add(this.lblDogum);
            this.groupControl1.Controls.Add(this.lblTc);
            this.groupControl1.Controls.Add(this.lblAd);

            // 
            // Layout Definitions
            // 

            // 1. Ad Soyad
            this.lblAd.Text = "Ad Soyad:";
            this.lblAd.Location = new System.Drawing.Point(15, 40);
            this.textAd.Location = new System.Drawing.Point(110, 37);
            this.textAd.Size = new System.Drawing.Size(220, 30);

            // 2. TC Kimlik
            this.lblTc.Text = "TC Kimlik:";
            this.lblTc.Location = new System.Drawing.Point(15, 80);
            this.textTc.Location = new System.Drawing.Point(110, 77);
            this.textTc.Size = new System.Drawing.Size(220, 30);

            // 3. Doğum Tarihi
            this.lblDogum.Text = "D. Tarihi:";
            this.lblDogum.Location = new System.Drawing.Point(15, 120);
            this.dateDogum.Location = new System.Drawing.Point(110, 117);
            this.dateDogum.Size = new System.Drawing.Size(220, 30);

            // 4. Engel Türü
            this.lblEngel.Text = "Engel Türü:";
            this.lblEngel.Location = new System.Drawing.Point(15, 160);
            this.cmbEngel.Location = new System.Drawing.Point(110, 157);
            this.cmbEngel.Size = new System.Drawing.Size(220, 30);

            // 5. Engel Oranı
            this.lblEngelOran.Text = "Engel %:";
            this.lblEngelOran.Location = new System.Drawing.Point(15, 200);
            this.textEngelOrani.Location = new System.Drawing.Point(110, 197);
            this.textEngelOrani.Size = new System.Drawing.Size(220, 30);

            // --- Veli Header ---
            this.lblVeliBaslik.Text = "--- VELİ BİLGİLERİ ---";
            this.lblVeliBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVeliBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblVeliBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVeliBaslik.Location = new System.Drawing.Point(15, 240);
            this.lblVeliBaslik.Size = new System.Drawing.Size(315, 20);

            // 6. Veli Ad
            this.lblVeliAd.Text = "Veli Adı:";
            this.lblVeliAd.Location = new System.Drawing.Point(15, 275);
            this.txtVeliAd.Location = new System.Drawing.Point(110, 272);
            this.txtVeliAd.Size = new System.Drawing.Size(220, 30);

            // 7. Veli Tel
            this.lblVeliTel.Text = "Veli Tel:";
            this.lblVeliTel.Location = new System.Drawing.Point(15, 315);
            this.txtVeliTel.Location = new System.Drawing.Point(110, 312);
            this.txtVeliTel.Size = new System.Drawing.Size(220, 30);

            // 8. Yakınlık
            this.lblVeliYakinlik.Text = "Yakınlık:";
            this.lblVeliYakinlik.Location = new System.Drawing.Point(15, 355);
            this.cmbVeliYakinlik.Location = new System.Drawing.Point(110, 352);
            this.cmbVeliYakinlik.Size = new System.Drawing.Size(220, 30);

            // --- Butonlar Row 1 ---
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.Location = new System.Drawing.Point(15, 410);
            this.btnKaydet.Size = new System.Drawing.Size(95, 40);
            this.btnKaydet.Text = "💾 KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnSil.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Appearance.Options.UseForeColor = true;
            this.btnSil.Location = new System.Drawing.Point(120, 410);
            this.btnSil.Size = new System.Drawing.Size(95, 40);
            this.btnSil.Text = "🗑️ SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Location = new System.Drawing.Point(225, 410);
            this.btnTemizle.Size = new System.Drawing.Size(95, 40);
            this.btnTemizle.Text = "🔄 TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);

            // --- Butonlar Row 2 ---
            // 
            // btnExcelAl
            // 
            this.btnExcelAl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnExcelAl.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExcelAl.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnExcelAl.Appearance.Options.UseBackColor = true;
            this.btnExcelAl.Appearance.Options.UseFont = true;
            this.btnExcelAl.Appearance.Options.UseForeColor = true;
            this.btnExcelAl.Location = new System.Drawing.Point(15, 460);
            this.btnExcelAl.Size = new System.Drawing.Size(145, 40);
            this.btnExcelAl.Text = "📗 EXCEL";
            this.btnExcelAl.Click += new System.EventHandler(this.btnExcelAl_Click);

            // 
            // btnPdfAl
            // 
            this.btnPdfAl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnPdfAl.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPdfAl.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnPdfAl.Appearance.Options.UseBackColor = true;
            this.btnPdfAl.Appearance.Options.UseFont = true;
            this.btnPdfAl.Appearance.Options.UseForeColor = true;
            this.btnPdfAl.Location = new System.Drawing.Point(170, 460);
            this.btnPdfAl.Size = new System.Drawing.Size(145, 40);
            this.btnPdfAl.Text = "📕 PDF";
            this.btnPdfAl.Click += new System.EventHandler(this.btnPdfAl_Click);


            // Timer
            this.timerSaat.Enabled = true;
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 718);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Form1";
            this.Text = "İlgi Özel Eğitim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            // Layout düzenlemeleri (GroupControl elemanlarının konumları)
            // ... (Mevcut konumlar korunacak şekilde basit atamalar yapılabilir veya Designer bu kısmı halledecek)
            // Örnek konumlandırmalar:
            this.lblAd.Location = new System.Drawing.Point(10, 30);
            this.textAd.Location = new System.Drawing.Point(120, 27);

            ((System.ComponentModel.ISupportInitialize)(this.pnlSidebar)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDashboard)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOgrenciler)).EndInit();
            this.pnlOgrenciler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVeliYakinlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVeliTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVeliAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEngelOrani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEngel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogum.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAd.Properties)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Kontrol Tanımları
        private DevExpress.XtraEditors.PanelControl pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private DevExpress.XtraEditors.SimpleButton btnNavAnasayfa;
        private DevExpress.XtraEditors.SimpleButton btnNavOgretmenler;
        private DevExpress.XtraEditors.SimpleButton btnNavOgrenciler;
        private DevExpress.XtraEditors.SimpleButton btnNavGelisim;
        private DevExpress.XtraEditors.SimpleButton btnNavSeanslar;
        private DevExpress.XtraEditors.SimpleButton btnNavTakvim;
        private DevExpress.XtraEditors.SimpleButton btnNavMuhasebe;
        private DevExpress.XtraEditors.SimpleButton btnNavAyarlar;
        private DevExpress.XtraEditors.SimpleButton btnNavCikis;

        private DevExpress.XtraEditors.PanelControl pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblKullanici;
        private DevExpress.XtraEditors.PictureEdit picUserAvatar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnMaximize;
        private DevExpress.XtraEditors.SimpleButton btnMinimize;

        private DevExpress.XtraEditors.PanelControl pnlContent;
        private DevExpress.XtraEditors.PanelControl pnlDashboard;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileGroup tileGroup6;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileGroup tileGroup7;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileGroup tileGroup8;
        private DevExpress.XtraEditors.TileItem tileItem4;

        private DevExpress.XtraEditors.PanelControl pnlOgrenciler;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;

        // Mevcut Form kontrolleri
        private DevExpress.XtraEditors.SimpleButton btnPdfAl;
        private DevExpress.XtraEditors.SimpleButton btnExcelAl;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.LabelControl lblVeliYakinlik;
        private DevExpress.XtraEditors.ComboBoxEdit cmbVeliYakinlik;
        private DevExpress.XtraEditors.TextEdit txtVeliTel;
        private DevExpress.XtraEditors.LabelControl lblVeliTel;
        private DevExpress.XtraEditors.TextEdit txtVeliAd;
        private DevExpress.XtraEditors.LabelControl lblVeliAd;
        private DevExpress.XtraEditors.LabelControl lblVeliBaslik;
        private DevExpress.XtraEditors.TextEdit textEngelOrani;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEngel;
        private DevExpress.XtraEditors.DateEdit dateDogum;
        private DevExpress.XtraEditors.TextEdit textTc;
        private DevExpress.XtraEditors.TextEdit textAd;
        private DevExpress.XtraEditors.LabelControl lblEngelOran;
        private DevExpress.XtraEditors.LabelControl lblEngel;
        private DevExpress.XtraEditors.LabelControl lblDogum;
        private DevExpress.XtraEditors.LabelControl lblTc;
        private DevExpress.XtraEditors.LabelControl lblAd;

        private System.Windows.Forms.Timer timerSaat;
    }
}
