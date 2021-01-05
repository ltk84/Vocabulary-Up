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
        bool darkMode = false;
        int currentID;

        // Tabs
        CampaignForm campaignTab;
        LibraryForm libraryTab;
        CollectionForm collectionTab;
        RevisionForm revisionTab;
        StatisticForm statisticTab;
        int currentTab = 0;

        public NavForm(UserAccessForm userAccess, int currentID)
        {
            this.userAccess = userAccess;
            this.currentID = currentID;
            InitializeComponent();


            // Update UserID và Connect đến database để load ReFlashCard của User 
            ManageUserAction.UpdateUserInfo(currentID);
            darkMode = ManageUserAction.GetDarkMode();
            //
            if (darkMode)
                swDarkMode.Checked = true;
            else
                swDarkMode.Checked = false;
            //
            ManageUserAction.InitAllCollections();
            campaignTab = new CampaignForm();
            libraryTab = new LibraryForm();
            collectionTab = new CollectionForm();
            revisionTab = new RevisionForm();
            statisticTab = new StatisticForm();

            // Khởi tạo Campaign Tab
            ToCampaignTab();
        }

        private void ToCampaignTab()
        {
            currentTab = 3;
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
            currentTab = 4;
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
            currentTab = 1;
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
            currentTab = 2;
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
            currentTab =5;
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

        private void UpdateTheme()
        {
            if (darkMode)
            {
                primary = Color.FromArgb(50, 74, 95);
                secondary = Color.FromArgb(27, 42, 65);
            }
            else
            {
                primary = Color.FromArgb(17, 223, 158);
                secondary = Color.FromArgb(7, 96, 68);
            }
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

        private void swDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (swDarkMode.Checked)
            {
                ManageUserAction.ChangeDarkMode(true);
            }
            else
            {
                ManageUserAction.ChangeDarkMode(false);
            }
            darkMode = ManageUserAction.GetDarkMode();
            UpdateTheme();
            RefreshTab();
        }

        private void RefreshTab()
        {
            switch (currentTab)
            {
                case 1:
                    campaignTab = new CampaignForm();
                    libraryTab = new LibraryForm();
                    collectionTab = new CollectionForm();
                    revisionTab = new RevisionForm();
                    statisticTab = new StatisticForm();
                    ToLibraryTab();
                    break;
                case 2:
                    campaignTab = new CampaignForm();
                    libraryTab = new LibraryForm();
                    collectionTab = new CollectionForm();
                    revisionTab = new RevisionForm();
                    statisticTab = new StatisticForm();
                    ToCollectionTab();
                    break;
                case 3:
                    campaignTab = new CampaignForm();
                    libraryTab = new LibraryForm();
                    collectionTab = new CollectionForm();
                    revisionTab = new RevisionForm();
                    statisticTab = new StatisticForm();
                    ToCampaignTab();
                    break;
                case 4:
                    campaignTab = new CampaignForm();
                    libraryTab = new LibraryForm();
                    collectionTab = new CollectionForm();
                    revisionTab = new RevisionForm();
                    statisticTab = new StatisticForm();
                    ToRevisionTab();
                    break;
                case 5:
                    campaignTab = new CampaignForm();
                    libraryTab = new LibraryForm();
                    collectionTab = new CollectionForm();
                    revisionTab = new RevisionForm();
                    statisticTab = new StatisticForm();
                    ToStatisticTab();
                    break;
            }
        }

        private void btnTutorial_MouseHover(object sender, EventArgs e)
        {
            string tutorial = "";
            switch (currentTab)
            {
                case 1:
                    tutorial = "Library: \n- Nhấn vào flashcard để chuyển sang tiếng Việt/tiếng Anh.\n- Ấn bên trái/phải flashcard để chuyển flashcard.\n- Có thể thêm flashcard đang hiện vào bộ sưu tập bằng nút có hình dấu cộng bên dưới.";
                    break;
                case 2:
                    tutorial = "Collection: \n- Nhấn đúp vào bộ sưu tập để xem những flashcards có trong đó, chức năng bên trong đó sẽ tương tự library.\n- Có thể thêm, đổi tên, xóa bộ sưu tập bằng ba nút hiển thị ở bên phải.";
                    break;
                case 3:
                    tutorial = "Study: \n- Chọn hình thức học (bên trái) và chủ đề (bên phải) để có thể bắt đầu vào học.";
                    break;
                case 4:
                    tutorial = "Revision: \n- Chọn nhân vật, sau đó chọn chế độ chơi để có thể vừa ôn tập vừa giải trí những từ vựng đã học.\n- Có thể vào cửa hàng ở góc trên bên phải để mua nhân vật mình thích.\n- Kim cương có thể tích lũy thông qua việc ôn tập.";
                    break;
                case 5:
                    tutorial = "Statistics: \n- Có thể thay đổi thông tin, mật khẩu người dùng trong mục Info (phần điều hướng bên trái).\n- Thông tin thống kê từ vựng đã học ở mục Result (phần điều hướng bên trái).";
                    break;
            }
            ttTutorial.SetToolTip(btnTutorial, tutorial);
        }
    }
}
