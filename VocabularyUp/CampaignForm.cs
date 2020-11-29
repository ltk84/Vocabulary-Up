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
        }

        private void Start()
        {
            ////MultipleChoiceForm quiz = new MultipleChoiceForm(currentTopic);
            //FillBlankForm quiz = new FillBlankForm(currentTopic);
            //quiz.TopLevel = false;
            ////pnlCampaignCate.Controls.Clear();
            //pnlTopicSelection.Hide();
            //pnlCampaignCate.Controls.Add(quiz);
            //quiz.FormBorderStyle = FormBorderStyle.None;
            //quiz.Show();
            //
            FillBlankForm quiz = new FillBlankForm(currentTopic, this);
            MultipleChoiceForm multiple = new MultipleChoiceForm(currentTopic, this);
            LearningForm learning = new LearningForm(currentTopic, this, quiz);

            learning.TopLevel = false;
            pnlTopicSelection.Hide();
            pnlCampaignCate.Controls.Add(learning);
            learning.FormBorderStyle = FormBorderStyle.None;
            learning.Show();

            if (type == 0)
            {
                //MultipleChoiceForm quiz = new MultipleChoiceForm(currentTopic);
                //FillBlankForm quiz = new FillBlankForm(currentTopic, this);
                quiz.TopLevel = false;
                //pnlCampaignCate.Controls.Clear();
                pnlTopicSelection.Hide();
                pnlCampaignCate.Controls.Add(quiz);
                quiz.FormBorderStyle = FormBorderStyle.None;
                quiz.Show();
            }
            else
            {
                //MultipleChoiceForm quiz = new MultipleChoiceForm(currentTopic);
                //FillBlankForm quiz = new FillBlankForm(currentTopic, this);
                multiple.TopLevel = false;
                //pnlCampaignCate.Controls.Clear();
                pnlTopicSelection.Hide();
                pnlCampaignCate.Controls.Add(multiple);
                multiple.FormBorderStyle = FormBorderStyle.None;
                multiple.Show();
            }
        }
        public void Return()
        {
            pnlTopicSelection.Show();
            ResetColorButton();
            btnMultipleChoice.FillColor = Color.FromArgb(192, 255, 192);
            btnFilBlank.FillColor = Color.FromArgb(192, 255, 192);
        }

        private void ResetColorButton()
        {
            btnAnimals.FillColor = Color.FromArgb(192, 255, 192);
            btnPlants.FillColor = Color.FromArgb(192, 255, 192);
            btnSport.FillColor = Color.FromArgb(192, 255, 192);
            btnTechnology.FillColor = Color.FromArgb(192, 255, 192);
            btnJob.FillColor = Color.FromArgb(192, 255, 192);
            btnFoodaDrinks.FillColor = Color.FromArgb(192, 255, 192);
            btnFruits.FillColor = Color.FromArgb(192, 255, 192);
            btnClothing.FillColor = Color.FromArgb(192, 255, 192);
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            currentTopic = 1; 
            if (btnAnimals.FillColor == Color.FromArgb(192, 255, 192))
            {
                btnAnimals.FillColor = Color.FromArgb(10, 182, 194);
            }
            
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnPlants.FillColor == Color.FromArgb(192, 255, 192))
            {
                btnPlants.FillColor = Color.FromArgb(10, 182, 194);
            }
            
            currentTopic = 2;
        }

        private void btnFruits_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnFruits.FillColor == Color.FromArgb(192, 255, 192))
            {
                btnFruits.FillColor = Color.FromArgb(10, 182, 194);
            }
            
            currentTopic = 3;
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnJob.FillColor == Color.FromArgb(192, 255, 192))
            {
                btnJob.FillColor = Color.FromArgb(10, 182, 194);
            }
           
            currentTopic = 4;
        }

        private void btnFoodaDrinks_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnFoodaDrinks.FillColor == Color.FromArgb(192, 255, 192))
            {
                btnFoodaDrinks.FillColor = Color.FromArgb(10, 182, 194);
            }
            
            currentTopic = 5;
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnSport.FillColor == Color.FromArgb(192, 255, 192))
            {
                btnSport.FillColor = Color.FromArgb(10, 182, 194);
            }
            
            currentTopic = 6;
        }

        private void btnClothing_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnClothing.FillColor == Color.FromArgb(192, 255, 192))
            {
                btnClothing.FillColor = Color.FromArgb(10, 182, 194);
            }
            
            currentTopic = 7;
        }

        private void btnTechnology_Click(object sender, EventArgs e)
        {
            ResetColorButton();

            if (btnTechnology.FillColor == Color.FromArgb(192, 255, 192))
            {
                btnTechnology.FillColor = Color.FromArgb(10, 182, 194);
            }
            
            currentTopic = 8;
        }

        private void btnMultipleChoice_Click(object sender, EventArgs e)
        {
            type = 1;
            btnMultipleChoice.FillColor = Color.FromArgb(192, 255, 192);
            btnFilBlank.FillColor = Color.FromArgb(192, 255, 192);
            btnMultipleChoice.FillColor = Color.FromArgb(10, 182, 194);
            
        }

        private void btnFilBlank_Click(object sender, EventArgs e)
        {
            type = 0;
            btnMultipleChoice.FillColor = Color.FromArgb(192, 255, 192);
            btnFilBlank.FillColor = Color.FromArgb(192, 255, 192);
            btnFilBlank.FillColor = Color.FromArgb(10, 182, 194);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (type >= 0 && currentTopic > 0)
                Start();
        }
    }
}
