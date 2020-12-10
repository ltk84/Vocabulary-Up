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
        public ShopForm()
        {
            InitializeComponent();
            ManageSystem.LoadCharacter();
            LoadShop();
        }

        public void LoadShop()
        {
            foreach (var character in ManageSystem.GetAllCharacter())
            {
                ItemForm item = new ItemForm();
                item.ChangeInfo(character.ID, character.Name, character.Price);
                item.TopLevel = false;
                item.FormBorderStyle = FormBorderStyle.None;
                item.Show();
                flpShop.Controls.Add(item);
            }

        }
    }
}
