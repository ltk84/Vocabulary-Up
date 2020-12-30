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
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        bool darkMode = false;
        public StatisticInfoForm()
        {
            InitializeComponent();
            darkMode = ManageUserAction.GetDarkMode();
            if (darkMode)
                UpdateTheme();
            Update();
            Level();
        }
        private void UpdateTheme()
        {
            this.guna2CustomGradientPanel1.BackColor = primary;
            this.guna2CustomGradientPanel1.FillColor = secondary;
            this.guna2CustomGradientPanel1.FillColor2 = secondary;
            this.guna2CustomGradientPanel1.FillColor3 = secondary;
            this.guna2CustomGradientPanel1.FillColor4 = secondary;
            this.guna2CustomGradientPanel2.BackColor = primary;
            this.guna2CustomGradientPanel2.FillColor = secondary;
            this.guna2CustomGradientPanel2.FillColor2 = secondary;
            this.guna2CustomGradientPanel2.FillColor3 = secondary;
            this.guna2CustomGradientPanel2.FillColor4 = secondary;
            this.guna2CustomGradientPanel3.BackColor = primary;
            this.guna2GradientPanel3.BackColor = secondary;
            this.guna2GradientPanel4.BackColor = secondary;
            this.btnSaveEdit.FillColor = primary;
            this.btSavePassword.FillColor = primary;
            this.btEditProfile.FillColor = primary;
            this.guna2Button2.FillColor = primary;
            this.guna2Button1.FillColor = primary;
            this.btChangePass.FillColor = primary;
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
            int a = ManageUserAction.GetItemOfAllCollection(0).ListFL.Count();

            int Level, Percent;

            Level = a / 50;
            Percent = a % 50;

            lbLevel.Text = Level.ToString();
            pbLevel.Value = Percent * 2;

            if (Level <= 1)
            {
                lbCapBac.Text = "Beginner";
                imageLevel.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Rankings/Iron 1.png");
            }
            else if (Level == 2)
            {
                lbCapBac.Text = "High Beginner";
                imageLevel.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Rankings/Iron 3.png");
            }
            else if (Level == 3)
            {
                lbCapBac.Text = "Low Intermediate";
                imageLevel.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Rankings/Bronze 3.png");
            }
            else if (Level == 4)
            {
                lbCapBac.Text = "Intermediate";
                imageLevel.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Rankings/Silver 3.png");
            }
            else if (Level == 5)
            {
                lbCapBac.Text = "High Intermediate";
                imageLevel.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Rankings/Gold 3.png");
            }
            else if (Level == 6)
            {
                lbCapBac.Text = "Low Advanced";
                imageLevel.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Rankings/Platinum 3.png");
            }
            else if (Level == 7)
            {
                lbCapBac.Text = "Advanced";
                imageLevel.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Rankings/Diamond 3.png");
            }
            else if (Level == 8)
            {
                lbCapBac.Text = "Master";
                imageLevel.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Rankings/Immortal 3.png");
            }
            else if (Level > 8)
            { 
                lbCapBac.Text = "Challenge";
                imageLevel.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Rankings/Master Vocab.png");
            }

        }
       
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
                MessageBox.Show("Please fill in all the information!");
            else
            {
                if (CheckValidName(txtHoTen.Text))
                {
                    string gender = "";
                    if (rbNam.Checked == true && rbNu.Checked == false)
                        gender = "Nam";
                    else if (rbNam.Checked == false && rbNu.Checked == true)
                        gender = "Nữ";
                    else
                        gender = "Bê đê";
                    string TK = ManageSystem.TK();
                    int ID = ManageSystem.GetUserID(TK);
                    ManageSystem.AddInfoPersonal(ID, dtpNgaySinh.Value.ToString("dd/MM/yyyy"), txtHoTen.Text, gender);
                    MessageBox.Show("Save Succes!");
                    pnlEdit.Visible = false;
                    pnlEdit.Enabled = false;
                    pnlPersonalDetails.Visible = true;
                    pnlPersonalDetails.Enabled = true;
                    pnlSavePass.Visible = false;
                    pnlSavePass.Enabled = false;
                    Update();
                }    
                else
                {
                    MessageBox.Show("Name has invalid character and number!");
                }
                ClearTextbox();
            }
        }

        private bool CheckValidName(string str)
        {
            string invalid = ".,:;`'/+-(){}[]<>*&^%$#@!?~/\\=\t\n1234567890";
            for (int i = 0; i < invalid.Length; i++)
            {
                if (str.Contains(invalid[i]))
                    return false;
            }
            return true;
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
            if (txtOldPass.Text == "") 
                MessageBox.Show("Password can not be empty");
            else if (ManageSystem.CheckStringIfValid(txtOldPass.Text))
                MessageBox.Show("Password can not have invalid character");
            else if (ManageSystem.CheckStringIfValid(txtNewPass.Text))
                MessageBox.Show("Password can not have invalid character");
            else
            {
                string ePassword = ManageSystem.EncryptPassword(txtOldPass.Text);
                if (!ManageSystem.Pass(ePassword)) { MessageBox.Show("Old password is not correct", "Thông báo"); }
                else if (txtNewPass.Text == "") MessageBox.Show("Password can not be empty");
                else if (txtNewPass.Text != txtReNewPass.Text) MessageBox.Show("Re-Password is not correct");
                else if (txtNewPass.Text == txtOldPass.Text) MessageBox.Show("The new password is the same as the old password");
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
