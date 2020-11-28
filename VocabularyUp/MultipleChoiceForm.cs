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
        int pivotCurrent = 0;
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
        }
        private void InitAnswer()
        {
            Random rd = new Random();
            questions[currentQuiz].Correct = rd.Next(1, 5);
            switch (questions[currentQuiz].Correct)
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
            if (isConfirmed == 0)
            {
                questions[currentQuiz].Selected = 1;
                btnA.FillColor = Color.FromArgb(107, 216, 255);
                btnB.FillColor = Color.FromArgb(192, 255, 192);
                btnC.FillColor = Color.FromArgb(192, 255, 192);
                btnD.FillColor = Color.FromArgb(192, 255, 192);
                isConfirmed = 1;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (isConfirmed == 0)
            {
                questions[currentQuiz].Selected = 2;
                btnB.FillColor = Color.FromArgb(107, 216, 255);
                btnA.FillColor = Color.FromArgb(192, 255, 192);
                btnC.FillColor = Color.FromArgb(192, 255, 192);
                btnD.FillColor = Color.FromArgb(192, 255, 192);
                isConfirmed = 1;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (isConfirmed == 0)
            {
                questions[currentQuiz].Selected = 3;
                btnC.FillColor = Color.FromArgb(107, 216, 255);
                btnA.FillColor = Color.FromArgb(192, 255, 192);
                btnB.FillColor = Color.FromArgb(192, 255, 192);
                btnD.FillColor = Color.FromArgb(192, 255, 192);
                isConfirmed = 1;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (isConfirmed == 0)
            {
                questions[currentQuiz].Selected = 4;
                btnD.FillColor = Color.FromArgb(107, 216, 255);
                btnA.FillColor = Color.FromArgb(192, 255, 192);
                btnB.FillColor = Color.FromArgb(192, 255, 192);
                btnC.FillColor = Color.FromArgb(192, 255, 192);
                isConfirmed = 1;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isConfirmed == 1)
            {
                ReloadButton();
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuiz == 0)
            {
                btnPrevious.Enabled = true;
            }
            if (currentQuiz != questions.Count - 1)
            {
                if (currentQuiz == pivotCurrent)
                {
                    currentQuiz++;
                    pivotCurrent++;
                    ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
                    btnNext.Enabled = false;
                    isConfirmed = 0;
                    ResetButton();
                }
                else
                {
                    ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
                    currentQuiz++;
                    ReloadButton();
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentQuiz != 0)
            {
                currentQuiz--;
                ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
                ReloadButton();
            }
            if (currentQuiz == 0)
            {
                btnPrevious.Enabled = false;
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
            if (questions[currentQuiz].Selected != questions[currentQuiz].Correct)
            {
                switch (questions[currentQuiz].Selected)
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
            switch (questions[currentQuiz].Correct)
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
