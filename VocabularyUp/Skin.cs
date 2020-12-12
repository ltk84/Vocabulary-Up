using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class Skin
    {
        private int id;
        private string name;
        private int price;

        public Skin(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }
}
