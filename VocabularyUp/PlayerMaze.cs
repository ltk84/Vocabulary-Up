using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VocabularyUp
{
    class PlayerMaze : ImgMazeObject
    {
        string name;
        int health;
        int damage;
        public PlayerMaze(Image image, Point location, Size size, int speed) : base(image, location, size, speed)
        {

        }
        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Damage { get => damage; set => damage = value; }
    }
}
