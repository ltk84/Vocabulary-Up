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
    public partial class MazeGameFrom : Form
    {
        private PlayerMaze player;
        bool goLeft, goRight, goUp, goDown;
        private bool isGameOver;
        private List<Treasure> treasures;
        private List<Monster> monsters;

        public MazeGameFrom(int idCol, int idSkin)
        {
            InitializeComponent();
            LoadBackGround();
            InitPlayer(idSkin);
            InitTreasure();
            InitMonster();
            timerUpdate.Start();
            isGameOver = false;

            this.DoubleBuffered = true;
        }

        private void InitMonster()
        {
            monsters = new List<Monster>();
            Monster mon1, mon2, mon3, mon4, mon5, mon6, monLast;
            Image image1 = Image.FromFile("../../db/Monsters/a_1.png");
            Image image2 = Image.FromFile("../../db/Monsters/a_2.png");
            Image image3 = Image.FromFile("../../db/Monsters/a_4.png");
            Image image4 = Image.FromFile("../../db/Monsters/a_5.png");
            Image imageLast = Image.FromFile("../../db/Monsters/5.png");

            Size size = new Size(50, 50);
            Size sizeLast = new Size(100, 80);

            Point location1 = new Point(26, 470);
            Point location2 = new Point(139, 364);
            Point location3 = new Point(871, 133);
            Point location4 = new Point(250, 243);
            Point location5 = new Point(307, 355);
            Point location6 = new Point(693, 451);
            Point locationLast = new Point(742, 584);

            mon1 = new Monster(image1, location1, size, 0, null, false);
            mon2 = new Monster(image2, location2, size, 0, null, false);
            mon3 = new Monster(image3, location3, size, 0, null, false);
            mon4 = new Monster(image4, location4, size, 0, null, false);
            mon5 = new Monster(image1, location5, size, 0, null, false);
            mon6 = new Monster(image2, location6, size, 0, null, false);
            monLast = new Monster(imageLast, locationLast, sizeLast, 0, null, false);

            monsters.Add(mon1);
            monsters.Add(mon2);
            monsters.Add(mon3);
            monsters.Add(mon4);
            monsters.Add(mon5);
            monsters.Add(mon6);
            monsters.Add(monLast);


        }
        private void InitTreasure()
        {
            treasures = new List<Treasure>();

            Image image = Image.FromFile("../../db/Treasure/kho bau.png");
            Size size = new Size(50, 50);
            Point location1 = new Point(523, 626);

            Treasure trea1,trea2,trea3, trea4,trea5,trea6,treaLast;
            trea1 = new Treasure(image, location1, size, 0, false);

            Point location2 = new Point(901, 217);
            trea2 = new Treasure(image, location2, size, 0, false);

            Point location3 = new Point(489, 521);
            trea3 = new Treasure(image, location3, size, 0, false);

            Point location4 = new Point(249, 407);
            trea4 = new Treasure(image, location4, size, 0, false);

            Point location5 = new Point(554, 405);
            trea5 = new Treasure(image, location5, size, 0, false);

            Point location6 = new Point(921, 350);
            trea6 = new Treasure(image, location6, size, 0, false);
            Point locationLast = new Point(639, 595);
            Image imageLast = Image.FromFile("../../db/Treasure/lasttreasure.jpg");
            treaLast = new Treasure(imageLast, locationLast, size, 0, true);
            treasures.Add(trea1);
            treasures.Add(trea2);
            treasures.Add(trea3);
            treasures.Add(trea4);
            treasures.Add(trea5);
            treasures.Add(trea6);
            treasures.Add(treaLast);
        }
        private void PlayerMaze_PriviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.Move(Direction1.Left);
                    goLeft = true;
                    goDown = goRight = goUp = false;
                    break;
                case Keys.Right:
                    player.Move(Direction1.Right);
                    goRight = true;
                    goDown = goUp = goLeft = false;
                    break;
                case Keys.Up:
                    player.Move(Direction1.Up);
                    goUp = true;
                    goLeft = goRight = goDown = false;
                    break;
                case Keys.Down:
                    player.Move(Direction1.Down);
                    goDown = true;
                    goLeft = goRight = goUp = false;
                    break;
                default:
                    break;
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            player.HandleOutsideClient(this);
            HandleNotThroughtWall();

            this.Invalidate();
        }

        public void LoadBackGround()
        {
            this.BackgroundImage = Image.FromFile("../../db/Backgrounds/mazeReal.jpg");
        }

        public void HandleNotThroughtWall()
        {
            //Wall1
            if (goRight == true && player.X + player.Size.Width > wall1.Location.X && player.Y + player.Size.Height > wall1.Location.Y && player.Y < wall1.Location.Y + wall1.Size.Height
                && player.X < wall1.Location.X)
                player.X = wall1.Location.X - player.Size.Width;
            if (goLeft == true && player.X < wall1.Location.X + wall1.Size.Width && player.Y + player.Size.Height > wall1.Location.Y && player.Y < wall1.Location.Y + wall1.Size.Height
                && player.X > wall1.Location.X)
                player.X = wall1.Location.X + wall1.Width;
            if (goUp == true && player.Y < wall1.Location.Y + wall1.Size.Height && player.X + player.Size.Width > wall1.Location.X && player.X < wall1.Location.X + wall1.Size.Width
                && player.Y > wall1.Location.Y)
                player.Y = wall1.Location.Y + wall1.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > wall1.Location.Y && player.X + player.Size.Width > wall1.Location.X && player.X < wall1.Location.X + wall1.Width
                && player.Y < wall1.Location.Y)
                player.Y = wall1.Location.Y - player.Size.Height;

            //Wall2
            if (goRight == true && player.X + player.Size.Width > wall2.Location.X && player.Y + player.Size.Height > wall2.Location.Y && player.Y < wall2.Location.Y + wall2.Size.Height
                && player.X < wall2.Location.X)
                player.X = wall2.Location.X - player.Size.Width;
            if (goLeft == true && player.X < wall2.Location.X + wall2.Size.Width && player.Y + player.Size.Height > wall2.Location.Y && player.Y < wall2.Location.Y + wall2.Size.Height
                && player.X > wall2.Location.X)
                player.X = wall2.Location.X + wall2.Width;
            if (goUp == true && player.Y < wall2.Location.Y + wall2.Size.Height && player.X + player.Size.Width > wall2.Location.X && player.X < wall2.Location.X + wall2.Size.Width
                && player.Y > wall2.Location.Y)
                player.Y = wall2.Location.Y + wall2.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > wall2.Location.Y && player.X + player.Size.Width > wall2.Location.X && player.X < wall2.Location.X + wall2.Width
                && player.Y < wall2.Location.Y)
                player.Y = wall2.Location.Y - player.Size.Height;
            //panel1
            if (goRight == true && player.X + player.Size.Width > panel1.Location.X && player.Y + player.Size.Height > panel1.Location.Y && player.Y < panel1.Location.Y + panel1.Size.Height
                && player.X < panel1.Location.X)
                player.X = panel1.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel1.Location.X + panel1.Size.Width && player.Y + player.Size.Height > panel1.Location.Y && player.Y < panel1.Location.Y + panel1.Size.Height
                && player.X > panel1.Location.X)
                player.X = panel1.Location.X + panel1.Width;
            if (goUp == true && player.Y < panel1.Location.Y + panel1.Size.Height && player.X + player.Size.Width > panel1.Location.X && player.X < panel1.Location.X + panel1.Size.Width
                && player.Y > panel1.Location.Y)
                player.Y = panel1.Location.Y + panel1.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel1.Location.Y && player.X + player.Size.Width > panel1.Location.X && player.X < panel1.Location.X + panel1.Width
                && player.Y < panel1.Location.Y)
                player.Y = panel1.Location.Y - player.Size.Height;
            //panel7
            if (goRight == true && player.X + player.Size.Width > panel7.Location.X && player.Y + player.Size.Height > panel7.Location.Y && player.Y < panel7.Location.Y + panel7.Size.Height
                && player.X < panel7.Location.X)
                player.X = panel7.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel7.Location.X + panel7.Size.Width && player.Y + player.Size.Height > panel7.Location.Y && player.Y < panel7.Location.Y + panel7.Size.Height
                && player.X > panel7.Location.X)
                player.X = panel7.Location.X + panel7.Width;
            if (goUp == true && player.Y < panel7.Location.Y + panel7.Size.Height && player.X + player.Size.Width > panel7.Location.X && player.X < panel7.Location.X + panel7.Size.Width
                && player.Y > panel7.Location.Y)
                player.Y = panel7.Location.Y + panel7.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel7.Location.Y && player.X + player.Size.Width > panel7.Location.X && player.X < panel7.Location.X + panel7.Width
                && player.Y < panel7.Location.Y)
                player.Y = panel7.Location.Y - player.Size.Height;

            //panel8
            if (goRight == true && player.X + player.Size.Width > panel8.Location.X && player.Y + player.Size.Height > panel8.Location.Y && player.Y < panel8.Location.Y + panel8.Size.Height
                && player.X < panel8.Location.X)
                player.X = panel8.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel8.Location.X + panel8.Size.Width && player.Y + player.Size.Height > panel8.Location.Y && player.Y < panel8.Location.Y + panel8.Size.Height
                && player.X > panel8.Location.X)
                player.X = panel8.Location.X + panel8.Width;
            if (goUp == true && player.Y < panel8.Location.Y + panel8.Size.Height && player.X + player.Size.Width > panel8.Location.X && player.X < panel8.Location.X + panel8.Size.Width
                && player.Y > panel8.Location.Y)
                player.Y = panel8.Location.Y + panel8.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel8.Location.Y && player.X + player.Size.Width > panel8.Location.X && player.X < panel8.Location.X + panel8.Width
                && player.Y < panel8.Location.Y)
                player.Y = panel8.Location.Y - player.Size.Height;
            //panel6
            if (goRight == true && player.X + player.Size.Width > panel6.Location.X && player.Y + player.Size.Height > panel6.Location.Y && player.Y < panel6.Location.Y + panel6.Size.Height
                && player.X < panel6.Location.X)
                player.X = panel6.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel6.Location.X + panel6.Size.Width && player.Y + player.Size.Height > panel6.Location.Y && player.Y < panel6.Location.Y + panel6.Size.Height
                && player.X > panel6.Location.X)
                player.X = panel6.Location.X + panel6.Width;
            if (goUp == true && player.Y < panel6.Location.Y + panel6.Size.Height && player.X + player.Size.Width > panel6.Location.X && player.X < panel6.Location.X + panel6.Size.Width
                && player.Y > panel6.Location.Y)
                player.Y = panel6.Location.Y + panel6.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel6.Location.Y && player.X + player.Size.Width > panel6.Location.X && player.X < panel6.Location.X + panel6.Width
                && player.Y < panel6.Location.Y)
                player.Y = panel6.Location.Y - player.Size.Height;
            //panel9
            if (goRight == true && player.X + player.Size.Width > panel9.Location.X && player.Y + player.Size.Height > panel9.Location.Y && player.Y < panel9.Location.Y + panel9.Size.Height
                && player.X < panel9.Location.X)
                player.X = panel9.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel9.Location.X + panel9.Size.Width && player.Y + player.Size.Height > panel9.Location.Y && player.Y < panel9.Location.Y + panel9.Size.Height
                && player.X > panel9.Location.X)
                player.X = panel9.Location.X + panel9.Width;
            if (goUp == true && player.Y < panel9.Location.Y + panel9.Size.Height && player.X + player.Size.Width > panel9.Location.X && player.X < panel9.Location.X + panel9.Size.Width
                && player.Y > panel9.Location.Y)
                player.Y = panel9.Location.Y + panel9.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel9.Location.Y && player.X + player.Size.Width > panel9.Location.X && player.X < panel9.Location.X + panel9.Width
                && player.Y < panel9.Location.Y)
                player.Y = panel9.Location.Y - player.Size.Height;
            //panel10
            if (goRight == true && player.X + player.Size.Width > panel10.Location.X && player.Y + player.Size.Height > panel10.Location.Y && player.Y < panel10.Location.Y + panel10.Size.Height
                && player.X < panel10.Location.X)
                player.X = panel10.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel10.Location.X + panel10.Size.Width && player.Y + player.Size.Height > panel10.Location.Y && player.Y < panel10.Location.Y + panel10.Size.Height
                && player.X > panel10.Location.X)
                player.X = panel10.Location.X + panel10.Width;
            if (goUp == true && player.Y < panel10.Location.Y + panel10.Size.Height && player.X + player.Size.Width > panel10.Location.X && player.X < panel10.Location.X + panel10.Size.Width
                && player.Y > panel10.Location.Y)
                player.Y = panel10.Location.Y + panel10.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel10.Location.Y && player.X + player.Size.Width > panel10.Location.X && player.X < panel10.Location.X + panel10.Width
                && player.Y < panel10.Location.Y)
                player.Y = panel10.Location.Y - player.Size.Height;
            //panel15
            if (goRight == true && player.X + player.Size.Width > panel15.Location.X && player.Y + player.Size.Height > panel15.Location.Y && player.Y < panel15.Location.Y + panel15.Size.Height
                && player.X < panel15.Location.X)
                player.X = panel15.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel15.Location.X + panel15.Size.Width && player.Y + player.Size.Height > panel15.Location.Y && player.Y < panel15.Location.Y + panel15.Size.Height
                && player.X > panel15.Location.X)
                player.X = panel15.Location.X + panel15.Width;
            if (goUp == true && player.Y < panel15.Location.Y + panel15.Size.Height && player.X + player.Size.Width > panel15.Location.X && player.X < panel15.Location.X + panel15.Size.Width
                && player.Y > panel15.Location.Y)
                player.Y = panel15.Location.Y + panel15.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel15.Location.Y && player.X + player.Size.Width > panel15.Location.X && player.X < panel15.Location.X + panel15.Width
                && player.Y < panel15.Location.Y)
                player.Y = panel15.Location.Y - player.Size.Height;
            //panel11
            if (goRight == true && player.X + player.Size.Width > panel11.Location.X && player.Y + player.Size.Height > panel11.Location.Y && player.Y < panel11.Location.Y + panel11.Size.Height
                && player.X < panel11.Location.X)
                player.X = panel11.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel11.Location.X + panel11.Size.Width && player.Y + player.Size.Height > panel11.Location.Y && player.Y < panel11.Location.Y + panel11.Size.Height
                && player.X > panel11.Location.X)
                player.X = panel11.Location.X + panel11.Width;
            if (goUp == true && player.Y < panel11.Location.Y + panel11.Size.Height && player.X + player.Size.Width > panel11.Location.X && player.X < panel11.Location.X + panel11.Size.Width
                && player.Y > panel11.Location.Y)
                player.Y = panel11.Location.Y + panel11.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel11.Location.Y && player.X + player.Size.Width > panel11.Location.X && player.X < panel11.Location.X + panel11.Width
                && player.Y < panel11.Location.Y)
                player.Y = panel11.Location.Y - player.Size.Height;
            //panel12
            if (goRight == true && player.X + player.Size.Width > panel12.Location.X && player.Y + player.Size.Height > panel12.Location.Y && player.Y < panel12.Location.Y + panel12.Size.Height
                && player.X < panel12.Location.X)
                player.X = panel12.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel12.Location.X + panel12.Size.Width && player.Y + player.Size.Height > panel12.Location.Y && player.Y < panel12.Location.Y + panel12.Size.Height
                && player.X > panel12.Location.X)
                player.X = panel12.Location.X + panel12.Width;
            if (goUp == true && player.Y < panel12.Location.Y + panel12.Size.Height && player.X + player.Size.Width > panel12.Location.X && player.X < panel12.Location.X + panel12.Size.Width
                && player.Y > panel12.Location.Y)
                player.Y = panel12.Location.Y + panel12.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel12.Location.Y && player.X + player.Size.Width > panel12.Location.X && player.X < panel12.Location.X + panel12.Width
                && player.Y < panel12.Location.Y)
                player.Y = panel12.Location.Y - player.Size.Height;
            //panel13
            if (goRight == true && player.X + player.Size.Width > panel13.Location.X && player.Y + player.Size.Height > panel13.Location.Y && player.Y < panel13.Location.Y + panel13.Size.Height
                && player.X < panel13.Location.X)
                player.X = panel13.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel13.Location.X + panel13.Size.Width && player.Y + player.Size.Height > panel13.Location.Y && player.Y < panel13.Location.Y + panel13.Size.Height
                && player.X > panel13.Location.X)
                player.X = panel13.Location.X + panel13.Width;
            if (goUp == true && player.Y < panel13.Location.Y + panel13.Size.Height && player.X + player.Size.Width > panel13.Location.X && player.X < panel13.Location.X + panel13.Size.Width
                && player.Y > panel13.Location.Y)
                player.Y = panel13.Location.Y + panel13.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel13.Location.Y && player.X + player.Size.Width > panel13.Location.X && player.X < panel13.Location.X + panel13.Width
                && player.Y < panel13.Location.Y)
                player.Y = panel13.Location.Y - player.Size.Height;
            //panel14
            if (goRight == true && player.X + player.Size.Width > panel14.Location.X && player.Y + player.Size.Height > panel14.Location.Y && player.Y < panel14.Location.Y + panel14.Size.Height
                && player.X < panel14.Location.X)
                player.X = panel14.Location.X - player.Size.Width;
            if (goLeft == true && player.X < panel14.Location.X + panel14.Size.Width && player.Y + player.Size.Height > panel14.Location.Y && player.Y < panel14.Location.Y + panel14.Size.Height
                && player.X > panel14.Location.X)
                player.X = panel14.Location.X + panel14.Width;
            if (goUp == true && player.Y < panel14.Location.Y + panel14.Size.Height && player.X + player.Size.Width > panel14.Location.X && player.X < panel14.Location.X + panel14.Size.Width
                && player.Y > panel14.Location.Y)
                player.Y = panel14.Location.Y + panel14.Size.Height;
            if (goDown == true && player.Y + player.Size.Height > panel14.Location.Y && player.X + player.Size.Width > panel14.Location.X && player.X < panel14.Location.X + panel14.Width
                && player.Y < panel14.Location.Y)
                player.Y = panel14.Location.Y - player.Size.Height;
        }
        public void InitPlayer(int idSkin)
        {
            Image image = Image.FromFile("../../db/Characters/" + idSkin.ToString() + ".png");
            Point location = new Point(25,125);
            Size size = new Size(50,50);

            player = new PlayerMaze(image, location, size, 15);

            ManageUserAction.LoadPlayerMazeStat(idSkin, player);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            player.Draw(g);

            foreach (var trea in treasures)
            {
                trea.Draw(g);
            }
            
            foreach (var mon in monsters)
            {
                mon.Draw(g);
            }
        }
    }
}
