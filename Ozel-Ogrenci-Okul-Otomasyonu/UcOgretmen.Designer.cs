namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class UcOgretmen
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
            this.gridControlOgretmen = new DevExpress.XtraGrid.GridControl();
            this.gridViewOgretmen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtOgrtSifre = new DevExpress.XtraEditors.TextEdit();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.listDersler = new DevExpress.XtraEditors.CheckedListBoxControl();
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
            this.lblDersler = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDersler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlOgretmen
            // 
            this.gridControlOgretmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOgretmen.Location = new System.Drawing.Point(420, 0);
            this.gridControlOgretmen.MainView = this.gridViewOgretmen;
            this.gridControlOgretmen.Name = "gridControlOgretmen";
            this.gridControlOgretmen.Size = new System.Drawing.Size(1092, 696);
            this.gridControlOgretmen.TabIndex = 30;
            this.gridControlOgretmen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOgretmen});
            // 
            // gridViewOgretmen
            // 
            this.gridViewOgretmen.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridViewOgretmen.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewOgretmen.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gridViewOgretmen.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewOgretmen.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewOgretmen.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewOgretmen.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridViewOgretmen.Appearance.Row.Options.UseFont = true;
            this.gridViewOgretmen.GridControl = this.gridControlOgretmen;
            this.gridViewOgretmen.Name = "gridViewOgretmen";
            this.gridViewOgretmen.OptionsView.RowAutoHeight = true;
            this.gridViewOgretmen.OptionsView.ShowGroupPanel = false;
            this.gridViewOgretmen.RowHeight = 35;
            this.gridViewOgretmen.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewOgretmen_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.txtOgrtSifre);
            this.groupControl1.Controls.Add(this.lblSifre);
            this.groupControl1.Controls.Add(this.listDersler);
            this.groupControl1.Controls.Add(this.lblDersler);
            this.groupControl1.Controls.Add(this.txtOgrtMail);
            this.groupControl1.Controls.Add(this.lblMail);
            this.groupControl1.Controls.Add(this.btnOgrtKaydet);
            this.groupControl1.Controls.Add(this.btnOgrtSil);
            this.groupControl1.Controls.Add(this.btnOgrtTemizle);
            this.groupControl1.Controls.Add(this.cmbBrans);
            this.groupControl1.Controls.Add(this.txtOgrtTel);
            this.groupControl1.Controls.Add(this.txtOgrtTc);
            this.groupControl1.Controls.Add(this.txtOgrtAd);
            this.groupControl1.Controls.Add(this.lblTlfNo);
            this.groupControl1.Controls.Add(this.lblBrans);
            this.groupControl1.Controls.Add(this.lblTc);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(420, 696);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "👨‍🏫 Öğretmen İşlemleri";
            // 
            // lblAd
            // 
            this.lblAd.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAd.Appearance.Options.UseFont = true;
            this.lblAd.Location = new System.Drawing.Point(20, 55);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(68, 20);
            this.lblAd.TabIndex = 32;
            this.lblAd.Text = "Adı Soyadı :";
            // 
            // txtOgrtAd
            // 
            this.txtOgrtAd.Location = new System.Drawing.Point(130, 52);
            this.txtOgrtAd.Name = "txtOgrtAd";
            this.txtOgrtAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOgrtAd.Properties.Appearance.Options.UseFont = true;
            this.txtOgrtAd.Size = new System.Drawing.Size(250, 24);
            this.txtOgrtAd.TabIndex = 36;
            // 
            // lblTc
            // 
            this.lblTc.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTc.Appearance.Options.UseFont = true;
            this.lblTc.Location = new System.Drawing.Point(20, 95);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(84, 20);
            this.lblTc.TabIndex = 33;
            this.lblTc.Text = "TC Numarası :";
            // 
            // txtOgrtTc
            // 
            this.txtOgrtTc.Location = new System.Drawing.Point(130, 92);
            this.txtOgrtTc.Name = "txtOgrtTc";
            this.txtOgrtTc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOgrtTc.Properties.Appearance.Options.UseFont = true;
            this.txtOgrtTc.Size = new System.Drawing.Size(180, 24);
            this.txtOgrtTc.TabIndex = 37;
            // 
            // lblTlfNo
            // 
            this.lblTlfNo.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTlfNo.Appearance.Options.UseFont = true;
            this.lblTlfNo.Location = new System.Drawing.Point(20, 135);
            this.lblTlfNo.Name = "lblTlfNo";
            this.lblTlfNo.Size = new System.Drawing.Size(77, 20);
            this.lblTlfNo.TabIndex = 35;
            this.lblTlfNo.Text = "Telefon No :";
            // 
            // txtOgrtTel
            // 
            this.txtOgrtTel.Location = new System.Drawing.Point(130, 132);
            this.txtOgrtTel.Name = "txtOgrtTel";
            this.txtOgrtTel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOgrtTel.Properties.Appearance.Options.UseFont = true;
            this.txtOgrtTel.Size = new System.Drawing.Size(180, 24);
            this.txtOgrtTel.TabIndex = 38;
            // 
            // lblBrans
            // 
            this.lblBrans.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBrans.Appearance.Options.UseFont = true;
            this.lblBrans.Location = new System.Drawing.Point(20, 175);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(42, 20);
            this.lblBrans.TabIndex = 34;
            this.lblBrans.Text = "Branş :";
            // 
            // cmbBrans
            // 
            this.cmbBrans.Location = new System.Drawing.Point(130, 172);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBrans.Properties.Appearance.Options.UseFont = true;
            this.cmbBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBrans.Properties.Items.AddRange(new object[] {
            "Zihinsel Engelliler Öğretmeni",
            "Fizyoterapist",
            "Dil ve Konuşma Terapisti",
            "Psikolog / Rehberlik",
            "Ergoterapist",
            "Okul Öncesi"});
            this.cmbBrans.Size = new System.Drawing.Size(250, 24);
            this.cmbBrans.TabIndex = 39;
            // 
            // lblMail
            // 
            this.lblMail.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMail.Appearance.Options.UseFont = true;
            this.lblMail.Location = new System.Drawing.Point(20, 215);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(78, 20);
            this.lblMail.TabIndex = 43;
            this.lblMail.Text = "Mail Adresi :";
            // 
            // txtOgrtMail
            // 
            this.txtOgrtMail.Location = new System.Drawing.Point(130, 212);
            this.txtOgrtMail.Name = "txtOgrtMail";
            this.txtOgrtMail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOgrtMail.Properties.Appearance.Options.UseFont = true;
            this.txtOgrtMail.Size = new System.Drawing.Size(250, 24);
            this.txtOgrtMail.TabIndex = 44;
            // 
            // lblSifre
            // 
            this.lblSifre.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.Location = new System.Drawing.Point(20, 255);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(35, 20);
            this.lblSifre.TabIndex = 46;
            this.lblSifre.Text = "Şifre :";
            // 
            // txtOgrtSifre
            // 
            this.txtOgrtSifre.Location = new System.Drawing.Point(130, 252);
            this.txtOgrtSifre.Name = "txtOgrtSifre";
            this.txtOgrtSifre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOgrtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtOgrtSifre.Properties.PasswordChar = '*';
            this.txtOgrtSifre.Size = new System.Drawing.Size(180, 24);
            this.txtOgrtSifre.TabIndex = 47;
            // 
            // lblDersler
            // 
            this.lblDersler.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDersler.Appearance.Options.UseFont = true;
            this.lblDersler.Location = new System.Drawing.Point(20, 295);
            this.lblDersler.Name = "lblDersler";
            this.lblDersler.Size = new System.Drawing.Size(47, 20);
            this.lblDersler.TabIndex = 48;
            this.lblDersler.Text = "Dersler :";
            // 
            // listDersler
            // 
            this.listDersler.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listDersler.Appearance.Options.UseFont = true;
            this.listDersler.Location = new System.Drawing.Point(130, 292);
            this.listDersler.Name = "listDersler";
            this.listDersler.Size = new System.Drawing.Size(250, 100);
            this.listDersler.TabIndex = 45;
            // 
            // btnOgrtKaydet
            // 
            this.btnOgrtKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnOgrtKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOgrtKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnOgrtKaydet.Appearance.Options.UseBackColor = true;
            this.btnOgrtKaydet.Appearance.Options.UseFont = true;
            this.btnOgrtKaydet.Appearance.Options.UseForeColor = true;
            this.btnOgrtKaydet.Location = new System.Drawing.Point(20, 420);
            this.btnOgrtKaydet.Name = "btnOgrtKaydet";
            this.btnOgrtKaydet.Size = new System.Drawing.Size(120, 50);
            this.btnOgrtKaydet.TabIndex = 42;
            this.btnOgrtKaydet.Text = "💾 KAYDET";
            this.btnOgrtKaydet.Click += new System.EventHandler(this.btnOgrtKaydet_Click);
            // 
            // btnOgrtSil
            // 
            this.btnOgrtSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnOgrtSil.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOgrtSil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnOgrtSil.Appearance.Options.UseBackColor = true;
            this.btnOgrtSil.Appearance.Options.UseFont = true;
            this.btnOgrtSil.Appearance.Options.UseForeColor = true;
            this.btnOgrtSil.Location = new System.Drawing.Point(150, 420);
            this.btnOgrtSil.Name = "btnOgrtSil";
            this.btnOgrtSil.Size = new System.Drawing.Size(120, 50);
            this.btnOgrtSil.TabIndex = 41;
            this.btnOgrtSil.Text = "🗑️ SİL";
            this.btnOgrtSil.Click += new System.EventHandler(this.btnOgrtSil_Click);
            // 
            // btnOgrtTemizle
            // 
            this.btnOgrtTemizle.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOgrtTemizle.Appearance.Options.UseFont = true;
            this.btnOgrtTemizle.Location = new System.Drawing.Point(280, 420);
            this.btnOgrtTemizle.Name = "btnOgrtTemizle";
            this.btnOgrtTemizle.Size = new System.Drawing.Size(120, 50);
            this.btnOgrtTemizle.TabIndex = 40;
            this.btnOgrtTemizle.Text = "🔄 TEMİZLE";
            this.btnOgrtTemizle.Click += new System.EventHandler(this.btnOgrtTemizle_Click);
            // 
            // UcOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlOgretmen);
            this.Controls.Add(this.groupControl1);
            this.Name = "UcOgretmen";
            this.Size = new System.Drawing.Size(1512, 696);
            this.Load += new System.EventHandler(this.UcOgretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDersler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtAd.Properties)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlOgretmen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOgretmen;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl listDersler;
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
        private DevExpress.XtraEditors.TextEdit txtOgrtSifre;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.LabelControl lblDersler;
    }
}
