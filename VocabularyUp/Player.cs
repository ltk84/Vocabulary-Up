using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class Player: ImgRendingObject
    {
        string name;
        int health;
        int damage;
        public Player(Image image, Point loc, Size size, int v): base(image, loc, size, v)
        {
            
        }
         
        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Damage { get => damage; set => damage = value; }
    }
}
