using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class Equipment
    {
        private int idType;
        private int idEquip;
        private string name;

        public Equipment(int idType, int idEquip, string name)
        {
            this.idType = idType;
            this.idEquip = idEquip;
            this.name = name;
        }

        public int IdType { get => idType; set => idType = value; }
        public int IdEquip { get => idEquip; set => idEquip = value; }
        public string Name { get => name; set => name = value; }
    }
}
