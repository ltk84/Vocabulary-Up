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
    public partial class StatisticForm : Form
    {
        StatisticInfoForm statisticInfo = new StatisticInfoForm();
        StatisticResultForm statisticResult = new StatisticResultForm();
        public StatisticForm()
        {
            InitializeComponent();
            ToStatisticInfo();
            update();
        }
        
        
        public void update()
        {
            string TK = ManageSystem.TK();
            int ID = ManageSystem.GetUserID(TK);
            List<string> a = ManageSystem.UserInfoPersonal(ID);
            lblTen.Text = a[1];
            lblBeginDate.Text = a[4];
            statisticResult.UpdateInfoResult();
        }
        private void ToStatisticInfo()
        {
            dashInfo.Show();
            dashResult.Hide();
            statisticInfo.TopLevel = false;
            pnlShowStatistic.Controls.Clear();
            pnlShowStatistic.Controls.Add(statisticInfo);
            statisticInfo.Show();
        }

        private void ToStatisticResult()
        {
            dashResult.Show();
            dashInfo.Hide();
            statisticResult.TopLevel = false;
            pnlShowStatistic.Controls.Clear();
            pnlShowStatistic.Controls.Add(statisticResult);
            statisticResult.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ToStatisticInfo();
            update();
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            ToStatisticResult();
            update();
        }

       
    }
}
