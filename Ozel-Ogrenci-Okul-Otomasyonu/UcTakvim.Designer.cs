using System;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class UcTakvim
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
            this.pnlUst = new DevExpress.XtraEditors.PanelControl();
            this.lblHaftaBilgi = new DevExpress.XtraEditors.LabelControl();
            this.btnIleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.dateTarih = new DevExpress.XtraEditors.DateEdit();
            this.gridControlTakvim = new DevExpress.XtraGrid.GridControl();
            this.gridViewTakvim = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTakvim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTakvim)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.lblHaftaBilgi);
            this.pnlUst.Controls.Add(this.btnIleri);
            this.pnlUst.Controls.Add(this.btnGeri);
            this.pnlUst.Controls.Add(this.dateTarih);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1213, 60);
            this.pnlUst.TabIndex = 0;
            // 
            // lblHaftaBilgi
            // 
            this.lblHaftaBilgi.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHaftaBilgi.Appearance.Options.UseFont = true;
            this.lblHaftaBilgi.Location = new System.Drawing.Point(400, 18);
            this.lblHaftaBilgi.Name = "lblHaftaBilgi";
            this.lblHaftaBilgi.Size = new System.Drawing.Size(0, 21);
            this.lblHaftaBilgi.TabIndex = 3;
            // 
            // btnIleri
            // 
            this.btnIleri.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIleri.Appearance.Options.UseFont = true;
            this.btnIleri.Location = new System.Drawing.Point(280, 15);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(100, 30);
            this.btnIleri.TabIndex = 2;
            this.btnIleri.Text = "Hafta İleri >";
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGeri.Appearance.Options.UseFont = true;
            this.btnGeri.Location = new System.Drawing.Point(20, 15);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 30);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "< Hafta Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dateTarih
            // 
            this.dateTarih.EditValue = null;
            this.dateTarih.Location = new System.Drawing.Point(130, 18);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTarih.Properties.Appearance.Options.UseFont = true;
            this.dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarih.Size = new System.Drawing.Size(140, 24);
            this.dateTarih.TabIndex = 0;
            this.dateTarih.EditValueChanged += new System.EventHandler(this.dateTarih_EditValueChanged);
            // 
            // gridControlTakvim
            // 
            this.gridControlTakvim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTakvim.Location = new System.Drawing.Point(0, 60);
            this.gridControlTakvim.MainView = this.gridViewTakvim;
            this.gridControlTakvim.Name = "gridControlTakvim";
            this.gridControlTakvim.Size = new System.Drawing.Size(1213, 554);
            this.gridControlTakvim.TabIndex = 1;
            this.gridControlTakvim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTakvim});
            // 
            // gridViewTakvim
            // 
            this.gridViewTakvim.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridViewTakvim.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewTakvim.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTakvim.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridViewTakvim.Appearance.Row.Options.UseFont = true;
            this.gridViewTakvim.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTakvim.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTakvim.GridControl = this.gridControlTakvim;
            this.gridViewTakvim.Name = "gridViewTakvim";
            this.gridViewTakvim.OptionsBehavior.Editable = false;
            this.gridViewTakvim.OptionsView.RowAutoHeight = true;
            this.gridViewTakvim.OptionsView.ShowGroupPanel = false;
            this.gridViewTakvim.RowHeight = 50;
            // 
            // UcTakvim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlTakvim);
            this.Controls.Add(this.pnlUst);
            this.Name = "UcTakvim";
            this.Size = new System.Drawing.Size(1213, 614);
            this.Load += new System.EventHandler(this.UcTakvim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTakvim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTakvim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlUst;
        private DevExpress.XtraEditors.SimpleButton btnIleri;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private DevExpress.XtraEditors.DateEdit dateTarih;
        private DevExpress.XtraEditors.LabelControl lblHaftaBilgi;
        private DevExpress.XtraGrid.GridControl gridControlTakvim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTakvim;
    }
}
