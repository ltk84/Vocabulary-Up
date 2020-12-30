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
using WMPLib;

namespace VocabularyUp
{
    public partial class WalkthroughForm : Form
    {
        private Collection choseCol;
        private Player player;
        private List<Monster> monsters;
        private Size size_Normal = new Size(80, 80);
        private Size size_Boss = new Size(160, 160);
        private bool isGameOver;
        private Random rd = new Random();
        private List<Bullet> bullets = new List<Bullet>();
        private bool isFinalRound;
        private int currentHealth = 0;
        private TrashTalkingForm trashTalkForm;
        private int idSkin;
        private int idWeapon;
        private int isPress = 0;
        private List<UserChoice> userChoices = new List<UserChoice>();
        private List<Quiz> questions = new List<Quiz>();
        private int currentQuiz = 0;
        private int isCorrect;
        private int turn;
        private int time = 0;
        private int count = 0;
        private int sound = 1;
        private bool inFighting = false;
        private bool isWin;
        private WMPLib.WindowsMediaPlayer mediaPlayer, music, bullet, last10s, click;

        public WalkthroughForm(int idCol, int idSkin, int idWeapon)
        {
            InitializeComponent();
            LoadBackGround();
            InitCollecion(idCol);
            InitPlayer(idSkin);
            InitMonster();
            ManageUserAction.UpdateGameMainFlashCards();
            InitQuiz();
            LoadingMusic();
            timerUpdate.Start();
            isGameOver = false;
            currentHealth = player.Health;
            isCorrect = -1;
            isFinalRound = false;
            turn = 0;
            pnlQuestion.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - pnlQuestion.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - pnlQuestion.Height / 2 - 100);
            this.idSkin = idSkin;
            this.idWeapon = idWeapon;
        }

        private void LoadingMusic()
        {
            mediaPlayer = new WMPLib.WindowsMediaPlayer();
            mediaPlayer.URL = ConfigurationManager.AppSettings.Get("musicPath") + "Ready.mp3";
            mediaPlayer.settings.volume = 10;
            mediaPlayer.controls.play();

            bullet = new WMPLib.WindowsMediaPlayer();
            bullet.URL = ConfigurationManager.AppSettings.Get("musicPath") + "bullet.mp3";
            bullet.controls.stop();

            music = new WMPLib.WindowsMediaPlayer();

            click = new WMPLib.WindowsMediaPlayer();
            click.URL = ConfigurationManager.AppSettings.Get("musicPath") + "click.mp3";
            click.controls.stop();

            last10s = new WMPLib.WindowsMediaPlayer();
            last10s.URL = ConfigurationManager.AppSettings.Get("musicPath") + "10s.mp3";
            last10s.controls.stop();
        }
        public void InitPlayer(int idSkin)
        {
            Image image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Characters/" + idSkin.ToString() + ".png");
            Point location = new Point(0, Screen.PrimaryScreen.Bounds.Height / 2);
            Size size = new Size(100, 100);

            player = new Player(image, location, size, 50);

            ManageUserAction.LoadPlayerStat(idSkin, player);
        }

        public void InitCollecion(int idCol)
        {
            choseCol = ManageUserAction.GetItemOfAllCollection(idCol);
        }

        public void InitMonster()
        {
            monsters = new List<Monster>();
            for (int i = 0; i < 3; i++)
            {

                Image image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Monsters/" + (i + 1).ToString() + ".png");
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                int y = rd.Next(Screen.PrimaryScreen.Bounds.Height * 2 / 3, Screen.PrimaryScreen.Bounds.Height - size_Normal.Height);
                Point location = new Point(((i + 1) * Screen.PrimaryScreen.Bounds.Width / 4), y);


                Monster mon;
                int v = rd.Next(10, 20);


                if (i == 2)
                {
                    location = new Point(((i + 1) * Screen.PrimaryScreen.Bounds.Width / 4), Screen.PrimaryScreen.Bounds.Height * 2 / 3);
                    mon = new Monster(image, location, size_Boss, 0, null, true);
                }
                else
                    mon = new Monster(image, location, size_Normal, v, null, false);

                monsters.Add(mon);
            }
        }
        public void LoadBackGround()
        {
            Random rd = new Random();
            this.BackgroundImage = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Backgrounds/maps/map_" + rd.Next(1,6).ToString() +".jpg");

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

            foreach (var b in bullets)
            {
                b.Draw(g);
            }
        }


        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            player.HandleOutsideClient(this);
            int j = -1;
            if (mediaPlayer.status == "Stopped")
                mediaPlayer.controls.play();

