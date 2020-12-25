using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    enum Direction { Up, Down, Left, Right};
    abstract class ImgRendingObject
    {
        Image image;
        Point location;
        Size size;
        int v;

        protected ImgRendingObject(Image image, Point location, Size size, int v)
        {
            this.image = image;
            this.location = location;
            this.size = size;
            this.v = v;
        }

        public Image Image { get => image; set => image = value; }
        public Point Location { get => location; set => location = value; }
        public int X { get => location.X; set => location.X = value; }
        public int Y { get => location.Y; set => location.Y = value; }
        public Size Size { get => size; set => size = value; }
        public int V { get => v; set => v = value; }

        public Rectangle Rect { get => new Rectangle(this.location, this.size); }
        virtual public void Draw(Graphics g)
        {
            g.DrawImage(this.image, new Rectangle(this.location, this.size), new Rectangle(0, 0, this.image.Width, this.image.Height), GraphicsUnit.Pixel);
        }
        public void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Up:
                    location.Y -= v;
                    break;
                case Direction.Down:
                    location.Y += v;
                    break;
                case Direction.Left:
                    location.X -= v;
                    break;
                case Direction.Right:
                    location.X += v;
                    break;
                default:
                    break;
            }
        }

        public void HandleOutsideClient(Form f)
        {

            int x = location.X;
            int y = location.Y;
            Size size = this.Size;

            if (x + size.Width > f.Width)
                x = f.Width - (size.Width);

            if (y < f.Height / 3)
                y = f.Height / 3;

            if (x < 0)
                x = 0;

            if (y + size.Height > f.Height)
                y = f.Height - size.Height;

            location.X = x;
            location.Y = y;
        }

        virtual public bool isCollision(ImgRendingObject obj)
        {
            return this.Rect.IntersectsWith(obj.Rect);
        }

        virtual public Bullet Attack(int idWeapon)
        {
            Image image = Image.FromFile(@ConfigurationManager.AppSettings.Get("imgPath_database") + "Fires/" + idWeapon.ToString() + ".png");
            //Image image = Image.FromFile(@ConfigurationManager.AppSettings.Get("imgPath_database") + "Fires/bullet.png");
            return new Bullet(image, this.location, this.size, 100);
        }
    }
}
