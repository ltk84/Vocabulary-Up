using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Speech.Synthesis;

namespace VocabularyUp
{
    public partial class LibraryForm : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private static int index = 0;
        FlashCard curFlashCard;
        public LibraryForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            ManageSystem.InitLibrary();
            curFlashCard = ManageSystem.GetFlashCard(index);
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
            InitAutoCompleteTextBox();
        }

        public void ChangeFlashCard(string content, int id)
        {
            try
            {
                lbMain.Text = content;
                pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath") + id.ToString() + ".jpg");
            }
            catch (Exception)
            {

            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            else
                index = ManageSystem.CountAllFlashCards() - 1;
            curFlashCard = ManageSystem.GetFlashCard(index);
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (index < ManageSystem.CountAllFlashCards() - 1)
                index++;
            else
                index = 0;
            curFlashCard = ManageSystem.GetFlashCard(index);
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int iTemp = ManageSystem.SearchFlashCardEng(txtSearching.Text);
            if (iTemp >= 0)
                index = iTemp;
            else
            {
                iTemp = ManageSystem.SearchFlashCardVie(txtSearching.Text);
                if (iTemp >= 0)
                    index = iTemp;
            }
            curFlashCard = ManageSystem.GetFlashCard(index);
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
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
            ManageUserAction.AddFlashCardToCollection(cbCollection.SelectedIndex + 1, curFlashCard);
            ManageUserAction.AddFlashCardToDatabase(cbCollection.SelectedIndex + 1, cbCollection.SelectedItem.ToString(), curFlashCard);
        }

        private void btnToCollection_Click(object sender, EventArgs e)
        {
            if (!ManageUserAction.IsFlashCardExist(cbCollection.SelectedIndex + 1, curFlashCard.IdCard) && cbCollection.SelectedIndex >= 0)
                AddFlashCard();
        }

        private void btnPronun_Click(object sender, EventArgs e)
        {
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

        private void LibraryForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                btnRight_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Left)
                btnLeft_Click(sender, e);
        }
        private void ChangeLabel()
        {
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

        private void InitAutoCompleteTextBox()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            for (int i = 0; i < ManageSystem.CountAllFlashCards(); i++)
            {
                data.Add(ManageSystem.GetFlashCard(i).Eng);
                data.Add(ManageSystem.GetFlashCard(i).Viet);
            }
            txtSearching.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearching.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearching.AutoCompleteCustomSource = data;
        }
    }
}
