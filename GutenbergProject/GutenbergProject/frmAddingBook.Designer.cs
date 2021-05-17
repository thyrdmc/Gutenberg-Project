namespace GutenbergProject
{
    partial class frmAddingBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddingBook));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMinimize = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPage = new DevExpress.XtraEditors.TextEdit();
            this.txtYear = new DevExpress.XtraEditors.TextEdit();
            this.txtAuthorName = new DevExpress.XtraEditors.TextEdit();
            this.txtBookName = new DevExpress.XtraEditors.TextEdit();
            this.btnSelectBook = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmbCategory1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPage1 = new DevExpress.XtraEditors.TextEdit();
            this.txtYear1 = new DevExpress.XtraEditors.TextEdit();
            this.txtAuthorName1 = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtBookName1 = new DevExpress.XtraEditors.TextEdit();
            this.btnUpdateBook = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookName.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookName1.Properties)).BeginInit();
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
            this.ribbonPage1.Text = "Kitap Ekle";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(264, 59);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(270, 379);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(264, 348);
            this.xtraTabPage1.Text = "Kitap Ekle";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbCategory);
            this.panelControl1.Controls.Add(this.txtPage);
            this.panelControl1.Controls.Add(this.txtYear);
            this.panelControl1.Controls.Add(this.txtAuthorName);
            this.panelControl1.Controls.Add(this.txtBookName);
            this.panelControl1.Controls.Add(this.btnSelectBook);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(258, 342);
            this.panelControl1.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Location = new System.Drawing.Point(105, 131);
            this.cmbCategory.MenuManager = this.ribbonControl1;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategory.Size = new System.Drawing.Size(100, 20);
            this.cmbCategory.TabIndex = 3;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(105, 178);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 20);
            this.txtPage.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(105, 225);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 2;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(105, 84);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorName.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(105, 37);
            this.txtBookName.MenuManager = this.ribbonControl1;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 20);
            this.txtBookName.TabIndex = 2;
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSelectBook.Location = new System.Drawing.Point(83, 271);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(75, 23);
            this.btnSelectBook.TabIndex = 1;
            this.btnSelectBook.Text = "Kitap Yükle";
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 228);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Basım Yılı :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 181);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Sayfa Sayısı :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Kategori :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Yazar Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kitap Adı :";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panelControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(264, 348);
            this.xtraTabPage2.Text = "Kitap Güncelle";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmbCategory1);
            this.panelControl2.Controls.Add(this.txtPage1);
            this.panelControl2.Controls.Add(this.txtYear1);
            this.panelControl2.Controls.Add(this.txtAuthorName1);
            this.panelControl2.Controls.Add(this.txtID);
            this.panelControl2.Controls.Add(this.txtBookName1);
            this.panelControl2.Controls.Add(this.btnUpdateBook);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Location = new System.Drawing.Point(3, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(258, 342);
            this.panelControl2.TabIndex = 4;
            // 
            // cmbCategory1
            // 
            this.cmbCategory1.Location = new System.Drawing.Point(105, 160);
            this.cmbCategory1.MenuManager = this.ribbonControl1;
            this.cmbCategory1.Name = "cmbCategory1";
            this.cmbCategory1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategory1.Size = new System.Drawing.Size(100, 20);
            this.cmbCategory1.TabIndex = 3;
            // 
            // txtPage1
            // 
            this.txtPage1.Location = new System.Drawing.Point(105, 207);
            this.txtPage1.Name = "txtPage1";
            this.txtPage1.Size = new System.Drawing.Size(100, 20);
            this.txtPage1.TabIndex = 2;
            // 
            // txtYear1
            // 
            this.txtYear1.Location = new System.Drawing.Point(105, 254);
            this.txtYear1.Name = "txtYear1";
            this.txtYear1.Size = new System.Drawing.Size(100, 20);
            this.txtYear1.TabIndex = 2;
            // 
            // txtAuthorName1
            // 
            this.txtAuthorName1.Location = new System.Drawing.Point(105, 113);
            this.txtAuthorName1.Name = "txtAuthorName1";
            this.txtAuthorName1.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorName1.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(105, 23);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtID.Properties.Appearance.Options.UseBackColor = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtBookName1
            // 
            this.txtBookName1.Location = new System.Drawing.Point(105, 66);
            this.txtBookName1.MenuManager = this.ribbonControl1;
            this.txtBookName1.Name = "txtBookName1";
            this.txtBookName1.Size = new System.Drawing.Size(100, 20);
            this.txtBookName1.TabIndex = 2;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnUpdateBook.Location = new System.Drawing.Point(83, 300);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBook.TabIndex = 1;
            this.btnUpdateBook.Text = "Kitap Güncelle";
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(32, 257);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Basım Yılı :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 210);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Sayfa Sayısı :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(34, 163);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Kategori :";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(32, 26);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Kitap ID :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(29, 116);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Yazar Adı :";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(32, 69);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Kitap Adı :";
            // 
            // frmAddingBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GutenbergProject.Properties.Resources.AddBookBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddingBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddingBook";
            this.Load += new System.EventHandler(this.frmAddingBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookName.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookName1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnMinimize;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelectBook;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCategory;
        private DevExpress.XtraEditors.TextEdit txtPage;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraEditors.TextEdit txtAuthorName;
        private DevExpress.XtraEditors.TextEdit txtBookName;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCategory1;
        private DevExpress.XtraEditors.TextEdit txtPage1;
        private DevExpress.XtraEditors.TextEdit txtYear1;
        private DevExpress.XtraEditors.TextEdit txtAuthorName1;
        private DevExpress.XtraEditors.TextEdit txtBookName1;
        private DevExpress.XtraEditors.SimpleButton btnUpdateBook;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}