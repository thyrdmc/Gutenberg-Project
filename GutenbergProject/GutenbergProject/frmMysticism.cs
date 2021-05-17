using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using word = Microsoft.Office.Interop.Word;

namespace GutenbergProject
{
    public partial class frmMysticism : Form
    {
        Classes.Connection connection = new Classes.Connection();
        DataSet ds = new DataSet();

        public frmMysticism()
        {
            InitializeComponent();
        }

        private void ShowData()
        {
            SqlConnection conn = new SqlConnection(connection.conString);
            conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT BookName, AuthorName, Category, Page, DateOfIssue, Book FROM products  WHERE Category = 'Din Tasavvuf'", conn);
            dataAdapter.Fill(ds, "products");
            dataGridView1.DataSource = ds.Tables["products"];
            conn.Close();
        }

        private void frmMysticism_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookPath = dataGridView1.CurrentRow.Cells["Book"].Value.ToString();
            MessageBox.Show(bookPath + " adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
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

    }
}
