using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class Quiz
    {
        FlashCard fl;
        string correctAnswer;
        string userAnswer;
        int selectedMP;
        int correctMP;
        int typeQuiz;
        string[] fakeAnswers = new string[3];
        int[] fakeChoices = new int[3];
        public Quiz(FlashCard fl, int typeQuiz)
        {
            this.fl = fl;
            this.typeQuiz = typeQuiz;
            this.correctAnswer = this.fl.Eng;
            this.userAnswer = "";
            this.selectedMP = -1;
            this.correctMP = -1;
        }

        public void SetFakeAnswers(string a1, string a2, string a3)
        {
            fakeAnswers[0] = a1;
            fakeAnswers[1] = a2;
            fakeAnswers[2] = a3;
        }

        public void SetFakeChoices(int i1, int i2, int i3)
        {
            fakeChoices[0] = i1;
            fakeChoices[1] = i2;
            fakeChoices[2] = i3;
        }

        public void SetUserAnswer(string content)
        {
            this.userAnswer = content;
        }

        public void SetSelectedChoice(int i)
        {
            this.selectedMP = i;
        }

        public void SetCorrectAnswer(int i)
        {
            this.correctMP = i;
        }
        public int GetTypeQuiz()
        {
            return typeQuiz;
        }
    }
}
