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
        int isConfirmed = 0;
        List<UserChoice> userChoices = new List<UserChoice>();
        public MultipleChoiceForm(int currentTopic)
        {
            InitializeComponent();
            this.currentTopic = currentTopic;
            ManageUserAction.UpdateMainFlashCard(currentTopic);
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
        }
        private void InitAnswer()
        {
            Random rd = new Random();
            UserChoice u = new UserChoice(-1, rd.Next(1, 5));
            userChoices.Add(u);
            switch (userChoices[currentQuiz].Correct)
            {
                case 1: 
                    btnA.Text = questions[currentQuiz].CorrectAnswer;
                    btnB.Text = questions[currentQuiz].FakeAnswers[0];
                    btnC.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 2:
                    btnB.Text = questions[currentQuiz].CorrectAnswer;
                    btnA.Text = questions[currentQuiz].FakeAnswers[0];
                    btnC.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 3:
                    btnC.Text = questions[currentQuiz].CorrectAnswer;
                    btnB.Text = questions[currentQuiz].FakeAnswers[0];
                    btnA.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 4:
                    btnD.Text = questions[currentQuiz].CorrectAnswer;
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
                //isConfirmed = 1;
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
            //    isConfirmed = 1;
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
            //    isConfirmed = 1;
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
            //    isConfirmed = 1;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //if (isConfirmed == 1)
            //{
            if (userChoices[currentQuiz].IsDone == false)
            {
                ReloadButton();
                btnNext.Enabled = true;
                userChoices[currentQuiz].IsDone = true;
            }
            //}
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
                btnNext.Enabled = false;

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
                ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
            }

            else
            {
                currentQuiz--;
                ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
            }
            

            if (userChoices[currentQuiz].IsDone)
                ReloadButton();
            else
                ResetButton();

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
            if (userChoices[currentQuiz].Selected != userChoices[currentQuiz].Correct)
            {
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
        }
    }
}
