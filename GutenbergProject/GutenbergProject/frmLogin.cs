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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.Personal p = (Classes.Personal)cbUserName.SelectedItem;
            Classes.Connection.personelID = p.PersonelID;
            Classes.Connection.gorevID = p.PersonelJobID;
            Classes.Connection.userName = p.PersonelName;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Classes.Personal p = new Classes.Personal();
            p.getPersonalInformation(cbUserName);
            txtPassword.Properties.PasswordChar = '*';
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Classes.Connection connection = new Classes.Connection();
            Classes.Personal p = new Classes.Personal();

            bool result = p.personalEntryControl(txtPassword.Text, Classes.Connection.personelID);

            if (result)
            {
                MessageBox.Show("Giriş Başarılı", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Classes.LoginHistory loginHistory = new Classes.LoginHistory();
                loginHistory.JobID = Classes.Connection.gorevID;
                loginHistory.Login = "Giriş Yaptı";
                loginHistory.Date = DateTime.Now;
                loginHistory.PersonnelAction(loginHistory);

                this.Hide();
                frmMainMenu menu = new frmMainMenu();
                menu.Show();
            }

            else
            {
                MessageBox.Show("Yanlış Şifre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }


        #region panelOperations

        private void btnMinimize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}
