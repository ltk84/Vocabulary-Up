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
        string[] fakeAnswers = new string[3];
        int selected;
        int correct;
        public Quiz(FlashCard fl)
        {
            this.fl = fl;
            this.correctAnswer = this.fl.Viet;
            selected = -1;
            correct = -1;
        }
        public FlashCard GetFlashCard()
        {
            return fl;
        }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public string[] FakeAnswers { get => fakeAnswers; set => fakeAnswers = value; }
        public int Selected { get => selected; set => selected = value; }
        public int Correct { get => correct; set => correct = value; }

        public void SetFakeAnswers(string a1, string a2, string a3)
        {
            fakeAnswers[0] = a1;
            fakeAnswers[1] = a2;
            fakeAnswers[2] = a3;
        }

    }
}
