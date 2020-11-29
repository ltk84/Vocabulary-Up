using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Configuration;

namespace VocabularyUp
{
    public partial class StatisticInfoForm : Form
    {
        public StatisticInfoForm()
        {
            InitializeComponent();
            Update();
            Level();
        }


        private void Update()
        {
            string TK = ManageSystem.TK();
            int ID = ManageSystem.GetUserID(TK);
            List<string> a = ManageSystem.UserInfoPersonal(ID);
            lblDate.Text = a[0];
            lblHoTen.Text = a[1];
            lblGioiTinh.Text = a[2];
            lblGmail.Text = a[3];

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
            txtReNewPass.Text = "";
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

        private void Level()
        {
            int  a =340;
           
            int Level, Percent;
            
            
            Level = a / 50;
            Percent = a % 50;
           
            lbLevel.Text = Level.ToString();
            pbLevel.Value = Percent * 2;
            if (Level == 1)
            {
                lbCapBac.Text = "Beginner";
                imageLevel.Image = Image.FromFile("../../Level/Beginner.PNG");
            }
            else if (Level == 2)
                lbCapBac.Text = "High Beginner";
            else if (Level == 3)
                lbCapBac.Text = "Low Intermediate";
            else if (Level == 4)
                lbCapBac.Text = "Intermediate";
            else if (Level == 5)
                lbCapBac.Text = "High Intermediate";
            else if (Level == 6)
            {
                lbCapBac.Text = "Low Advanced";
                imageLevel.Image = Image.FromFile("../../Level/LowAdvanced.PNG");
            }
            else if (Level == 7)
                lbCapBac.Text = "Advanced";
            else if (Level == 8)
                lbCapBac.Text = "Master";
            else if (Level > 8)
                lbCapBac.Text = "Challenge";
                
        }
       
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {

            if (txtHoTen.Text == "" || txtDate.Text == "" || txtGioiTinh.Text == "")
                MessageBox.Show("bạn vui lòng điền đẩy đủ thông tin");
            else
            {
                string TK = ManageSystem.TK();
                int ID = ManageSystem.GetUserID(TK);
                ManageSystem.AddInfoPersonal(ID,txtDate.Text,txtHoTen.Text,txtGioiTinh.Text);
                MessageBox.Show("Save Succes!");
                pnlEdit.Visible = false;
                pnlEdit.Enabled = false;
                pnlPersonalDetails.Visible = true;
                pnlPersonalDetails.Enabled = true;
                pnlSavePass.Visible = false;
                pnlSavePass.Enabled = false;
                Update();

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
            else
            {
                string ePassword = ManageSystem.EncryptPassword(txtOldPass.Text);
                if (!ManageSystem.Pass(ePassword)) { MessageBox.Show("Old password is not correct", "Thông báo"); }
                else if (txtNewPass.Text == "") MessageBox.Show("Password can not be empty");
                else if (txtNewPass.Text != txtReNewPass.Text) MessageBox.Show("Re-Password is not correct");
                else if (txtNewPass.Text == txtOldPass.Text) MessageBox.Show("Không được dùng mật khẩu củ");
                else
                {
                    string TK = ManageSystem.TK();

                    ManageSystem.UpdateNewPassword(ManageSystem.GetUserID(TK), txtNewPass.Text);
                    ManageSystem.UpdateNewPasswordToDatabase(ManageSystem.GetUserID(TK), txtNewPass.Text);

                    string ePassword1 = ManageSystem.EncryptPassword(txtNewPass.Text);
                    ManageSystem.UpdatePass(ePassword1);
                    MessageBox.Show("Save success!");
                    pnlEdit.Visible = false;
                    pnlEdit.Enabled = false;
                    pnlPersonalDetails.Visible = true;
                    pnlPersonalDetails.Enabled = true;
                    pnlSavePass.Visible = false;
                    pnlSavePass.Enabled = false;


                    ClearTextbox();

                }
            }
        }

        private void pnlSavePass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGmail_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void guna2Button2_Click(object sender, EventArgs e)
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
