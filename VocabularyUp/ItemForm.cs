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
            MessageBox.Show(this.lbName.Text);
            ManageUserAction.AddToOwnCharacterList(lbName.Text);
            shop.LoadShop();
        }

        public void ChangeInfo(int id, string name, int price)
        {
            string link = "../../db/Characters/" + id.ToString() + ".png";
            Image image = Image.FromFile(link);
            pbChar.Image = image;
            lbName.Text = name;
            lbPrice.Text = price.ToString();
        }
    }
}
