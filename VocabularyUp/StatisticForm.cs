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
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        bool darkMode = false;
        public StatisticForm()
        {
            InitializeComponent();
            darkMode = ManageUserAction.GetDarkMode();
            if (darkMode)
                UpdateTheme();
            ToStatisticInfo();
            update();
        }
        
        private void UpdateTheme()
        {
            this.BackColor = primary;
            this.guna2CustomGradientPanel1.BackColor = primary;
            this.guna2CustomGradientPanel1.FillColor = primary;
            this.guna2CustomGradientPanel1.FillColor2 = primary;
            this.guna2CustomGradientPanel1.FillColor3 = primary;
            this.guna2CustomGradientPanel1.FillColor4 = primary;
            this.pnlShowStatistic.BackColor = primary;
            this.guna2CustomGradientPanel2.FillColor = secondary;
            this.guna2CustomGradientPanel2.FillColor2 = secondary;
            this.guna2CustomGradientPanel2.FillColor3 = secondary;
            this.guna2CustomGradientPanel2.FillColor4 = secondary;
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
