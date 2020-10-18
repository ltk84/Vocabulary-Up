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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        public void UpdateInfo(string name, string email, DateTime beginDate, int total)
        {
            lbName.Text = name;
            lbEmail.Text = email;
            lbBeginDate.Text = beginDate.ToString();
            lbTotal.Text = total.ToString();
        }
    }
}
