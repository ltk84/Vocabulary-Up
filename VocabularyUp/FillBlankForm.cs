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
    public partial class FillBlankForm : Form
    {
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        int darkMode = 0;
        List<Quiz> questions = new List<Quiz>();
        int currentTopic = 0;
        int currentQuiz = 0;
        int  wrongAns = 10;
        List<UserChoice> userChoices = new List<UserChoice>();
        CampaignForm campaignForm;
        int time = 0;
        public int result = 1;
        public FillBlankForm(int currentTopic, CampaignForm campaignForm)
        {
            InitializeComponent();
            UpdateTheme();
            this.currentTopic = currentTopic;
            this.campaignForm = campaignForm;
            this.KeyPreview = true;
            int res = ManageUserAction.UpdateMainFlashCard(currentTopic);
            if (res == 0)
            {
                result = 0;
                return;
            }
            InitQuiz();
            InitAnswer();
            ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
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
            this.pnlQuizFB.BackColor = primary;
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
            this.guna2CustomGradientPanel4.FillColor = primary;
            this.guna2CustomGradientPanel4.FillColor2 = primary;
            this.guna2CustomGradientPanel4.FillColor3 = primary;
            this.guna2CustomGradientPanel4.FillColor4 = primary;
            this.btnPrevious.FillColor = primary;
            this.btnNext.FillColor = primary;
            this.btnConfirm.FillColor = primary;
            this.panel1.BackColor = primary;
        }
        public void ChangeFlashCard(string content, int id)
        {
            lbMain_FB.Text = content;
            pbMain_FB.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath") + id.ToString() + ".jpg");
            lbCorrectAnswer.Text = userChoices[currentQuiz].CorrectAns;
            if (userChoices[currentQuiz].IsDone == true)
                btnNext.Enabled = true;
            else
                btnNext.Enabled = false;
        }
        private void InitQuiz()
        {
            for (int i = 0; i < ManageUserAction.GetMainFlashCards().Count; i++)
            {
                Quiz q = new Quiz(ManageUserAction.GetMainFlashCards()[i]);
                questions.Add(q);
            }
        }

        private void InitAnswer()
        {
            foreach (var item in questions)
            {
                UserChoice u = new UserChoice(item.GetFlashCard().Eng, "");
                userChoices.Add(u);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text.ToLower();
            userChoices[currentQuiz].CorrectAns = questions[currentQuiz].GetFlashCard().Eng;
            userChoices[currentQuiz].Correct = 0;
            if (txtAnswer.Text != null && txtAnswer.Text.Length != 0)
            {
                bool isCorrect = true;
                if (txtAnswer.Text != questions[currentQuiz].GetFlashCard().Eng)
                {
                    lbWrong.Visible = true;
                    isCorrect = false;
                    userChoices[currentQuiz].Selected = -1;
                }

                lbCorrectAnswer.Text = questions[currentQuiz].GetFlashCard().Eng;   
                lbCorrectAnswer.Visible = true;
                userChoices[currentQuiz].IsDone = true;
                btnNext.Enabled = true;
                userChoices[currentQuiz].Answer = txtAnswer.Text;
                userChoices[currentQuiz].IsDone = true;
                txtAnswer.Enabled = false;

                if (isCorrect == true)
                {
                    FlashCard fl = questions[currentQuiz].GetFlashCard();
                    if (!ManageUserAction.IsFlashCardExist(0, fl.IdCard))
                        AddFlashCard(fl);
                    wrongAns--;
                    userChoices[currentQuiz].Selected = 0;
                }
            }
        }

        private void AddFlashCard(FlashCard fl)
        {
            ManageUserAction.AddFlashCardToCollection(0, fl);
            ManageUserAction.AddFlashCardToDatabase(0, ManageUserAction.GetItemOfAllCollection(0).NameCollection, fl);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuiz == 0)
            {
                btnPrevious.Enabled = true;
                currentQuiz++;
                if (ManageUserAction.GetMainFlashCards().Count > 1)
                    ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
            }

            else if (currentQuiz != questions.Count - 1)
            {
                currentQuiz++;
                if (ManageUserAction.GetMainFlashCards().Count > 1)
                    ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
            }

            else
            {
                btnNext.Enabled = false;
                campaignForm.Reset();
                campaignForm.InitResult(userChoices);
                timerFillBlank.Stop();
                this.Close();
            }

            MovePointer(currentQuiz);

            if (currentQuiz < ManageUserAction.GetMainFlashCards().Count)
            {
                if (userChoices[currentQuiz].IsDone)
                    Reload();
                else
                    Reset();
            }
            else
            {
                btnNext.Enabled = false;
                campaignForm.Reset();
                campaignForm.InitResult(userChoices);
                timerFillBlank.Stop();
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

            ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
            MovePointer(currentQuiz);

            Reload();
        }

        private void Reset()
        {
            txtAnswer.Text = "";
            txtAnswer.Enabled = true;
            lbWrong.Visible = false;
            lbCorrectAnswer.Visible = false;
            txtAnswer.Enabled = true;
            txtAnswer.Focus();
        }

        private void Reload()
        {
            if (userChoices[currentQuiz].CorrectAns != userChoices[currentQuiz].Answer)
            {
                lbWrong.Visible = true;
                txtAnswer.Enabled = false;
            }
            else
                lbWrong.Visible = false;

            txtAnswer.Text = userChoices[currentQuiz].Answer;
            lbCorrectAnswer.Visible = true;
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

       


        private void timerFillBlank_Tick(object sender, EventArgs e)
        {
            if (timerFillBlank.Enabled == false)
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
                timerFillBlank.Stop();
                campaignForm.Reset();
                campaignForm.InitResult(userChoices);
                //InitResult(10 - wrongAns, wrongAns);
                this.Close();
            }
        }



        public void StartTimer()
        {
            timerFillBlank.Enabled = true;
            timerFillBlank.Start();
        }

        private void FillBlankForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && btnNext.Enabled == true)
                btnNext_Click(sender, e);
            else if (e.KeyCode == Keys.Left && btnPrevious.Enabled == true)
                btnPrevious_Click(sender, e);
        }
    }
}
