namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnOgretmen = new DevExpress.XtraBars.BarButtonItem();
            this.btnOgrenciler = new DevExpress.XtraBars.BarButtonItem();
            this.btnyonetici = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pnlDashboard = new DevExpress.XtraEditors.PanelControl();
            this.pnlOgrenciler = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEngel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEngelOrani = new DevExpress.XtraEditors.TextEdit();
            this.dateDogum = new DevExpress.XtraEditors.DateEdit();
            this.textTc = new DevExpress.XtraEditors.TextEdit();
            this.textAd = new DevExpress.XtraEditors.TextEdit();
            this.lblEngelOran = new DevExpress.XtraEditors.LabelControl();
            this.lblEngel = new DevExpress.XtraEditors.LabelControl();
            this.lblDogum = new DevExpress.XtraEditors.LabelControl();
            this.lblTc = new DevExpress.XtraEditors.LabelControl();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDashboard)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOgrenciler)).BeginInit();
            this.pnlOgrenciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEngel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEngelOrani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogum.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAnasayfa,
            this.btnOgretmen,
            this.btnOgrenciler});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.btnyonetici});
            this.ribbonControl1.Size = new System.Drawing.Size(1381, 158);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Caption = "ANASAYFA";
            this.btnAnasayfa.Id = 1;
            this.btnAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.ImageOptions.LargeImage")));
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAnasayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnasayfa_ItemClick);
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.Caption = "OGRETMENLER";
            this.btnOgretmen.Id = 2;
            this.btnOgretmen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOgretmen.ImageOptions.LargeImage")));
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnOgretmen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOgretmen_ItemClick);
            // 
            // btnOgrenciler
            // 
            this.btnOgrenciler.Caption = "OGRENCILER";
            this.btnOgrenciler.Id = 3;
            this.btnOgrenciler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOgrenciler.ImageOptions.LargeImage")));
            this.btnOgrenciler.Name = "btnOgrenciler";
            this.btnOgrenciler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnOgrenciler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOgrenciler_ItemClick);
            // 
            // btnyonetici
            // 
            this.btnyonetici.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.btnyonetici.Name = "btnyonetici";
            this.btnyonetici.Text = "YONETICI";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOgretmen);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOgrenciler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.labelControl1);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 158);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1381, 512);
            this.pnlDashboard.TabIndex = 1;
            this.pnlDashboard.Visible = false;
            // 
            // pnlOgrenciler
            // 
            this.pnlOgrenciler.AutoSize = true;
            this.pnlOgrenciler.Controls.Add(this.gridControl1);
            this.pnlOgrenciler.Controls.Add(this.groupControl1);
            this.pnlOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOgrenciler.Location = new System.Drawing.Point(0, 158);
            this.pnlOgrenciler.Name = "pnlOgrenciler";
            this.pnlOgrenciler.Size = new System.Drawing.Size(1381, 512);
            this.pnlOgrenciler.TabIndex = 1;
            this.pnlOgrenciler.Visible = false;
            this.pnlOgrenciler.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOgrenciler_Paint);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(548, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(831, 508);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1,
            this.gridView1});
            this.gridControl1.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gridView1_FocusedRowChanged);
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Red;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.cmbEngel);
            this.groupControl1.Controls.Add(this.textEngelOrani);
            this.groupControl1.Controls.Add(this.dateDogum);
            this.groupControl1.Controls.Add(this.textTc);
            this.groupControl1.Controls.Add(this.textAd);
            this.groupControl1.Controls.Add(this.lblEngelOran);
            this.groupControl1.Controls.Add(this.lblEngel);
            this.groupControl1.Controls.Add(this.lblDogum);
            this.groupControl1.Controls.Add(this.lblTc);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(10, 33);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(389, 385);
            this.groupControl1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(19, 270);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 54);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(141, 270);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 54);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SIL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(251, 270);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(91, 54);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "TEMIZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // cmbEngel
            // 
            this.cmbEngel.Location = new System.Drawing.Point(126, 170);
            this.cmbEngel.MenuManager = this.ribbonControl1;
            this.cmbEngel.Name = "cmbEngel";
            this.cmbEngel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEngel.Properties.Items.AddRange(new object[] {
            "İşitme",
            "Görme",
            "Zihinsel"});
            this.cmbEngel.Size = new System.Drawing.Size(100, 20);
            this.cmbEngel.TabIndex = 9;
            // 
            // textEngelOrani
            // 
            this.textEngelOrani.Location = new System.Drawing.Point(126, 215);
            this.textEngelOrani.MenuManager = this.ribbonControl1;
            this.textEngelOrani.Name = "textEngelOrani";
            this.textEngelOrani.Size = new System.Drawing.Size(100, 20);
            this.textEngelOrani.TabIndex = 8;
            // 
            // dateDogum
            // 
            this.dateDogum.EditValue = null;
            this.dateDogum.Location = new System.Drawing.Point(126, 127);
            this.dateDogum.MenuManager = this.ribbonControl1;
            this.dateDogum.Name = "dateDogum";
            this.dateDogum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDogum.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDogum.Size = new System.Drawing.Size(100, 20);
            this.dateDogum.TabIndex = 7;
            this.dateDogum.EditValueChanged += new System.EventHandler(this.dateDogum_EditValueChanged);
            // 
            // textTc
            // 
            this.textTc.Location = new System.Drawing.Point(126, 84);
            this.textTc.MenuManager = this.ribbonControl1;
            this.textTc.Name = "textTc";
            this.textTc.Size = new System.Drawing.Size(100, 20);
            this.textTc.TabIndex = 6;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(126, 47);
            this.textAd.MenuManager = this.ribbonControl1;
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(100, 20);
            this.textAd.TabIndex = 5;
            // 
            // lblEngelOran
            // 
            this.lblEngelOran.Location = new System.Drawing.Point(19, 219);
            this.lblEngelOran.Name = "lblEngelOran";
            this.lblEngelOran.Size = new System.Drawing.Size(84, 13);
            this.lblEngelOran.TabIndex = 4;
            this.lblEngelOran.Text = "Engel Orani (%) :";
            // 
            // lblEngel
            // 
            this.lblEngel.Location = new System.Drawing.Point(19, 174);
            this.lblEngel.Name = "lblEngel";
            this.lblEngel.Size = new System.Drawing.Size(58, 13);
            this.lblEngel.TabIndex = 3;
            this.lblEngel.Text = "Engel Turu :";
            // 
            // lblDogum
            // 
            this.lblDogum.Location = new System.Drawing.Point(19, 128);
            this.lblDogum.Name = "lblDogum";
            this.lblDogum.Size = new System.Drawing.Size(69, 13);
            this.lblDogum.TabIndex = 2;
            this.lblDogum.Text = "Dogum Tarihi :";
            // 
            // lblTc
            // 
            this.lblTc.Location = new System.Drawing.Point(19, 85);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(66, 13);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "TC numarasi :";
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(19, 48);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(50, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Adi Soyadi";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(372, 122);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "HOSGELDINIZ\r\n";
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 670);
            this.Controls.Add(this.pnlOgrenciler);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDashboard)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOgrenciler)).EndInit();
            this.pnlOgrenciler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEngel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEngelOrani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogum.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage btnyonetici;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem btnOgretmen;
        private DevExpress.XtraBars.BarButtonItem btnOgrenciler;
        private DevExpress.XtraEditors.PanelControl pnlDashboard;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pnlOgrenciler;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEngel;
        private DevExpress.XtraEditors.TextEdit textEngelOrani;
        private DevExpress.XtraEditors.DateEdit dateDogum;
        private DevExpress.XtraEditors.TextEdit textTc;
        private DevExpress.XtraEditors.TextEdit textAd;
        private DevExpress.XtraEditors.LabelControl lblEngelOran;
        private DevExpress.XtraEditors.LabelControl lblEngel;
        private DevExpress.XtraEditors.LabelControl lblDogum;
        private DevExpress.XtraEditors.LabelControl lblTc;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

