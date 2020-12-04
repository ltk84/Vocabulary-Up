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
    public partial class ResultForm : Form
    {
        int correctAns;
        int wrongAns;
        Panel panel;
        public ResultForm(int correct, int wrong, Panel panel)
        {
            InitializeComponent();
            this.correctAns = correct;
            this.wrongAns = wrong;
            this.panel = panel;
        }

        public void ChangeLabel()
        {
            lbCorrect.Text = correctAns.ToString();
            lbWrong.Text = wrongAns.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            this.panel.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //DetailsForm details = new DetailsForm();
            //details.TopLevel = false;
            //this.Controls.Add(details);
            //details.FormBorderStyle = FormBorderStyle.None;
            //details.Show();
            ////this.Hide();
        }
    }
}
