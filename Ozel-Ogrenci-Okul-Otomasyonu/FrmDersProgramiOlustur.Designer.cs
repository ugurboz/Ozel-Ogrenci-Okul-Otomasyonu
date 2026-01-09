namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class FrmDersProgramiOlustur
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.groupTarih = new DevExpress.XtraEditors.GroupControl();
            this.lblBitis = new DevExpress.XtraEditors.LabelControl();
            this.lblBaslangic = new DevExpress.XtraEditors.LabelControl();
            this.dateBitis = new DevExpress.XtraEditors.DateEdit();
            this.dateBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.groupOgrenciler = new DevExpress.XtraEditors.GroupControl();
            this.chkListOgrenciler = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.groupOgretmenler = new DevExpress.XtraEditors.GroupControl();
            this.chkListOgretmenler = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTarih)).BeginInit();
            this.groupTarih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOgrenciler)).BeginInit();
            this.groupOgrenciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkListOgrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOgretmenler)).BeginInit();
            this.groupOgretmenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkListOgretmenler)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelHeader.Controls.Add(this.lblBaslik);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(600, 50);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "📅 Ders Programı Oluştur";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupTarih
            // 
            this.groupTarih.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupTarih.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.groupTarih.AppearanceCaption.Options.UseFont = true;
            this.groupTarih.AppearanceCaption.Options.UseForeColor = true;
            this.groupTarih.Controls.Add(this.lblBitis);
            this.groupTarih.Controls.Add(this.lblBaslangic);
            this.groupTarih.Controls.Add(this.dateBitis);
            this.groupTarih.Controls.Add(this.dateBaslangic);
            this.groupTarih.Location = new System.Drawing.Point(12, 60);
            this.groupTarih.Name = "groupTarih";
            this.groupTarih.Size = new System.Drawing.Size(576, 80);
            this.groupTarih.TabIndex = 1;
            this.groupTarih.Text = "Tarih Aralığı";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblBaslangic.Location = new System.Drawing.Point(20, 40);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(60, 16);
            this.lblBaslangic.TabIndex = 0;
            this.lblBaslangic.Text = "Başlangıç:";
            // 
            // lblBitis
            // 
            this.lblBitis.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblBitis.Location = new System.Drawing.Point(300, 40);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(30, 16);
            this.lblBitis.TabIndex = 1;
            this.lblBitis.Text = "Bitiş:";
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.EditValue = null;
            this.dateBaslangic.Location = new System.Drawing.Point(90, 35);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslangic.Size = new System.Drawing.Size(150, 22);
            this.dateBaslangic.TabIndex = 2;
            // 
            // dateBitis
            // 
            this.dateBitis.EditValue = null;
            this.dateBitis.Location = new System.Drawing.Point(350, 35);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBitis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBitis.Size = new System.Drawing.Size(150, 22);
            this.dateBitis.TabIndex = 3;
            // 
            // groupOgrenciler
            // 
            this.groupOgrenciler.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupOgrenciler.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.groupOgrenciler.AppearanceCaption.Options.UseFont = true;
            this.groupOgrenciler.AppearanceCaption.Options.UseForeColor = true;
            this.groupOgrenciler.Controls.Add(this.chkListOgrenciler);
            this.groupOgrenciler.Location = new System.Drawing.Point(12, 150);
            this.groupOgrenciler.Name = "groupOgrenciler";
            this.groupOgrenciler.Size = new System.Drawing.Size(280, 200);
            this.groupOgrenciler.TabIndex = 2;
            this.groupOgrenciler.Text = "Öğrenciler";
            // 
            // chkListOgrenciler
            // 
            this.chkListOgrenciler.CheckOnClick = true;
            this.chkListOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListOgrenciler.Location = new System.Drawing.Point(2, 23);
            this.chkListOgrenciler.Name = "chkListOgrenciler";
            this.chkListOgrenciler.Size = new System.Drawing.Size(276, 175);
            this.chkListOgrenciler.TabIndex = 0;
            // 
            // groupOgretmenler
            // 
            this.groupOgretmenler.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupOgretmenler.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.groupOgretmenler.AppearanceCaption.Options.UseFont = true;
            this.groupOgretmenler.AppearanceCaption.Options.UseForeColor = true;
            this.groupOgretmenler.Controls.Add(this.chkListOgretmenler);
            this.groupOgretmenler.Location = new System.Drawing.Point(308, 150);
            this.groupOgretmenler.Name = "groupOgretmenler";
            this.groupOgretmenler.Size = new System.Drawing.Size(280, 200);
            this.groupOgretmenler.TabIndex = 3;
            this.groupOgretmenler.Text = "Öğretmenler";
            // 
            // chkListOgretmenler
            // 
            this.chkListOgretmenler.CheckOnClick = true;
            this.chkListOgretmenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListOgretmenler.Location = new System.Drawing.Point(2, 23);
            this.chkListOgretmenler.Name = "chkListOgretmenler";
            this.chkListOgretmenler.Size = new System.Drawing.Size(276, 175);
            this.chkListOgretmenler.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelButtons.Controls.Add(this.btnIptal);
            this.panelButtons.Controls.Add(this.btnOlustur);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 365);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(600, 60);
            this.panelButtons.TabIndex = 4;
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.BackColor = System.Drawing.Color.Gray;
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Appearance.Options.UseBackColor = true;
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.Appearance.Options.UseForeColor = true;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Location = new System.Drawing.Point(320, 12);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(130, 36);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnOlustur.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOlustur.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnOlustur.Appearance.Options.UseBackColor = true;
            this.btnOlustur.Appearance.Options.UseFont = true;
            this.btnOlustur.Appearance.Options.UseForeColor = true;
            this.btnOlustur.Location = new System.Drawing.Point(150, 12);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(150, 36);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "🤖 Oluştur";
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // FrmDersProgramiOlustur
            // 
            this.AcceptButton = this.btnOlustur;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(600, 425);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.groupOgretmenler);
            this.Controls.Add(this.groupOgrenciler);
            this.Controls.Add(this.groupTarih);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDersProgramiOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ders Programı Oluştur";
            this.Load += new System.EventHandler(this.FrmDersProgramiOlustur_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupTarih)).EndInit();
            this.groupTarih.ResumeLayout(false);
            this.groupTarih.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOgrenciler)).EndInit();
            this.groupOgrenciler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkListOgrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOgretmenler)).EndInit();
            this.groupOgretmenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkListOgretmenler)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupTarih;
        private DevExpress.XtraEditors.LabelControl lblBitis;
        private DevExpress.XtraEditors.LabelControl lblBaslangic;
        private DevExpress.XtraEditors.DateEdit dateBitis;
        private DevExpress.XtraEditors.DateEdit dateBaslangic;
        private DevExpress.XtraEditors.GroupControl groupOgrenciler;
        private DevExpress.XtraEditors.CheckedListBoxControl chkListOgrenciler;
        private DevExpress.XtraEditors.GroupControl groupOgretmenler;
        private DevExpress.XtraEditors.CheckedListBoxControl chkListOgretmenler;
        private System.Windows.Forms.Panel panelButtons;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.SimpleButton btnOlustur;
    }
}
