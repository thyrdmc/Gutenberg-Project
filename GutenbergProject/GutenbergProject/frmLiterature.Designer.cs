namespace GutenbergProject
{
    partial class frmLiterature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLiterature));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMinimize = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnFahrenheit = new System.Windows.Forms.PictureBox();
            this.btnHayvanCiftliği = new System.Windows.Forms.PictureBox();
            this.btnKorluk = new System.Windows.Forms.PictureBox();
            this.btnPembe = new System.Windows.Forms.PictureBox();
            this.btnTalebe = new System.Windows.Forms.PictureBox();
            this.btnSekerPortakalı = new System.Windows.Forms.PictureBox();
            this.btnSucveCeza = new System.Windows.Forms.PictureBox();
            this.btnSinekler = new System.Windows.Forms.PictureBox();
            this.btnSimyacı = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFahrenheit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHayvanCiftliği)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKorluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPembe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTalebe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSekerPortakalı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSucveCeza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSinekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimyacı)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonImageOptions.Image = global::GutenbergProject.Properties.Resources.logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Image = global::GutenbergProject.Properties.Resources.panel;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnMinimize,
            this.btnExit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.btnMinimize);
            this.ribbonControl1.PageHeaderItemLinks.Add(this.btnExit);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 53);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Caption = "btn";
            this.btnMinimize.Id = 1;
            this.btnMinimize.ImageOptions.Image = global::GutenbergProject.Properties.Resources.minimize;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMinimize_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "barButtonItem2";
            this.btnExit.Id = 2;
            this.btnExit.ImageOptions.Image = global::GutenbergProject.Properties.Resources.close;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Edebiyat";
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Image = global::GutenbergProject.Properties.Resources.Fahrenheit_451;
            this.btnFahrenheit.Location = new System.Drawing.Point(12, 59);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(110, 130);
            this.btnFahrenheit.TabIndex = 1;
            this.btnFahrenheit.TabStop = false;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnHayvanCiftliği
            // 
            this.btnHayvanCiftliği.Image = global::GutenbergProject.Properties.Resources.Hayvan_Çiftliği;
            this.btnHayvanCiftliği.Location = new System.Drawing.Point(226, 59);
            this.btnHayvanCiftliği.Name = "btnHayvanCiftliği";
            this.btnHayvanCiftliği.Size = new System.Drawing.Size(110, 130);
            this.btnHayvanCiftliği.TabIndex = 1;
            this.btnHayvanCiftliği.TabStop = false;
            this.btnHayvanCiftliği.Click += new System.EventHandler(this.btnHayvanCiftliği_Click);
            // 
            // btnKorluk
            // 
            this.btnKorluk.Image = global::GutenbergProject.Properties.Resources.Körlük;
            this.btnKorluk.Location = new System.Drawing.Point(469, 59);
            this.btnKorluk.Name = "btnKorluk";
            this.btnKorluk.Size = new System.Drawing.Size(110, 130);
            this.btnKorluk.TabIndex = 1;
            this.btnKorluk.TabStop = false;
            this.btnKorluk.Click += new System.EventHandler(this.btnKorluk_Click);
            // 
            // btnPembe
            // 
            this.btnPembe.Image = global::GutenbergProject.Properties.Resources.Pembe_Fili_Düşünme;
            this.btnPembe.Location = new System.Drawing.Point(678, 59);
            this.btnPembe.Name = "btnPembe";
            this.btnPembe.Size = new System.Drawing.Size(110, 130);
            this.btnPembe.TabIndex = 1;
            this.btnPembe.TabStop = false;
            this.btnPembe.Click += new System.EventHandler(this.btnPembe_Click);
            // 
            // btnTalebe
            // 
            this.btnTalebe.Image = global::GutenbergProject.Properties.Resources.Tabele;
            this.btnTalebe.Location = new System.Drawing.Point(678, 308);
            this.btnTalebe.Name = "btnTalebe";
            this.btnTalebe.Size = new System.Drawing.Size(110, 130);
            this.btnTalebe.TabIndex = 1;
            this.btnTalebe.TabStop = false;
            this.btnTalebe.Click += new System.EventHandler(this.btnTalebe_Click);
            // 
            // btnSekerPortakalı
            // 
            this.btnSekerPortakalı.Image = global::GutenbergProject.Properties.Resources.Şeker_Portakalı;
            this.btnSekerPortakalı.Location = new System.Drawing.Point(469, 308);
            this.btnSekerPortakalı.Name = "btnSekerPortakalı";
            this.btnSekerPortakalı.Size = new System.Drawing.Size(110, 130);
            this.btnSekerPortakalı.TabIndex = 1;
            this.btnSekerPortakalı.TabStop = false;
            this.btnSekerPortakalı.Click += new System.EventHandler(this.btnSekerPortakalı_Click);
            // 
            // btnSucveCeza
            // 
            this.btnSucveCeza.Image = global::GutenbergProject.Properties.Resources.Suç_ve_Ceza;
            this.btnSucveCeza.Location = new System.Drawing.Point(226, 308);
            this.btnSucveCeza.Name = "btnSucveCeza";
            this.btnSucveCeza.Size = new System.Drawing.Size(110, 130);
            this.btnSucveCeza.TabIndex = 1;
            this.btnSucveCeza.TabStop = false;
            this.btnSucveCeza.Click += new System.EventHandler(this.btnSucveCeza_Click);
            // 
            // btnSinekler
            // 
            this.btnSinekler.Image = global::GutenbergProject.Properties.Resources.Sineklerin_Tanrısı;
            this.btnSinekler.Location = new System.Drawing.Point(12, 308);
            this.btnSinekler.Name = "btnSinekler";
            this.btnSinekler.Size = new System.Drawing.Size(110, 130);
            this.btnSinekler.TabIndex = 1;
            this.btnSinekler.TabStop = false;
            this.btnSinekler.Click += new System.EventHandler(this.btnSinekler_Click);
            // 
            // btnSimyacı
            // 
            this.btnSimyacı.Image = global::GutenbergProject.Properties.Resources.Simyacı;
            this.btnSimyacı.Location = new System.Drawing.Point(348, 183);
            this.btnSimyacı.Name = "btnSimyacı";
            this.btnSimyacı.Size = new System.Drawing.Size(110, 130);
            this.btnSimyacı.TabIndex = 1;
            this.btnSimyacı.TabStop = false;
            this.btnSimyacı.Click += new System.EventHandler(this.btnSimyacı_Click);
            // 
            // frmLiterature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSucveCeza);
            this.Controls.Add(this.btnSekerPortakalı);
            this.Controls.Add(this.btnSimyacı);
            this.Controls.Add(this.btnSinekler);
            this.Controls.Add(this.btnTalebe);
            this.Controls.Add(this.btnPembe);
            this.Controls.Add(this.btnKorluk);
            this.Controls.Add(this.btnHayvanCiftliği);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLiterature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLiterature";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFahrenheit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHayvanCiftliği)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKorluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPembe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTalebe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSekerPortakalı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSucveCeza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSinekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimyacı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnMinimize;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private System.Windows.Forms.PictureBox btnFahrenheit;
        private System.Windows.Forms.PictureBox btnHayvanCiftliği;
        private System.Windows.Forms.PictureBox btnKorluk;
        private System.Windows.Forms.PictureBox btnPembe;
        private System.Windows.Forms.PictureBox btnTalebe;
        private System.Windows.Forms.PictureBox btnSekerPortakalı;
        private System.Windows.Forms.PictureBox btnSucveCeza;
        private System.Windows.Forms.PictureBox btnSinekler;
        private System.Windows.Forms.PictureBox btnSimyacı;
    }
}