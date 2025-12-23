namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class UcOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcOdeme));
            this.gridControlOdeme = new DevExpress.XtraGrid.GridControl();
            this.gridViewOdeme = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lueOgrenci = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.memAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.dateTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOgrenci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlOdeme
            // 
            this.gridControlOdeme.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControlOdeme.Location = new System.Drawing.Point(402, 0);
            this.gridControlOdeme.MainView = this.gridViewOdeme;
            this.gridControlOdeme.Name = "gridControlOdeme";
            this.gridControlOdeme.Size = new System.Drawing.Size(841, 648);
            this.gridControlOdeme.TabIndex = 0;
            this.gridControlOdeme.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOdeme});
            // 
            // gridViewOdeme
            // 
            this.gridViewOdeme.GridControl = this.gridControlOdeme;
            this.gridViewOdeme.Name = "gridViewOdeme";
            this.gridViewOdeme.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewOdeme_FocusedRowChanged);
            // 
            // lueOgrenci
            // 
            this.lueOgrenci.Location = new System.Drawing.Point(188, 86);
            this.lueOgrenci.Name = "lueOgrenci";
            this.lueOgrenci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOgrenci.Size = new System.Drawing.Size(100, 20);
            this.lueOgrenci.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.memAciklama);
            this.groupControl1.Controls.Add(this.dateTarih);
            this.groupControl1.Controls.Add(this.lueOgrenci);
            this.groupControl1.Controls.Add(this.txtTutar);
            this.groupControl1.Location = new System.Drawing.Point(12, 27);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 539);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 186);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 48;
            this.labelControl3.Text = "Odeme Tarihi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 47;
            this.labelControl2.Text = "Tutar";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "Ogrenci";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(22, 438);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 54);
            this.btnKaydet.TabIndex = 45;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(144, 438);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 54);
            this.btnSil.TabIndex = 44;
            this.btnSil.Text = "SIL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(254, 438);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(91, 54);
            this.btnTemizle.TabIndex = 43;
            this.btnTemizle.Text = "TEMIZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // memAciklama
            // 
            this.memAciklama.Location = new System.Drawing.Point(22, 255);
            this.memAciklama.Name = "memAciklama";
            this.memAciklama.Size = new System.Drawing.Size(323, 145);
            this.memAciklama.TabIndex = 2;
            // 
            // dateTarih
            // 
            this.dateTarih.EditValue = null;
            this.dateTarih.Location = new System.Drawing.Point(188, 183);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarih.Size = new System.Drawing.Size(100, 20);
            this.dateTarih.TabIndex = 1;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(188, 133);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 0;
            // 
            // UcOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlOdeme);
            this.Name = "UcOdeme";
            this.Size = new System.Drawing.Size(1243, 648);
            this.Load += new System.EventHandler(this.UcOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOgrenci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOdeme;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOdeme;
        private DevExpress.XtraEditors.LookUpEdit lueOgrenci;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit memAciklama;
        private DevExpress.XtraEditors.DateEdit dateTarih;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
