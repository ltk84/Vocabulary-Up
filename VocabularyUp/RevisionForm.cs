using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    public partial class RevisionForm : Form
    {
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        bool darkMode = false;
        ShopForm shop;
        int currentChar = 0;
        int curentWeapon = 1;
        int type = 0;
        public RevisionForm()
        {
            InitializeComponent();
            darkMode = ManageUserAction.GetDarkMode();
            if (darkMode)
                UpdateTheme();
            ManageUserAction.UpdateOwnCharacter();
            if (ManageUserAction.GetOwnCharacterList().Count == 1)
            {
                btnNext.Enabled = false;
            }
           
            LoadPictureBoxCharacter(currentChar);
            LoadPictureBoxWeapon(curentWeapon);

            shop = new ShopForm(this.pnlChoosePlay);
            LoadDiamondLabel();
        }

        private void UpdateTheme()
        {
            this.BackColor = primary;
            this.pnlRevision.BackColor = primary;
            this.btnBack.FillColor = primary;
            this.btnStart.FillColor = primary;
            this.btnChooseType.FillColor = primary;
            this.btnShop.FillColor = primary;
            this.btnPrevious.FillColor = primary;
            this.btnNext.FillColor = primary;
            this.btnLeft2.FillColor = primary;
            this.btnRight2.FillColor = primary;
        }

        public void LoadShop()
        {
            this.pnlChoosePlay.Hide();
            shop.TopLevel = false;
            shop.FormBorderStyle = FormBorderStyle.None;
            this.pnlRevision.Controls.Add(shop);
            shop.Dock = DockStyle.Fill;
            shop.Show();
        }

        public void LoadPictureBoxCharacter(int currentChar)
        {
            int idChar = ManageUserAction.GetOwnCharacterList()[currentChar].ID;
            pbCharacter.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Characters/" + idChar.ToString() + ".png");
            Changelabel(ManageUserAction.GetOwnCharacterList()[currentChar].Name);
        }

        public void LoadPictureBoxWeapon(int idWeapon)
        {
            pbWeapon.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("ImgPath_database") + "Fires/" + idWeapon.ToString() + ".png");
        }

        public void Changelabel(string name)
        {
            if (name != "")
                lbName.Text = name;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            LoadShop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentChar == ManageUserAction.GetOwnCharacterList().Count - 1)
                return;

            if (btnPrevious.Enabled == false)
                btnPrevious.Enabled = true;

            currentChar++;

            if (currentChar == ManageUserAction.GetOwnCharacterList().Count - 1)
                btnNext.Enabled = false;

            LoadPictureBoxCharacter(currentChar);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentChar == 0)
                return;

            if (btnNext.Enabled == false)
                btnNext.Enabled = true;

            currentChar--;
            if (currentChar == 0)
                btnPrevious.Enabled = false;

            LoadPictureBoxCharacter(currentChar);
        }

        private void pnlChoosePlay_VisibleChanged(object sender, EventArgs e)
        {
            if (currentChar == ManageUserAction.GetOwnCharacterList().Count - 1)
            {
                btnNext.Enabled = true;
            }

            if (ManageUserAction.GetOwnCharacterList().Count > 1 && currentChar != ManageUserAction.GetOwnCharacterList().Count - 1)
            {
                btnNext.Enabled = true;
            }

            lbDiamond.Text = ManageUserAction.GetDiamond().ToString();

            pnlType.Hide();
            btnChooseType.Show();
            btnStart.Hide();
            btnBack.Hide();
        }

        private void LoadDiamondLabel()
        {
            ManageUserAction.LoadCurrency();
            lbDiamond.Text = ManageUserAction.GetDiamond().ToString();
        }

        private void pnlType_2_Click(object sender, EventArgs e)
        {
            pnlType_1.BorderThickness = 0;
            pnlType_2.BorderThickness = 5;
            type = 2;
        }

        private void pnlType_1_Click(object sender, EventArgs e)
        {
            pnlType_1.BorderThickness = 5;
            pnlType_2.BorderThickness = 0;
            type = 1;
        }

        private void btnChooseType_Click(object sender, EventArgs e)
        {
            if (ManageUserAction.GetItemOfAllCollection(0).ListFL.Count >= 20)
            {
                pnlType.Show();
                btnChooseType.Hide();
                btnStart.Show();
                lbNotification.Visible = false;
                btnBack.Show();
            }
            else
            {
                guna2Transition1.ShowSync(lbNotification);
                timer1.Start();
            }
        }

        private void lbMaze_Click(object sender, EventArgs e)
        {
            pnlType_2_Click(sender, e);
        }

        private void lbWalkthrough_Click(object sender, EventArgs e)
        {
            pnlType_1_Click(sender, e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (type == 0)
                return;

            if (type == 1)
            {
                WalkthroughForm wtf = new WalkthroughForm(0, ManageUserAction.GetOwnCharacterList()[currentChar].ID, curentWeapon);
                wtf.TopMost = true;
                wtf.Show();
                wtf.OpenTrashTalk(0, "Thằng rác rưởi, tránh ra!", "Bước qua xác tao này, thằng nhóc!");
            }
            else if (type == 2)
            {
                MazeGameFrom mgf = new MazeGameFrom(ManageUserAction.GetOwnCharacterList()[currentChar].ID);
                mgf.TopMost = true;
                mgf.Show();
                mgf.OpenTrashTalk(5, "Cái rương ở đâu?", "Bước qua xác ta đã!");

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlType.Hide();
            btnChooseType.Show();
            btnStart.Hide();
            btnBack.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbNotification.Hide();
            timer1.Stop();
        }

        private void btnRight2_Click(object sender, EventArgs e)
        {
            if (curentWeapon > 3)
                return;

            if (btnLeft2.Enabled == false)
                btnLeft2.Enabled = true;

            curentWeapon++;

            if (curentWeapon == 3)
                btnRight2.Enabled = false;

            LoadPictureBoxWeapon(curentWeapon);
        }

        private void btnLeft2_Click(object sender, EventArgs e)
        {
            if (curentWeapon < 1)
                return;

            if (btnRight2.Enabled == false)
                btnRight2.Enabled = true;

            curentWeapon--;

            if (curentWeapon == 1)
                btnLeft2.Enabled = false;

            LoadPictureBoxWeapon(curentWeapon);
        }
    }
}
