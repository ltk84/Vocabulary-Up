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
        public FillBlankForm(int currentTopic)
        {
            InitializeComponent();
            this.currentTopic = currentTopic;
            ManageUserAction.UpdateMainFlashCard(currentTopic);
            InitQuiz();
            ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
        }
        public void ChangeFlashCard(string content, int id)
        {
            lbMain_FB.Text = content;
            pbMain_FB.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath") + id.ToString() + ".jpg");
        }
        private void InitQuiz()
        {
            for (int i = 0; i < ManageUserAction.GetMainFlashCards().Count; i++)
            {
                Quiz q = new Quiz(ManageUserAction.GetMainFlashCards()[i]);
                questions.Add(q);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == questions[currentQuiz].GetFlashCard().Eng)
            {

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

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
    }
}
