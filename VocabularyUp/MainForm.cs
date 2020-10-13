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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void ChangeTheme(Color primaryColor, Color secondaryColor)
        {
            this.BackColor = primaryColor;
            this.pnlMain.BackColor = primaryColor;
            this.pnlDash.BackColor = primaryColor;
        }
    }
}
