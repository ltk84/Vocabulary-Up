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
using System.Speech.Synthesis;

namespace VocabularyUp
{
    public partial class CollectionLib : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private static int index = 0;
        FlashCard curFlashCard;
        Collection curCollection;
        CollectionForm collectionTab;
        public CollectionLib(CollectionForm collectionTab, int idCollection)
        {
            InitializeComponent();
            //
            this.collectionTab = collectionTab;
            this.KeyPreview = true;
            //
            index = 0;
            this.curCollection = ManageUserAction.GetItemOfAllCollection(idCollection);
            if (idCollection == 0)
                btnRemoveFromCollection.Visible = false;
            else
                btnRemoveFromCollection.Visible = true;
            lbCollectionName.Text = curCollection.NameCollection;
            curFlashCard = curCollection.ListFL[index];
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
            InitAutoCompleteTextBox();
        }
        public void ChangeFlashCard(string content, int id)
        {
            lbMain.Text = content;
            pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath") + id.ToString() + ".jpg");
        }

        private void ToTheRight()
        {
            if (index < curCollection.ListFL.Count - 1)
                index++;
            else
                index = 0;
            curFlashCard = curCollection.ListFL[index];
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
        }

        private void ToTheLeft()
        {
            if (index > 0)
                index--;
            else
                index = curCollection.ListFL.Count - 1;
            curFlashCard = curCollection.ListFL[index];
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            ToTheLeft();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ToTheRight();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int iTemp = SearchFlashCardEng(txtSearching.Text);
            if (iTemp >= 0)
                index = iTemp;
            else
            {
                iTemp = SearchFlashCardVie(txtSearching.Text);
                if (iTemp >= 0)
                    index = iTemp;
            }    

            curFlashCard = curCollection.ListFL[index];
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
        }
        private int SearchFlashCardEng(string content)
        {
            return curCollection.ListFL.FindIndex(f => f.Eng == content);
        }
        private int SearchFlashCardVie(string content)
        {
            return curCollection.ListFL.FindIndex(f => f.Viet == content);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            collectionTab.ProShow();
            this.Close();
        }

        private void btnRemoveFromCollection_Click(object sender, EventArgs e)
        {
            RemoveFlashCard();
        }
        public void RemoveFlashCard()
        {
            if (ManageUserAction.IsFlashCardExist(curCollection.IdCollection, curFlashCard.IdCard) && curFlashCard.IdCard != 0)
            {
                ManageUserAction.RemoveFlashCardFromCollection(curCollection.IdCollection, curFlashCard);
                ManageUserAction.DeleteFlashCardFromDatabase(curCollection.IdCollection, curFlashCard);
                ToTheRight();
            } 
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

        private void CollectionLib_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                btnRight_Click(sender, e);
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
            for (int i = 0; i < curCollection.ListFL.Count; i++)
            {
                data.Add(curCollection.ListFL[i].Eng);
                data.Add(curCollection.ListFL[i].Viet);
            }
            txtSearching.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearching.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearching.AutoCompleteCustomSource = data;
        }
    }
}
