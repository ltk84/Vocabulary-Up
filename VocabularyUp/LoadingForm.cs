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
    public partial class LoadingForm : Form
    {
        int ID;
        UserAccessForm userAccess;
        public LoadingForm(UserAccessForm userAccess, int CurrentID)
        {
            this.ID = CurrentID;
            this.userAccess = userAccess;
            InitializeComponent();
            timer1.Start();
            this.DoubleBuffered = true;
        }



        private void Timer_Tick(object sender, EventArgs e)
        {

            pbLoading.Value += 1;
            lbPercentLoading.Text = pbLoading.Value.ToString();
            if (pbLoading.Value == 100)
            {
                ToNavTab(ID);
                this.Close();
            }

        }
        private void ToNavTab(int currentID)
        {

            NavForm navTab = new NavForm(userAccess, currentID);
            navTab.Show();
            this.Hide();

        }
    }
}
