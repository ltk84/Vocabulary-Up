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

namespace VocabularyUp
{
    public partial class MultipleChoiceForm : Form
    {
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        int darkMode = 1;
        List<Quiz> questions = new List<Quiz>();
        int currentTopic = 0;
        int currentQuiz = 0;
        int isPress = 0;
        int wrongAns = 10;
        List<UserChoice> userChoices = new List<UserChoice>();
        CampaignForm campaign = new CampaignForm();
        int time;
        public MultipleChoiceForm(int currentTopic, CampaignForm campaign)
        {
            InitializeComponent();
            UpdateTheme();
            this.currentTopic = currentTopic;
            this.campaign = campaign;
            InitQuiz();
            ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
        }

        private void UpdateTheme()
        {
            if (darkMode == 1)
            {
                primary = Color.FromArgb(50, 74, 95);
                secondary = Color.White;
            }
            else
            {
                primary = Color.FromArgb(17, 223, 158);
                secondary = Color.FromArgb(7, 96, 68);
            }
            this.pnlQuiz.BackColor = primary;
            this.guna2CircleButton1.FillColor = primary;
            this.guna2CircleButton2.FillColor = primary;
            this.guna2CircleButton3.FillColor = primary;
            this.guna2CircleButton4.FillColor = primary;
            this.guna2CircleButton5.FillColor = primary;
            this.guna2CircleButton6.FillColor = primary;
            this.guna2CircleButton7.FillColor = primary;
            this.guna2CircleButton8.FillColor = primary;
            this.guna2CircleButton9.FillColor = primary;
            this.guna2CircleButton10.FillColor = primary;
            this.btnPointer1.FillColor = secondary;
            this.btnPointer1.BackColor = primary;
            this.btnPointer2.FillColor = secondary;
            this.btnPointer2.BackColor = primary;
            this.btnPointer3.FillColor = secondary;
            this.btnPointer3.BackColor = primary;
            this.btnPointer4.FillColor = secondary;
            this.btnPointer4.BackColor = primary;
            this.btnPointer5.FillColor = secondary;
            this.btnPointer5.BackColor = primary;
            this.btnPointer6.FillColor = secondary;
            this.btnPointer6.BackColor = primary;
            this.btnPointer7.FillColor = secondary;
            this.btnPointer7.BackColor = primary;
            this.btnPointer8.FillColor = secondary;
            this.btnPointer8.BackColor = primary;
            this.btnPointer9.FillColor = secondary;
            this.btnPointer9.BackColor = primary;
            this.btnPointer10.FillColor = secondary;
            this.btnPointer10.BackColor = primary;
            this.guna2CustomGradientPanel1.FillColor = primary;
            this.guna2CustomGradientPanel1.FillColor2 = primary;
            this.guna2CustomGradientPanel1.FillColor3 = primary;
            this.guna2CustomGradientPanel1.FillColor4 = primary;
            this.btnA.FillColor = primary;
            this.btnB.FillColor = primary;
            this.btnC.FillColor = primary;
            this.btnD.FillColor = primary;
            this.btnPrevious.FillColor = primary;
            this.btnNext.FillColor = primary;
            this.btnConfirm.FillColor = primary;
            this.panel1.BackColor = primary;
        }
        public void ChangeFlashCard(string content, int id)
        {
            lbMain.Text = content;
            pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath") + id.ToString() + ".jpg");
            InitAnswer();
            if (userChoices[currentQuiz].IsDone == true)
                btnNext.Enabled = true;
            else
                btnNext.Enabled = false;
            isPress = 0;
        }
        private void InitAnswer()
        {
            Random rd = new Random();
            UserChoice u = new UserChoice(-1, rd.Next(1, 5));
            userChoices.Add(u);
            switch (userChoices[currentQuiz].Correct)
            {
                case 1: 
                    btnA.Text = questions[currentQuiz].GetFlashCard().Viet;
                    btnB.Text = questions[currentQuiz].FakeAnswers[0];
                    btnC.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 2:
                    btnB.Text = questions[currentQuiz].GetFlashCard().Viet;
                    btnA.Text = questions[currentQuiz].FakeAnswers[0];
                    btnC.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 3:
                    btnC.Text = questions[currentQuiz].GetFlashCard().Viet;
                    btnB.Text = questions[currentQuiz].FakeAnswers[0];
                    btnA.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 4:
                    btnD.Text = questions[currentQuiz].GetFlashCard().Viet;
                    btnB.Text = questions[currentQuiz].FakeAnswers[0];
                    btnC.Text = questions[currentQuiz].FakeAnswers[1];
                    btnA.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
            }    
        }