            if (!isGameOver)
            {
                for (int i = monsters.Count - 1; i >= 0; i--)
                {
                    if (player.isCollision(monsters[i]))
                    {
                        timerUpdate.Stop();
                        
                        if (monsters[i].IsBoss == true)
                        {
                            mediaPlayer.URL = ConfigurationManager.AppSettings.Get("musicPath") + "BossFight.mp3";
                            mediaPlayer.controls.play();
                            OpenTrashTalk(i, "Mày đây rồi, thằng khốn! Chạy đâu cho thoát!", "Bố đã làm gì mày đâu?");
                            j = i;
                            break;
                        }
                        else
                        {
                            if (isCorrect >= 0)
                            {
                                if (isCorrect == 1)
                                {
                                    // Init dead.
                                    PictureBox pb = new PictureBox();
                                    pb.BackColor = Color.Transparent;
                                    pb.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Monsters/dead.png");
                                    pb.Location = monsters[i].Location;
                                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                                    pb.Size = size_Normal;
                                    pb.Show();
                                    this.Controls.Add(pb);

                                    monsters.Remove(monsters[i]);

                                    ManageUserAction.UpdateDiamond(ManageUserAction.GetDiamond() + 1);
                                }
                                else
                                {
                                    player.Location = new Point(0, this.ClientSize.Height / 2);
                                    currentHealth -= 1;
                                }

                                isCorrect = -1;
                                timerUpdate.Start();
                                inFighting = false;
                            }
                            else 
                            { 
                                inFighting = true;
                                timerQuestion.Start();
                                ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
                                
                                pnlQuestion.Show();
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
                    isFinalRound = true;
                }

                if (isFinalRound == true)
                {
                    if (isCorrect >= 0)
                    {
                        if (isCorrect == 1)
                        {

                            ManageUserAction.UpdateDiamond(ManageUserAction.GetDiamond() + 1);
                            bullets.Clear();
                            bullets.Add(player.Attack(idWeapon));
                            turn = 1;
                            timerBullet.Start();

                        }
                        else
                        {
                            bullets.Clear();
                            turn = 2;
                            bullets.Add(monsters[0].Attack(idWeapon));
                            timerBullet.Start();
                        }
                        isCorrect = -1;
                        timerUpdate.Start();
                    }
                }
                 

                if (currentHealth > 0)
                {
                    double percent = (((double)currentHealth) / player.Health) * 100;
                    if (pgbHealth.Value != (int)percent)
                        pgbHealth.Value = (int)percent;
                }
                else
                {
                    pgbHealth.Value = 0;
                    currentHealth = 0;
                    isGameOver = true;
                    isWin = false;

                    music.URL = ConfigurationManager.AppSettings.Get("musicPath") + "lose1.mp3";
                    music.controls.play();
                }

                lbDiamond.Text = ManageUserAction.GetDiamond().ToString();
                this.Invalidate();
                this.Focus();
            }
            else
            {
                double percent = (((double)currentHealth) / player.Health) * 100;
                if (pgbHealth.Value != (int)percent)
                    pgbHealth.Value = (int)percent;
                btnClose.Visible = true;
                btnDetails.Visible = true;
                HandleMusicGameOver();
                HandleGameOver();
                timerUpdate.Stop();
            }
        }

        private void HandleGameOver()
        {
            if (isWin)
            {
                lbFinal.ForeColor = Color.Lime;
                lbFinal.Text = "Congratulations!";
            }
            else if (!isWin)
            {
                lbFinal.ForeColor = Color.Red;
                lbFinal.Text = "Game Over!";
            }

            pnlFinal.Location = new Point(this.ClientSize.Width / 2 - pnlFinal.Size.Width / 2, this.ClientSize.Height / 2 - pnlFinal.Size.Height / 2);
            guna2Transition1.ShowSync(pnlFinal);
        }

        private void HandleMusicGameOver()
        {
            mediaPlayer.controls.stop();

            if (pgbMonsterHealth.Value <= 0)
                music.URL = ConfigurationManager.AppSettings.Get("musicPath") + "win1.mp3";
            else
                music.URL = ConfigurationManager.AppSettings.Get("musicPath") + "lose1.mp3";

            music.controls.play();
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
                    backgroundForm.WindowState = FormWindowState.Maximized;
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
            ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
            guna2Transition1.ShowSync(pnlQuestion);
            pnlQuestion.Show();
            timerQuestion.Start();
            pnlQuestion.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - pnlQuestion.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - pnlQuestion.Height / 2 - 100);

            this.Invalidate();
        }

        private void WalkthroughForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (isFinalRound == false && inFighting == false)
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

        public void ChangeFlashCard(string content, int id)
        {
            lbMain.Text = content;
            pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + id.ToString() + ".jpg");
            InitAnswer();

            isPress = 0;
        }

