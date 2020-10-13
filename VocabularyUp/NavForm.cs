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
    public partial class NavForm : Form
    {
        MainForm mainTab = new MainForm();
        ReviseForm reviseTab = new ReviseForm();
        public NavForm()
        {
            InitializeComponent();
            ToMainTab();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToMainTab()
        {
            mainTab.TopLevel = false;
            pnlTab.Controls.Clear();
            pnlTab.Controls.Add(mainTab);
            mainTab.FormBorderStyle = FormBorderStyle.None;
            mainTab.Show();
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            ToReviseTab();
        }

        private void ToReviseTab()
        {
            reviseTab.TopLevel = false;
            pnlTab.Controls.Clear();
            pnlTab.Controls.Add(reviseTab);
            reviseTab.FormBorderStyle = FormBorderStyle.None;
            reviseTab.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            ToMainTab();
        }
    }
}
