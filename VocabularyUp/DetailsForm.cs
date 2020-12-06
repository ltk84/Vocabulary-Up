﻿using System;
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
    public partial class DetailsForm : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        ResultForm resForm;
        FlashCard curFlashCard;
        public DetailsForm(ResultForm resForm)
        {
            InitializeComponent();
            this.resForm = resForm;
            LoadListView();
            LoadComboBox();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadComboBox()
        {
            cbCollection.Items.Clear();
            for (int i = 1; i < ManageUserAction.CollectionCount(); i++)
            {
                cbCollection.Items.Add(ManageUserAction.GetItemOfAllCollection(i).NameCollection);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            resForm.ProShow();
            this.Close();
        }

        public void LoadListView()
        {
            int index = 1;
            foreach (var item in resForm.GetCorrectAnsList())
            {
                lvCorrectWord.Items.Add(new ListViewItem(new string[] { index.ToString(), item }));
                index++;
            }

            index = 1;
            foreach (var item in resForm.GetWrongAnsList())
            {
                lvWrongWord.Items.Add(new ListViewItem(new string[] { index.ToString(), item }));
                index++;
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
                pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath") + id.ToString() + ".jpg");
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
            if (!ManageUserAction.IsFlashCardExist(cbCollection.SelectedIndex + 1, curFlashCard.IdCard) && cbCollection.SelectedIndex >= 0)
                AddFlashCard();
        }
        public void AddFlashCard()
        {
            ManageUserAction.AddFlashCardToCollection(cbCollection.SelectedIndex + 1, curFlashCard);
            ManageUserAction.AddFlashCardToDatabase(cbCollection.SelectedIndex + 1, cbCollection.SelectedItem.ToString(), curFlashCard);
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
    }
}
