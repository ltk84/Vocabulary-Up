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
        List<Quiz> questions = new List<Quiz>();
        int currentTopic = 0;
        int currentQuiz = 0;
        int  wrongAns = 0;
        List<UserChoice> userChoices = new List<UserChoice>();
        CampaignForm campaignForm;
        int time = 0;
        public FillBlankForm(int currentTopic, CampaignForm campaignForm)
        {
            InitializeComponent();
            this.currentTopic = currentTopic;
            this.campaignForm = campaignForm;
            this.KeyPreview = true;
            ManageUserAction.UpdateMainFlashCard(currentTopic);
            InitQuiz();
            InitAnswer();
            ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
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
            if (txtAnswer.Text != null && txtAnswer.Text.Length != 0)
            {
                bool isCorrect = true;
                if (txtAnswer.Text != questions[currentQuiz].GetFlashCard().Eng)
                {
                    lbWrong.Visible = true;
                    isCorrect = false;
                    wrongAns++;
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
                ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
            }

            else if (currentQuiz != questions.Count - 1)
            {
                currentQuiz++;
                ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
            }

            else
            {
                btnNext.Enabled = false;
                this.campaignForm.Return();
                timerFillBlank.Stop();
                InitResult(10 - wrongAns, wrongAns);
                this.Close();
            }

            MovePointer(currentQuiz);

            if (userChoices[currentQuiz].IsDone)
                Reload();
            else
                Reset();
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
                campaignForm.Return();
                InitResult(10 - wrongAns, wrongAns);
                this.Close();
            }
        }

        public void InitResult(int correct, int wrong)
        {
            ResultForm res = new ResultForm(correct, wrong);
            res.ChangeLabel();
            res.StartPosition = FormStartPosition.CenterScreen;
            res.TopMost = true;
            res.Show();
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
