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
        private List<Bullet> bullet;
        private bool isFinalRound;

        private GameMCForm gameForm;
        private TrashTalkingForm trashTalkForm;
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
            bullet = new List<Bullet>();
            isFinalRound = false;
        }

        public void InitPlayer(int idSkin)
        {
            Image image = Image.FromFile("../../db/Characters/" + idSkin.ToString() + ".png");
            Point location = new Point(0, Screen.PrimaryScreen.Bounds.Height / 2);
            Size size = new Size(100, 100);

            player = new Player(image, location, size, 50);

            ManageUserAction.LoadPlayerStat(idSkin, player);
        }

        public  void InitCollecion(int idCol)
        {
            choosedCol = ManageUserAction.GetItemOfAllCollection(idCol);
        }

        public void InitMonster()
        {
            monsters = new List<Monster>();
            for (int i = 0; i < 3; i++)
            {
                
                Image image = Image.FromFile("../../db/Monsters/" + (i+1).ToString() + ".png");
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                Size size = new Size(80, 80);
                int y = rd.Next(Screen.PrimaryScreen.Bounds.Height * 2 / 3, Screen.PrimaryScreen.Bounds.Height - size.Height);
                Point location = new Point(((i + 1) * Screen.PrimaryScreen.Bounds.Width / 4), y);


                Monster mon;
                int v = rd.Next(10, 20);
                

                if (i == 2)
                {
                     //location = new Point(((1) * Screen.PrimaryScreen.Bounds.Width / 4), y);
                    location = new Point(((i + 1) * Screen.PrimaryScreen.Bounds.Width / 4), Screen.PrimaryScreen.Bounds.Height * 2 / 3);
                    size = new Size(160, 160);
                    mon = new Monster(image, location, size, 0, null, true);
                }    
                else
                    mon = new Monster(image, location, size, v, null, false);

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

            foreach (var b in bullet)
            {
                b.Draw(g);
            }

            if (isGameOver)
            {
                SizeF Size = e.Graphics.MeasureString("Game Over", new Font("Arial", 20));
                e.Graphics.DrawString("Game Over", new Font("Arial", 20), new SolidBrush(Color.White), new PointF(this.Width / 2 - Size.Width / 2, this.Height / 2 - Size.Height / 2));
            }
        }

        int a = 1;

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            player.HandleOutsideClient(this);
            int j = -1;

            if (!isGameOver)
            {
                for (int i = monsters.Count - 1; i >= 0; i--)
                {

                    if (player.isCollision(monsters[i]))
                    {
                        timerUpdate.Stop();
                        if (monsters[i].IsBoss == true)
                        {
                            OpenTrashTalk(i, "Mày đây rồi, thằng khốn! Chạy đâu cho thoát!", "Bố đã làm gì mày đâu?");
                            j = i;
                            break;
                        }
                        else
                        {
                            OpenGameForm();

                            if (gameForm.IsCorrect == true)
                            {
                                //if (monsters[i].IsBoss)
                                //    isGameOver = true;
                                monsters[i].IsDeath = true;
                                monsters.Remove(monsters[i]);
                                ManageUserAction.UpdateDiamond(ManageUserAction.GetDiamond() + 1);
                            }
                            else
                            {
                                currentHealth -= 1;
                                player.Location = new Point(0, this.ClientSize.Height / 2);
                            }

                            if (player.Health == 0)
                            {
                                isGameOver = true;
                            }

                            timerUpdate.Start();
                        }
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

                if (j >= 0 && monsters[j].IsBoss == true)
                {
                    InitFinalRound();
                    timerUpdate.Start();
                }

                // Handle Fighting screen in final round.
                if (isFinalRound == true)
                {

                }

                // Display player's health bar.
                double percent = (((double) currentHealth) / player.Health) * 100;
                pgbHealth.Value =   (int) percent;

                // Display diamond.
                lbDiamond.Text = ManageUserAction.GetDiamond().ToString();

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
                this.Focus();
            }
            catch (Exception)
            {

            }
            finally
            {
                backgroundForm.Dispose();
            }
            
               
        }

        public void OpenTrashTalk(int idMonster, string charTrashTalk, string monTrashTalk)
        {
            Form backgroundForm = new Form();
            try
            {
                using (trashTalkForm = new TrashTalkingForm(player.Image, monsters[idMonster].Image, charTrashTalk, monTrashTalk))
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

                    trashTalkForm.Owner = backgroundForm;
                    trashTalkForm.ShowDialog();

                    backgroundForm.Dispose();
                }
                this.Focus();
            }
            catch (Exception)
            {

            }
            finally
            {
                backgroundForm.Dispose();
            }
        }

        private void InitFinalRound()
        {
            // Boss selection.
            for (int i = 0; i < 2; i++)
            {
                if (monsters[0].IsBoss == false)
                    monsters.RemoveAt(0);
            }

            // Relocate, resize.
            player.X = Screen.PrimaryScreen.Bounds.Width / 4 - player.Size.Width;
            player.Y = Screen.PrimaryScreen.Bounds.Height * 2 / 3;
            player.Size = new Size(150, 150);
            monsters[0].X = Screen.PrimaryScreen.Bounds.Width * 3 / 4;
            monsters[0].Y = player.Y + player.Size.Height - monsters[0].Size.Height;
            monsters[0].Size = new Size(200, 200);

            // Init boss's health.
            pgbMonsterHealth.Show();
            pgbMonsterHealth.Location = new Point(Screen.PrimaryScreen.Bounds.Width - pgbMonsterHealth.Size.Width - 50, pnlInfo.Location.X + pgbHealth.Location.X);
            pgbMonsterHealth.Value = 100;
            //pnlMonsterHealth.Show();
            //for (int i = 0; i < 5; i++)
            //{
            //    PictureBox pbHealth = new PictureBox();
            //    pbHealth.Image = Image.FromFile("../../icons/health.png");
            //    pbHealth.SizeMode = PictureBoxSizeMode.StretchImage;
            //    pbHealth.Dock = DockStyle.Right;
            //    pbHealth.Width -= 20;
            //    pnlMonsterHealth.Controls.Add(pbHealth);
            //}
            //// Init player's health
            //pnlPlayerHealth.Show();
            //for (int i = 0; i < player.Health / 10; i++)
            //{
            //    PictureBox pbHealth = new PictureBox();
            //    pbHealth.Image = Image.FromFile("../../icons/health.png");
            //    pbHealth.SizeMode = PictureBoxSizeMode.StretchImage;
            //    pbHealth.Dock = DockStyle.Left;
            //    pbHealth.Width -= 20;
            //    pnlPlayerHealth.Controls.Add(pbHealth);
            //}
            isFinalRound = true;

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
                    bullet.Add(player.Attack());
                    break;
            }
        }
    }
}
