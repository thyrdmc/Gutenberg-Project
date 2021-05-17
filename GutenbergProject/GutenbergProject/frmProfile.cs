using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace GutenbergProject
{
    public partial class frmProfile : Form
    {
        Classes.Connection connection = new Classes.Connection();

        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            SqlConnection conn = new SqlConnection(connection.conString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM staff WHERE Name = @name", conn);
            cmd.Parameters.AddWithValue("@name", Classes.Connection.userName);
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                lblName.Text = dataReader["RealName"].ToString();
                lblSurname.Text = dataReader["Surname"].ToString();
                lblPhone.Text = dataReader["Phone"].ToString();
                lblBirthday.Text = dataReader["Birthday"].ToString();
                lblMail.Text = dataReader["Mail"].ToString();
                lblJob.Text = dataReader["Job"].ToString();
                yeniyol = "C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject" + "\\ProfilePictures\\" + dataReader["ProfilePicture"].ToString();
                ProfilePicture.ImageLocation = yeniyol;
            }
            conn.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtRealName.Text != "" && txtSurname.Text != "" && txtPhone.Text != "" && txtMail.Text != "" && txtJob.Text != "" && txtBirthday.Text != "")
            {
                SqlConnection conn = new SqlConnection(connection.conString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE staff SET RealName=@RealName, Surname=@Surname, Phone=@Phone, Birthday=@Birthday, Mail=@Mail, Job=@Job WHERE Name= '" + Classes.Connection.userName + "' ", conn);
                cmd.Parameters.AddWithValue("@RealName", txtRealName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Birthday", txtBirthday.Text);
                cmd.Parameters.AddWithValue("@Mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@Job", txtJob.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Profil güncellendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }

            else
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string yeniyol;

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog  dosya = new OpenFileDialog();
            dosya.Filter = "Resim dosyası | *.jpg;*png;*nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\mtyar\\source\\repos\\GutenbergProject\\GutenbergProject" + "\\ProfilePictures\\" + Guid.NewGuid().ToString() + ".jpg" ;
            File.Copy(dosyayolu, yeniyol);
            ProfilePicture.ImageLocation = yeniyol;

            SqlConnection conn = new SqlConnection(connection.conString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE staff SET ProfilePicture=@ProfilePicture WHERE Name= '" + Classes.Connection.userName + "' ", conn);
            cmd.Parameters.AddWithValue("@ProfilePicture", Path.GetFileName(yeniyol));
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowData();
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
