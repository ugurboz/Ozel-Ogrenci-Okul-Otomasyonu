
namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class FrmSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifremiUnuttum));
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.txtTc = new DevExpress.XtraEditors.TextEdit();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlMain
            // 
            this.pnlMain.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.pnlMain.Appearance.Options.UseBackColor = true;
            this.pnlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMain.Controls.Add(this.labelControl2);
            this.pnlMain.Controls.Add(this.labelControl1);
            this.pnlMain.Controls.Add(this.btnGonder);
            this.pnlMain.Controls.Add(this.txtMail);
            this.pnlMain.Controls.Add(this.txtTc);
            this.pnlMain.Controls.Add(this.lblBaslik);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(400, 350);
            this.pnlMain.TabIndex = 0;

            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.Location = new System.Drawing.Point(0, 30);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(400, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Şifre Kurtarma";

            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "TC Kimlik:";

            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(50, 108);
            this.txtTc.Name = "txtTc";
            this.txtTc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTc.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtTc.Properties.Appearance.Options.UseBackColor = true;
            this.txtTc.Properties.Appearance.Options.UseFont = true;
            this.txtTc.Properties.Appearance.Options.UseForeColor = true;
            this.txtTc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtTc.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtTc.Properties.ContextImageOptions.Image")));
            this.txtTc.Properties.MaxLength = 11;
            this.txtTc.Properties.NullText = "TC Kimlik Numaranızı Giriniz";
            this.txtTc.Properties.AutoHeight = false;
            this.txtTc.Size = new System.Drawing.Size(300, 35);
            this.txtTc.TabIndex = 1;

            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(50, 160);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 17);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mail Adresi:";

            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(50, 183);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMail.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMail.Properties.Appearance.Options.UseBackColor = true;
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Properties.Appearance.Options.UseForeColor = true;
            this.txtMail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMail.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtMail.Properties.ContextImageOptions.Image")));
            this.txtMail.Properties.NullText = "Mail Adresinizi Giriniz";
            this.txtMail.Properties.AutoHeight = false;
            this.txtMail.Size = new System.Drawing.Size(300, 35);
            this.txtMail.TabIndex = 2;

            // 
            // btnGonder
            // 
            this.btnGonder.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnGonder.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGonder.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGonder.Appearance.Options.UseBackColor = true;
            this.btnGonder.Appearance.Options.UseFont = true;
            this.btnGonder.Appearance.Options.UseForeColor = true;
            this.btnGonder.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnGonder.AppearanceHovered.Options.UseBackColor = true;
            this.btnGonder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGonder.Location = new System.Drawing.Point(50, 250);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(300, 45);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "KOD GÖNDER";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);

            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.Load += new System.EventHandler(this.FrmSifremiUnuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.TextEdit txtTc;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}