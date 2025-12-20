namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class FrmSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifremiUnuttum));
            this.txtTc = new DevExpress.XtraEditors.TextEdit();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(63, 65);
            this.txtTc.Name = "txtTc";
            this.txtTc.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtTc.Properties.ContextImageOptions.Image")));
            this.txtTc.Properties.MaxLength = 11;
            this.txtTc.Properties.NullText = "TC Kimlik Numaranizi Giriniz :";
            this.txtTc.Size = new System.Drawing.Size(183, 36);
            this.txtTc.TabIndex = 0;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(63, 116);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtMail.Properties.ContextImageOptions.Image")));
            this.txtMail.Properties.NullText = "Mail Adresinizi Giriniz :";
            this.txtMail.Size = new System.Drawing.Size(183, 36);
            this.txtMail.TabIndex = 1;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.Location = new System.Drawing.Point(76, 175);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(154, 42);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "Kod Gonder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 291);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTc);
            this.Name = "FrmSifremiUnuttum";
            this.Text = "FrmSifremiUnuttum";
            this.Load += new System.EventHandler(this.FrmSifremiUnuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTc;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
    }
}