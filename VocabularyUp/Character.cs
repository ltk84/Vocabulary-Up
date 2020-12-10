using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class Character
    {
        private int id;
        private string name;
        private int health;
        private int damage;
        private int price;

        public Character(int id, string name, int health, int damage, int price)
        {
            this.id = id;
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.price = price;
        }

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Price { get => price; set => price = value; }
    }
}
