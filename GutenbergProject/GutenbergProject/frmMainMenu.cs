using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GutenbergProject
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            if(Classes.Connection.gorevID == 1)
            {
                btnAddingBook.Enabled = true;
            }
            else
            {
                btnAddingBook.Enabled = false;
            }

        }

        private void btnEdebiyat_Click(object sender, EventArgs e)
        {
            frmLiterature frmLiterature = new frmLiterature();
            frmLiterature.ShowDialog();
        }

        private void btnKisiselGelisim_Click(object sender, EventArgs e)
        {
            frmPersonalGrowth frmPersonalGrowth = new frmPersonalGrowth();
            frmPersonalGrowth.ShowDialog();
        }

        private void btnSanat_Click(object sender, EventArgs e)
        {
            frmArt frmArt = new frmArt();
            frmArt.ShowDialog();
        }

        private void btnBilimKurgu_Click(object sender, EventArgs e)
        {
            frmScienceFiction frmScienceFiction = new frmScienceFiction();
            frmScienceFiction.ShowDialog();
        }

        private void btnCizgiRoman_Click(object sender, EventArgs e)
        {
            frmComicStrip frmComicStrip = new frmComicStrip();
            frmComicStrip.ShowDialog();
        }

        private void btnTasavvuf_Click(object sender, EventArgs e)
        {
            frmMysticism frmMysticism = new frmMysticism();
            frmMysticism.ShowDialog();
        }

        private void btnYabancıDil_Click(object sender, EventArgs e)
        {
            frmLanguage frmLanguage = new frmLanguage();
            frmLanguage.ShowDialog();
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            frmHistory frmHistory = new frmHistory();
            frmHistory.ShowDialog();
        }

        private void btnCocuk_Click(object sender, EventArgs e)
        {
            frmChildren frmChildren = new frmChildren();
            frmChildren.ShowDialog();
        }

        private void btnProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            frmProfile.ShowDialog();
        }

        private void btnAddingBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddingBook frmAddingBook = new frmAddingBook();
            frmAddingBook.ShowDialog();
        }

        #region panelOperations

        private void btnMinimize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmShowingBooks frmShowingBooks = new frmShowingBooks();
            frmShowingBooks.ShowDialog();
        }
    }
}
