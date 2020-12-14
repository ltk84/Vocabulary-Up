using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    public partial class WalkthroughForm : Form
    {
        private Collection choosedCol;
        private Player player;
        private Monster monster;
        public WalkthroughForm(int idCol, int idSkin)
        {
            InitializeComponent();
            InitCollecion(idCol);
            InitPlayer(idSkin);
            InitMonster();
        }

        public void InitPlayer(int idSkin)
        {
            Image image = Image.FromFile("../../db/Characters/" + idSkin.ToString() + ".png");
            Point location = new Point(0, this.ClientSize.Height / 2);
            Size size = new Size(60, 60);

            player = new Player(image, location, size, 10);

            ManageUserAction.LoadPlayerStat(idSkin, player);
        }

        public  void InitCollecion(int idCol)
        {
            choosedCol = ManageUserAction.GetItemOfAllCollection(idCol);
        }

        public void InitMonster()
        {
            Image image = Image.FromFile("../../db/");
            Point location = new Point(this.ClientSize.Width - 20, this.ClientSize.Height / 2);
            Size size = new Size(60, 60);

            Monster mon = new Monster(image, location, size, null);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            player.Draw(g);

            monster.Draw(g);
        }
    }
}
