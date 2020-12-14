using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    public partial class CampaignForm : Form
    {
        int type = -1;
        int currentTopic = -1;
        int darkMode = 1;
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        Color foreColor = Color.White;
        public CampaignForm()
        {
            InitializeComponent();
            UpdateTheme();
            this.KeyPreview = true;
        }

        private void UpdateTheme()
        {
            if (darkMode == 1)
            {
                primary = Color.FromArgb(50, 74, 95);
                secondary = Color.FromArgb(27, 42, 65);
                foreColor = Color.White;
            }
            else
            {
                primary = Color.FromArgb(17, 223, 158);
                secondary = Color.FromArgb(7, 96, 68);
                foreColor = Color.Black;
            }    
            this.pnlTopicSelection.BackColor = primary;
            this.label3.ForeColor = primary;
            this.guna2CustomGradientPanel2.FillColor = primary;
            this.guna2CustomGradientPanel2.FillColor2 = primary;
            this.guna2CustomGradientPanel2.FillColor3 = primary;
            this.guna2CustomGradientPanel2.FillColor4 = primary;
            this.guna2CustomGradientPanel3.FillColor = primary;
            this.guna2CustomGradientPanel3.FillColor2 = primary;
            this.guna2CustomGradientPanel3.FillColor3 = primary;
            this.guna2CustomGradientPanel3.FillColor4 = primary;
            this.btnConfirm.FillColor = primary;
        }

        public int GetType()
        {
            return type;
        }

        private void Start()
        {
            FillBlankForm fillBQuiz = new FillBlankForm(currentTopic, this);

            if (fillBQuiz.result == 0)
            {
                FinalForm f = new FinalForm(pnlTopicSelection);
                f.TopLevel = false;
                pnlTopicSelection.Hide();
                pnlCampaignCate.Controls.Add(f);
                f.FormBorderStyle = FormBorderStyle.None;
                f.Show();
                this.Reset();
                return;
            }

            MultipleChoiceForm multiQuiz = new MultipleChoiceForm(currentTopic, this);
            LearningForm learning = new LearningForm(currentTopic, this, fillBQuiz, multiQuiz);

            

            learning.TopLevel = false;
            pnlTopicSelection.Hide();
            pnlCampaignCate.Controls.Add(learning);
            learning.FormBorderStyle = FormBorderStyle.None;
            learning.Show();
            learning.StartTimerLearning();

            if (type == 0)
            {
                fillBQuiz.TopLevel = false;
                pnlTopicSelection.Hide();
                pnlCampaignCate.Controls.Add(fillBQuiz);
                fillBQuiz.FormBorderStyle = FormBorderStyle.None;
                fillBQuiz.Show();
            }
            else
            {
                multiQuiz.TopLevel = false;
                pnlTopicSelection.Hide();
                pnlCampaignCate.Controls.Add(multiQuiz);
                multiQuiz.FormBorderStyle = FormBorderStyle.None;
                multiQuiz.Show();
            }
            
        }

        public void InitResult(List<UserChoice> userChoices)
        {
            ResultForm result = new ResultForm(userChoices, pnlTopicSelection);
            result.TopLevel = false;
            result.ChangeLabel();
            pnlCampaignCate.Controls.Add(result);
            result.FormBorderStyle = FormBorderStyle.None;
            result.TopMost = true;
            result.Show();
            pnlTopicSelection.Hide();
        }

        public void Reset()
        {
            type = -1;
            currentTopic = -1;
            ResetColorButton();
            btnMultipleChoice.FillColor = primary;
            lbMultipleChoice.BackColor = primary;
            lbMultipleChoice.ForeColor = foreColor;
            btnFilBlank.FillColor = primary;
            lbFillBlank.BackColor = primary;
            lbFillBlank.ForeColor = foreColor;
        }
        public void Return()
        {
            pnlTopicSelection.Show();
            Reset();
        }

        private void ResetColorButton()
        {
            btnAnimals.FillColor = primary;
            btnAnimals.ForeColor = foreColor;
            lbAnimals.BackColor = primary;
            lbAnimals.ForeColor = foreColor;

            btnPlants.FillColor = primary;
            btnPlants.ForeColor = foreColor;
            lbPlants.BackColor = primary;
            lbPlants.ForeColor = foreColor;

            btnSport.FillColor = primary;
            btnSport.ForeColor = foreColor;
            lbSport.BackColor = primary;
            lbSport.ForeColor = foreColor;

            btnTechnology.FillColor = primary;
            btnTechnology.ForeColor = foreColor;
            lbTechnology.BackColor = primary;
            lbTechnology.ForeColor = foreColor;

            btnJob.FillColor = primary;
            btnJob.ForeColor = foreColor;
            lbJob.BackColor = primary;
            lbJob.ForeColor = foreColor;

            btnFoodaDrinks.FillColor = primary;
            btnFoodaDrinks.ForeColor = foreColor;
            lbFoodaDrinks.BackColor = primary;
            lbFoodaDrinks.ForeColor = foreColor;

            btnFruits.FillColor = primary;
            btnFruits.ForeColor = foreColor;
            lbFruits.BackColor = primary;
            lbFruits.ForeColor = foreColor;

            btnClothing.FillColor = primary;
            btnClothing.ForeColor = foreColor;
            lbClothing.BackColor = primary;
            lbClothing.ForeColor = foreColor;
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            currentTopic = 1; 
            if (btnAnimals.FillColor == primary)
            {
                btnAnimals.FillColor = secondary;
                lbAnimals.BackColor = secondary;
                lbAnimals.ForeColor = Color.White;
                btnAnimals.ForeColor = Color.White;
            }
            
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnPlants.FillColor == primary)
            {
                btnPlants.FillColor = secondary;
                lbPlants.BackColor = secondary;
                lbPlants.ForeColor = Color.White;
                btnPlants.ForeColor = Color.White;
            }
            
            currentTopic = 2;
        }

        private void btnFruits_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnFruits.FillColor == primary)
            {
                btnFruits.FillColor = secondary;
                lbFruits.BackColor = secondary;
                lbFruits.ForeColor = Color.White;
                btnFruits.ForeColor = Color.White;
            }
            
            currentTopic = 3;
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnJob.FillColor == primary)
            {
                btnJob.FillColor = secondary;
                lbJob.BackColor = secondary;
                lbJob.ForeColor = Color.White;
                btnJob.ForeColor = Color.White;
            }
           
            currentTopic = 4;
        }

        private void btnFoodaDrinks_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnFoodaDrinks.FillColor == primary)
            {
                btnFoodaDrinks.FillColor = secondary;
                lbFoodaDrinks.BackColor = secondary;
                lbFoodaDrinks.ForeColor = Color.White;
                btnFoodaDrinks.ForeColor = Color.White;
            }
            
            currentTopic = 5;
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnSport.FillColor == primary)
            {
                btnSport.FillColor = secondary;
                lbSport.BackColor = secondary;
                lbSport.ForeColor = Color.White;
                btnSport.ForeColor = Color.White;
            }
            
            currentTopic = 6;
        }

        private void btnClothing_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnClothing.FillColor == primary)
            {
                btnClothing.FillColor = secondary;
                lbClothing.BackColor = secondary;
                lbClothing.ForeColor = Color.White;
                btnClothing.ForeColor = Color.White;
            }
            
            currentTopic = 7;
        }

        private void btnTechnology_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnTechnology.FillColor == primary)
            {
                btnTechnology.FillColor = secondary;
                lbTechnology.BackColor = secondary;
                lbTechnology.ForeColor = Color.White;
                btnTechnology.ForeColor = Color.White;
            }
            
            currentTopic = 8;
        }

        private void btnMultipleChoice_Click(object sender, EventArgs e)
        {
            type = 1;
            //btnMultipleChoice.FillColor = primary;
            btnFilBlank.FillColor = primary;
            btnFilBlank.ForeColor = foreColor;
            lbFillBlank.BackColor = primary;
            lbFillBlank.ForeColor = foreColor;
            btnMultipleChoice.FillColor = secondary;
            lbMultipleChoice.BackColor = secondary;
            lbMultipleChoice.ForeColor = Color.White;

        }

        private void btnFilBlank_Click(object sender, EventArgs e)
        {
            type = 0;
            btnMultipleChoice.FillColor = primary;
            btnMultipleChoice.ForeColor = foreColor;
            lbMultipleChoice.BackColor = primary;
            lbMultipleChoice.ForeColor = foreColor;
            //btnFilBlank.FillColor = primary;
            btnFilBlank.FillColor = secondary;
            lbFillBlank.BackColor = secondary;
            lbFillBlank.ForeColor = Color.White;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (type >= 0 && currentTopic > 0)
            {
                Start();
            }
        }
    }
}
