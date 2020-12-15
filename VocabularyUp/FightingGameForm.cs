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
    public partial class FightingGameForm : Form
    {
        private Collection choosedCol;
        private Player player;
        private Monster monster;
        private bool isGameOver;
        private Random rd = new Random();
        public FightingGameForm(int idCol, int idSkin)
        {
            InitializeComponent();
            LoadBackGround();
            InitCollecion(idCol);
            InitPlayer(idSkin);
            InitMonster();
            //timerUpdate.Start();
            isGameOver = false;
        }

        public void InitPlayer(int idSkin)
        {
            Image image = Image.FromFile("../../db/Characters/" + idSkin.ToString() + ".png");
            Point location = new Point(0, this.ClientSize.Height - 100);
            Size size = new Size(100, 100);

            player = new Player(image, location, size, 10);

            ManageUserAction.LoadPlayerStat(idSkin, player);
        }
        public void InitMonster()
        {
            Image image = Image.FromFile("../../db/Monsters/1.png");
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Point location = new Point(this.ClientSize.Width - 100, this.ClientSize.Height - 100);
            Size size = new Size(100, 100);

            monster = new Monster(image, location, size, 0, null);
        }

        public void InitCollecion(int idCol)
        {
            choosedCol = ManageUserAction.GetItemOfAllCollection(idCol);
        }

        public void LoadBackGround()
        {
            this.BackgroundImage = Image.FromFile("../../db/Backgrounds/maps/vs_1.gif");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            player.Draw(g);

            //foreach (var mon in monsters)
            //{
                monster.Draw(g);
            //}

            //string text = "Health: " + player.Health.ToString();
            //g.DrawString(text, new Font("Arial", 16), new SolidBrush(Color.Red), new PointF(0, 0));

            //if (isGameOver)
            //{
            //    SizeF Size = e.Graphics.MeasureString("Game Over", new Font("Arial", 20));
            //    e.Graphics.DrawString("Game Over", new Font("Arial", 20), new SolidBrush(Color.White), new PointF(this.Width / 2 - Size.Width / 2, this.Height / 2 - Size.Height / 2));
            //}
        }

        private void PopUpFadeBackground()
        {
            Form backgroundForm = new Form();
            try
            {
                using (GameMCForm f = new GameMCForm())
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

                    f.Owner = backgroundForm;
                    f.ShowDialog();

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
