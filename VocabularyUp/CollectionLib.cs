﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    public partial class CollectionLib : Form
    {
        private static int index = 0;
        FlashCard curFlashCard;
        Collection curCollection;
        CollectionForm collectionTab;
        public CollectionLib(CollectionForm collectionTab, int idCollection)
        {
            InitializeComponent();
            //
            this.collectionTab = collectionTab;
            //
            index = 0;
            this.curCollection = ManageUserAction.GetItemOfAllCollection(idCollection);
            lbCollectionName.Text = curCollection.NameCollection;
            curFlashCard = curCollection.ListFL[index];
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
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
            int iTemp = SearchFlashCard(txtSearching.Text);
            if (iTemp >= 0)
                index = iTemp;
            curFlashCard = curCollection.ListFL[index];
            ChangeFlashCard(curFlashCard.Eng, curFlashCard.IdCard);
        }
        private int SearchFlashCard(string content)
        {
            return curCollection.ListFL.FindIndex(f => f.Eng == content);
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
    }
}