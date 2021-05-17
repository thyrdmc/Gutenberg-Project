using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace GutenbergProject
{
    public partial class frmLiterature : Form
    {
        public frmLiterature()
        {
            InitializeComponent();
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

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            string bookPath = "Fahrenheit 451.docx";
            MessageBox.Show(bookPath + " adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
        }

        private void btnHayvanCiftliği_Click(object sender, EventArgs e)
        {
            string bookPath = "Hayvan Çiftliği.docx";
            MessageBox.Show(bookPath + " adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
        }

        private void btnKorluk_Click(object sender, EventArgs e)
        {            
            string bookPath = "Körlük.docx";
            MessageBox.Show(bookPath + " adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
        }

        private void btnPembe_Click(object sender, EventArgs e)
        {
            string bookPath = "Pembe Fili Düşünme.docx";
            MessageBox.Show(bookPath + " adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
        }

        private void btnSimyacı_Click(object sender, EventArgs e)
        {
            string bookPath = "Simyacı.docx";
            MessageBox.Show(bookPath + " adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
        }

        private void btnSinekler_Click(object sender, EventArgs e)
        {
            string bookPath = "Sineklerin Tanrısı.docx";
            MessageBox.Show(bookPath + " adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
        }

        private void btnSucveCeza_Click(object sender, EventArgs e)
        {
            string bookPath = "Suç ve Ceza.docx";
            MessageBox.Show(bookPath + " adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
        }

        private void btnSekerPortakalı_Click(object sender, EventArgs e)
        {
            string bookPath = "Şeker Portakalı.docx";
            MessageBox.Show(bookPath + " adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
        }

        private void btnTalebe_Click(object sender, EventArgs e)
        {
            string bookPath = "Talebe.docx";
            MessageBox.Show(bookPath + " adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
        }        
    }
}
