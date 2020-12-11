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
        ShopForm shop;
        int currentChar = 0;
        public RevisionForm()
        {
            InitializeComponent();
            ManageUserAction.UpdateOwnCharacter();
            LoadPictureBoxCharacter(currentChar);
            shop = new ShopForm(this.pnlChoosePlay);
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

        private void HideMenu()
        {
            btnShop.Hide();
            pbCharacter.Hide();
            btnNext.Hide();
            btnPrevious.Hide();
            lbName.Hide();
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
        }
    }
}
