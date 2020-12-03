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
        public ResultForm(int correct, int wrong)
        {
            InitializeComponent();
            this.correctAns = correct;
            this.wrongAns = wrong;
        }

        public void ChangeLabel()
        {
            lbCorrect.Text = correctAns.ToString();
            lbWrong.Text = wrongAns.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
