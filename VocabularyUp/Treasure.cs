using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VocabularyUp
{
    class Treasure : ImgMazeObject
    {
        bool isDeath = false;
        bool isLastTreasure;
        public Treasure(Image image, Point location,Size size, int speed, bool isLastTreasure) : base (image,location,size,speed)
        {
            this.isLastTreasure = isLastTreasure;
        }
        public bool IsDeath { get => isDeath; set => isDeath = value; }
        public bool IsLastTreasure { get => isLastTreasure; set => isLastTreasure = value; }
    }
}
