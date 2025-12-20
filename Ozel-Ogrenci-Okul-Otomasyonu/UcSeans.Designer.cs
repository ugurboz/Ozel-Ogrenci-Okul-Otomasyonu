namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class UcSeans
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSeans));
            this.lueOgrenci = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.timeSaat = new DevExpress.XtraEditors.TimeEdit();
            this.dateTarih = new DevExpress.XtraEditors.DateEdit();
            this.lueOgretmen = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlSeans = new DevExpress.XtraGrid.GridControl();
            this.gridViewSeans = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmsSeans = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öğrenciGeldiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelmediİptalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.lueOgrenci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOgretmen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSeans)).BeginInit();
            this.cmsSeans.SuspendLayout();
            this.SuspendLayout();
            // 
            // lueOgrenci
            // 
            this.lueOgrenci.Location = new System.Drawing.Point(97, 68);
            this.lueOgrenci.Name = "lueOgrenci";
            this.lueOgrenci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOgrenci.Size = new System.Drawing.Size(100, 20);
            this.lueOgrenci.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.timeSaat);
            this.groupControl1.Controls.Add(this.dateTarih);
            this.groupControl1.Controls.Add(this.lueOgretmen);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.lueOgrenci);
            this.groupControl1.Location = new System.Drawing.Point(26, 39);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(361, 387);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(17, 276);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 54);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(139, 276);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 54);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "SIL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(249, 276);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(91, 54);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "TEMIZLE";
            // 
            // timeSaat
            // 
            this.timeSaat.EditValue = new System.DateTime(2025, 12, 19, 0, 0, 0, 0);
            this.timeSaat.Location = new System.Drawing.Point(97, 210);
            this.timeSaat.Name = "timeSaat";
            this.timeSaat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeSaat.Size = new System.Drawing.Size(100, 20);
            this.timeSaat.TabIndex = 7;
            // 
            // dateTarih
            // 
            this.dateTarih.EditValue = null;
            this.dateTarih.Location = new System.Drawing.Point(97, 161);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarih.Size = new System.Drawing.Size(100, 20);
            this.dateTarih.TabIndex = 6;
            // 
            // lueOgretmen
            // 
            this.lueOgretmen.Location = new System.Drawing.Point(97, 118);
            this.lueOgretmen.Name = "lueOgretmen";
            this.lueOgretmen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOgretmen.Size = new System.Drawing.Size(100, 20);
            this.lueOgretmen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ogretmen :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ogrenci :";
            // 
            // gridControlSeans
            // 
            this.gridControlSeans.Location = new System.Drawing.Point(585, 0);
            this.gridControlSeans.MainView = this.gridViewSeans;
            this.gridControlSeans.Name = "gridControlSeans";
            this.gridControlSeans.Size = new System.Drawing.Size(792, 676);
            this.gridControlSeans.TabIndex = 2;
            this.gridControlSeans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSeans});
            // 
            // gridViewSeans
            // 
            this.gridViewSeans.GridControl = this.gridControlSeans;
            this.gridViewSeans.Name = "gridViewSeans";
            this.gridViewSeans.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewSeans_RowStyle);
            // 
            // cmsSeans
            // 
            this.cmsSeans.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciGeldiToolStripMenuItem,
            this.gelmediİptalToolStripMenuItem1});
            this.cmsSeans.Name = "cmsSeans";
            this.cmsSeans.Size = new System.Drawing.Size(168, 48);
            // 
            // öğrenciGeldiToolStripMenuItem
            // 
            this.öğrenciGeldiToolStripMenuItem.Name = "öğrenciGeldiToolStripMenuItem";
            this.öğrenciGeldiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.öğrenciGeldiToolStripMenuItem.Text = "🟢 Öğrenci Geldi";
            this.öğrenciGeldiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciGeldiToolStripMenuItem_Click);
            // 
            // gelmediİptalToolStripMenuItem1
            // 
            this.gelmediİptalToolStripMenuItem1.Name = "gelmediİptalToolStripMenuItem1";
            this.gelmediİptalToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.gelmediİptalToolStripMenuItem1.Text = "🔴 Gelmedi / İptal";
            this.gelmediİptalToolStripMenuItem1.Click += new System.EventHandler(this.gelmediİptalToolStripMenuItem1_Click);
            // 
            // UcSeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlSeans);
            this.Controls.Add(this.groupControl1);
            this.Name = "UcSeans";
            this.Size = new System.Drawing.Size(1447, 679);
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
            this.cmsSeans.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueOgrenci;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlSeans;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSeans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TimeEdit timeSaat;
        private DevExpress.XtraEditors.DateEdit dateTarih;
        private DevExpress.XtraEditors.LookUpEdit lueOgretmen;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private System.Windows.Forms.ContextMenuStrip cmsSeans;
        private System.Windows.Forms.ToolStripMenuItem öğrenciGeldiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelmediİptalToolStripMenuItem1;
    }
}
