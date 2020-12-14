﻿using System;
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
    public partial class RevisionForm : Form
    {
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        ShopForm shop;
        int currentChar = 0;
        public RevisionForm()
        {
            InitializeComponent();
            UpdateTheme();
            ManageUserAction.UpdateOwnCharacter();
            if (ManageUserAction.GetOwnCharacterList().Count == 1)
            {
                btnNext.Enabled = false;
            }
           
            LoadPictureBoxCharacter(currentChar);
            shop = new ShopForm(this.pnlChoosePlay);
            LoadDiamondLabel();
        }

        private void UpdateTheme()
        {
            this.BackColor = primary;
            this.pnlRevision.BackColor = primary;
        }

        public void LoadShop()
        {
            this.pnlChoosePlay.Hide();
            shop.TopLevel = false;
            shop.FormBorderStyle = FormBorderStyle.None;
            this.pnlRevision.Controls.Add(shop);
            shop.Show();
            //this.Parent.Show();
           
            //HideMenu();
        }

        public void LoadPictureBoxCharacter(int currentChar)
        {
            int idChar = ManageUserAction.GetOwnCharacterList()[currentChar].ID;
            pbCharacter.Image = Image.FromFile("../../db/Characters/" + idChar.ToString() + ".png");
            Changelabel(ManageUserAction.GetOwnCharacterList()[currentChar].Name);
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
            if (currentChar == ManageUserAction.GetOwnCharacterList().Count - 1 && btnToggle.Text == "1")
            {
                btnNext.Enabled = true;
                btnToggle.Text = "0";
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

        private void pnlType_3_Click(object sender, EventArgs e)
        {
            pnlType_1.BorderThickness = 0;
            pnlType_2.BorderThickness = 0;
            pnlType_3.BorderThickness = 5;
        }

        private void pnlType_2_Click(object sender, EventArgs e)
        {
            pnlType_1.BorderThickness = 0;
            pnlType_2.BorderThickness = 5;
            pnlType_3.BorderThickness = 0;
        }

        private void pnlType_1_Click(object sender, EventArgs e)
        {
            pnlType_1.BorderThickness = 5;
            pnlType_2.BorderThickness = 0;
            pnlType_3.BorderThickness = 0;
        }

        private void btnChooseType_Click(object sender, EventArgs e)
        {
            pnlType.Show();
            btnChooseType.Hide();
            btnStart.Show();
            btnBack.Show();
        }

        private void lbMaze_Click(object sender, EventArgs e)
        {
            pnlType_1_Click(sender, e);
        }

        private void lbWalkthrough_Click(object sender, EventArgs e)
        {
            pnlType_2_Click(sender, e);
        }

        private void lbChallenge_Click(object sender, EventArgs e)
        {
            pnlType_3_Click(sender, e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlType.Hide();
            btnChooseType.Show();
            btnStart.Hide();
            btnBack.Hide();
        }
    }
}
