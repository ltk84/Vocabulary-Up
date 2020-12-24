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
    public partial class DetailsGameForm : Form
    {
        //Color primary = Color.FromArgb(50, 74, 95);
        //Color secondary = Color.FromArgb(27, 42, 65);
        //bool darkMode = false;
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        FlashCard curFlashCard;
        List<UserChoice> userChoices;
        List<string> correctAns = new List<string>();
        List<string> wrongAns = new List<string>();


        public DetailsGameForm(List<UserChoice> userChoices)
        {
            InitializeComponent();
            this.userChoices = userChoices;
            //darkMode = ManageUserAction.GetDarkMode();
            //UpdateTheme();
            InitStatList();
            LoadListView();
            LoadComboBox();
        }

        //private void UpdateTheme()
        //{
        //    if (darkMode)
        //    {
        //        primary = Color.FromArgb(50, 74, 95);
        //        secondary = Color.White;
        //    }
        //    else
        //    {
        //        primary = Color.FromArgb(17, 223, 158);
        //        secondary = Color.FromArgb(7, 96, 68);
        //    }
        //    this.pnlTopicSelection.BackColor = primary;
        //    this.btnBack.Image = Image.FromFile("../../icons/back_arrow_dark.png");
        //    this.btnToCollection.FillColor = primary;
        //    this.pnlTab.FillColor = primary;
        //    this.pnlTab.FillColor2 = primary;
        //    this.pnlTab.FillColor3 = primary;
        //    this.pnlTab.FillColor4 = primary;
        //}

       

        public void LoadComboBox()
        {
            cbCollection.Items.Clear();
            for (int i = 1; i < ManageUserAction.CollectionCount(); i++)
            {
                cbCollection.Items.Add(ManageUserAction.GetItemOfAllCollection(i).NameCollection);
            }
        }

        private void InitStatList()
        {
            foreach (var choice in userChoices)
            {
                if (choice.Selected == choice.Correct)
                {
                    correctAns.Add(choice.CorrectAns);
                }
                else
                {
                    wrongAns.Add(choice.CorrectAns);
                }
            }
        }

      

        public void LoadListView()
        {
            int index = 1;
            foreach (var item in correctAns)
            {
                if (item != null)
                {
                    lvCorrectWord.Items.Add(new ListViewItem(new string[] { index.ToString(), item }));
                    index++;
                }
            }

            index = 1;
            foreach (var item in wrongAns)
            {
                if (item != null)
                {
                    lvWrongWord.Items.Add(new ListViewItem(new string[] { index.ToString(), item }));
                    index++;
                }
            }
        }

        private void lvWrongWord_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            curFlashCard = ManageSystem.SearchFlashCardEng(e.Item.SubItems[1].Text);
            if (curFlashCard != null)
            {
                ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
            }
        }

        public void ChangeFlashCard(string content, int id)
        {
            try
            {
                lbMain.Text = content;
                pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + id.ToString() + ".jpg");
            }
            catch (Exception)
            {

            }
        }
        private void ChangeLabel()
        {
            if (curFlashCard == null)
                return;

            if (lbMain.Text == curFlashCard.Eng)
                lbMain.Text = curFlashCard.Viet;
            else
                lbMain.Text = curFlashCard.Eng;
        }

        private void pbMain_Click(object sender, EventArgs e)
        {
            ChangeLabel();
        }

        private void pnlTab_Click(object sender, EventArgs e)
        {
            ChangeLabel();
        }

        private void lbMain_Click(object sender, EventArgs e)
        {
            ChangeLabel();
        }

        private void btnToCollection_Click(object sender, EventArgs e)
        {
            if (curFlashCard != null)
            {
                if (!ManageUserAction.IsFlashCardExist(cbCollection.SelectedIndex + 1, curFlashCard.IdCard) && cbCollection.SelectedIndex >= 0)
                    AddFlashCard();
            }
        }
        public void AddFlashCard()
        {
            if (curFlashCard == null)
                return;

            ManageUserAction.AddFlashCardToCollection(cbCollection.SelectedIndex + 1, curFlashCard);
            ManageUserAction.AddFlashCardToDatabase(cbCollection.SelectedIndex + 1, cbCollection.SelectedItem.ToString(), curFlashCard);
        }
        private void btnPronun_Click(object sender, EventArgs e)
        {
            if (curFlashCard == null)
                return;

            string pronun = " " + curFlashCard.Eng;
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            timerSpeaker.Start();
            btnPronun.Enabled = false;
            synthesizer.Speak(pronun);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerSpeaker.Stop();
            btnPronun.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
