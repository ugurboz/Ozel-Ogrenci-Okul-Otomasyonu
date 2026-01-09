
namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class FrmGiris
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
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblSubtitle = new DevExpress.XtraEditors.LabelControl();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.chkYonetici = new DevExpress.XtraEditors.CheckEdit();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.lblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.lblKullanici = new DevExpress.XtraEditors.LabelControl();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();

            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkYonetici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlMain
            // 
            this.pnlMain.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.pnlMain.Appearance.Options.UseBackColor = true;
            this.pnlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMain.Controls.Add(this.lblSifre);
            this.pnlMain.Controls.Add(this.lblKullanici);
            this.pnlMain.Controls.Add(this.picLogo);
            this.pnlMain.Controls.Add(this.lblSifremiUnuttum);
            this.pnlMain.Controls.Add(this.btnGiris);
            this.pnlMain.Controls.Add(this.chkYonetici);
            this.pnlMain.Controls.Add(this.txtSifre);
            this.pnlMain.Controls.Add(this.txtKullanici);
            this.pnlMain.Controls.Add(this.lblSubtitle);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(400, 500);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGiris_MouseDown);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmGiris_MouseMove);
            this.pnlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmGiris_MouseUp);

            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btnClose.AppearanceHovered.Options.UseBackColor = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(360, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 99;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Location = new System.Drawing.Point(0, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "İLGİ ÖZEL EĞİTİM";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblSubtitle.Appearance.Options.UseFont = true;
            this.lblSubtitle.Appearance.Options.UseForeColor = true;
            this.lblSubtitle.Appearance.Options.UseTextOptions = true;
            this.lblSubtitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSubtitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 95);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(400, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Özel Eğitim ve Rehabilitasyon Merkezi";

            // 
            // lblKullanici
            // 
            this.lblKullanici.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKullanici.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblKullanici.Appearance.Options.UseFont = true;
            this.lblKullanici.Appearance.Options.UseForeColor = true;
            this.lblKullanici.Location = new System.Drawing.Point(50, 160);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(127, 17);
            this.lblKullanici.TabIndex = 6;
            this.lblKullanici.Text = "Kullanıcı Adı / TC No";

            // 
            // txtKullanici
            // 
            this.txtKullanici.EditValue = "";
            this.txtKullanici.Location = new System.Drawing.Point(50, 185);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtKullanici.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKullanici.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtKullanici.Properties.Appearance.Options.UseBackColor = true;
            this.txtKullanici.Properties.Appearance.Options.UseFont = true;
            this.txtKullanici.Properties.Appearance.Options.UseForeColor = true;
            this.txtKullanici.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtKullanici.Properties.AutoHeight = false;
            this.txtKullanici.Size = new System.Drawing.Size(300, 35);
            this.txtKullanici.TabIndex = 0;

            // 
            // lblSifre
            // 
            this.lblSifre.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSifre.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.Appearance.Options.UseForeColor = true;
            this.lblSifre.Location = new System.Drawing.Point(50, 230);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(29, 17);
            this.lblSifre.TabIndex = 7;
            this.lblSifre.Text = "Şifre";

            // 
            // txtSifre
            // 
            this.txtSifre.EditValue = "";
            this.txtSifre.Location = new System.Drawing.Point(50, 255);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSifre.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtSifre.Properties.Appearance.Options.UseBackColor = true;
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.Appearance.Options.UseForeColor = true;
            this.txtSifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSifre.Properties.PasswordChar = '●';
            this.txtSifre.Properties.AutoHeight = false;
            this.txtSifre.Size = new System.Drawing.Size(300, 35);
            this.txtSifre.TabIndex = 1;

            // 
            // chkYonetici
            // 
            this.chkYonetici.Location = new System.Drawing.Point(50, 310);
            this.chkYonetici.Name = "chkYonetici";
            this.chkYonetici.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkYonetici.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.chkYonetici.Properties.Appearance.Options.UseFont = true;
            this.chkYonetici.Properties.Appearance.Options.UseForeColor = true;
            this.chkYonetici.Properties.Caption = "Yönetici olarak giriş";
            this.chkYonetici.Size = new System.Drawing.Size(150, 22);
            this.chkYonetici.TabIndex = 2;

            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Appearance.Options.UseBackColor = true;
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnGiris.AppearanceHovered.Options.UseBackColor = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Location = new System.Drawing.Point(50, 360);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(300, 50);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);

            // 
            // lblSifremiUnuttum
            // 
            this.lblSifremiUnuttum.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.lblSifremiUnuttum.AutoSize = true;
            this.lblSifremiUnuttum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSifremiUnuttum.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblSifremiUnuttum.Location = new System.Drawing.Point(255, 430);
            this.lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            this.lblSifremiUnuttum.Size = new System.Drawing.Size(95, 15);
            this.lblSifremiUnuttum.TabIndex = 4;
            this.lblSifremiUnuttum.TabStop = true;
            this.lblSifremiUnuttum.Text = "Şifremi unuttum";
            this.lblSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSifremiUnuttum_LinkClicked);

            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogo.Size = new System.Drawing.Size(0, 0); // Görünmez (placeholder)
            this.picLogo.TabIndex = 5;
            this.picLogo.Visible = false;

            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlgi Özel Eğitim - Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkYonetici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.LabelControl lblSubtitle;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.CheckEdit chkYonetici;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private System.Windows.Forms.LinkLabel lblSifremiUnuttum;
        private DevExpress.XtraEditors.PictureEdit picLogo;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.LabelControl lblKullanici;
    }
}