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
        public CampaignForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
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
            btnMultipleChoice.FillColor = Color.FromArgb(17, 223, 158);
            lbMultipleChoice.BackColor = Color.FromArgb(17, 223, 158);
            lbMultipleChoice.ForeColor = Color.Black;
            btnFilBlank.FillColor = Color.FromArgb(17, 223, 158);
            lbFillBlank.BackColor = Color.FromArgb(17, 223, 158);
            lbFillBlank.ForeColor = Color.Black;
        }
        public void Return()
        {
            pnlTopicSelection.Show();
            Reset();
        }

        private void ResetColorButton()
        {
            btnAnimals.FillColor = Color.FromArgb(17, 223, 158);
            lbAnimals.BackColor = Color.FromArgb(17, 223, 158);
            lbAnimals.ForeColor = Color.Black;

            btnPlants.FillColor = Color.FromArgb(17, 223, 158);
            lbPlants.BackColor = Color.FromArgb(17, 223, 158);
            lbPlants.ForeColor = Color.Black;

            btnSport.FillColor = Color.FromArgb(17, 223, 158);
            lbSport.BackColor = Color.FromArgb(17, 223, 158);
            lbSport.ForeColor = Color.Black;

            btnTechnology.FillColor = Color.FromArgb(17, 223, 158);
            lbTechnology.BackColor = Color.FromArgb(17, 223, 158);
            lbTechnology.ForeColor = Color.Black;

            btnJob.FillColor = Color.FromArgb(17, 223, 158);
            lbJob.BackColor = Color.FromArgb(17, 223, 158);
            lbJob.ForeColor = Color.Black;

            btnFoodaDrinks.FillColor = Color.FromArgb(17, 223, 158);
            lbFoodaDrinks.BackColor = Color.FromArgb(17, 223, 158);
            lbFoodaDrinks.ForeColor = Color.Black;

            btnFruits.FillColor = Color.FromArgb(17, 223, 158);
            lbFruits.BackColor = Color.FromArgb(17, 223, 158);
            lbFruits.ForeColor = Color.Black;

            btnClothing.FillColor = Color.FromArgb(17, 223, 158);
            lbClothing.BackColor = Color.FromArgb(17, 223, 158);
            lbClothing.ForeColor = Color.Black;
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            currentTopic = 1; 
            if (btnAnimals.FillColor == Color.FromArgb(17, 223, 158))
            {
                btnAnimals.FillColor = Color.FromArgb(7, 96, 68);
                lbAnimals.BackColor = Color.FromArgb(7, 96, 68);
                lbAnimals.ForeColor = Color.White;
            }
            
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnPlants.FillColor == Color.FromArgb(17, 223, 158))
            {
                btnPlants.FillColor = Color.FromArgb(7, 96, 68);
                lbPlants.BackColor = Color.FromArgb(7, 96, 68);
                lbPlants.ForeColor = Color.White;
            }
            
            currentTopic = 2;
        }

        private void btnFruits_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnFruits.FillColor == Color.FromArgb(17, 223, 158))
            {
                btnFruits.FillColor = Color.FromArgb(7, 96, 68);
                lbFruits.BackColor = Color.FromArgb(7, 96, 68);
                lbFruits.ForeColor = Color.White;
            }
            
            currentTopic = 3;
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnJob.FillColor == Color.FromArgb(17, 223, 158))
            {
                btnJob.FillColor = Color.FromArgb(7, 96, 68);
                lbJob.BackColor = Color.FromArgb(7, 96, 68);
                lbJob.ForeColor = Color.White;
            }
           
            currentTopic = 4;
        }

        private void btnFoodaDrinks_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnFoodaDrinks.FillColor == Color.FromArgb(17, 223, 158))
            {
                btnFoodaDrinks.FillColor = Color.FromArgb(7, 96, 68);
                lbFoodaDrinks.BackColor = Color.FromArgb(7, 96, 68);
                lbFoodaDrinks.ForeColor = Color.White;
            }
            
            currentTopic = 5;
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnSport.FillColor == Color.FromArgb(17, 223, 158))
            {
                btnSport.FillColor = Color.FromArgb(7, 96, 68);
                lbSport.BackColor = Color.FromArgb(7, 96, 68);
                lbSport.ForeColor = Color.White;
            }
            
            currentTopic = 6;
        }

        private void btnClothing_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnClothing.FillColor == Color.FromArgb(17, 223, 158))
            {
                btnClothing.FillColor = Color.FromArgb(7, 96, 68);
                lbClothing.BackColor = Color.FromArgb(7, 96, 68);
                lbClothing.ForeColor = Color.White;
            }
            
            currentTopic = 7;
        }

        private void btnTechnology_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnTechnology.FillColor == Color.FromArgb(17, 223, 158))
            {
                btnTechnology.FillColor = Color.FromArgb(7, 96, 68);
                lbTechnology.BackColor = Color.FromArgb(7, 96, 68);
                lbTechnology.ForeColor = Color.White;
            }
            
            currentTopic = 8;
        }

        private void btnMultipleChoice_Click(object sender, EventArgs e)
        {
            type = 1;
            //btnMultipleChoice.FillColor = Color.FromArgb(17, 223, 158);
            btnFilBlank.FillColor = Color.FromArgb(17, 223, 158);
            lbFillBlank.BackColor = Color.FromArgb(17, 223, 158);
            lbFillBlank.ForeColor = Color.Black;
            btnMultipleChoice.FillColor = Color.FromArgb(7, 96, 68);
            lbMultipleChoice.BackColor = Color.FromArgb(7, 96, 68);
            lbMultipleChoice.ForeColor = Color.White;

        }

        private void btnFilBlank_Click(object sender, EventArgs e)
        {
            type = 0;
            btnMultipleChoice.FillColor = Color.FromArgb(17, 223, 158);
            lbMultipleChoice.BackColor = Color.FromArgb(17, 223, 158);
            lbMultipleChoice.ForeColor = Color.Black;
            //btnFilBlank.FillColor = Color.FromArgb(17, 223, 158);
            btnFilBlank.FillColor = Color.FromArgb(7, 96, 68);
            lbFillBlank.BackColor = Color.FromArgb(7, 96, 68);
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
