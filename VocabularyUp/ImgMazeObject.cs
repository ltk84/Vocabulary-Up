using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    enum Direction1 { Up, Down, Left, Right };
    abstract class ImgMazeObject
    {
        Image image;
        Point location;
        Size size;
        int speed;
        protected ImgMazeObject(Image image, Point location, Size size, int speed)
        {
            this.image = image;
            this.location = location;
            this.size = size;
            this.speed = speed;
        }
        public Image Image { get => image; set => image = value; }
        public Point Location { get => location; set => location = value; }
        public int X { get => location.X; set => location.X = value; }
        public int Y { get => location.Y; set => location.Y = value; }
        public Size Size { get => size; set => size = value; }
        public int Speed { get => speed; set => speed = value; }

        public Rectangle rec { get => new Rectangle(this.location, this.size); }

        virtual public void Draw(Graphics g)
        {
            g.DrawImage(this.image, new Rectangle(this.location, this.size), new Rectangle(0, 0, this.image.Width, this.image.Height), GraphicsUnit.Pixel);
        }
        public void Move(Direction1 dir)
        {
            switch (dir)
            {
                case Direction1.Up:
                    location.Y -= speed;
                    break;
                case Direction1.Down:
                    location.Y += speed;
                    break;
                case Direction1.Left:
                    location.X -= speed;
                    break;
                case Direction1.Right:
                    location.X += speed;
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

                if (x > 925)
                    x = 925;

                if (y < 125)
                    y = 125;

                if (x < 25)
                    x = 25;

                if (y > 625)
                    y = 625;

                location.X = x;
                location.Y = y;
         }
        virtual public bool isCollision(ImgMazeObject obj)
        {
            return this.rec.IntersectsWith(obj.rec);
        }
    }
}

