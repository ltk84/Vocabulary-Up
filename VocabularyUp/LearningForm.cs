using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    public partial class LearningForm : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private static int index = 0;
        List<FlashCard> flList = new List<FlashCard>();
        int currentTopic = 0;
        CampaignForm campaignForm;
        FillBlankForm fillBQuiz;
        MultipleChoiceForm multiQuiz;

        public LearningForm(int currentTopic, CampaignForm campaignForm, FillBlankForm fillBquiz, MultipleChoiceForm multiQuiz)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.campaignForm = campaignForm;
            this.fillBQuiz = fillBquiz;
            this.multiQuiz = multiQuiz;
            this.currentTopic = currentTopic;
            //ManageUserAction.UpdateMainFlashCard(currentTopic);
            flList = ManageUserAction.GetMainFlashCards();
            LoadComboBox();
        }
        public void ChangeFlashCard(string content, int id)
        {
            lbMain.Text = content;
            pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath") + id.ToString() + ".jpg");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (index < flList.Count - 1)
                index++;
            else
                index = 0;
            ChangeFlashCard(flList[index].Eng, flList[index].IdCard);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            else
                index = flList.Count - 1;
            ChangeFlashCard(flList[index].Eng, flList[index].IdCard);
        }

        private void btnToCollection_Click(object sender, EventArgs e)
        {
            if (!ManageUserAction.IsFlashCardExist(cbCollection.SelectedIndex + 1, flList[index].IdCard) && cbCollection.SelectedIndex >= 0)
                AddFlashCard();
        }

        private void btnPronun_Click(object sender, EventArgs e)
        {
            string pronun = " " + flList[index].Eng;
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            timer1.Start();
            btnPronun.Enabled = false;
            synthesizer.Speak(pronun);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.campaignForm.Return();
            this.multiQuiz.Close();
            this.fillBQuiz.Close();
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            btnPronun.Enabled = true;
        }
        public void LoadComboBox()
        {
            cbCollection.Items.Clear();
            for (int i = 1; i < ManageUserAction.CollectionCount(); i++)
            {
                cbCollection.Items.Add(ManageUserAction.GetItemOfAllCollection(i).NameCollection);
            }
        }
        public void AddFlashCard()
        {
            ManageUserAction.AddFlashCardToCollection(cbCollection.SelectedIndex + 1, flList[index]);
            ManageUserAction.AddFlashCardToDatabase(cbCollection.SelectedIndex + 1, cbCollection.SelectedItem.ToString(), flList[index]);
        }
        

        private void LearningForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                btnRight_Click(sender, e);
            else if (e.KeyCode == Keys.Left)
                btnLeft_Click(sender, e);
        }
    }
}