        private void InitAnswer()
        {
            Random rd = new Random();
            UserChoice u = new UserChoice(-1, rd.Next(1, 5), questions[currentQuiz].GetFlashCard().Eng);
            userChoices.Add(u);
            switch (userChoices[currentQuiz].Correct)
            {
                case 1:
                    btnA.Text = questions[currentQuiz].GetFlashCard().Eng;
                    btnB.Text = questions[currentQuiz].FakeAnswers[0];
                    btnC.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 2:
                    btnB.Text = questions[currentQuiz].GetFlashCard().Eng;
                    btnA.Text = questions[currentQuiz].FakeAnswers[0];
                    btnC.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 3:
                    btnC.Text = questions[currentQuiz].GetFlashCard().Eng;
                    btnB.Text = questions[currentQuiz].FakeAnswers[0];
                    btnA.Text = questions[currentQuiz].FakeAnswers[1];
                    btnD.Text = questions[currentQuiz].FakeAnswers[2];
                    break;
                case 4:
                    btnD.Text = questions[currentQuiz].GetFlashCard().Eng;
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
                    string eng = "";

                    index = rd.Next(0, ManageUserAction.GetMainFlashCards().Count);
                    eng = ManageUserAction.GetMainFlashCards()[index].Eng;

                    if (fakeAnswers.IndexOf(eng) < 0 && eng != ManageUserAction.GetMainFlashCards()[i].Eng)
                    {
                        fakeAnswers.Add(eng);
                    }
                }
                Quiz q = new Quiz(ManageUserAction.GetMainFlashCards()[i]);
                q.SetFakeAnswers(fakeAnswers[0], fakeAnswers[1], fakeAnswers[2]);
                questions.Add(q);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            click.controls.play();
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 1;
                btnA.BorderThickness = 5;
                btnB.BorderThickness = 0;
                btnC.BorderThickness = 0;
                btnD.BorderThickness = 0;
                isPress = 1;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            click.controls.play();
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 2;
                btnA.BorderThickness = 0;
                btnB.BorderThickness = 5;
                btnC.BorderThickness = 0;
                btnD.BorderThickness = 0;
                isPress = 1;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            click.controls.play();
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 3;
                btnA.BorderThickness = 0;
                btnB.BorderThickness = 0;
                btnC.BorderThickness = 5;
                btnD.BorderThickness = 0;
                isPress = 1;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            click.controls.play();
            if (userChoices[currentQuiz].IsDone == false)
            {
                userChoices[currentQuiz].Selected = 4;
                btnA.BorderThickness = 0;
                btnB.BorderThickness = 0;
                btnC.BorderThickness = 0;
                btnD.BorderThickness = 5;
                isPress = 1;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            click.controls.play();
            userChoices[currentQuiz].CorrectAns = questions[currentQuiz].GetFlashCard().Eng;
            if (userChoices[currentQuiz].IsDone == false && isPress == 1)
            {
                userChoices[currentQuiz].IsDone = true;
                if (userChoices[currentQuiz].Selected == userChoices[currentQuiz].Correct)
                {
                    isCorrect = 1;
                    music.URL = ConfigurationManager.AppSettings.Get("musicPath") + "correct.mp3";
                    music.controls.play();
                }
                else
                {
                    isCorrect = 0;
                    music.URL = ConfigurationManager.AppSettings.Get("musicPath") + "incorrect.mp3";
                    music.controls.play();
                }
            }

            if (userChoices[currentQuiz].Selected != -1)
            {
                pnlQuestion.Hide();
                timerQuestion.Stop();
                timerUpdate.Start();
                currentQuiz++;
                time = 0;
                inFighting = false;
            }

        }

        private void pnlQuestion_VisibleChanged(object sender, EventArgs e)
        {
            btnA.BorderThickness = 0;
            btnB.BorderThickness = 0;
            btnC.BorderThickness = 0;
            btnD.BorderThickness = 0;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            click.controls.play();
            Form backgroundForm = new Form();
            try
            {
                using (DetailsGameForm detailForm = new DetailsGameForm(userChoices))
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

                    detailForm.Owner = backgroundForm;
                    detailForm.ShowDialog();

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            click.controls.play();
            last10s.controls.stop();
            mediaPlayer.controls.stop();
            music.controls.stop();

            this.Close();
        }

        private void timerBullet_Tick(object sender, EventArgs e)
        {
            if (currentHealth <= 0 || pgbMonsterHealth.Value <= 0)
            {
                isGameOver = true;
                pnlQuestion.Hide();
                timerBullet.Stop();
                timerQuestion.Stop();
                this.Invalidate();
            }

            if (turn == 1)
            {
                for (int i = bullets.Count - 1; i >= 0; i--)
                {
                    bool isCol = false;
                    if (bullets[i].isCollision(monsters[0]) == true)
                    {
                        isCol = true;
                        bullet.controls.play();
                        if (pgbMonsterHealth.Value - 20 > 0)
                            pgbMonsterHealth.Value -= 20;
                        else
                        {
                            pgbMonsterHealth.Value = 0;
                            isWin = true;
                            isGameOver = true;
                            pnlQuestion.Hide();
                            timerBullet.Stop();
                            timerEffect.Start();
                            timerQuestion.Stop();
                            this.Invalidate();
                            return;
                        }

                        bullets.RemoveAt(i);
                        timerEffect.Start();
                        timerQuestion.Start();
                    }

                    if (isCol == false)
                    {
                        bullets[i].Move(Direction.Right);
                    }
                }
            }
            else if (turn == 2)
            {
                for (int i = bullets.Count - 1; i >= 0; i--)
                {
                    bool isCol = false;
                    if (bullets[i].isCollision(player) == true)
                    {
                        bullet.controls.play();
                        isCol = true;
                        if (currentHealth - 1 > 0)
                            currentHealth -= 1;
                        else
                        {
                            currentHealth = 0;
                            isWin = false;
                            isGameOver = true;
                            pnlQuestion.Hide();
                            timerBullet.Stop();
                            timerQuestion.Stop();
                            timerEffect.Start();
                            this.Invalidate();
                            return;
                        }

                        bullets.RemoveAt(i);
                        timerEffect.Start();
                        timerQuestion.Start();

                    }

                    if (isCol == false)
                    {
                        bullets[i].Move(Direction.Left);
                    }
                }
            }

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            click.controls.play();
            last10s.controls.stop();
            mediaPlayer.controls.stop();
            music.controls.stop();

            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            click.controls.play();
            if (sound == 1)
            {
                pbSound.Image = Image.FromFile("../../icons/sound-off.png");
                mediaPlayer.settings.volume = 0;
                music.settings.volume = 0;
                last10s.settings.volume = 0;
                bullet.settings.volume = 0;
                click.settings.volume = 0;
                sound = 0;
            }
            else
            {

                pbSound.Image = Image.FromFile("../../icons/sound.png");
                mediaPlayer.settings.volume = 10;
                music.settings.volume = 100;
                last10s.settings.volume = 10;
                click.settings.volume = 50;
                bullet.settings.volume = 100;
                sound = 1;
            }
        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            if (timerQuestion.Enabled == false)
                return;

            time++;
            if (time == 50)
            {
                last10s.URL = ConfigurationManager.AppSettings.Get("musicPath") +  "10s.mp3";
                last10s.controls.play();
            }

            lbTimer.Text = (60 - time).ToString();

            if (time < 50)
            {
                lbTimer.ForeColor = Color.Black;
            }
            else
            {
                lbTimer.ForeColor = Color.Red;
            }

            if (time == 60)
            {
                timerQuestion.Stop();

                if (isFinalRound == false)
                {
                    pnlQuestion.Hide();
                    timerUpdate.Start();
                    player.Location = new Point(0, this.ClientSize.Height / 2);
                    inFighting = false;
                    currentHealth--;
                }
                else
                {
                    bullets.Add(monsters[0].Attack(idWeapon));
                    turn = 2;
                    timerBullet.Start();
                    timerUpdate.Start();
                }
                currentQuiz++;
                time = 0;
            }
        }

        private void timerEffect_Tick(object sender, EventArgs e)
        {
            count++;
            if (turn == 1)
            {
                Image image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Monsters/Hit/3.png");
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                monsters[0].Image = image;
            }
            else if (turn == 2)
            {
                player.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Characters/Hit/" + idSkin.ToString() +".png");
            }

            if (count == 2)
            {
                if (turn == 2)
                    player.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Characters/" + idSkin.ToString() + ".png");
                else
                {
                    Image image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Monsters/3.png");
                    image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    monsters[0].Image = image;

                }

                timerEffect.Stop();

                if (currentHealth > 0 && pgbMonsterHealth.Value > 0)
                {
                    ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
                    guna2Transition1.ShowSync(pnlQuestion);
                }

                count = 0;
            }
        }
    }
}
