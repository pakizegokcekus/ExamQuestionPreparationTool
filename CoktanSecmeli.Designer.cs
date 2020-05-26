namespace Proje
{
    partial class frm_CoktanSecmeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CoktanSecmeli));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_dyanıt = new System.Windows.Forms.ComboBox();
            this.cmb_seviye = new System.Windows.Forms.ComboBox();
            this.txt_puan = new DevExpress.XtraEditors.TextEdit();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ekle = new DevExpress.XtraEditors.SimpleButton();
            this.txt_soru = new System.Windows.Forms.RichTextBox();
            this.txt_d = new DevExpress.XtraEditors.TextEdit();
            this.txt_c = new DevExpress.XtraEditors.TextEdit();
            this.txt_b = new DevExpress.XtraEditors.TextEdit();
            this.txt_a = new DevExpress.XtraEditors.TextEdit();
            this.txt_dersadi = new DevExpress.XtraEditors.TextEdit();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_d.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_c.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_b.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_a.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dersadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(525, 525);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmb_dyanıt);
            this.groupControl1.Controls.Add(this.cmb_seviye);
            this.groupControl1.Controls.Add(this.txt_puan);
            this.groupControl1.Controls.Add(this.btn_guncelle);
            this.groupControl1.Controls.Add(this.btn_sil);
            this.groupControl1.Controls.Add(this.btn_ekle);
            this.groupControl1.Controls.Add(this.txt_soru);
            this.groupControl1.Controls.Add(this.txt_d);
            this.groupControl1.Controls.Add(this.txt_c);
            this.groupControl1.Controls.Add(this.txt_b);
            this.groupControl1.Controls.Add(this.txt_a);
            this.groupControl1.Controls.Add(this.txt_dersadi);
            this.groupControl1.Controls.Add(this.txt_id);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.id);
            this.groupControl1.Location = new System.Drawing.Point(529, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(250, 530);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "groupControl1";
            // 
            // cmb_dyanıt
            // 
            this.cmb_dyanıt.FormattingEnabled = true;
            this.cmb_dyanıt.Location = new System.Drawing.Point(127, 296);
            this.cmb_dyanıt.Name = "cmb_dyanıt";
            this.cmb_dyanıt.Size = new System.Drawing.Size(113, 21);
            this.cmb_dyanıt.TabIndex = 46;
            // 
            // cmb_seviye
            // 
            this.cmb_seviye.FormattingEnabled = true;
            this.cmb_seviye.Location = new System.Drawing.Point(127, 322);
            this.cmb_seviye.Name = "cmb_seviye";
            this.cmb_seviye.Size = new System.Drawing.Size(113, 21);
            this.cmb_seviye.TabIndex = 45;
            // 
            // txt_puan
            // 
            this.txt_puan.Location = new System.Drawing.Point(127, 348);
            this.txt_puan.Name = "txt_puan";
            this.txt_puan.Properties.Mask.EditMask = "n0";
            this.txt_puan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_puan.Size = new System.Drawing.Size(113, 20);
            this.txt_puan.TabIndex = 44;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.ImageOptions.Image")));
            this.btn_guncelle.Location = new System.Drawing.Point(121, 474);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(119, 37);
            this.btn_guncelle.TabIndex = 43;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.ImageOptions.Image")));
            this.btn_sil.Location = new System.Drawing.Point(121, 435);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(119, 33);
            this.btn_sil.TabIndex = 42;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Appearance.Options.UseFont = true;
            this.btn_ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.ImageOptions.Image")));
            this.btn_ekle.Location = new System.Drawing.Point(121, 394);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(119, 35);
            this.btn_ekle.TabIndex = 41;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_soru
            // 
            this.txt_soru.Location = new System.Drawing.Point(81, 72);
            this.txt_soru.Name = "txt_soru";
            this.txt_soru.Size = new System.Drawing.Size(159, 114);
            this.txt_soru.TabIndex = 37;
            this.txt_soru.Text = "";
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(127, 270);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(113, 20);
            this.txt_d.TabIndex = 35;
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(127, 244);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(113, 20);
            this.txt_c.TabIndex = 34;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(127, 219);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(113, 20);
            this.txt_b.TabIndex = 33;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(127, 193);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(113, 20);
            this.txt_a.TabIndex = 32;
            // 
            // txt_dersadi
            // 
            this.txt_dersadi.Location = new System.Drawing.Point(127, 45);
            this.txt_dersadi.Name = "txt_dersadi";
            this.txt_dersadi.Size = new System.Drawing.Size(113, 20);
            this.txt_dersadi.TabIndex = 30;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(127, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(113, 20);
            this.txt_id.TabIndex = 29;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(10, 345);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 18);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "PUAN:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(10, 321);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 18);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "SEVİYE:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(9, 295);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(112, 18);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "DOĞRUYANIT:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(9, 272);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 18);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "SECENEKD:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(10, 248);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 18);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "SECENEKC:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(10, 224);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 18);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "SECENEKB:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 200);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 18);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "SECENEKA:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 18);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "SORU:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 18);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "DERS ADI:";
            // 
            // id
            // 
            this.id.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.Appearance.Options.UseFont = true;
            this.id.Location = new System.Drawing.Point(15, 21);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(25, 18);
            this.id.TabIndex = 19;
            this.id.Text = "ID:";
            // 
            // frm_CoktanSecmeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 530);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frm_CoktanSecmeli";
            this.Text = "CoktanSecmeli";
            this.Load += new System.EventHandler(this.frmCoktanSecmeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_d.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_c.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_b.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_a.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dersadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txt_soru;
        private DevExpress.XtraEditors.TextEdit txt_d;
        private DevExpress.XtraEditors.TextEdit txt_c;
        private DevExpress.XtraEditors.TextEdit txt_b;
        private DevExpress.XtraEditors.TextEdit txt_a;
        private DevExpress.XtraEditors.TextEdit txt_dersadi;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl id;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_ekle;
        private DevExpress.XtraEditors.TextEdit txt_puan;
        private System.Windows.Forms.ComboBox cmb_seviye;
        private System.Windows.Forms.ComboBox cmb_dyanıt;
    }
}