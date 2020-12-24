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
        public ItemForm(ShopForm shop)
        {
            InitializeComponent();
            this.shop = shop;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPrice.Text);
            if (shop.GetCurrentDiamond() >= price)
            {
                MessageBox.Show(this.lbName.Text);
                ManageUserAction.AddToOwnCharacterList(lbName.Text);
                //shop.LoadShop();
                shop.LoadAllCharacter();
                shop.UpdateDiamond(price);
            }
            else
            {
                MessageBox.Show("Khong du tien kia thang loz !");
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
