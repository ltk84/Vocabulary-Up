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
        private List<Monster> monsters;
        private bool isGameOver;
        private Random rd = new Random();
        public WalkthroughForm(int idCol, int idSkin)
        {
            InitializeComponent();
            LoadBackGround();
            InitCollecion(idCol);
            InitPlayer(idSkin);
            InitMonster();
            timerUpdate.Start();
            isGameOver = false;
        }

        public void InitPlayer(int idSkin)
        {
            Image image = Image.FromFile("../../db/Characters/" + idSkin.ToString() + ".png");
            Point location = new Point(0, this.ClientSize.Height / 2);
            Size size = new Size(30, 30);

            player = new Player(image, location, size, 10);

            ManageUserAction.LoadPlayerStat(idSkin, player);
        }

        public  void InitCollecion(int idCol)
        {
            choosedCol = ManageUserAction.GetItemOfAllCollection(idCol);
        }

        public void InitMonster()
        {
            //Image image = Image.FromFile("../../db/Monsters/3.png");
            //image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            //Point location = new Point(this.ClientSize.Width/ 2 , this.ClientSize.Height / 2);
            //Size size = new Size(150, 150);

            //monster = new Monster(image, location, size, null);

            monsters = new List<Monster>();
            for (int i = 0; i < 3; i++)
            {
                
                Image image = Image.FromFile("../../db/Monsters/" + (i+1).ToString() + ".png");
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                Size size = new Size(60, 60);
                int y = rd.Next(this.Height * 2 / 3, this.Height - size.Height);
                Point location = new Point(((i + 1) * this.ClientSize.Width / 4), y);


                Monster mon;
                int v = rd.Next(10, 20);
                mon = new Monster(image, location, size, v, null);

                if (i == 2)
                {
                   location = new Point(((i + 1) * this.ClientSize.Width / 4),  this.Height * 2 / 3);
                  
                    mon = new Monster(image, location, size, 0, null);
                }    

                monsters.Add(mon);
            }
        }

        public void LoadBackGround()
        {
            this.BackgroundImage = Image.FromFile("../../db/Backgrounds/maps/map_1.jpg");
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            player.Draw(g);

            foreach (var mon in monsters)
            {
                mon.Draw(g);
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            player.HandleOutsideClient(this);

            if (!isGameOver)
            {
                foreach (var mon in monsters)
                {
                    if (player.isCollision(mon))
                        isGameOver = true;
                    else
                    {
                        mon.Move(mon.Cur);

                        if (mon.Y + mon.Size.Height > this.Height)
                            mon.Cur = Direction.Up;
                        else if (mon.Y < this.Height / 3)
                            mon.Cur = Direction.Down;
                    }
                }
            }

            this.Invalidate();
        }

        private void WalkthroughForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.Move(Direction.Left);
                    break;
                case Keys.Right:
                    player.Move(Direction.Right);
                    break;
                case Keys.Up:
                    player.Move(Direction.Up);
                    break;
                case Keys.Down:
                    player.Move(Direction.Down);
                    break;
                case Keys.Space:
                    break;
            }
        }

        private void HandlePlayerOutsideClient()
        {

            int x = player.X;
            int y = player.Y;
            Size size = player.Size;

            if (x + size.Width > this.Width)
                x = this.Width - (size.Width);

            if (y  < this.Height / 3)
                y = this.Height / 3;

            if (x  < 0)
                x = 0;

            if (y + size.Height > this.Height)
                y = this.Height - size.Height;

            player.X = x;
            player.Y = y;
        }
    }
}
