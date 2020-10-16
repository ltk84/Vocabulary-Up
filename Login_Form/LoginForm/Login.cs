using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            pnSignup.Visible = true;
            pnLogin.Visible = false;
            guna2Transition1.ShowSync(pnSignup);
            this.AcceptButton = this.btCreate;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            pnSignup.Visible = false;
            pnLogin.Visible = true;
            guna2Transition1.HideSync(pnSignup);
            this.AcceptButton = this.btLogin;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký thành công!", "Thông báo");
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng Nhập thành công!", "Thông báo");
        }
    }
}
