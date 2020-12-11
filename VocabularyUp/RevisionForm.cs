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
    public partial class RevisionForm : Form
    {
        ShopForm shop;
        public RevisionForm()
        {
            InitializeComponent();
            ManageUserAction.UpdateOwnCharacter();
            LoadPictureBoxCharacter();
            shop = new ShopForm(this.panel1);
        }

        public void LoadShop()
        {
            this.panel1.Hide();
            shop.TopLevel = false;
            shop.FormBorderStyle = FormBorderStyle.None;
            this.pnlRevision.Controls.Add(shop);
            shop.Show();
            //this.Parent.Show();
           
            //HideMenu();
        }

        public void LoadPictureBoxCharacter()
        {
            int idChar = ManageUserAction.GetOwnCharacterList()[0].ID;
            pbCharacter.Image = Image.FromFile("../../db/Characters/" + idChar.ToString() + ".png");
            Changelabel(ManageUserAction.GetOwnCharacterList()[0].Name);
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
    }
}
