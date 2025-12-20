namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.tglGirisTuru = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.lblSifremiUnuttum = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglGirisTuru.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(102, 84);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKullanici.Properties.ContextImageOptions.Image")));
            this.txtKullanici.Properties.NullText = "Kullanıcı Adı veya TC Kimlik";
            this.txtKullanici.Size = new System.Drawing.Size(208, 36);
            this.txtKullanici.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(102, 142);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSifre.Properties.ContextImageOptions.Image")));
            this.txtSifre.Properties.NullText = "Şifre";
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(208, 36);
            this.txtSifre.TabIndex = 1;
            // 
            // tglGirisTuru
            // 
            this.tglGirisTuru.Location = new System.Drawing.Point(102, 200);
            this.tglGirisTuru.Name = "tglGirisTuru";
            this.tglGirisTuru.Properties.OffText = "Öğretmen";
            this.tglGirisTuru.Properties.OnText = "Yönetici";
            this.tglGirisTuru.Size = new System.Drawing.Size(104, 18);
            this.tglGirisTuru.TabIndex = 2;
            // 
            // btnGiris
            // 
            this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
            this.btnGiris.Location = new System.Drawing.Point(102, 247);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(208, 35);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "GIRIS";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblSifremiUnuttum
            // 
            this.lblSifremiUnuttum.Location = new System.Drawing.Point(234, 202);
            this.lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            this.lblSifremiUnuttum.Size = new System.Drawing.Size(76, 13);
            this.lblSifremiUnuttum.TabIndex = 4;
            this.lblSifremiUnuttum.Text = "Sifremi Unuttum";
            this.lblSifremiUnuttum.Click += new System.EventHandler(this.lblSifremiUnuttum_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 388);
            this.Controls.Add(this.lblSifremiUnuttum);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tglGirisTuru);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglGirisTuru.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.ToggleSwitch tglGirisTuru;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblSifremiUnuttum;
    }
}