namespace Proje
{
    partial class frmSoruBankası
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoruBankası));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_coktanSecmeli = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dogruYanlis = new DevExpress.XtraBars.BarButtonItem();
            this.btn_klasik = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sinavOlusturma = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sinavOkuma = new DevExpress.XtraBars.BarButtonItem();
            this.btn_soruİstatistikleri = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonControl1.ExpandCollapseItem.ItemAppearance.Normal.Options.UseFont = true;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_coktanSecmeli,
            this.btn_dogruYanlis,
            this.btn_klasik,
            this.btn_sinavOlusturma,
            this.btn_sinavOkuma,
            this.btn_soruİstatistikleri,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(781, 133);
            // 
            // btn_coktanSecmeli
            // 
            this.btn_coktanSecmeli.Caption = "CoktanSeçmeli";
            this.btn_coktanSecmeli.Id = 1;
            this.btn_coktanSecmeli.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_coktanSecmeli.ImageOptions.Image")));
            this.btn_coktanSecmeli.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_coktanSecmeli.ImageOptions.LargeImage")));
            this.btn_coktanSecmeli.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_coktanSecmeli.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_coktanSecmeli.Name = "btn_coktanSecmeli";
            this.btn_coktanSecmeli.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_coktanSecmeli_ItemClick);
            // 
            // btn_dogruYanlis
            // 
            this.btn_dogruYanlis.Caption = "DoğruYanlış";
            this.btn_dogruYanlis.Id = 2;
            this.btn_dogruYanlis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dogruYanlis.ImageOptions.Image")));
            this.btn_dogruYanlis.ImageOptions.ImageIndex = 0;
            this.btn_dogruYanlis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_dogruYanlis.ImageOptions.LargeImage")));
            this.btn_dogruYanlis.ImageOptions.LargeImageIndex = 0;
            this.btn_dogruYanlis.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dogruYanlis.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_dogruYanlis.Name = "btn_dogruYanlis";
            this.btn_dogruYanlis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dogruYanlis_ItemClick);
            // 
            // btn_klasik
            // 
            this.btn_klasik.Caption = "Klasik";
            this.btn_klasik.Id = 4;
            this.btn_klasik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_klasik.ImageOptions.Image")));
            this.btn_klasik.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_klasik.ImageOptions.LargeImage")));
            this.btn_klasik.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_klasik.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_klasik.Name = "btn_klasik";
            this.btn_klasik.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_klasik_ItemClick);
            // 
            // btn_sinavOlusturma
            // 
            this.btn_sinavOlusturma.Caption = "SınavOluşturma";
            this.btn_sinavOlusturma.Id = 5;
            this.btn_sinavOlusturma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sinavOlusturma.ImageOptions.Image")));
            this.btn_sinavOlusturma.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_sinavOlusturma.ImageOptions.LargeImage")));
            this.btn_sinavOlusturma.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sinavOlusturma.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_sinavOlusturma.Name = "btn_sinavOlusturma";
            // 
            // btn_sinavOkuma
            // 
            this.btn_sinavOkuma.Caption = "SınavOkuma";
            this.btn_sinavOkuma.Id = 6;
            this.btn_sinavOkuma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sinavOkuma.ImageOptions.Image")));
            this.btn_sinavOkuma.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_sinavOkuma.ImageOptions.LargeImage")));
            this.btn_sinavOkuma.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sinavOkuma.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_sinavOkuma.Name = "btn_sinavOkuma";
            // 
            // btn_soruİstatistikleri
            // 
            this.btn_soruİstatistikleri.Caption = "Soru İstatistikleri";
            this.btn_soruİstatistikleri.Id = 7;
            this.btn_soruİstatistikleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_soruİstatistikleri.ImageOptions.Image")));
            this.btn_soruİstatistikleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_soruİstatistikleri.ImageOptions.LargeImage")));
            this.btn_soruİstatistikleri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_soruİstatistikleri.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_soruİstatistikleri.Name = "btn_soruİstatistikleri";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "An";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Soru Bankası";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_coktanSecmeli);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_dogruYanlis, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_klasik, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Soru Bankası";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_sinavOlusturma);
            this.ribbonPageGroup2.MergeOrder = 2;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Sınav Oluşturma";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_sinavOkuma);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Sınav Okuma";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_soruİstatistikleri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Soru İstatistikleri";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmSoruBankası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 680);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmSoruBankası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SORU BANKASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_coktanSecmeli;
        private DevExpress.XtraBars.BarButtonItem btn_dogruYanlis;
        private DevExpress.XtraBars.BarButtonItem btn_klasik;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_sinavOlusturma;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_sinavOkuma;
        private DevExpress.XtraBars.BarButtonItem btn_soruİstatistikleri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

