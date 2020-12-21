using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private TrashTalkingForm trashTalkForm;

        private int isPress = 0;
        private List<UserChoice> userChoices = new List<UserChoice>();
        private List<Quiz> questions = new List<Quiz>();
        int time;
        private int currentQuiz = 0;
        private int isCorrect;

        public WalkthroughForm(int idCol, int idSkin)
        {
            InitializeComponent();
            LoadBackGround();
            InitCollecion(idCol);
            InitPlayer(idSkin);
            InitMonster();
            ManageUserAction.UpdateGameMainFlashCards();
            InitQuiz();
            //ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
            timerUpdate.Start();
            isGameOver = false;
            currentHealth = player.Health;
            isCorrect = -1;
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
                            //timerUpdate.Stop();
                            OpenTrashTalk(i, "Mày đây rồi, thằng khốn! Chạy đâu cho thoát!", "Bố đã làm gì mày đâu?");
                            j = i;
                            break;
                        }
                        else
                        {
                            //OpenGameForm();
                            //ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
                            //currentQuiz++;
                            //pnlQuestion.Show();

                            if (isCorrect >= 0)
                            {
                                if (isCorrect == 1)
                                {
                                    monsters[i].IsDeath = true;
                                    monsters.Remove(monsters[i]);
                                    ManageUserAction.UpdateDiamond(ManageUserAction.GetDiamond() + 1);
                                }
                                else
                                {
                                    currentHealth -= 10;
                                    player.Location = new Point(0, this.ClientSize.Height / 2);
                                }

                                isCorrect = -1;
                                timerUpdate.Start();
                            }
                            else
                            {
                                ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);
                                //currentQuiz++;
                                pnlQuestion.Show();
                            }

                            if (player.Health == 0)
                            {
                                isGameOver = true;
                            }

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
                }
                double percent = (((double) currentHealth) / player.Health) * 100;
                pgbHealth.Value =   (int) percent;
                lbDiamond.Text = ManageUserAction.GetDiamond().ToString();
                this.Invalidate();
                this.Focus();
            }

        }

        //private void OpenGameForm()
        //{
        //    Form backgroundForm = new Form();
        //    try
        //    {
        //        using (gameForm = new GameMCForm())
        //        {
        //            backgroundForm.StartPosition = FormStartPosition.Manual;
        //            backgroundForm.FormBorderStyle = FormBorderStyle.None;
        //            backgroundForm.Opacity = .70d;
        //            backgroundForm.BackColor = Color.Black;
        //            backgroundForm.Size = this.Size;
        //            backgroundForm.TopMost = true;
        //            backgroundForm.Location = this.Location;
        //            backgroundForm.ShowInTaskbar = false;
        //            backgroundForm.Show();

        //            gameForm.Owner = backgroundForm;
        //            gameForm.ShowDialog();

        //            backgroundForm.Dispose();
        //        }
        //        this.Focus();
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    finally
        //    {
        //        backgroundForm.Dispose();
        //    }
            
               
        //}

       
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
            player.X = Screen.PrimaryScreen.Bounds.Width / 4 - player.Size.Width - 50;
            player.Y = Screen.PrimaryScreen.Bounds.Height * 2 / 3 + 50;
            player.Size = new Size(100, 100);
            monsters[0].X = Screen.PrimaryScreen.Bounds.Width * 3 / 4;
            monsters[0].Y = player.Y + player.Size.Height - monsters[0].Size.Height - 50;
            monsters[0].Size = new Size(250, 250);

            // Init boss's health.
            pgbMonsterHealth.Show();
            pgbMonsterHealth.Location = new Point(Screen.PrimaryScreen.Bounds.Width - pgbMonsterHealth.Size.Width - 50, pnlInfo.Location.Y + pgbHealth.Location.Y);
            pgbMonsterHealth.Value = 100;

            // Init questions.
            ChangeFlashCard(questions[currentQuiz].GetFlashCard().Eng, questions[currentQuiz].GetFlashCard().IdCard);

            pnlQuestion.Show();
            pnlQuestion.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - pnlQuestion.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - pnlQuestion.Height / 2 - 150);

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
        public void ChangeFlashCard(string content, int id)
        {
            lbMain.Text = content;
            pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath") + id.ToString() + ".jpg");
            InitAnswer();

            isPress = 0;
        }
        private void InitAnswer()
        {
            Random rd = new Random();
            UserChoice u = new UserChoice(-1, rd.Next(1, 5));
            userChoices.Add(u);
            switch (userChoices[currentQuiz].Correct)
            {
                case 1:
                    btnA.Text = questions[currentQuiz].GetFlashCard().Viet;
                    btnB.Text = questions[currentQuiz].FakeAnswers[0];
                    btnC.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 2:
                    btnB.Text = questions[currentQuiz].GetFlashCard().Viet;
                    btnA.Text = questions[currentQuiz].FakeAnswers[0];
                    btnC.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 3:
                    btnC.Text = questions[currentQuiz].GetFlashCard().Viet;
                    btnB.Text = questions[currentQuiz].FakeAnswers[0];
                    btnA.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 4:
                    btnD.Text = questions[currentQuiz].GetFlashCard().Viet;
                    btnB.Text = questions[currentQuiz].FakeAnswers[0];
                    btnC.Text = questions[currentQuiz].FakeAnswers[1];
                    btnA.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
            }
        }

        private void InitQuiz()
        {
            for (int i = 0; i < ManageUserAction.GetMainFlashCards().Count; i++)
            {
                List<string> fakeAnswers = new List<string>();
                List<string> backupAnswers = new List<string>() { "Trúcc Trúc", "Cẩm Nhi", "Ngọc Hà", "Minh Trâm", "Thái Mỹ", "Thanh Thúy", "Trúc Mai", "Thanh Trúc", "Khánh An", "Kim Nga", "Anh Thư" };
                Random rd = new Random();
                while (fakeAnswers.Count != 3)
                {
                    int index;
                    string vie = "a";
                    if (ManageUserAction.GetMainFlashCards().Count > 3)
                    {
                        do
                        {
                            index = rd.Next(0, ManageUserAction.GetMainFlashCards().Count);
                            vie = ManageUserAction.GetMainFlashCards()[index].Viet;
                        } while (vie == "");

                    }
                    else
                    {
                        do
                        {
                            index = rd.Next(0, ManageUserAction.GetMainFlashCards().Count);
                            vie = ManageUserAction.GetMainFlashCards()[index].Viet;
                        } while (vie == "");
                    }

                    if (fakeAnswers.IndexOf(vie) < 0 && vie != ManageUserAction.GetMainFlashCards()[i].Viet)
                    {
                        fakeAnswers.Add(vie);
                    }
                }
                Quiz q = new Quiz(ManageUserAction.GetMainFlashCards()[i]);
                q.SetFakeAnswers(fakeAnswers[0], fakeAnswers[1], fakeAnswers[2]);
                questions.Add(q);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 1;
                //btnA.FillColor = Color.FromArgb(107, 216, 255);
                //btnB.FillColor = Color.FromArgb(17, 223, 158);
                //btnC.FillColor = Color.FromArgb(17, 223, 158);
                //btnD.FillColor = Color.FromArgb(17, 223, 158);
                btnA.BorderThickness = 5;
                btnB.BorderThickness = 0;
                btnC.BorderThickness = 0;
                btnD.BorderThickness = 0;
                isPress = 1;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 2;
                //btnB.FillColor = Color.FromArgb(107, 216, 255);
                //btnA.FillColor = Color.FromArgb(17, 223, 158);
                //btnC.FillColor = Color.FromArgb(17, 223, 158);
                //btnD.FillColor = Color.FromArgb(17, 223, 158);
                btnA.BorderThickness = 0;
                btnB.BorderThickness = 5;
                btnC.BorderThickness = 0;
                btnD.BorderThickness = 0;
                isPress = 1;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 3;
                //btnC.FillColor = Color.FromArgb(107, 216, 255);
                //btnA.FillColor = Color.FromArgb(17, 223, 158);
                //btnB.FillColor = Color.FromArgb(17, 223, 158);
                //btnD.FillColor = Color.FromArgb(17, 223, 158);
                btnA.BorderThickness = 0;
                btnB.BorderThickness = 0;
                btnC.BorderThickness = 5;
                btnD.BorderThickness = 0;
                isPress = 1;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 4;
                //btnD.FillColor = Color.FromArgb(107, 216, 255);
                //btnA.FillColor = Color.FromArgb(17, 223, 158);
                //btnB.FillColor = Color.FromArgb(17, 223, 158);
                //btnC.FillColor = Color.FromArgb(17, 223, 158);
                btnA.BorderThickness = 0;
                btnB.BorderThickness = 0;
                btnC.BorderThickness = 0;
                btnD.BorderThickness = 5;
                isPress = 1;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            userChoices[currentQuiz].CorrectAns = questions[currentQuiz].GetFlashCard().Eng;
            if (userChoices[currentQuiz].IsDone == false && isPress == 1)
            {
                //ReloadButton();
                userChoices[currentQuiz].IsDone = true;
                if (userChoices[currentQuiz].Selected == userChoices[currentQuiz].Correct)
                {
                    isCorrect = 1;
                }
                else
                    isCorrect = 0;
            }

            if (userChoices[currentQuiz].Selected != -1)
            {
                pnlQuestion.Hide();
                timerUpdate.Start();
                currentQuiz++;
            }

        }

        private void pnlQuestion_VisibleChanged(object sender, EventArgs e)
        {
            btnA.BorderThickness = 0;
            btnB.BorderThickness = 0;
            btnC.BorderThickness = 0;
            btnD.BorderThickness = 0;
        }
    }
}
