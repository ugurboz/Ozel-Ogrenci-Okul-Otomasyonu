namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    partial class FormAddStudent
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
            this.addname = new DevExpress.XtraEditors.LabelControl();
            this.txtadsoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.tcno = new DevExpress.XtraEditors.TextEdit();
            this.dogumtarih = new DevExpress.XtraEditors.DateEdit();
            this.engelturu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.engelorani = new DevExpress.XtraEditors.TextEdit();
            this.addname_Clickbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtadsoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogumtarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogumtarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelturu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelorani.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // addname
            // 
            this.addname.Location = new System.Drawing.Point(42, 37);
            this.addname.Name = "addname";
            this.addname.Size = new System.Drawing.Size(57, 13);
            this.addname.TabIndex = 1;
            this.addname.Text = "Adi Soyadi :";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(118, 34);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtadsoyad.TabIndex = 2;
            this.txtadsoyad.EditValueChanged += new System.EventHandler(this.txtadsoyad_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "TC Kimlik No :";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Dogum Tarihi :";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(42, 161);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Engel Turu :";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(42, 201);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Engel Orani :";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(112, 82);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 13);
            this.labelControl5.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(117, 121);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(0, 13);
            this.labelControl6.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(105, 161);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(0, 13);
            this.labelControl7.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(110, 201);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(0, 13);
            this.labelControl8.TabIndex = 10;
            // 
            // tcno
            // 
            this.tcno.Location = new System.Drawing.Point(118, 79);
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(100, 20);
            this.tcno.TabIndex = 11;
            this.tcno.EditValueChanged += new System.EventHandler(this.tcno_EditValueChanged);
            // 
            // dogumtarih
            // 
            this.dogumtarih.EditValue = null;
            this.dogumtarih.Location = new System.Drawing.Point(118, 118);
            this.dogumtarih.Name = "dogumtarih";
            this.dogumtarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dogumtarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dogumtarih.Size = new System.Drawing.Size(100, 20);
            this.dogumtarih.TabIndex = 12;
            this.dogumtarih.EditValueChanged += new System.EventHandler(this.dogumtarih_EditValueChanged);
            // 
            // engelturu
            // 
            this.engelturu.Location = new System.Drawing.Point(118, 158);
            this.engelturu.Name = "engelturu";
            this.engelturu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.engelturu.Size = new System.Drawing.Size(100, 20);
            this.engelturu.TabIndex = 13;
            this.engelturu.SelectedIndexChanged += new System.EventHandler(this.engelturu_SelectedIndexChanged);
            // 
            // engelorani
            // 
            this.engelorani.Location = new System.Drawing.Point(118, 198);
            this.engelorani.Name = "engelorani";
            this.engelorani.Size = new System.Drawing.Size(100, 20);
            this.engelorani.TabIndex = 14;
            this.engelorani.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // addname_Clickbtn
            // 
            this.addname_Clickbtn.Location = new System.Drawing.Point(143, 248);
            this.addname_Clickbtn.Name = "addname_Clickbtn";
            this.addname_Clickbtn.Size = new System.Drawing.Size(75, 23);
            this.addname_Clickbtn.TabIndex = 15;
            this.addname_Clickbtn.Text = "Kaydet";
            this.addname_Clickbtn.Click += new System.EventHandler(this.addname_Click);
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addname_Clickbtn);
            this.Controls.Add(this.engelorani);
            this.Controls.Add(this.engelturu);
            this.Controls.Add(this.dogumtarih);
            this.Controls.Add(this.tcno);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.addname);
            this.Name = "FormAddStudent";
            this.Text = "FormAddStudent";
            this.Load += new System.EventHandler(this.FormAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtadsoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogumtarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogumtarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelturu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelorani.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl addname;
        private DevExpress.XtraEditors.TextEdit txtadsoyad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit tcno;
        private DevExpress.XtraEditors.DateEdit dogumtarih;
        private DevExpress.XtraEditors.ComboBoxEdit engelturu;
        private DevExpress.XtraEditors.TextEdit engelorani;
        private DevExpress.XtraEditors.SimpleButton addname_Clickbtn;
    }
}