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
        int type = 0;
        int currentTopic = 0;
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
            LearningForm learning = new LearningForm(currentTopic, this);
            learning.TopLevel = false;
            pnlTopicSelection.Hide();
            pnlCampaignCate.Controls.Add(learning);
            learning.FormBorderStyle = FormBorderStyle.None;
            learning.Show();

            //MultipleChoiceForm quiz = new MultipleChoiceForm(currentTopic);
            FillBlankForm quiz = new FillBlankForm(currentTopic);
            quiz.TopLevel = false;
            //pnlCampaignCate.Controls.Clear();
            pnlTopicSelection.Hide();
            pnlCampaignCate.Controls.Add(quiz);
            quiz.FormBorderStyle = FormBorderStyle.None;
            quiz.Show();
        }
        public void Return()
        {
            pnlTopicSelection.Show();
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            currentTopic = 1;
            Start();
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            currentTopic = 2;
            Start();
        }

        private void btnFruits_Click(object sender, EventArgs e)
        {
            currentTopic = 3;
            Start();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            currentTopic = 4;
            Start();
        }

        private void btnFoodaDrinks_Click(object sender, EventArgs e)
        {
            currentTopic = 5;
            Start();
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            currentTopic = 6;
            Start();
        }

        private void btnClothing_Click(object sender, EventArgs e)
        {
            currentTopic = 7;
            Start();
        }

        private void btnTechnology_Click(object sender, EventArgs e)
        {
            currentTopic = 8;
            Start();
        }
    }
}
