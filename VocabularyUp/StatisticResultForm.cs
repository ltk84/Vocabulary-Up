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
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        bool darkMode = false;
        public StatisticResultForm()
        {
            InitializeComponent();
            darkMode = ManageUserAction.GetDarkMode();
            if (darkMode)
                UpdateTheme();
            UpdateInfoResult();
        }

        private void UpdateTheme()
        {
            this.guna2CustomGradientPanel1.BackColor = primary;
            this.guna2CustomGradientPanel1.FillColor = secondary;
            this.guna2CustomGradientPanel1.FillColor2 = secondary;
            this.guna2CustomGradientPanel1.FillColor3 = secondary;
            this.guna2CustomGradientPanel1.FillColor4 = secondary;
            this.guna2CustomGradientPanel2.BackColor = primary;
            this.guna2CustomGradientPanel5.FillColor = secondary;
            this.guna2CustomGradientPanel5.FillColor2 = secondary;
            this.guna2CustomGradientPanel5.FillColor3 = secondary;
            this.guna2CustomGradientPanel5.FillColor4 = secondary;
            this.guna2GradientPanel2.BackColor = secondary;
            this.guna2GradientPanel3.BackColor = secondary;
            this.guna2GradientPanel4.BackColor = secondary;
        }

        public void UpdateInfoResult()
        {
            string TK = ManageSystem.TK();
            int ID = ManageSystem.GetUserID(TK);
            List<string> a = ManageSystem.UserInfoPersonal(ID);
            lbTotal.Text = a[5];

            //
            lbTotal.Text = ManageUserAction.GetItemOfAllCollection(0).ListFL.Count().ToString();
            lbLearned.Text = lbTotal.Text;
            lbToLearn.Text = (ManageSystem.CountAllFlashCards() - ManageUserAction.GetItemOfAllCollection(0).ListFL.Count()).ToString();
            pbAnimals.Value = ManageUserAction.CalculateProgress(1,ID);
            pbPlants.Value = ManageUserAction.CalculateProgress(2, ID);
            pbFruits.Value = ManageUserAction.CalculateProgress(3, ID);
            pbJob.Value = ManageUserAction.CalculateProgress(4, ID);
            pbFoodaDrinks.Value = ManageUserAction.CalculateProgress(5, ID);
            pbSport.Value = ManageUserAction.CalculateProgress(6, ID);
            pbClothing.Value = ManageUserAction.CalculateProgress(7, ID);
            pbTechnology.Value = ManageUserAction.CalculateProgress(8, ID);
        }

    }
}
