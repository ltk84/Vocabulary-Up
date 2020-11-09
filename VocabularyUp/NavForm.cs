using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    public partial class NavForm : Form
    {
        //int flag = 1;
        //FlashCard curMainFl = null;
        //FlashCard curReviseFl = null;
        //MainForm mainTab = new MainForm();
        //ReviseForm reviseTab = new ReviseForm();
        //StatisticsForm statisticsTab = new StatisticsForm();
        //UserAccessForm userAccess;
        //int currentID;

        //public NavForm(UserAccessForm userAccess, int currentID)
        //{
        //    this.userAccess = userAccess;
        //    this.currentID = currentID;
        //    InitializeComponent();

        //    // Update UserID và Connect đến database để load ReFlashCard của User 
        //    ManageUserAction.UpdateUserInfo(currentID);

        //    // Connect đến database để load MainFlashCard
        //    ManageUserAction.UpdateMainFlashCard(currentID);

        //    // Chuyển đến MainTab
        //    ToMainTab();
        //}

        //private void btnMain_Click(object sender, EventArgs e)
        //{
        //    ToMainTab();
        //    btnMain.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
        //    btnRevise.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
        //    btnStatistics.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
        //}

        //private void ToMainTab()
        //{
        //    mainTab.TopLevel = false;
        //    pnlTab.Controls.Clear();
        //    pnlTab.Controls.Add(mainTab);
        //    mainTab.FormBorderStyle = FormBorderStyle.None;
        //    mainTab.Show();
        //    flag = 1;
        //}

        //private void btnRevise_Click(object sender, EventArgs e)
        //{
        //    ToReviseTab();
        //    btnRevise.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
        //    btnMain.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
        //    btnStatistics.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
        //}

        //private void ToReviseTab()
        //{
        //    reviseTab.TopLevel = false;
        //    pnlTab.Controls.Clear();
        //    pnlTab.Controls.Add(reviseTab);
        //    reviseTab.FormBorderStyle = FormBorderStyle.None;
        //    reviseTab.Show();
        //    flag = 2;
        //}

        //private void btnStatistics_Click(object sender, EventArgs e)
        //{
        //    ToStatisticsTab();
        //    btnStatistics.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
        //    btnMain.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
        //    btnRevise.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
        //}

        //private void ToStatisticsTab()
        //{
        //    statisticsTab.TopLevel = false;
        //    pnlTab.Controls.Clear();
        //    pnlTab.Controls.Add(statisticsTab);
        //    statisticsTab.FormBorderStyle = FormBorderStyle.None;
        //    //statisticsTab.Dock = DockStyle.Fill;
        //    UpdateStatistics();
        //    statisticsTab.Show();
        //    flag = 3;
        //}

        //private void UpdateStatistics()
        //{
        //    ManageUserAction.UpdateTotalWord();
        //    statisticsTab.UpdateInfo(ManageSystem.GetUserInfo(currentID-1).Username, ManageSystem.GetUserInfo(currentID-1).Email, ManageSystem.GetUserInfo(currentID-1).BeginDate, ManageSystem.GetUserInfo(currentID-1).TotalWord);
        //}

        //// LOAD FLASHCARD TIẾP THEO
        //private void NextFlashCard()
        //{
        //    if (flag == 1)
        //    {
        //        FlashCard tempt = ManageUserAction.RandomMainFlashCard();
        //        while (tempt == curMainFl)
        //        {
        //            tempt = ManageUserAction.RandomMainFlashCard();
        //        }
        //        curMainFl = tempt;
        //        mainTab.ChangeLabelMain(curMainFl.Eng, curMainFl.IdCard);
        //    }
        //    else if (flag == 2)
        //    {
        //        FlashCard tempt = ManageUserAction.RandomReviseFlashCard();
        //        while (tempt == curReviseFl)
        //        {
        //            tempt = ManageUserAction.RandomReviseFlashCard();
        //        }
        //        curReviseFl = tempt;
        //        reviseTab.ChangeLabelRevise(curReviseFl.Eng, curReviseFl.IdCard);
        //    }
        //}

        //private void btnRight_Click(object sender, EventArgs e)
        //{
        //    if (curMainFl != null)
        //    {
        //        if (flag == 1 && curMainFl.IdCard != -1)
        //        {
        //            ManageUserAction.RemoveMain(curMainFl);
        //            ManageUserAction.AddRevise(curMainFl);
        //        }
        //    }
        //    NextFlashCard();
        //}

        //private void btnLeft_Click(object sender, EventArgs e)
        //{
        //    if (curReviseFl != null)
        //    {
        //        if (flag == 2 && curReviseFl.IdCard != -1)
        //        {
        //            ManageUserAction.RemoveRevise(curReviseFl);
        //            ManageUserAction.AddMain(curReviseFl);
        //        }
        //    }
        //    NextFlashCard();
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            userAccess.Show();
            this.Close();
        }

        private void btnFullScr_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void NavForm_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Left)
        //    {
        //        if (curReviseFl != null)
        //        {
        //            if (flag == 2 && curReviseFl.IdCard != -1)
        //            {
        //                ManageUserAction.RemoveRevise(curReviseFl);
        //                ManageUserAction.AddMain(curReviseFl);
        //            }
        //        }
        //        NextFlashCard();
        //    }
        //    else if (e.KeyData == Keys.Right)
        //    {
        //        if (curMainFl != null)
        //        {
        //            if (flag == 1 && curMainFl.IdCard != -1)
        //            {
        //                ManageUserAction.RemoveMain(curMainFl);
        //                ManageUserAction.AddRevise(curMainFl);
        //            }
        //        }
        //        NextFlashCard();
        //    }
        //}


        // User Info
        UserAccessForm userAccess;
        int currentID;

        // Tabs
        CampaignForm campaignTab = new CampaignForm();
        LibraryForm libraryTab = new LibraryForm();
        CollectionForm collectionTab = new CollectionForm();
        RevisionForm revisionTab = new RevisionForm();
        StatisticForm statisticTab = new StatisticForm();
        //int flag = 0;

        public NavForm(UserAccessForm userAccess, int currentID)
        {
            this.userAccess = userAccess;
            this.currentID = currentID;
            InitializeComponent();

            // Update UserID và Connect đến database để load ReFlashCard của User 
            ManageUserAction.UpdateUserInfo(currentID);

            // Connect đến database để load MainFlashCard
            ManageUserAction.UpdateMainFlashCard(currentID);

            // Khởi tạo Campaign Tab
            ToCampaignTab();
        }

        //private void CloseCurrentTab()
        //{
        //    switch (flag)
        //    {
        //        case 1:
        //            libraryTab.Close();
        //            break;
        //        case 2:
        //            collectionTab.Close();
        //            break;
        //        case 3:
        //            campaignTab.Close();
        //            break;
        //        case 4:
        //            revisionTab.Close();
        //            break;
        //        case 5:
        //            statisticTab.Close();
        //            break;
        //    }
        //}

        private void ToCampaignTab()
        {
            dashLibraryTab.Hide();
            dashCollectionTab.Hide();
            dashCampaignTab.Show();
            dashRevisionTab.Hide();
            dashStatisticTab.Hide();

            campaignTab.TopLevel = false;
            pnlTab.Controls.Clear();
            pnlTab.Controls.Add(campaignTab);
            campaignTab.FormBorderStyle = FormBorderStyle.None;
            campaignTab.Show();
        }

        private void ToRevisionTab()
        {
            dashLibraryTab.Hide();
            dashCollectionTab.Hide();
            dashCampaignTab.Hide();
            dashRevisionTab.Show();
            dashStatisticTab.Hide();

            revisionTab.TopLevel = false;
            pnlTab.Controls.Clear();
            pnlTab.Controls.Add(revisionTab);
            revisionTab.FormBorderStyle = FormBorderStyle.None;
            revisionTab.Show();
        }

        private void ToLibraryTab()
        {
            dashLibraryTab.Show();
            dashCollectionTab.Hide();
            dashCampaignTab.Hide();
            dashRevisionTab.Hide();
            dashStatisticTab.Hide();

            libraryTab.TopLevel = false;
            pnlTab.Controls.Clear();
            pnlTab.Controls.Add(libraryTab);
            libraryTab.FormBorderStyle = FormBorderStyle.None;
            libraryTab.Show();
        }

        private void ToCollectionTab()
        {
            dashLibraryTab.Hide();
            dashCollectionTab.Show();
            dashCampaignTab.Hide();
            dashRevisionTab.Hide();
            dashStatisticTab.Hide();

            collectionTab.TopLevel = false;
            pnlTab.Controls.Clear();
            pnlTab.Controls.Add(collectionTab);
            collectionTab.FormBorderStyle = FormBorderStyle.None;
            collectionTab.Show();
        }

        private void ToStatisticTab()
        {
            dashLibraryTab.Hide();
            dashCollectionTab.Hide();
            dashCampaignTab.Hide();
            dashRevisionTab.Hide();
            dashStatisticTab.Show();

            statisticTab.TopLevel = false;
            pnlTab.Controls.Clear();
            pnlTab.Controls.Add(statisticTab);
            statisticTab.FormBorderStyle = FormBorderStyle.None;
            statisticTab.Show();
        }

        private void btnLib_Click(object sender, EventArgs e)
        {
            ToLibraryTab();
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            ToCollectionTab();
        }

        private void btnCampaign_Click(object sender, EventArgs e)
        {
            ToCampaignTab();
        }

        private void btnRevision_Click(object sender, EventArgs e)
        {
            ToRevisionTab();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ToStatisticTab();
        }
    }
}
