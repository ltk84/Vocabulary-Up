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
    public partial class CustomizeDialog : Form
    {
        NavForm parent = new NavForm();
        public CustomizeDialog(NavForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            parent.ChangeTheme(btnTbColor.FillColor, btnPriColor.FillColor, btnSecColor.FillColor);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTbColor_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            btnTbColor.FillColor = colorPicker.Color;
        }

        private void btnPriColor_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            btnPriColor.FillColor = colorPicker.Color;
        }

        private void btnSecColor_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            btnSecColor.FillColor = colorPicker.Color;
        }
    }
}
