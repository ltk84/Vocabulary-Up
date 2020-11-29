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
    public partial class StatisticInfoForm : Form
    {
        public StatisticInfoForm()
        {
            InitializeComponent();
        }


        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void ClearTextbox()
        {
            txtDate.Text = "";
            txtGioiTinh.Text = "";
            txtHoTen.Text = "";
            txtOldPass.Text = "";
            txtNewPass.Text = "";
        }
        private void btEditProfile_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlEdit.Enabled = true;
            pnlPersonalDetails.Visible = false;
            pnlPersonalDetails.Enabled = false;
            pnlSavePass.Visible = false;
            pnlSavePass.Enabled = false;
           
            this.AcceptButton = this.btnSaveEdit;
            ClearTextbox();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtDate.Text == "" || txtGioiTinh.Text == "")
                MessageBox.Show("bạn vui lòng điền đẩy đủ thông tin");
            else
            {

                pnlEdit.Visible = false;
                pnlEdit.Enabled = false;
                pnlPersonalDetails.Visible = true;
                pnlPersonalDetails.Enabled = true;
                pnlSavePass.Visible = false;
                pnlSavePass.Enabled = false;

                this.AcceptButton = this.btEditProfile;
                ClearTextbox();
            }
        }

        private void btChangePass_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            pnlEdit.Enabled = false;
            pnlPersonalDetails.Visible = false;
            pnlPersonalDetails.Enabled = false;
            pnlSavePass.Visible = true;
            pnlSavePass.Enabled = true;

            this.AcceptButton = this.btSavePassword;
            ClearTextbox();
        }

        private void btSavePassword_Click(object sender, EventArgs e)
        {
            
            if (txtOldPass.Text == "") MessageBox.Show("Password can not be empty");
            else if (ManageSystem.Pass(txtOldPass.Text)) { MessageBox.Show("Old password is not correct", "Thông báo"); }
            else if (txtNewPass.Text == "") MessageBox.Show("Password can not be empty");
            else if (txtNewPass.Text != txtReNewPass.Text) MessageBox.Show("Re-Password is not correct");
            else
            {
                string TK = ManageSystem.TK();
                ManageSystem.UpdateNewPassword(ManageSystem.GetUserID(TK), txtNewPass.Text);
                ManageSystem.UpdateNewPasswordToDatabase(ManageSystem.GetUserID(TK), txtNewPass.Text);
                ManageSystem.UpdatePass(txtNewPass.Text);
                MessageBox.Show("Save success!");
                pnlEdit.Visible = false;
                pnlEdit.Enabled = false;
                pnlPersonalDetails.Visible = true;
                pnlPersonalDetails.Enabled = true;
                pnlSavePass.Visible = false;
                pnlSavePass.Enabled = false;

                this.AcceptButton = this.btEditProfile;
                ClearTextbox();

            }                

        }

        private void pnlSavePass_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
