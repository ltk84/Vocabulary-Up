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
            txtNewPass.Text = "";
            txtRePass.Text = "";
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
            pnlEdit.Visible = false;
            pnlEdit.Enabled = false;
            pnlPersonalDetails.Visible = true;
            pnlPersonalDetails.Enabled = true;
            pnlSavePass.Visible = false;
            pnlSavePass.Enabled = false;

            this.AcceptButton = this.btEditProfile;
            ClearTextbox();
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
}
