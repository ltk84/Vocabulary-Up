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
    public partial class ShopForm : Form
    {
        Panel panel;
        public ShopForm(Panel p)
        {
            InitializeComponent();
            ManageSystem.LoadCharacter();
            LoadShop();
            this.panel = p;
        }

        public void LoadShop()
        {
            this.flpShop.Controls.Clear();
            foreach (var character in ManageSystem.GetAllCharacter())
            {
                if (!ManageUserAction.CheckExistCharacter(character))
                {
                    ItemForm item = new ItemForm(this);
                    item.ChangeInfo(character.ID, character.Name, character.Price);
                    item.TopLevel = false;
                    item.FormBorderStyle = FormBorderStyle.None;
                    item.Show();
                    flpShop.Controls.Add(item);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel.Show();
            panel.Controls[0].Text = "1";
            //this.Parent.Show();
            
        }
    }
}
