namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class UcOgretmen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcOgretmen));
            this.txtOgrtMail = new DevExpress.XtraEditors.TextEdit();
            this.lblMail = new DevExpress.XtraEditors.LabelControl();
            this.btnOgrtKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnOgrtSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnOgrtTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtOgrtTel = new DevExpress.XtraEditors.TextEdit();
            this.txtOgrtTc = new DevExpress.XtraEditors.TextEdit();
            this.txtOgrtAd = new DevExpress.XtraEditors.TextEdit();
            this.lblTlfNo = new DevExpress.XtraEditors.LabelControl();
            this.lblBrans = new DevExpress.XtraEditors.LabelControl();
            this.lblTc = new DevExpress.XtraEditors.LabelControl();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.gridControlOgretmen = new DevExpress.XtraGrid.GridControl();
            this.gridViewOgretmen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.listDersler = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOgrtMail
            // 
            this.txtOgrtMail.Location = new System.Drawing.Point(154, 238);
            this.txtOgrtMail.Name = "txtOgrtMail";
            this.txtOgrtMail.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtMail.TabIndex = 29;
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(47, 238);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(58, 13);
            this.lblMail.TabIndex = 28;
            this.lblMail.Text = "Mail Adresi :";
            // 
            // btnOgrtKaydet
            // 
            this.btnOgrtKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrtKaydet.ImageOptions.Image")));
            this.btnOgrtKaydet.Location = new System.Drawing.Point(49, 424);
            this.btnOgrtKaydet.Name = "btnOgrtKaydet";
            this.btnOgrtKaydet.Size = new System.Drawing.Size(97, 54);
            this.btnOgrtKaydet.TabIndex = 27;
            this.btnOgrtKaydet.Text = "KAYDET";
            this.btnOgrtKaydet.Click += new System.EventHandler(this.btnOgrtKaydet_Click);
            // 
            // btnOgrtSil
            // 
            this.btnOgrtSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrtSil.ImageOptions.Image")));
            this.btnOgrtSil.Location = new System.Drawing.Point(171, 424);
            this.btnOgrtSil.Name = "btnOgrtSil";
            this.btnOgrtSil.Size = new System.Drawing.Size(85, 54);
            this.btnOgrtSil.TabIndex = 26;
            this.btnOgrtSil.Text = "SIL";
            this.btnOgrtSil.Click += new System.EventHandler(this.btnOgrtSil_Click);
            // 
            // btnOgrtTemizle
            // 
            this.btnOgrtTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrtTemizle.ImageOptions.Image")));
            this.btnOgrtTemizle.Location = new System.Drawing.Point(281, 424);
            this.btnOgrtTemizle.Name = "btnOgrtTemizle";
            this.btnOgrtTemizle.Size = new System.Drawing.Size(91, 54);
            this.btnOgrtTemizle.TabIndex = 25;
            this.btnOgrtTemizle.Text = "TEMIZLE";
            this.btnOgrtTemizle.Click += new System.EventHandler(this.btnOgrtTemizle_Click);
            // 
            // cmbBrans
            // 
            this.cmbBrans.Location = new System.Drawing.Point(154, 197);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBrans.Properties.Items.AddRange(new object[] {
            "Zihinsel Engelliler Öğretmeni",
            "",
            "Fizyoterapist",
            "",
            "Dil ve Konuşma Terapisti",
            "",
            "Psikolog / Rehberlik",
            "",
            "Ergoterapist",
            "",
            "Okul Öncesi"});
            this.cmbBrans.Size = new System.Drawing.Size(100, 20);
            this.cmbBrans.TabIndex = 24;
            // 
            // txtOgrtTel
            // 
            this.txtOgrtTel.Location = new System.Drawing.Point(154, 158);
            this.txtOgrtTel.Name = "txtOgrtTel";
            this.txtOgrtTel.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtTel.TabIndex = 23;
            // 
            // txtOgrtTc
            // 
            this.txtOgrtTc.Location = new System.Drawing.Point(154, 111);
            this.txtOgrtTc.Name = "txtOgrtTc";
            this.txtOgrtTc.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtTc.TabIndex = 21;
            // 
            // txtOgrtAd
            // 
            this.txtOgrtAd.Location = new System.Drawing.Point(154, 74);
            this.txtOgrtAd.Name = "txtOgrtAd";
            this.txtOgrtAd.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtAd.TabIndex = 20;
            // 
            // lblTlfNo
            // 
            this.lblTlfNo.Location = new System.Drawing.Point(46, 161);
            this.lblTlfNo.Name = "lblTlfNo";
            this.lblTlfNo.Size = new System.Drawing.Size(59, 13);
            this.lblTlfNo.TabIndex = 19;
            this.lblTlfNo.Text = "Telefon No :";
            // 
            // lblBrans
            // 
            this.lblBrans.Location = new System.Drawing.Point(47, 201);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(37, 13);
            this.lblBrans.TabIndex = 18;
            this.lblBrans.Text = "Brans  :";
            // 
            // lblTc
            // 
            this.lblTc.Location = new System.Drawing.Point(47, 112);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(66, 13);
            this.lblTc.TabIndex = 16;
            this.lblTc.Text = "TC numarasi :";
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(47, 75);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(50, 13);
            this.lblAd.TabIndex = 15;
            this.lblAd.Text = "Adi Soyadi";
            // 
            // gridControlOgretmen
            // 
            this.gridControlOgretmen.Location = new System.Drawing.Point(593, 0);
            this.gridControlOgretmen.MainView = this.gridViewOgretmen;
            this.gridControlOgretmen.Name = "gridControlOgretmen";
            this.gridControlOgretmen.Size = new System.Drawing.Size(916, 693);
            this.gridControlOgretmen.TabIndex = 30;
            this.gridControlOgretmen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOgretmen});
            this.gridControlOgretmen.Click += new System.EventHandler(this.UcOgretmen_Load);
            // 
            // gridViewOgretmen
            // 
            this.gridViewOgretmen.GridControl = this.gridControlOgretmen;
            this.gridViewOgretmen.Name = "gridViewOgretmen";
            this.gridViewOgretmen.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewOgretmen_FocusedRowChanged);
            // 
            // listDersler
            // 
            this.listDersler.Location = new System.Drawing.Point(154, 275);
            this.listDersler.Name = "listDersler";
            this.listDersler.Size = new System.Drawing.Size(120, 95);
            this.listDersler.TabIndex = 31;
            // 
            // UcOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listDersler);
            this.Controls.Add(this.gridControlOgretmen);
            this.Controls.Add(this.txtOgrtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnOgrtKaydet);
            this.Controls.Add(this.btnOgrtSil);
            this.Controls.Add(this.btnOgrtTemizle);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.txtOgrtTel);
            this.Controls.Add(this.txtOgrtTc);
            this.Controls.Add(this.txtOgrtAd);
            this.Controls.Add(this.lblTlfNo);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblAd);
            this.Name = "UcOgretmen";
            this.Size = new System.Drawing.Size(1512, 696);
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtOgrtMail;
        private DevExpress.XtraEditors.LabelControl lblMail;
        private DevExpress.XtraEditors.SimpleButton btnOgrtKaydet;
        private DevExpress.XtraEditors.SimpleButton btnOgrtSil;
        private DevExpress.XtraEditors.SimpleButton btnOgrtTemizle;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBrans;
        private DevExpress.XtraEditors.TextEdit txtOgrtTel;
        private DevExpress.XtraEditors.TextEdit txtOgrtTc;
        private DevExpress.XtraEditors.TextEdit txtOgrtAd;
        private DevExpress.XtraEditors.LabelControl lblTlfNo;
        private DevExpress.XtraEditors.LabelControl lblBrans;
        private DevExpress.XtraEditors.LabelControl lblTc;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraGrid.GridControl gridControlOgretmen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOgretmen;
        private DevExpress.XtraEditors.CheckedListBoxControl listDersler;
    }
}
