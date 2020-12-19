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

        public MazeGameFrom(int idCol, int idSkin)
        {
            InitializeComponent();
            LoadBackGround();
            InitPlayer(idSkin);
            InitTreasure();
            timerUpdate.Start();
            isGameOver = false;

            this.DoubleBuffered = true;
        }
        private void InitTreasure()
        {
            treasures = new List<Treasure>();

            Image image = Image.FromFile("../../db/Treasure/kho bau.png");
            Size size = new Size(50, 50);
            Point location1 = new Point(25, 150);

            Treasure trea1,trea2,trea3;
            trea1 = new Treasure(image, location1, size, 0, false);
            treasures.Add(trea1);

            Point location2 = new Point(875, 175);
            trea2 = new Treasure(image, location2, size, 0, false);
            Point location3 = new Point(639, 595);
            trea3 = new Treasure(image, location3, size, 0, true);
            treasures.Add(trea2);
            treasures.Add(trea3);
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
        }
        public void InitPlayer(int idSkin)
        {
            Image image = Image.FromFile("../../db/Characters/" + idSkin.ToString() + ".png");
            Point location = new Point(25,125);
            Size size = new Size(50,50);

            player = new PlayerMaze(image, location, size, 10);

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
        }
    }
}
