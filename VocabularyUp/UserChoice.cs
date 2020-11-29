﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class UserChoice
    {
        private int selected;
        private int correct;
        private bool isDone = false;
        private string correctAns;
        private string answer;

        public UserChoice(int selected, int correct)
        {
            this.selected = selected;
            this.correct = correct;
        }

        public UserChoice(string correctAns, string answer)
        {
            this.correctAns = correctAns;
            this.answer = answer;
        }

        public int Selected { get => selected; set => selected = value; }
        public int Correct { get => correct; set => correct = value; }
        public bool IsDone { get => isDone; set => isDone = value; }
        public string CorrectAns { get => correctAns; set => correctAns = value; }
        public string Answer { get => answer; set => answer = value; }
    }
}