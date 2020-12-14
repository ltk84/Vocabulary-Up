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

        // User Info
        UserAccessForm userAccess;
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        int currentID;

        // Tabs
        CampaignForm campaignTab;
        LibraryForm libraryTab;
        CollectionForm collectionTab;
        RevisionForm revisionTab;
        StatisticForm statisticTab;
        //int flag = 0;

        public NavForm(UserAccessForm userAccess, int currentID)
        {
            this.userAccess = userAccess;
            this.currentID = currentID;
            InitializeComponent();


            // Update UserID và Connect đến database để load ReFlashCard của User 
            ManageUserAction.UpdateUserInfo(currentID);
            //
            UpdateTheme();
            //
            ManageUserAction.InitAllCollections();
            campaignTab = new CampaignForm();
            libraryTab = new LibraryForm();
            collectionTab = new CollectionForm();
            revisionTab = new RevisionForm();
            statisticTab = new StatisticForm();
            // Connect đến database để load MainFlashCard
            //ManageUserAction.UpdateMainFlashCard();

            // Khởi tạo Campaign Tab
            ToCampaignTab();
        }

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
            campaignTab.Reset();
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
            revisionTab.Parent = this.pnlTab;
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
            libraryTab.LoadComboBox();
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
            collectionTab.LoadListView();
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

            statisticTab.update();
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

        private void NavForm_Load(object sender, EventArgs e)
        {

        }
        private void UpdateTheme()
        {
            this.BackColor = primary;
            this.barTop.BackColor = primary;
            this.barTop.FillColor = primary;
            this.barTop.FillColor2 = primary;
            this.dashFix1.FillColor = primary;
            this.dashFix1.FillColor2 = primary;
            this.dashFix1.FillColor3 = primary;
            this.dashFix1.FillColor4 = primary;
            this.dashFix2.FillColor = primary;
            this.dashFix2.FillColor2 = primary;
            this.dashFix2.FillColor3 = primary;
            this.dashFix2.FillColor4 = primary;
            this.pnlTab.BackColor = primary;
            this.dashCampaignTab.FillColor = primary;
            this.dashCampaignTab.FillColor2 = primary;
            this.dashCampaignTab.FillColor3 = primary;
            this.dashCampaignTab.FillColor4 = primary;
            this.dashCollectionTab.FillColor = primary;
            this.dashCollectionTab.FillColor2 = primary;
            this.dashCollectionTab.FillColor3 = primary;
            this.dashCollectionTab.FillColor4 = primary;
            this.dashLibraryTab.FillColor = primary;
            this.dashLibraryTab.FillColor2 = primary;
            this.dashLibraryTab.FillColor3 = primary;
            this.dashLibraryTab.FillColor4 = primary;
            this.dashRevisionTab.FillColor = primary;
            this.dashRevisionTab.FillColor2 = primary;
            this.dashRevisionTab.FillColor3 = primary;
            this.dashRevisionTab.FillColor4 = primary;
            this.dashStatisticTab.FillColor = primary;
            this.dashStatisticTab.FillColor2 = primary;
            this.dashStatisticTab.FillColor3 = primary;
            this.dashStatisticTab.FillColor4 = primary;
        }
    }
}
