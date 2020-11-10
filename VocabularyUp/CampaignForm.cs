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
        int currentTopic = 0;
        MultipleChoiceForm quizMP = new MultipleChoiceForm();
        FillBlankForm quizFB = new FillBlankForm();
        public CampaignForm()
        {
            InitializeComponent();
        }

        private void Start(int currentTopic)
        {
            ManageUserAction.UpdateMainFlashCard(currentTopic);
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            currentTopic = 1;
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            currentTopic = 2;
        }

        private void btnFruits_Click(object sender, EventArgs e)
        {
            currentTopic = 3;
        }

        private void btnHobbies_Click(object sender, EventArgs e)
        {
            currentTopic = 4;
        }

        private void btnPersonality_Click(object sender, EventArgs e)
        {
            currentTopic = 5;
        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            currentTopic = 6;
        }

        private void btnClothing_Click(object sender, EventArgs e)
        {
            currentTopic = 7;
        }

        private void btnTechnology_Click(object sender, EventArgs e)
        {
            currentTopic = 8;
        }
    }
}
