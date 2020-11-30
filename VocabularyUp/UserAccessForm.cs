using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Threading;
using System.Net;

namespace VocabularyUp
{

    public partial class UserAccessForm : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        string verifiedCode;
        int iCountDown = 5;
        public UserAccessForm()
        {
            InitializeComponent();
            ManageSystem.ConnectDatabase();
        }

        public void ClearTextBox()
        {
            txtEmail_SignUp.Text = "";
            txtPassword_Login.Text = "";
            txtPassword_SignUp.Text = "";
            txtRePassword_SignUp.Text = "";
            txtUsename_Login.Text = "";
            txtUsername_SignUp.Text = "";
        }

        private void btnCreateAccount_Login_Click(object sender, EventArgs e)
        {
            pnlForgetPass.Visible = false;
            pnlUserLogin.Visible = false;
            pnlSignup.Visible = true;
            transitionPanel.ShowSync(pnlSignup);
            this.AcceptButton = this.btnCreateAccount_SignUp;
            ClearTextBox();
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

        private void lbLoginAccess_SignUp_Click(object sender, EventArgs e)
        {
            pnlForgetPass.Visible = false;
            pnlUserLogin.Visible = true;
            pnlSignup.Visible = false;
            transitionPanel.HideSync(pnlSignup);
            this.AcceptButton = this.btnLogin;
            ClearTextBox();
        }

        private void btnCreateAccount_SignUp_Click(object sender, EventArgs e)
        {
            SignUp();
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
            pnlUserLogin.Visible = true;
            pnlSignup.Visible = false;
            transitionPanel.HideSync(pnlSignup);
            this.AcceptButton = this.btnLogin;
            NavForm navTab = new NavForm(this, currentID);
            navTab.Show();
            this.Hide();
            ClearTextBox();
        }
               
        private void lbForget_Click(object sender, EventArgs e)
        {
            pnlUserLogin.Visible = false;
            pnlSignup.Visible = false;
            pnlForgetPass.Visible = true;
            txtCheckEmail.Visible = true;
            btnCheckEmail.Visible = true;
            txtPassForget.Visible = false;
            txtRePassForget.Visible = false;
            btnConfirm.Visible = false;
            txtValidateCode.Visible = false;
            lblBack.Visible = false;
            transitionPanel.ShowSync(pnlForgetPass);
            this.AcceptButton = this.btnCheckEmail;
            txtCheckEmail.Text = "";
            ClearTextBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pnlForgetPass.Visible = false;
            pnlUserLogin.Visible = true;
            pnlSignup.Visible = false;
            transitionPanel.ShowSync(pnlUserLogin);
            this.AcceptButton = this.btnLogin;
            ClearTextBox();
        }

        private void btnCheckEmail_Click(object sender, EventArgs e)
        {
            int idUser = ManageSystem.SearchEmail(txtCheckEmail.Text);
            if (idUser == -1) MessageBox.Show("Email không tồn tại!", "Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {

                txtPassForget.Visible = true;
                txtRePassForget.Visible = true;
                txtValidateCode.Visible = true;
                lblBack.Visible = true;
                btnConfirm.Visible = true;
                txtCheckEmail.Visible = false;
                btnCheckEmail.Visible = false;
                this.AcceptButton = this.btnConfirm;
                ClearTextBox();
                string code = GenerateCode();
                string tk = "vocabularyup1903";
                string mk = "123456789vn";
                string port = "587";
                string SMTP = "smtp.gmail.com";
                string Messge = "Mã xác nhận của bạn là : " + code;
                string To = txtCheckEmail.Text;
                string cc = "";
                string subject = "Your Code";
                //     txtMessage.Text = "Mã xác nhận của bạn là : " + code.ToString();
                login = new NetworkCredential(tk, mk);
                client = new SmtpClient(SMTP);
                client.Port = Convert.ToInt32(port);
                client.EnableSsl = checkBox.Checked;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress(tk + SMTP.Replace("smtp.", "@"), "Trung tâm Vocabulary-Up", Encoding.UTF8) };
                msg.To.Add(new MailAddress(To));
                if (!string.IsNullOrEmpty(cc))
                    msg.To.Add(new MailAddress(cc));
                msg.Subject = subject;
                msg.Body = Messge;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendOrPostCallback);
                string userstate = "Sending...";
                client.SendAsync(msg, userstate);
                verifiedCode = code;
                countDown.Start();
                countDownText.Start();
                btnCheckEmail.Enabled = false;
            }
        }

        private void ClearForget()
        {
            txtPassForget.Text = "";
            txtRePassForget.Text = "";
            txtValidateCode.Text = "";

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            txtPassForget.Visible = false;
            txtRePassForget.Visible = false;
            txtValidateCode.Visible = false;
            lblBack.Visible = false;
            btnConfirm.Visible = false;
            txtCheckEmail.Visible = true;
            btnCheckEmail.Visible = true;
            this.AcceptButton = this.btnCheckEmail;
            ClearForget();
        }

        public string GenerateCode()
        {
            string code = "";
            char c;
            var random = new Random();

            var rd = new Random();

            for (int i = 0; i < 6; i++)
            {
                int n = rd.Next(1, 3);
                switch (n)
                {
                    case 2:
                        c = Convert.ToChar(Convert.ToInt32(random.Next(65, 90)));
                        code = code + c.ToString();
                        break;
                    case 1:
                        c = Convert.ToChar(Convert.ToInt32(random.Next(48, 57)));
                        code = code + c.ToString();
                        break;
                    default:
                        break;
                }
            }
            return code;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (txtRePassForget.Text != txtPassForget.Text) 
                MessageBox.Show("Nhập lại mật khẩu không chính xác!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtValidateCode.Text != verifiedCode) 
                MessageBox.Show("Mã xác nhận không chính xác !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ManageSystem.UpdateNewPassword(ManageSystem.GetUserID_Email(txtCheckEmail.Text), txtPassForget.Text);
                ManageSystem.UpdateNewPasswordToDatabase(ManageSystem.GetUserID_Email(txtCheckEmail.Text), txtPassForget.Text);
                MessageBox.Show("du ma m xong r do !");
                pnlForgetPass.Visible = false;
                pnlUserLogin.Visible = true;
                pnlSignup.Visible = false;
                transitionPanel.HideSync(pnlSignup);
                this.AcceptButton = this.btnLogin;
                ClearTextBox();
            }
            
        }

        private static void SendOrPostCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(String.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(String.Format("{0} {1} ", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your message has been successsfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void countDown_Tick(object sender, EventArgs e)
        {
            btnCheckEmail.Enabled = true;
            lbCountDown.Hide();
            iCountDown = 5;
            countDown.Stop();
            countDownText.Stop();
        }

        private void CountDownLabel()
        {
            iCountDown--;
            lbCountDown.Text = "Please wait " + iCountDown.ToString();
        }

        private void countDownText_Tick(object sender, EventArgs e)
        {   
            if (btnCheckEmail.Visible == true)
                lbCountDown.Show();
            CountDownLabel();

        }
    }
}

