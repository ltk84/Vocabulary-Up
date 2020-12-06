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
        List<UserChoice> userChoices;
        List<string> correctAns = new List<string>();
        List<string> wrongAns = new List<string>();
        Panel panel;
        public ResultForm(List<UserChoice> userChoices,  Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.userChoices = userChoices;
        }

        public void ChangeLabel()
        {
            int correct = 0, wrong = 0;
            foreach (var choice in userChoices)
            {
                if (choice.Selected == choice.Correct)
                {
                    correct++;
                    correctAns.Add(choice.CorrectAns);
                }
                else
                {
                    wrong++;
                    wrongAns.Add(choice.CorrectAns);
                }
            }

            lbCorrect.Text = correct.ToString();
            lbWrong.Text = wrong.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            this.panel.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            DetailsForm details = new DetailsForm(this);
            details.TopLevel = false;
            this.pnlResultForm.Hide();
            this.Controls.Add(details);
           // details.TopMost = true;
            details.FormBorderStyle = FormBorderStyle.None;
            details.Show();
        }

        public void ProShow()
        {
            this.pnlResultForm.Show();
        }

        public List<string> GetCorrectAnsList()
        {
            return correctAns;
        }

        public List<string> GetWrongAnsList()
        {
            return wrongAns;
        }
    }
}
