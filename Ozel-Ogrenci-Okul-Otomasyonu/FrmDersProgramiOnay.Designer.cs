namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class FrmDersProgramiOnay
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnReddet = new DevExpress.XtraEditors.SimpleButton();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelHeader.Controls.Add(this.lblBaslik);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(900, 60);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "📋 Yapay Zeka Ders Programı Önerisi";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelButtons.Controls.Add(this.btnReddet);
            this.panelButtons.Controls.Add(this.btnOnayla);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 530);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(900, 70);
            this.panelButtons.TabIndex = 2;
            // 
            // btnReddet
            // 
            this.btnReddet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnReddet.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReddet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnReddet.Appearance.Options.UseBackColor = true;
            this.btnReddet.Appearance.Options.UseFont = true;
            this.btnReddet.Appearance.Options.UseForeColor = true;
            this.btnReddet.Location = new System.Drawing.Point(480, 15);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(180, 40);
            this.btnReddet.TabIndex = 1;
            this.btnReddet.Text = "❌ Reddet";
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnOnayla.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOnayla.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Appearance.Options.UseBackColor = true;
            this.btnOnayla.Appearance.Options.UseFont = true;
            this.btnOnayla.Appearance.Options.UseForeColor = true;
            this.btnOnayla.Location = new System.Drawing.Point(240, 15);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(180, 40);
            this.btnOnayla.TabIndex = 0;
            this.btnOnayla.Text = "✅ Onayla ve Kaydet";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(900, 470);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmDersProgramiOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDersProgramiOnay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Programı Onayı";
            this.panelHeader.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelButtons;
        private DevExpress.XtraEditors.SimpleButton btnReddet;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
