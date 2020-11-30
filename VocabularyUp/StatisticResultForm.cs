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
    public partial class StatisticResultForm : Form
    {
        public StatisticResultForm()
        {
            InitializeComponent();
            UpdateInfoResult();
        }

        private void UpdateInfoResult()
        {
            string TK = ManageSystem.TK();
            int ID = ManageSystem.GetUserID(TK);
            List<string> a = ManageSystem.UserInfoPersonal(ID);
            lbTotal.Text = a[5];
            lbHightest.Text = a[6];
            lbRecent.Text = a[7];
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pbar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
