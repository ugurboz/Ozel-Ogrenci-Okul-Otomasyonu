namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class UcFatura
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelSozlesme = new DevExpress.XtraEditors.PanelControl();
            this.lblSozlesmeBilgi = new DevExpress.XtraEditors.LabelControl();
            this.lblAylikSeans = new DevExpress.XtraEditors.LabelControl();
            this.lblAylikUcret = new DevExpress.XtraEditors.LabelControl();
            this.lblTutar = new DevExpress.XtraEditors.LabelControl();
            this.lblSeansSayisi = new DevExpress.XtraEditors.LabelControl();
            this.spinSeansSayisi = new DevExpress.XtraEditors.SpinEdit();
            this.lblTaksitSayisi = new DevExpress.XtraEditors.LabelControl();
            this.spinTaksitSayisi = new DevExpress.XtraEditors.SpinEdit();
            this.btnTaksitOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.lblToplam = new DevExpress.XtraEditors.LabelControl();
            this.lueOgrenci = new DevExpress.XtraEditors.LookUpEdit();
            this.lblOgrenci = new DevExpress.XtraEditors.LabelControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlTaksit = new DevExpress.XtraGrid.GridControl();
            this.gridViewTaksit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelTaksitButonlar = new DevExpress.XtraEditors.PanelControl();
            this.btnOdendi = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdenmedi = new DevExpress.XtraEditors.SimpleButton();
            this.btnMakbuzYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.btnMakbuzPdf = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaksitSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSozlesme)).BeginInit();
            this.panelSozlesme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinSeansSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTaksitSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOgrenci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTaksit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaksit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTaksitButonlar)).BeginInit();
            this.panelTaksitButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1512, 696);
            this.splitContainerControl1.SplitterPosition = 400;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.txtTutar);
            this.groupControl1.Controls.Add(this.panelSozlesme);
            this.groupControl1.Controls.Add(this.lblTutar);
            this.groupControl1.Controls.Add(this.lblSeansSayisi);
            this.groupControl1.Controls.Add(this.spinSeansSayisi);
            this.groupControl1.Controls.Add(this.lblTaksitSayisi);
            this.groupControl1.Controls.Add(this.spinTaksitSayisi);
            this.groupControl1.Controls.Add(this.btnTaksitOlustur);
            this.groupControl1.Controls.Add(this.lblToplam);
            this.groupControl1.Controls.Add(this.lueOgrenci);
            this.groupControl1.Controls.Add(this.lblOgrenci);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(400, 696);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "💰 Ödeme Yönetimi";
            // 
            // panelSozlesme
            // 
            this.panelSozlesme.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panelSozlesme.Appearance.Options.UseBackColor = true;
            this.panelSozlesme.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelSozlesme.Controls.Add(this.lblSozlesmeBilgi);
            this.panelSozlesme.Controls.Add(this.lblAylikSeans);
            this.panelSozlesme.Controls.Add(this.lblAylikUcret);
            this.panelSozlesme.Location = new System.Drawing.Point(20, 115);
            this.panelSozlesme.Name = "panelSozlesme";
            this.panelSozlesme.Size = new System.Drawing.Size(360, 120);
            this.panelSozlesme.TabIndex = 0;
            // 
            // lblSozlesmeBilgi
            // 
            this.lblSozlesmeBilgi.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSozlesmeBilgi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblSozlesmeBilgi.Appearance.Options.UseFont = true;
            this.lblSozlesmeBilgi.Appearance.Options.UseForeColor = true;
            this.lblSozlesmeBilgi.Location = new System.Drawing.Point(15, 15);
            this.lblSozlesmeBilgi.Name = "lblSozlesmeBilgi";
            this.lblSozlesmeBilgi.Size = new System.Drawing.Size(137, 20);
            this.lblSozlesmeBilgi.TabIndex = 0;
            this.lblSozlesmeBilgi.Text = "📋 Sözleşme Bilgisi";
            // 
            // lblAylikSeans
            // 
            this.lblAylikSeans.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAylikSeans.Appearance.Options.UseFont = true;
            this.lblAylikSeans.Location = new System.Drawing.Point(15, 50);
            this.lblAylikSeans.Name = "lblAylikSeans";
            this.lblAylikSeans.Size = new System.Drawing.Size(76, 17);
            this.lblAylikSeans.TabIndex = 1;
            this.lblAylikSeans.Text = "Aylık Seans: -";
            // 
            // lblAylikUcret
            // 
            this.lblAylikUcret.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAylikUcret.Appearance.Options.UseFont = true;
            this.lblAylikUcret.Location = new System.Drawing.Point(15, 80);
            this.lblAylikUcret.Name = "lblAylikUcret";
            this.lblAylikUcret.Size = new System.Drawing.Size(73, 17);
            this.lblAylikUcret.TabIndex = 2;
            this.lblAylikUcret.Text = "Aylık Ücret: -";
            // 
            // lblTutar
            // 
            this.lblTutar.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTutar.Appearance.Options.UseFont = true;
            this.lblTutar.Location = new System.Drawing.Point(20, 250);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(117, 17);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "Toplam Tutar (TL):";
            // 
            // lblSeansSayisi
            // 
            this.lblSeansSayisi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSeansSayisi.Appearance.Options.UseFont = true;
            this.lblSeansSayisi.Location = new System.Drawing.Point(20, 320);
            this.lblSeansSayisi.Name = "lblSeansSayisi";
            this.lblSeansSayisi.Size = new System.Drawing.Size(130, 17);
            this.lblSeansSayisi.TabIndex = 11;
            this.lblSeansSayisi.Text = "Aylık Seans Sayısı:";
            // 
            // spinSeansSayisi
            // 
            this.spinSeansSayisi.EditValue = new decimal(new int[] { 8, 0, 0, 0 });
            this.spinSeansSayisi.Location = new System.Drawing.Point(20, 345);
            this.spinSeansSayisi.Name = "spinSeansSayisi";
            this.spinSeansSayisi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spinSeansSayisi.Properties.Appearance.Options.UseFont = true;
            this.spinSeansSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSeansSayisi.Properties.MaxValue = new decimal(new int[] { 30, 0, 0, 0 });
            this.spinSeansSayisi.Properties.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            this.spinSeansSayisi.Size = new System.Drawing.Size(360, 28);
            this.spinSeansSayisi.TabIndex = 12;
            // 
            // lblTaksitSayisi
            // 
            this.lblTaksitSayisi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTaksitSayisi.Appearance.Options.UseFont = true;
            this.lblTaksitSayisi.Location = new System.Drawing.Point(20, 390);
            this.lblTaksitSayisi.Name = "lblTaksitSayisi";
            this.lblTaksitSayisi.Size = new System.Drawing.Size(80, 17);
            this.lblTaksitSayisi.TabIndex = 3;
            this.lblTaksitSayisi.Text = "Taksit Sayısı:";
            // 
            // spinTaksitSayisi
            // 
            this.spinTaksitSayisi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinTaksitSayisi.Location = new System.Drawing.Point(20, 415);
            this.spinTaksitSayisi.Name = "spinTaksitSayisi";
            this.spinTaksitSayisi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spinTaksitSayisi.Properties.Appearance.Options.UseFont = true;
            this.spinTaksitSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTaksitSayisi.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spinTaksitSayisi.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinTaksitSayisi.Size = new System.Drawing.Size(360, 28);
            this.spinTaksitSayisi.TabIndex = 4;
            // 
            // btnTaksitOlustur
            // 
            this.btnTaksitOlustur.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTaksitOlustur.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTaksitOlustur.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTaksitOlustur.Appearance.Options.UseBackColor = true;
            this.btnTaksitOlustur.Appearance.Options.UseFont = true;
            this.btnTaksitOlustur.Appearance.Options.UseForeColor = true;
            this.btnTaksitOlustur.Location = new System.Drawing.Point(20, 460);
            this.btnTaksitOlustur.Name = "btnTaksitOlustur";
            this.btnTaksitOlustur.Size = new System.Drawing.Size(360, 40);
            this.btnTaksitOlustur.TabIndex = 5;
            this.btnTaksitOlustur.Text = "📝 SÖZLEŞME OLUŞTUR";
            this.btnTaksitOlustur.Click += new System.EventHandler(this.btnTaksitOlustur_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblToplam.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblToplam.Appearance.Options.UseFont = true;
            this.lblToplam.Appearance.Options.UseForeColor = true;
            this.lblToplam.Location = new System.Drawing.Point(20, 520);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(170, 30);
            this.lblToplam.TabIndex = 6;
            this.lblToplam.Text = "TOPLAM: 0.00 TL";
            // 
            // lueOgrenci
            // 
            this.lueOgrenci.Location = new System.Drawing.Point(20, 75);
            this.lueOgrenci.Name = "lueOgrenci";
            this.lueOgrenci.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lueOgrenci.Properties.Appearance.Options.UseFont = true;
            this.lueOgrenci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOgrenci.Size = new System.Drawing.Size(360, 24);
            this.lueOgrenci.TabIndex = 7;
            this.lueOgrenci.EditValueChanged += new System.EventHandler(this.lueOgrenci_EditValueChanged);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOgrenci.Appearance.Options.UseFont = true;
            this.lblOgrenci.Location = new System.Drawing.Point(20, 50);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(88, 17);
            this.lblOgrenci.TabIndex = 8;
            this.lblOgrenci.Text = "Öğrenci Seçin:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Location = new System.Drawing.Point(20, 570);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(360, 40);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "🔄 TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.gridControlTaksit);
            this.groupControl2.Controls.Add(this.panelTaksitButonlar);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1102, 696);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "📊 Ödeme Planı / Taksitler";
            // 
            // gridControlTaksit
            // 
            this.gridControlTaksit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTaksit.Location = new System.Drawing.Point(2, 26);
            this.gridControlTaksit.MainView = this.gridViewTaksit;
            this.gridControlTaksit.Name = "gridControlTaksit";
            this.gridControlTaksit.Size = new System.Drawing.Size(1098, 608);
            this.gridControlTaksit.TabIndex = 0;
            this.gridControlTaksit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTaksit});
            // 
            // gridViewTaksit
            // 
            this.gridViewTaksit.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridViewTaksit.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewTaksit.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridViewTaksit.Appearance.Row.Options.UseFont = true;
            this.gridViewTaksit.GridControl = this.gridControlTaksit;
            this.gridViewTaksit.Name = "gridViewTaksit";
            this.gridViewTaksit.OptionsView.ShowGroupPanel = false;
            this.gridViewTaksit.RowHeight = 35;
            this.gridViewTaksit.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTaksit_FocusedRowChanged);
            // 
            // panelTaksitButonlar
            // 
            this.panelTaksitButonlar.Controls.Add(this.btnOdendi);
            this.panelTaksitButonlar.Controls.Add(this.btnOdenmedi);
            this.panelTaksitButonlar.Controls.Add(this.btnMakbuzYazdir);
            this.panelTaksitButonlar.Controls.Add(this.btnMakbuzPdf);
            this.panelTaksitButonlar.Controls.Add(this.btnTaksitSil);
            this.panelTaksitButonlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTaksitButonlar.Location = new System.Drawing.Point(2, 634);
            this.panelTaksitButonlar.Name = "panelTaksitButonlar";
            this.panelTaksitButonlar.Size = new System.Drawing.Size(1098, 60);
            this.panelTaksitButonlar.TabIndex = 1;
            // 
            // btnOdendi
            // 
            this.btnOdendi.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnOdendi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOdendi.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnOdendi.Appearance.Options.UseBackColor = true;
            this.btnOdendi.Appearance.Options.UseFont = true;
            this.btnOdendi.Appearance.Options.UseForeColor = true;
            this.btnOdendi.Location = new System.Drawing.Point(15, 12);
            this.btnOdendi.Name = "btnOdendi";
            this.btnOdendi.Size = new System.Drawing.Size(150, 40);
            this.btnOdendi.TabIndex = 0;
            this.btnOdendi.Text = "✅ ÖDENDİ";
            this.btnOdendi.Click += new System.EventHandler(this.btnOdendi_Click);
            // 
            // btnOdenmedi
            // 
            this.btnOdenmedi.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnOdenmedi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOdenmedi.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnOdenmedi.Appearance.Options.UseBackColor = true;
            this.btnOdenmedi.Appearance.Options.UseFont = true;
            this.btnOdenmedi.Appearance.Options.UseForeColor = true;
            this.btnOdenmedi.Location = new System.Drawing.Point(175, 12);
            this.btnOdenmedi.Name = "btnOdenmedi";
            this.btnOdenmedi.Size = new System.Drawing.Size(150, 40);
            this.btnOdenmedi.TabIndex = 1;
            this.btnOdenmedi.Text = "❌ ÖDENMEDİ";
            this.btnOdenmedi.Click += new System.EventHandler(this.btnOdenmedi_Click);
            // 
            // btnMakbuzYazdir
            // 
            this.btnMakbuzYazdir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnMakbuzYazdir.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMakbuzYazdir.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnMakbuzYazdir.Appearance.Options.UseBackColor = true;
            this.btnMakbuzYazdir.Appearance.Options.UseFont = true;
            this.btnMakbuzYazdir.Appearance.Options.UseForeColor = true;
            this.btnMakbuzYazdir.Location = new System.Drawing.Point(360, 12);
            this.btnMakbuzYazdir.Name = "btnMakbuzYazdir";
            this.btnMakbuzYazdir.Size = new System.Drawing.Size(180, 40);
            this.btnMakbuzYazdir.TabIndex = 2;
            this.btnMakbuzYazdir.Text = "🖨️ MAKBUZ YAZDIR";
            this.btnMakbuzYazdir.Click += new System.EventHandler(this.btnMakbuzYazdir_Click);
            // 
            // btnMakbuzPdf
            // 
            this.btnMakbuzPdf.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnMakbuzPdf.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMakbuzPdf.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnMakbuzPdf.Appearance.Options.UseBackColor = true;
            this.btnMakbuzPdf.Appearance.Options.UseFont = true;
            this.btnMakbuzPdf.Appearance.Options.UseForeColor = true;
            this.btnMakbuzPdf.Location = new System.Drawing.Point(550, 12);
            this.btnMakbuzPdf.Name = "btnMakbuzPdf";
            this.btnMakbuzPdf.Size = new System.Drawing.Size(180, 40);
            this.btnMakbuzPdf.TabIndex = 3;
            this.btnMakbuzPdf.Text = "📄 PDF KAYDET";
            this.btnMakbuzPdf.Click += new System.EventHandler(this.btnMakbuzPdf_Click);
            // 
            // btnTaksitSil
            // 
            this.btnTaksitSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnTaksitSil.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaksitSil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTaksitSil.Appearance.Options.UseBackColor = true;
            this.btnTaksitSil.Appearance.Options.UseFont = true;
            this.btnTaksitSil.Appearance.Options.UseForeColor = true;
            this.btnTaksitSil.Location = new System.Drawing.Point(760, 12);
            this.btnTaksitSil.Name = "btnTaksitSil";
            this.btnTaksitSil.Size = new System.Drawing.Size(120, 40);
            this.btnTaksitSil.TabIndex = 4;
            this.btnTaksitSil.Text = "🗑️ SİL";
            this.btnTaksitSil.Click += new System.EventHandler(this.btnTaksitSil_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(20, 273);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTutar.Properties.Appearance.Options.UseFont = true;
            this.txtTutar.Size = new System.Drawing.Size(360, 28);
            this.txtTutar.TabIndex = 10;
            // 
            // UcFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UcFatura";
            this.Size = new System.Drawing.Size(1512, 696);
            this.Load += new System.EventHandler(this.UcFatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSozlesme)).EndInit();
            this.panelSozlesme.ResumeLayout(false);
            this.panelSozlesme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinSeansSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTaksitSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOgrenci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTaksit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaksit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTaksitButonlar)).EndInit();
            this.panelTaksitButonlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelSozlesme;
        private DevExpress.XtraEditors.LabelControl lblSozlesmeBilgi;
        private DevExpress.XtraEditors.LabelControl lblAylikSeans;
        private DevExpress.XtraEditors.LabelControl lblAylikUcret;
        private DevExpress.XtraEditors.LabelControl lblTaksitSayisi;
        private DevExpress.XtraEditors.SpinEdit spinTaksitSayisi;
        private DevExpress.XtraEditors.SimpleButton btnTaksitOlustur;
        private DevExpress.XtraEditors.LabelControl lblToplam;
        private DevExpress.XtraEditors.LookUpEdit lueOgrenci;
        private DevExpress.XtraEditors.LabelControl lblOgrenci;
        private DevExpress.XtraEditors.LabelControl lblTutar;
        private DevExpress.XtraEditors.LabelControl lblSeansSayisi;
        private DevExpress.XtraEditors.SpinEdit spinSeansSayisi;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlTaksit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTaksit;
        private DevExpress.XtraEditors.PanelControl panelTaksitButonlar;
        private DevExpress.XtraEditors.SimpleButton btnOdendi;
        private DevExpress.XtraEditors.SimpleButton btnOdenmedi;
        private DevExpress.XtraEditors.SimpleButton btnMakbuzYazdir;
        private DevExpress.XtraEditors.SimpleButton btnMakbuzPdf;
        private DevExpress.XtraEditors.SimpleButton btnTaksitSil;
        private DevExpress.XtraEditors.TextEdit txtTutar;
    }
}

