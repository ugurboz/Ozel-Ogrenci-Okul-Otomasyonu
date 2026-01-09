namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class UcGelisim
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.trackDil = new DevExpress.XtraEditors.TrackBarControl();
            this.lblDil = new DevExpress.XtraEditors.LabelControl();
            this.trackSosyal = new DevExpress.XtraEditors.TrackBarControl();
            this.lblSosyal = new DevExpress.XtraEditors.LabelControl();
            this.trackZihinsel = new DevExpress.XtraEditors.TrackBarControl();
            this.lblZihinsel = new DevExpress.XtraEditors.LabelControl();
            this.trackFiziksel = new DevExpress.XtraEditors.TrackBarControl();
            this.lblFiziksel = new DevExpress.XtraEditors.LabelControl();
            this.trackGenel = new DevExpress.XtraEditors.TrackBarControl();
            this.lblGenel = new DevExpress.XtraEditors.LabelControl();
            this.memAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            this.txtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.dateRapor = new DevExpress.XtraEditors.DateEdit();
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.lueOgrenci = new DevExpress.XtraEditors.LookUpEdit();
            this.lblOgrenci = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPdfAktar = new DevExpress.XtraEditors.SimpleButton();
            this.panelGraph = new DevExpress.XtraEditors.PanelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gridControlGelisim = new DevExpress.XtraGrid.GridControl();
            this.gridViewGelisim = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSosyal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSosyal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZihinsel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZihinsel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFiziksel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFiziksel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGenel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGenel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRapor.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRapor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOgrenci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelGraph)).BeginInit();
            this.panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGelisim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGelisim)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(420, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.panelGraph);
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlGelisim);
            this.splitContainerControl1.Size = new System.Drawing.Size(1092, 696);
            this.splitContainerControl1.SplitterPosition = 300;
            // 
            // panelGraph
            // 
            this.panelGraph.Controls.Add(this.chartControl1);
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(0, 0);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(1092, 300);
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(2, 2);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(1088, 296);
            // 
            // gridControlGelisim
            // 
            this.gridControlGelisim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGelisim.MainView = this.gridViewGelisim;
            this.gridControlGelisim.Name = "gridControlGelisim";
            this.gridControlGelisim.Size = new System.Drawing.Size(1092, 386);
            this.gridControlGelisim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.gridViewGelisim });
            // 
            // gridViewGelisim
            // 
            this.gridViewGelisim.GridControl = this.gridControlGelisim;
            this.gridViewGelisim.Name = "gridViewGelisim";
            this.gridViewGelisim.OptionsView.ShowGroupPanel = false;
            this.gridViewGelisim.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewGelisim_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.trackDil);
            this.groupControl1.Controls.Add(this.lblDil);
            this.groupControl1.Controls.Add(this.trackSosyal);
            this.groupControl1.Controls.Add(this.lblSosyal);
            this.groupControl1.Controls.Add(this.trackZihinsel);
            this.groupControl1.Controls.Add(this.lblZihinsel);
            this.groupControl1.Controls.Add(this.trackFiziksel);
            this.groupControl1.Controls.Add(this.lblFiziksel);
            this.groupControl1.Controls.Add(this.trackGenel);
            this.groupControl1.Controls.Add(this.lblGenel);
            this.groupControl1.Controls.Add(this.memAciklama);
            this.groupControl1.Controls.Add(this.lblAciklama);
            this.groupControl1.Controls.Add(this.txtBaslik);
            this.groupControl1.Controls.Add(this.lblBaslik);
            this.groupControl1.Controls.Add(this.dateRapor);
            this.groupControl1.Controls.Add(this.lblTarih);
            this.groupControl1.Controls.Add(this.lueOgrenci);
            this.groupControl1.Controls.Add(this.lblOgrenci);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.btnPdfAktar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(420, 696);
            this.groupControl1.Text = "Gelişim Takibi";
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.Location = new System.Drawing.Point(20, 45);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(50, 13);
            this.lblOgrenci.Text = "Öğrenci :";
            // 
            // lueOgrenci
            // 
            this.lueOgrenci.Location = new System.Drawing.Point(130, 42);
            this.lueOgrenci.Name = "lueOgrenci";
            this.lueOgrenci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOgrenci.Size = new System.Drawing.Size(200, 20);
            this.lueOgrenci.EditValueChanged += new System.EventHandler(this.lueOgrenci_EditValueChanged);
            // 
            // lblTarih
            // 
            this.lblTarih.Location = new System.Drawing.Point(20, 75);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(30, 13);
            this.lblTarih.Text = "Tarih :";
            // 
            // dateRapor
            // 
            this.dateRapor.EditValue = null;
            this.dateRapor.Location = new System.Drawing.Point(130, 72);
            this.dateRapor.Name = "dateRapor";
            this.dateRapor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRapor.Size = new System.Drawing.Size(150, 20);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Location = new System.Drawing.Point(20, 105);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(35, 13);
            this.lblBaslik.Text = "Başlık :";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(130, 102);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(270, 20);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Location = new System.Drawing.Point(20, 135);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.Text = "Açıklama :";
            // 
            // memAciklama
            // 
            this.memAciklama.Location = new System.Drawing.Point(130, 132);
            this.memAciklama.Name = "memAciklama";
            this.memAciklama.Size = new System.Drawing.Size(270, 70);
            // 
            // lblGenel
            // 
            this.lblGenel.Location = new System.Drawing.Point(20, 220);
            this.lblGenel.Name = "lblGenel";
            this.lblGenel.Size = new System.Drawing.Size(75, 13);
            this.lblGenel.Text = "Genel Durum :";
            // 
            // trackGenel
            // 
            this.trackGenel.EditValue = 5;
            this.trackGenel.Location = new System.Drawing.Point(130, 215);
            this.trackGenel.Name = "trackGenel";
            this.trackGenel.Properties.Maximum = 10;
            this.trackGenel.Properties.Minimum = 1;
            this.trackGenel.Size = new System.Drawing.Size(200, 45);
            this.trackGenel.Value = 5;
            // 
            // lblFiziksel
            // 
            this.lblFiziksel.Location = new System.Drawing.Point(20, 270);
            this.lblFiziksel.Name = "lblFiziksel";
            this.lblFiziksel.Size = new System.Drawing.Size(90, 13);
            this.lblFiziksel.Text = "Fiziksel Gelişim :";
            // 
            // trackFiziksel
            // 
            this.trackFiziksel.EditValue = 5;
            this.trackFiziksel.Location = new System.Drawing.Point(130, 265);
            this.trackFiziksel.Name = "trackFiziksel";
            this.trackFiziksel.Properties.Maximum = 10;
            this.trackFiziksel.Properties.Minimum = 1;
            this.trackFiziksel.Size = new System.Drawing.Size(200, 45);
            this.trackFiziksel.Value = 5;
            // 
            // lblZihinsel
            // 
            this.lblZihinsel.Location = new System.Drawing.Point(20, 320);
            this.lblZihinsel.Name = "lblZihinsel";
            this.lblZihinsel.Size = new System.Drawing.Size(90, 13);
            this.lblZihinsel.Text = "Zihinsel Gelişim :";
            // 
            // trackZihinsel
            // 
            this.trackZihinsel.EditValue = 5;
            this.trackZihinsel.Location = new System.Drawing.Point(130, 315);
            this.trackZihinsel.Name = "trackZihinsel";
            this.trackZihinsel.Properties.Maximum = 10;
            this.trackZihinsel.Properties.Minimum = 1;
            this.trackZihinsel.Size = new System.Drawing.Size(200, 45);
            this.trackZihinsel.Value = 5;
            // 
            // lblSosyal
            // 
            this.lblSosyal.Location = new System.Drawing.Point(20, 370);
            this.lblSosyal.Name = "lblSosyal";
            this.lblSosyal.Size = new System.Drawing.Size(85, 13);
            this.lblSosyal.Text = "Sosyal Gelişim :";
            // 
            // trackSosyal
            // 
            this.trackSosyal.EditValue = 5;
            this.trackSosyal.Location = new System.Drawing.Point(130, 365);
            this.trackSosyal.Name = "trackSosyal";
            this.trackSosyal.Properties.Maximum = 10;
            this.trackSosyal.Properties.Minimum = 1;
            this.trackSosyal.Size = new System.Drawing.Size(200, 45);
            this.trackSosyal.Value = 5;
            // 
            // lblDil
            // 
            this.lblDil.Location = new System.Drawing.Point(20, 420);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(65, 13);
            this.lblDil.Text = "Dil Gelişimi :";
            // 
            // trackDil
            // 
            this.trackDil.EditValue = 5;
            this.trackDil.Location = new System.Drawing.Point(130, 415);
            this.trackDil.Name = "trackDil";
            this.trackDil.Properties.Maximum = 10;
            this.trackDil.Properties.Minimum = 1;
            this.trackDil.Size = new System.Drawing.Size(200, 45);
            this.trackDil.Value = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.Location = new System.Drawing.Point(20, 480);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 45);
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseForeColor = true;
            this.btnSil.Location = new System.Drawing.Point(150, 480);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 45);
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(280, 480);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 45);
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnPdfAktar
            // 
            this.btnPdfAktar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPdfAktar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnPdfAktar.Appearance.Options.UseBackColor = true;
            this.btnPdfAktar.Appearance.Options.UseForeColor = true;
            this.btnPdfAktar.Location = new System.Drawing.Point(20, 540);
            this.btnPdfAktar.Name = "btnPdfAktar";
            this.btnPdfAktar.Size = new System.Drawing.Size(380, 45);
            this.btnPdfAktar.Text = "PDF'YE AKTAR";
            this.btnPdfAktar.Click += new System.EventHandler(this.btnPdfAktar_Click);
            // 
            // UcGelisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "UcGelisim";
            this.Size = new System.Drawing.Size(1512, 696);
            this.Load += new System.EventHandler(this.UcGelisim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSosyal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSosyal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZihinsel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZihinsel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFiziksel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFiziksel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGenel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGenel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRapor.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRapor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOgrenci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelGraph)).EndInit();
            this.panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGelisim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGelisim)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelGraph;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraGrid.GridControl gridControlGelisim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGelisim;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lueOgrenci;
        private DevExpress.XtraEditors.LabelControl lblOgrenci;
        private DevExpress.XtraEditors.DateEdit dateRapor;
        private DevExpress.XtraEditors.LabelControl lblTarih;
        private DevExpress.XtraEditors.TextEdit txtBaslik;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.MemoEdit memAciklama;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private DevExpress.XtraEditors.TrackBarControl trackGenel;
        private DevExpress.XtraEditors.LabelControl lblGenel;
        private DevExpress.XtraEditors.TrackBarControl trackFiziksel;
        private DevExpress.XtraEditors.LabelControl lblFiziksel;
        private DevExpress.XtraEditors.TrackBarControl trackZihinsel;
        private DevExpress.XtraEditors.LabelControl lblZihinsel;
        private DevExpress.XtraEditors.TrackBarControl trackSosyal;
        private DevExpress.XtraEditors.LabelControl lblSosyal;
        private DevExpress.XtraEditors.TrackBarControl trackDil;
        private DevExpress.XtraEditors.LabelControl lblDil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnPdfAktar;
    }
}
