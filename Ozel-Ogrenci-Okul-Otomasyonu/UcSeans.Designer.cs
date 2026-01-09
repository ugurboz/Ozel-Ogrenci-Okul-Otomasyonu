namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class UcSeans
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
            this.components = new System.ComponentModel.Container();
            this.lueOgrenci = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.timeSaat = new DevExpress.XtraEditors.TimeEdit();
            this.dateTarih = new DevExpress.XtraEditors.DateEdit();
            this.lueOgretmen = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSaat = new DevExpress.XtraEditors.LabelControl();
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.lblOgretmen = new DevExpress.XtraEditors.LabelControl();
            this.lblOgrenci = new DevExpress.XtraEditors.LabelControl();
            this.gridControlSeans = new DevExpress.XtraGrid.GridControl();
            this.gridViewSeans = new DevExpress.XtraGrid.Views.Grid.GridView();

            ((System.ComponentModel.ISupportInitialize)(this.lueOgrenci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOgretmen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSeans)).BeginInit();

            this.SuspendLayout();
            // 
            // lueOgrenci
            // 
            this.lueOgrenci.Location = new System.Drawing.Point(130, 55);
            this.lueOgrenci.Name = "lueOgrenci";
            this.lueOgrenci.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lueOgrenci.Properties.Appearance.Options.UseFont = true;
            this.lueOgrenci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOgrenci.Properties.NullText = "Öğrenci Seçiniz...";
            this.lueOgrenci.Size = new System.Drawing.Size(250, 24);
            this.lueOgrenci.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.timeSaat);
            this.groupControl1.Controls.Add(this.dateTarih);
            this.groupControl1.Controls.Add(this.lueOgretmen);
            this.groupControl1.Controls.Add(this.lblSaat);
            this.groupControl1.Controls.Add(this.lblTarih);
            this.groupControl1.Controls.Add(this.lblOgretmen);
            this.groupControl1.Controls.Add(this.lblOgrenci);
            this.groupControl1.Controls.Add(this.lueOgrenci);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(420, 696);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "🎯 Seans İşlemleri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.Location = new System.Drawing.Point(20, 280);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 50);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "💾 KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnSil.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Appearance.Options.UseForeColor = true;
            this.btnSil.Location = new System.Drawing.Point(150, 280);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 50);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "🗑️ SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Location = new System.Drawing.Point(280, 280);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 50);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "🔄 TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // timeSaat
            // 
            this.timeSaat.EditValue = new System.DateTime(2025, 12, 19, 9, 0, 0, 0);
            this.timeSaat.Location = new System.Drawing.Point(130, 205);
            this.timeSaat.Name = "timeSaat";
            this.timeSaat.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.timeSaat.Properties.Appearance.Options.UseFont = true;
            this.timeSaat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeSaat.Size = new System.Drawing.Size(150, 24);
            this.timeSaat.TabIndex = 7;
            // 
            // dateTarih
            // 
            this.dateTarih.EditValue = null;
            this.dateTarih.Location = new System.Drawing.Point(130, 155);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTarih.Properties.Appearance.Options.UseFont = true;
            this.dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarih.Size = new System.Drawing.Size(180, 24);
            this.dateTarih.TabIndex = 6;
            // 
            // lueOgretmen
            // 
            this.lueOgretmen.Location = new System.Drawing.Point(130, 105);
            this.lueOgretmen.Name = "lueOgretmen";
            this.lueOgretmen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lueOgretmen.Properties.Appearance.Options.UseFont = true;
            this.lueOgretmen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOgretmen.Properties.NullText = "Öğretmen Seçiniz...";
            this.lueOgretmen.Size = new System.Drawing.Size(250, 24);
            this.lueOgretmen.TabIndex = 5;
            // 
            // lblSaat
            // 
            this.lblSaat.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSaat.Appearance.Options.UseFont = true;
            this.lblSaat.Location = new System.Drawing.Point(20, 208);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(33, 20);
            this.lblSaat.TabIndex = 4;
            this.lblSaat.Text = "Saat :";
            // 
            // lblTarih
            // 
            this.lblTarih.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTarih.Appearance.Options.UseFont = true;
            this.lblTarih.Location = new System.Drawing.Point(20, 158);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(36, 20);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "Tarih :";
            // 
            // lblOgretmen
            // 
            this.lblOgretmen.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOgretmen.Appearance.Options.UseFont = true;
            this.lblOgretmen.Location = new System.Drawing.Point(20, 108);
            this.lblOgretmen.Name = "lblOgretmen";
            this.lblOgretmen.Size = new System.Drawing.Size(68, 20);
            this.lblOgretmen.TabIndex = 2;
            this.lblOgretmen.Text = "Öğretmen :";
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOgrenci.Appearance.Options.UseFont = true;
            this.lblOgrenci.Location = new System.Drawing.Point(20, 58);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(55, 20);
            this.lblOgrenci.TabIndex = 1;
            this.lblOgrenci.Text = "Öğrenci :";
            // 
            // gridControlSeans
            // 
            this.gridControlSeans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSeans.Location = new System.Drawing.Point(420, 0);
            this.gridControlSeans.MainView = this.gridViewSeans;
            this.gridControlSeans.Name = "gridControlSeans";
            this.gridControlSeans.Size = new System.Drawing.Size(1092, 696);
            this.gridControlSeans.TabIndex = 2;
            this.gridControlSeans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSeans});
            // 
            // gridViewSeans
            // 
            this.gridViewSeans.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridViewSeans.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewSeans.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.gridViewSeans.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewSeans.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewSeans.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewSeans.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridViewSeans.Appearance.Row.Options.UseFont = true;
            this.gridViewSeans.GridControl = this.gridControlSeans;
            this.gridViewSeans.Name = "gridViewSeans";
            this.gridViewSeans.OptionsView.RowAutoHeight = true;
            this.gridViewSeans.OptionsView.ShowGroupPanel = false;
            this.gridViewSeans.RowHeight = 35;
            this.gridViewSeans.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewSeans_RowStyle);
            this.gridViewSeans.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSeans_FocusedRowChanged);

            // 
            // UcSeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlSeans);
            this.Controls.Add(this.groupControl1);
            this.Name = "UcSeans";
            this.Size = new System.Drawing.Size(1512, 696);
            this.Load += new System.EventHandler(this.UcSeans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueOgrenci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOgretmen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSeans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSeans)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueOgrenci;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlSeans;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSeans;
        private DevExpress.XtraEditors.LabelControl lblSaat;
        private DevExpress.XtraEditors.LabelControl lblTarih;
        private DevExpress.XtraEditors.LabelControl lblOgretmen;
        private DevExpress.XtraEditors.LabelControl lblOgrenci;
        private DevExpress.XtraEditors.TimeEdit timeSaat;
        private DevExpress.XtraEditors.DateEdit dateTarih;
        private DevExpress.XtraEditors.LookUpEdit lueOgretmen;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;

    }
}
