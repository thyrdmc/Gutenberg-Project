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
using System.IO;


namespace GutenbergProject
{
    public partial class frmAddingBook : Form
    {
        Classes.Connection connection = new Classes.Connection();


        public frmAddingBook()
        {
            InitializeComponent();
        }

        public void getCategory()
        {
            SqlConnection conn = new SqlConnection(connection.conString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT *FROM category", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCategory.Properties.Items.Add(dr["CategoryName"].ToString());
            }
            conn.Close();
        }

        public void clearTextbox()
        {
            txtPage.Text = "";
            txtYear.Text = "";
            txtBookName.Text = "";
            txtAuthorName.Text = "";
            cmbCategory.Text = "";
            txtPage1.Text = "";
            txtYear1.Text = "";
            txtBookName1.Text = "";
            txtAuthorName1.Text = "";
            cmbCategory1.Text = "";
        }

        private void frmAddingBook_Load(object sender, EventArgs e)
        {
            getCategory();
        }

        public string yeniyol;

        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            if (txtPage.Text != "" && txtYear.Text != "" && txtBookName.Text != "" && txtAuthorName.Text != "" && cmbCategory.Text != "")
            {
                SqlConnection conn = new SqlConnection(connection.conString);

                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Filter = "Metin dosyası | *.docx;*pdf;*txt | Tüm Dosyalar | *.*";
                dosya.ShowDialog();
                string dosyayolu = dosya.FileName;
                yeniyol = "C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject" + "\\Books\\" + txtBookName.Text.ToString() + ".docx";
                File.Copy(dosyayolu, yeniyol);

                SqlCommand cmd = new SqlCommand("insert into products (BookName, AuthorName, Category, Page, DateofIssue ,Book) values (@BookName, @AuthorName, @Category, @Page, @DateofIssue ,@Book)", conn);
                cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
                cmd.Parameters.AddWithValue("@AuthorName", txtAuthorName.Text);
                cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@Page", txtPage.Text);
                cmd.Parameters.AddWithValue("@DateofIssue", txtYear.Text);
                cmd.Parameters.AddWithValue("@Book", Path.GetFileName(yeniyol));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kitap ekleme işlemi başarılı.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextbox();
            }

            else
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection.conString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE products SET BookName=@BookName, AuthorName=@AuthorName, Category=@Category, Page=@Page, DateofIssue=@DateofIssue WHERE BookID= '" + txtID.Text + "' ", conn);
            cmd.Parameters.AddWithValue("@BookName", txtBookName1.Text);
            cmd.Parameters.AddWithValue("@AuthorName", txtAuthorName1.Text);
            cmd.Parameters.AddWithValue("@Category", cmbCategory1.Text);
            cmd.Parameters.AddWithValue("@Page", txtPage1.Text);
            cmd.Parameters.AddWithValue("@DateofIssue", txtYear1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kitap güncellendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearTextbox();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                clearTextbox();
            }

            else
            {
                SqlConnection conn = new SqlConnection(connection.conString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT *FROM products WHERE [BookID] LIKE '" + txtID.Text + "' ", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    txtBookName1.Text = dataReader["BookName"].ToString();
                    txtAuthorName1.Text = dataReader["AuthorName"].ToString();
                    cmbCategory1.Text = dataReader["Category"].ToString();
                    txtPage1.Text = dataReader["Page"].ToString();
                    txtYear1.Text = dataReader["DateofIssue"].ToString();
                }
                conn.Close();
            }
        }
    }
}
