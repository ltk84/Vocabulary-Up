﻿using System;
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
        public StatisticForm()
        {
            InitializeComponent();

            ToStatisticInfo();
        }
        StatisticInfoForm statisticInfo = new StatisticInfoForm();
        StatisticResultForm statisticResult = new StatisticResultForm();
        private void ToStatisticInfo()
        {
            
            statisticInfo.TopLevel = false;
            pnlShowStatistic.Controls.Clear();
            pnlShowStatistic.Controls.Add(statisticInfo);
            statisticInfo.Show();
        }

        private void ToStatisticResult()
        {
            statisticResult.TopLevel = false;
            pnlShowStatistic.Controls.Clear();
            pnlShowStatistic.Controls.Add(statisticResult);
            statisticResult.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ToStatisticInfo();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            ToStatisticResult();
        }

        private void UpdateStatistic(string name, DateTime beginDate)
        {
            lblBeginDate.Text = beginDate.ToString();
            lblTen.Text = name;
        }
    }
}
