using System;
using System.Collections.Generic;
using System.Configuration;
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
        public override Bullet Attack(int idWeapon)
        {
            Image image = Image.FromFile(@ConfigurationManager.AppSettings.Get("imgPath_database") + "Fires/m_1.png");
            return new Bullet(image, new Point(this.Location.X, this.Location.Y + this.Size.Height / 2), new Size(this.Size.Width / 2, this.Size.Height / 2), 100);
        }
    }
}
