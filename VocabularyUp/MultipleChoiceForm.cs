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
        List<Quiz> questions = new List<Quiz>();
        int currentTopic = 0;
        int currentQuiz = 0;
        int isPress = 0;
        List<UserChoice> userChoices = new List<UserChoice>();
        CampaignForm campaign = new CampaignForm();
        int time;
        public MultipleChoiceForm(int currentTopic, CampaignForm campaign)
        {
            InitializeComponent();
            this.currentTopic = currentTopic;
            this.campaign = campaign;
            //ManageUserAction.UpdateMainFlashCard(currentTopic);
            InitQuiz();
            ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
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
                Random rd = new Random();
                while (fakeAnswers.Count != 3)
                {
                    int index = rd.Next(0, ManageUserAction.GetMainFlashCards().Count);
                    string vie = ManageUserAction.GetMainFlashCards()[index].Viet;
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
                btnB.FillColor = Color.FromArgb(192, 255, 192);
                btnC.FillColor = Color.FromArgb(192, 255, 192);
                btnD.FillColor = Color.FromArgb(192, 255, 192);
                isPress = 1;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 2;
                btnB.FillColor = Color.FromArgb(107, 216, 255);
                btnA.FillColor = Color.FromArgb(192, 255, 192);
                btnC.FillColor = Color.FromArgb(192, 255, 192);
                btnD.FillColor = Color.FromArgb(192, 255, 192);
                isPress = 1;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 3;
                btnC.FillColor = Color.FromArgb(107, 216, 255);
                btnA.FillColor = Color.FromArgb(192, 255, 192);
                btnB.FillColor = Color.FromArgb(192, 255, 192);
                btnD.FillColor = Color.FromArgb(192, 255, 192);
                isPress = 1;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 4;
                btnD.FillColor = Color.FromArgb(107, 216, 255);
                btnA.FillColor = Color.FromArgb(192, 255, 192);
                btnB.FillColor = Color.FromArgb(192, 255, 192);
                btnC.FillColor = Color.FromArgb(192, 255, 192);
                isPress = 1;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false && isPress == 1)
            {
                ReloadButton();
                btnNext.Enabled = true;
                userChoices[currentQuiz].IsDone = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            //if (currentQuiz != questions.Count - 1)
            //{
            //    if (questions[currentQuiz].Selected == -1)
            //    {
            //        currentQuiz++;
            //        ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
            //        btnNext.Enabled = false;
            //        isConfirmed = 0;
            //        ResetButton();
            //    }
            //    else
            //    {
            //        ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
            //        ReloadButton();
            //    }
            //}
            //else
            //{
            //    btnNext.Enabled = false;
            //}
            if (currentQuiz == 0)
            {
                btnPrevious.Enabled = true;
                currentQuiz++; 
                ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
            }

            else if (currentQuiz != questions.Count - 1)
            {
                currentQuiz++;
                ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
            }
                
            else 
            {
                btnNext.Enabled = false;
                campaign.Return();
                timerMultiple.Stop();
                this.Close();
            }
            MovePointer(currentQuiz);


            if (userChoices[currentQuiz].IsDone)
                ReloadButton();
            else
                ResetButton();

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
            btnD.FillColor = Color.FromArgb(192, 255, 192);
            btnA.FillColor = Color.FromArgb(192, 255, 192);
            btnB.FillColor = Color.FromArgb(192, 255, 192);
            btnC.FillColor = Color.FromArgb(192, 255, 192);
        }
        private void ReloadButton()
        {
            btnA.FillColor = Color.FromArgb(192, 255, 192);
            btnB.FillColor = Color.FromArgb(192, 255, 192);
            btnC.FillColor = Color.FromArgb(192, 255, 192);
            btnD.FillColor = Color.FromArgb(192, 255, 192);
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
            }
        }

        private void AddFlashCard(FlashCard fl)
        {
            ManageUserAction.AddFlashCardToCollection(0, fl);
            ManageUserAction.AddFlashCardToDatabase(0, ManageUserAction.GetItemOfAllCollection(0).NameCollection, fl);
        }

        private void timerMultiple_Tick(object sender, EventArgs e)
        {
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
                campaign.Return();
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
