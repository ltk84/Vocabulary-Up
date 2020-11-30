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
        string[] fakeAnswers = new string[3];
        public Quiz(FlashCard fl)
        {
            this.fl = fl;
        }
        public FlashCard GetFlashCard()
        {
            return fl;
        }
        public string[] FakeAnswers { get => fakeAnswers; set => fakeAnswers = value; }

        public void SetFakeAnswers(string a1, string a2, string a3)
        {
            fakeAnswers[0] = a1;
            fakeAnswers[1] = a2;
            fakeAnswers[2] = a3;
        }

    }
}
