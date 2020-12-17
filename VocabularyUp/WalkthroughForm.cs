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
        private List<Monster> monsters;
        private bool isGameOver;
        private Random rd = new Random();
        private int currentHealth = 0;
        private GameMCForm gameForm;
        public WalkthroughForm(int idCol, int idSkin)
        {
            InitializeComponent();
            LoadBackGround();
            InitCollecion(idCol);
            InitPlayer(idSkin);
            InitMonster();
            timerUpdate.Start();
            isGameOver = false;
            currentHealth = player.Health;
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
                int y = rd.Next(this.ClientSize.Height * 2 / 3, this.ClientSize.Height - size.Height);
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

            string text = "Health: " + currentHealth.ToString();
            g.DrawString(text, new Font("Arial", 16), new SolidBrush(Color.Red), new PointF(0, 0));

            if (isGameOver)
            {
                SizeF Size = e.Graphics.MeasureString("Game Over", new Font("Arial", 20));
                e.Graphics.DrawString("Game Over", new Font("Arial", 20), new SolidBrush(Color.White), new PointF(this.Width / 2 - Size.Width / 2, this.Height / 2 - Size.Height / 2));
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            player.HandleOutsideClient(this);

            if (!isGameOver)
            {
                for (int i = monsters.Count - 1; i >= 0; i--)
                {
                    if (player.isCollision(monsters[i]))
                    {
                        timerUpdate.Stop();

                        OpenGameForm();

                        if (gameForm.IsCorrect == true)
                        {
                            monsters[i].IsDeath = true;
                            monsters.Remove(monsters[i]);
                        }
                        else
                        {
                            currentHealth -= 10;
                            player.Location = new Point(0, this.ClientSize.Height / 2);
                        }

                        if (player.Health == 0)
                        {
                            isGameOver = true;
                        }

                        timerUpdate.Start();

                    }

                    else if (monsters[i].IsDeath == false)
                    {
                        monsters[i].Move(monsters[i].Cur);

                        if (monsters[i].Y + monsters[i].Size.Height > this.Height)
                            monsters[i].Cur = Direction.Up;
                        else if (monsters[i].Y < this.Height / 3)
                            monsters[i].Cur = Direction.Down;
                    }
                }

                Graphics g = this.CreateGraphics();
                string text = "Health: " + currentHealth.ToString();
                g.DrawString(text, new Font("Arial", 16), new SolidBrush(Color.Red), new PointF(0, 0));

                this.Invalidate();
            }
            
        }

        private void OpenGameForm()
        {
            Form backgroundForm = new Form();
            try
            {
                using (gameForm = new GameMCForm())
                {
                    backgroundForm.StartPosition = FormStartPosition.Manual;
                    backgroundForm.FormBorderStyle = FormBorderStyle.None;
                    backgroundForm.Opacity = .70d;
                    backgroundForm.BackColor = Color.Black;
                    backgroundForm.Size = this.Size;
                    backgroundForm.TopMost = true;
                    backgroundForm.Location = this.Location;
                    backgroundForm.ShowInTaskbar = false;
                    backgroundForm.Show();

                    gameForm.Owner = backgroundForm;
                    gameForm.ShowDialog();

                    backgroundForm.Dispose();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                backgroundForm.Dispose();
            }
            
               
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

        
    }
}
