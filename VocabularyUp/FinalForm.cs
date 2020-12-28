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
    public partial class FinalForm : Form
    {
        Panel panel;
        public FinalForm(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.panel.Show();
        }
    }
}
