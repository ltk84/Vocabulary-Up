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
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        bool darkMode = false;
        Panel panel;
        public ShopForm(Panel p)
        {
            InitializeComponent();
            darkMode = ManageUserAction.GetDarkMode();
            if (darkMode)
                UpdateTheme();
            ManageSystem.LoadCharacter();
            LoadAllCharacter();
            this.panel = p;
            LoadDiamondLabel();
        }
        private void UpdateTheme()
        {
            this.BackColor = primary;
            this.pnlShop.BackColor = primary;
            this.btnExit.FillColor = primary;
        }

        

        public void LoadAllCharacter()
        {
            this.flpShop.Controls.Clear();
            foreach (var character in ManageSystem.GetAllCharacter())
            {  
                ItemForm item = new ItemForm(this);
                item.ChangeInfo(character.ID, character.Name, character.Price);
                item.TopLevel = false;
                item.FormBorderStyle = FormBorderStyle.None;
                item.Show();
                if (ManageUserAction.CheckExistCharacter(character))
                {
                    item.ChangeStatus();
                }
                flpShop.Controls.Add(item);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel.Controls[0].Text = "1";
            panel.Show();
        }

        private void LoadDiamondLabel()
        {
            ManageUserAction.LoadCurrency();
            lbDiamond.Text = ManageUserAction.GetDiamond().ToString();
        }

        public int GetCurrentDiamond()
        {
            try
            {
                return Int32.Parse(lbDiamond.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateDiamond(int num)
        {
            ManageUserAction.UpdateDiamondAfterBuy(num);
            LoadDiamondLabel();
        }
    }
}
