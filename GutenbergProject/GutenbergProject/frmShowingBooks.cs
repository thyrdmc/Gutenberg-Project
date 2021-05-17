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
    public partial class frmShowingBooks : Form
    {
        Classes.Connection connection = new Classes.Connection();
        DataSet ds = new DataSet();

        public frmShowingBooks()
        {
            InitializeComponent();
        }

        private void ShowData()
        {
            SqlConnection conn = new SqlConnection(connection.conString);
            conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT BookName, AuthorName, Category, Page, DateOfIssue, Book FROM products", conn);
            dataAdapter.Fill(ds, "products");
            dataGridView1.DataSource = ds.Tables["products"];
            conn.Close();
        }

        private void frmShowingBooks_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void txtSearchAuthor_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(connection.conString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT BookName, AuthorName, Category, Page, DateOfIssue, Book FROM products WHERE AuthorName LIKE '%" + txtSearchAuthor.Text + "%' ", conn);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(connection.conString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT BookName, AuthorName, Category, Page, DateOfIssue, Book FROM products WHERE BookName LIKE '%" + txtSearchBook.Text + "%' ", conn);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string bookPath = "Kavgam.docx";
            string bookPath = dataGridView1.CurrentRow.Cells["Book"].Value.ToString();
            MessageBox.Show(bookPath+" adlı kitap açılıyor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            word.Application ap = new word.Application();
            word.Document document = ap.Documents.Open(@"C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject\\Books\\" + bookPath + "");
        }
    }
}
