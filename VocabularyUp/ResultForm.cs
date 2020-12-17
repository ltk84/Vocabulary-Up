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
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        bool darkMode = false;
        List<UserChoice> userChoices;
        List<string> correctAns = new List<string>();
        List<string> wrongAns = new List<string>();
        Panel panel;
        public ResultForm(List<UserChoice> userChoices,  Panel panel)
        {
            InitializeComponent();
            darkMode = ManageUserAction.GetDarkMode();
            UpdateTheme();
            this.panel = panel;
            this.userChoices = userChoices;
        }
        private void UpdateTheme()
        {
            if (darkMode)
            {
                primary = Color.FromArgb(50, 74, 95);
                secondary = Color.White;
            }
            else
            {
                primary = Color.FromArgb(17, 223, 158);
                secondary = Color.FromArgb(7, 96, 68);
            }
            this.pnlResultForm.BackColor = primary;
            this.btnDetails.FillColor = primary;
            this.btnOK.FillColor = primary;
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
