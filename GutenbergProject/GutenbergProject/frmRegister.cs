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
    public partial class frmRegister : Form
    {
        Classes.Connection connection = new Classes.Connection();

        public frmRegister()
        {
            InitializeComponent();
        }

        public string default_pp;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            default_pp = "50d67025-8479-4aa8-9955-4af62494733e" + ".jpg";


            if (txtName.Text != "" && txtPassword.Text != "")
            {
                SqlConnection conn = new SqlConnection(connection.conString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into staff (Name, Password, JobID, ProfilePicture) values ('" + txtName.Text + "','" + txtPassword.Text + "', 2, '"+ default_pp + "' )", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Kayıt eklendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextbox();
            }

            else
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void clearTextbox()
        {            
            txtName.Text = "";
            txtPassword.Text = "";
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
