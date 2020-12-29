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
    public partial class ItemForm : Form
    {
        ShopForm shop; 
        bool darkMode = false;
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        Color foreColor = Color.White;

        public ItemForm(ShopForm shop)
        {
            InitializeComponent();
            darkMode = ManageUserAction.GetDarkMode();
            UpdateTheme();
            this.shop = shop;
        }

        private void UpdateTheme()
        {
            if (darkMode)
            {
                primary = Color.FromArgb(50, 74, 95);
                secondary = Color.FromArgb(27, 42, 65);
                foreColor = Color.White;
            }
            else
            {
                primary = Color.FromArgb(17, 223, 158);
                secondary = Color.FromArgb(7, 96, 68);
                foreColor = Color.Black;
            }
            this.pnlItem.FillColor = primary;
            this.pnlItem.FillColor2 = primary;
            this.pnlItem.FillColor3 = primary;
            this.pnlItem.FillColor4 = primary;
            this.pnlItem.BorderColor = secondary;
            this.lbName.ForeColor = foreColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPrice.Text);
            if (shop.GetCurrentDiamond() >= price)
            {
                ManageUserAction.AddToOwnCharacterList(lbName.Text);
                shop.LoadAllCharacter();
                shop.UpdateDiamond(price);
            }
            else
            {
                MessageBox.Show("Not enough diamond!");
            }
        }

        public void ChangeInfo(int id, string name, int price)
        {
            string link = @ConfigurationManager.AppSettings.Get("imgPath_database") + "Characters/" + id.ToString() + ".png";
            Image image = Image.FromFile(link);
            pbChar.Image = image;
            lbName.Text = name;
            lbPrice.Text = price.ToString();
        }

        public void ChangeStatus()
        {
            btnBuy.Enabled = false;
            lbOwned.Visible = true;
        }
    }
}
