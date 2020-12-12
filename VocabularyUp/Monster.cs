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
        public Monster(Image image, Point loc, Size size, List<Quiz> q): base(image, loc, size, 0)
        {
            this.quizzes = q;
        }
    }
}
