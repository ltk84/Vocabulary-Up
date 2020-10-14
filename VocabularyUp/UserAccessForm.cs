using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{

    public partial class UserAccessForm : Form
    {
        public UserAccessForm()
        {
            InitializeComponent();
            ManageSystem.ConnectDatabase();
        }

        

        private void btnCreateAccount_Login_Click(object sender, EventArgs e)
        {
            pnlSignup.Visible = true;
            transitionPanel.ShowSync(pnlSignup);
        }

        

        private void lbLoginAccess_SignUp_Click(object sender, EventArgs e)
        {
            pnlSignup.Visible = false;
            transitionPanel.HideSync(pnlSignup);
        }

        private void btnCreateAccount_SignUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string encodedPassword = ManageSystem.EncryptPassword(txtPassword_Login.Text);
            if (ManageSystem.CheckLoginIfValid(txtUsename_Login.Text, txtPassword_Login.Text))
            {
                if (ManageSystem.CheckSignIn(txtUsename_Login.Text, encodedPassword))
                    ToNavTab(ManageSystem.GetUserID(txtUsename_Login.Text));
                else
                    MessageBox.Show("Username or Password is not correct", "Notification");
            }
            else
                return;
        }

        private void SignUp()
        {
            if (ManageSystem.CheckSignUpIfValid(txtUsername_SignUp.Text, txtEmail_SignUp.Text, txtPassword_SignUp.Text, txtRePassword_SignUp.Text))
            {
                if (ManageSystem.CheckSignUp(txtUsername_SignUp.Text, txtEmail_SignUp.Text, txtPassword_SignUp.Text, txtRePassword_SignUp.Text))
                {
                    string encodedPassword = ManageSystem.EncryptPassword(txtPassword_SignUp.Text);
                    ManageSystem.AddUser(txtUsername_SignUp.Text, txtEmail_SignUp.Text, encodedPassword);
                    ToNavTab(ManageSystem.GetUserID(txtUsername_SignUp.Text));
                }
                else
                    return;
            }
            else
                return;
        }
        
        private void ToNavTab(int currentID)
        {
            NavForm navTab = new NavForm(this, currentID);
            navTab.Show();
            this.Hide();
        }

        private void txtEmail_SignUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
