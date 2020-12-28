using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VocabularyUp
{
    class MonsterMaze : ImgMazeObject
    {
        List<Quiz> quizzes;
        Direction1 cur = Direction1.Down;
        bool isDeath = false;
        bool isBoss;
        public MonsterMaze(Image image, Point loc, Size size, int v, List<Quiz> q, bool isBoss) : base(image, loc, size, v)
        {
            this.quizzes = q;
            this.isBoss = isBoss;
        }
        public Direction1 Cur { get => cur; set => cur = value; }
        public bool IsDeath { get => isDeath; set => isDeath = value; }
        public bool IsBoss { get => isBoss; set => isBoss = value; }
    }
}
