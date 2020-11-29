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
            ManageSystem.InitLibrary();
            curFlashCard = ManageSystem.GetFlashCard(index);
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
        }

        public void ChangeFlashCard(string content, int id)
        {
            lbMain.Text = content;
            pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath") + id.ToString() + ".jpg");
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
            int iTemp = ManageSystem.SearchFlashCard(txtSearching.Text);
            if (iTemp >= 0)
                index = iTemp;
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
            timer1.Start();
            btnPronun.Enabled = false;
            synthesizer.Speak(pronun);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            btnPronun.Enabled = true;
        }

        private void btnLeft_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                btnLeft_Click(sender, e);
        }

        private void btnRight_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                btnRight_Click(sender, e);
        }
    }
}
