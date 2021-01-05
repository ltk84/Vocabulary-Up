using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class Bullet: ImgRendingObject
    {
        bool isBoom;
        public Bullet(Image image, Point location, Size size, int v): base(image, location, size, v)
        {
            this.isBoom = false;
        }
        public bool IsBoom { get => isBoom; set => isBoom = value; }
    }
}