        private void InitQuiz()
        {
            for (int i = 0; i < ManageUserAction.GetMainFlashCards().Count; i++)
            {
                List<string> fakeAnswers = new List<string>();
                List<string> backupAnswers = new List<string>() { "Trúcc Trúc", "Cẩm Nhi", "Ngọc Hà", "Minh Trâm", "Thái Mỹ", "Thanh Thúy", "Trúc Mai", "Thanh Trúc", "Khánh An", "Kim Nga", "Anh Thư"};
                Random rd = new Random();
                while (fakeAnswers.Count != 3)
                {
                    int index;
                    string vie;
                    if (ManageUserAction.GetMainFlashCards().Count > 3)
                    {
                        index = rd.Next(0, ManageUserAction.GetMainFlashCards().Count);
                        vie = ManageUserAction.GetMainFlashCards()[index].Viet;
                    }
                    else
                    {
                        index = rd.Next(0, backupAnswers.Count);
                        vie = backupAnswers[index];
                    }
                    
                    if (fakeAnswers.IndexOf(vie) < 0 && vie != ManageUserAction.GetMainFlashCards()[i].Viet)
                    {
                        fakeAnswers.Add(vie);
                    }
                }
                Quiz q = new Quiz(ManageUserAction.GetMainFlashCards()[i]);
                q.SetFakeAnswers(fakeAnswers[0], fakeAnswers[1], fakeAnswers[2]);
                questions.Add(q);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 1;
                btnA.FillColor = Color.FromArgb(107, 216, 255);
                btnB.FillColor = primary;
                btnC.FillColor = primary;
                btnD.FillColor = primary;
                isPress = 1;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 2;
                btnB.FillColor = Color.FromArgb(107, 216, 255);
                btnA.FillColor = primary;
                btnC.FillColor = primary;
                btnD.FillColor = primary;
                isPress = 1;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 3;
                btnC.FillColor = Color.FromArgb(107, 216, 255);
                btnA.FillColor = primary;
                btnB.FillColor = primary;
                btnD.FillColor = primary;
                isPress = 1;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 4;
                btnD.FillColor = Color.FromArgb(107, 216, 255);
                btnA.FillColor = primary;
                btnB.FillColor = primary;
                btnC.FillColor = primary;
                isPress = 1;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            userChoices[currentQuiz].CorrectAns = questions[currentQuiz].GetFlashCard().Eng;
            if (userChoices[currentQuiz].IsDone == false && isPress == 1)
            {
                ReloadButton();
                btnNext.Enabled = true;
                userChoices[currentQuiz].IsDone = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuiz == 0)
            {
                btnPrevious.Enabled = true;
                currentQuiz++; 
                if (ManageUserAction.GetMainFlashCards().Count > 1)
                    ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
            }

            else if (currentQuiz != questions.Count - 1)
            {
                currentQuiz++;
                if (ManageUserAction.GetMainFlashCards().Count > 1)
                    ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
            }
                
            else 
            {
                btnNext.Enabled = false;
                campaign.Reset();
                campaign.InitResult(userChoices);
                timerMultiple.Stop();
                //InitResult(10 - wrongAns, wrongAns);
                this.Close();
            }
            MovePointer(currentQuiz);

            if (currentQuiz < ManageUserAction.GetMainFlashCards().Count)
            {
                if (userChoices[currentQuiz].IsDone)
                    ReloadButton();
                else
                    ResetButton();
            }
            else
            {
                btnNext.Enabled = false;
                campaign.Reset();
                campaign.InitResult(userChoices);
                timerMultiple.Stop();
                //InitResult(10 - wrongAns, wrongAns);
                this.Close();
            }    

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentQuiz == 1)
            {
                btnPrevious.Enabled = false;
                currentQuiz--;
            }
            else
            {
                currentQuiz--;
            }

            ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
            MovePointer(currentQuiz);

            if (userChoices[currentQuiz].IsDone)
                ReloadButton();
            else
                ResetButton();

        }

