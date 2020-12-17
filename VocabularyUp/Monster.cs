using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class Monster:ImgRendingObject
    {
        List<Quiz> quizzes;
        Direction cur = Direction.Down;
        bool isDeath = false;
        bool isBoss;
        public Monster(Image image, Point loc, Size size, int v, List<Quiz> q, bool isBoss): base(image, loc, size, v)
        {
            this.quizzes = q;
            this.isBoss = isBoss;
        }
        public Direction Cur { get => cur; set => cur = value; }
        public bool IsDeath { get => isDeath; set => isDeath = value; }
        public bool IsBoss { get => isBoss; set => isBoss = value; }
    }
}
