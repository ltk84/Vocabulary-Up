﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class FlashCard
    {
        private int idCard;
        private string eng;
        private string viet;
        private string definition;
        private string pronunciation;
        private string example;
        private string field;

        public FlashCard(int idCard, string eng, string viet, string definition, string pronunciation, string example, string field)
        {
            this.idCard = idCard;
            this.eng = eng;
            this.viet = viet;
            this.definition = definition;
            this.pronunciation = pronunciation;
            this.example = example;
            this.field = field;
        }

        public int IdCard { get => idCard; set => idCard = value; }
        public string Eng { get => eng; set => eng = value; }
        public string Viet { get => viet; set => viet = value; }
        public string Definition { get => definition; set => definition = value; }
        public string Pronunciation { get => pronunciation; set => pronunciation = value; }
        public string Example { get => example; set => example = value; }
        public string Field { get => field; set => field = value; }
    }
}
