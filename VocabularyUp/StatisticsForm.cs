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
        public void ChangeTheme(Color primaryColor, Color secondaryColor)
        {
            this.BackColor = primaryColor;
            this.pnlStatistics.BackColor = primaryColor;
            this.pnlDash.BackColor = primaryColor;

            this.pnlBody_1.FillColor = primaryColor;
            this.pnlBody_1.FillColor2 = primaryColor;
            this.pnlBody_1.FillColor3 = primaryColor;
            this.pnlBody_1.FillColor4 = primaryColor;
            this.pnlBody_1_a.BackColor = primaryColor;
            this.pnlBody_1_b.BackColor = primaryColor;

            this.pnlBody_2.FillColor = primaryColor;
            this.pnlBody_2.FillColor2 = primaryColor;
            this.pnlBody_2.FillColor3 = primaryColor;
            this.pnlBody_2.FillColor4 = primaryColor;
            this.pnlBody_2_a.BackColor = primaryColor;
            this.pnlBody_2_b.BackColor = primaryColor;

            this.pnlHeader_1.FillColor = secondaryColor;
            this.pnlHeader_1.FillColor2 = secondaryColor;
            this.pnlHeader_1.FillColor3 = secondaryColor;
            this.pnlHeader_1.FillColor4 = secondaryColor;

            this.pnlHeader_2.FillColor = secondaryColor;
            this.pnlHeader_2.FillColor2 = secondaryColor;
            this.pnlHeader_2.FillColor3 = secondaryColor;
            this.pnlHeader_2.FillColor4 = secondaryColor;
        }
    }
}
