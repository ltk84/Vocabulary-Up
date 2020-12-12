using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    location.Y += v;
                    break;
                case Direction.Down:
                    location.Y -= v;
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

        virtual public bool isCollision(ImgRendingObject obj)
        {
            return this.Rect.IntersectsWith(obj.Rect);
        }

        public Bullet Attack()
        {
            Image image = Image.FromFile("../../");
            return new Bullet(image, this.location, this.size, 10);
        }
    }
}
