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
    public partial class GameMCForm : Form
    {
        int isPress = 0;
        List<UserChoice> userChoices = new List<UserChoice>();
        List<Quiz> questions = new List<Quiz>();
        int time;
        int currentQuiz = 0;
        bool isCorrect = false;
        public GameMCForm()
        {
            InitializeComponent();
            ManageUserAction.UpdateGameMainFlashCards();
            InitQuiz();
            ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
        }
        public void ChangeFlashCard(string content, int id)
        {
            lbMain.Text = content;
            pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + id.ToString() + ".jpg");
            InitAnswer();
            
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
                List<string> backupAnswers = new List<string>() { "Trúcc Trúc", "Cẩm Nhi", "Ngọc Hà", "Minh Trâm", "Thái Mỹ", "Thanh Thúy", "Trúc Mai", "Thanh Trúc", "Khánh An", "Kim Nga", "Anh Thư" };
                Random rd = new Random();
                while (fakeAnswers.Count != 3)
                {
                    int index;
                    string vie = "a";
                    if (ManageUserAction.GetMainFlashCards().Count > 3)
                    {
                        do
                        {
                            index = rd.Next(0, ManageUserAction.GetMainFlashCards().Count);
                            vie = ManageUserAction.GetMainFlashCards()[index].Viet;
                        } while (vie == "");
                        
                    }
                    else
                    {
                        do
                        {
                            index = rd.Next(0, ManageUserAction.GetMainFlashCards().Count);
                            vie = ManageUserAction.GetMainFlashCards()[index].Viet;
                        } while (vie == "");
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
                //btnA.FillColor = Color.FromArgb(107, 216, 255);
                //btnB.FillColor = Color.FromArgb(17, 223, 158);
                //btnC.FillColor = Color.FromArgb(17, 223, 158);
                //btnD.FillColor = Color.FromArgb(17, 223, 158);
                btnA.BorderThickness = 5;
                btnB.BorderThickness = 0;
                btnC.BorderThickness = 0;
                btnD.BorderThickness = 0;
                isPress = 1;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 2;
                //btnB.FillColor = Color.FromArgb(107, 216, 255);
                //btnA.FillColor = Color.FromArgb(17, 223, 158);
                //btnC.FillColor = Color.FromArgb(17, 223, 158);
                //btnD.FillColor = Color.FromArgb(17, 223, 158);
                btnA.BorderThickness = 0;
                btnB.BorderThickness = 5;
                btnC.BorderThickness = 0;
                btnD.BorderThickness = 0;
                isPress = 1;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 3;
                //btnC.FillColor = Color.FromArgb(107, 216, 255);
                //btnA.FillColor = Color.FromArgb(17, 223, 158);
                //btnB.FillColor = Color.FromArgb(17, 223, 158);
                //btnD.FillColor = Color.FromArgb(17, 223, 158);
                btnA.BorderThickness = 0;
                btnB.BorderThickness = 0;
                btnC.BorderThickness = 5;
                btnD.BorderThickness = 0;
                isPress = 1;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 4;
                //btnD.FillColor = Color.FromArgb(107, 216, 255);
                //btnA.FillColor = Color.FromArgb(17, 223, 158);
                //btnB.FillColor = Color.FromArgb(17, 223, 158);
                //btnC.FillColor = Color.FromArgb(17, 223, 158);
                btnA.BorderThickness = 0;
                btnB.BorderThickness = 0;
                btnC.BorderThickness = 0;
                btnD.BorderThickness = 5;
                isPress = 1;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            userChoices[currentQuiz].CorrectAns = questions[currentQuiz].GetFlashCard().Eng;
            if (userChoices[currentQuiz].IsDone == false && isPress == 1)
            {
                //ReloadButton();
                userChoices[currentQuiz].IsDone = true;
                if (userChoices[currentQuiz].Selected == userChoices[currentQuiz].Correct)
                    isCorrect = true;
              
            }

            if (userChoices[currentQuiz].Selected != -1)
                this.Close();

        }

        public bool IsCorrect { get => isCorrect; }

        
    }
}