        private void MovePointer(int currentQuiz)
        {
            btnPointer1.Visible = false;
            btnPointer2.Visible = false;
            btnPointer3.Visible = false;
            btnPointer4.Visible = false;
            btnPointer5.Visible = false;
            btnPointer6.Visible = false;
            btnPointer7.Visible = false;
            btnPointer8.Visible = false;
            btnPointer9.Visible = false;
            btnPointer10.Visible = false;
            switch (currentQuiz)
            {
                case 0:
                    btnPointer1.Visible = true;
                    break;
                case 1:
                    btnPointer2.Visible = true;
                    break;
                case 2:
                    btnPointer3.Visible = true;
                    break;
                case 3:
                    btnPointer4.Visible = true;
                    break;
                case 4:
                    btnPointer5.Visible = true;
                    break;
                case 5:
                    btnPointer6.Visible = true;
                    break;
                case 6:
                    btnPointer7.Visible = true;
                    break;
                case 7:
                    btnPointer8.Visible = true;
                    break;
                case 8:
                    btnPointer9.Visible = true;
                    break;
                case 9:
                    btnPointer10.Visible = true;
                    break;
            }
        }

        private void ResetButton()
        {
            btnD.FillColor = primary;
            btnA.FillColor = primary;
            btnB.FillColor = primary;
            btnC.FillColor = primary;
        }
        private void ReloadButton()
        {
            btnA.FillColor = primary;
            btnB.FillColor = primary;
            btnC.FillColor = primary;
            btnD.FillColor = primary;
            bool isCorrect = true;
            if (userChoices[currentQuiz].Selected != userChoices[currentQuiz].Correct)
            {
                isCorrect = false;
                switch (userChoices[currentQuiz].Selected)
                {
                    case 1:
                        btnA.FillColor = Color.FromArgb(224, 92, 92);
                        
                        break;
                    case 2:
                        btnB.FillColor = Color.FromArgb(224, 92, 92);
                        break;
                    case 3:
                        btnC.FillColor = Color.FromArgb(224, 92, 92);
                        break;
                    case 4:
                        btnD.FillColor = Color.FromArgb(224, 92, 92);
                        break;
                }
            }
            switch (userChoices[currentQuiz].Correct)
            {
                case 1:
                    btnA.FillColor = Color.FromArgb(108, 255, 125);
                    break;
                case 2:
                    btnB.FillColor = Color.FromArgb(108, 255, 125);
                    break;
                case 3:
                    btnC.FillColor = Color.FromArgb(108, 255, 125);
                    break;
                case 4:
                    btnD.FillColor = Color.FromArgb(108, 255, 125);
                    break;
            }

            if (isCorrect == true)
            {
                FlashCard fl = questions[currentQuiz].GetFlashCard();
                if (!ManageUserAction.IsFlashCardExist(0, fl.IdCard))
                AddFlashCard(fl);
                wrongAns--;
            }
        }

        private void AddFlashCard(FlashCard fl)
        {
            ManageUserAction.AddFlashCardToCollection(0, fl);
            ManageUserAction.AddFlashCardToDatabase(0, ManageUserAction.GetItemOfAllCollection(0).NameCollection, fl);
        }

        private void timerMultiple_Tick(object sender, EventArgs e)
        {
            if (timerMultiple.Enabled == false)
                return;

            time++;
            lbTimer.Text = (60 - time).ToString();
            if (time < 50)
            {
                lbTimer.ForeColor = Color.Black;
            }
            else
            {
                lbTimer.ForeColor = Color.Red;
            }
            if (time == 60)
            {
                timerMultiple.Stop();
                campaign.Reset();
                campaign.InitResult(userChoices);
               // InitResult(10 - wrongAns, wrongAns);
                this.Close();
            }
        }

        public void StartTimer()
        {
            timerMultiple.Enabled = true;
            timerMultiple.Start();
        }
    }
}
