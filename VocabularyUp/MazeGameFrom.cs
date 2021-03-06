﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Media;
using WMPLib;


namespace VocabularyUp
{
    public partial class MazeGameFrom : Form
    {
        private PlayerMaze player;
        bool goLeft, goRight, goUp, goDown;
        private bool isGameOver;
        private List<Treasure> treasures;
        private List<MonsterMaze> monsters;
        private int currentHealth = 0;
        private List<Quiz> questions = new List<Quiz>();
        private int isCorrect;
        private List<UserChoice> userChoices = new List<UserChoice>();
        private int currentQuiz = 0;
        private int isPress = 0;
        private TrashTalkingForm trashTalking;
        private int isBossCorrect;
        private int time=0;
        private int sound = 1;
        private bool isBoss;
        private bool isWin;
        private bool inFighting = false;
        private Direction curDir;
        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private SoundPlayer soundPlayer= new SoundPlayer();
        private WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer last10s = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer click = new WMPLib.WindowsMediaPlayer();

        public MazeGameFrom(int idSkin)
        {
            InitializeComponent();
            LoadBackGround();
            InitTreasure();
            InitMonster();
            ManageUserAction.UpdateGameMainFlashCards();
            InitQuiz();
            InitPlayer(idSkin);
            LoadMusic();
            timerUpdate.Start();
            isGameOver = false;
            currentHealth = player.Health;
            isCorrect = -1;
            isBossCorrect = -1;
            isWin = false;
            Point locationLast = new Point(panel12.Location.X, panel11.Location.Y+panel11.Height);
            this.DoubleBuffered = true;
        }

        private void LoadMusic()
        {
            mediaPlayer.URL = ConfigurationManager.AppSettings.Get("musicPath") + "MazeGame.mp3";
            mediaPlayer.settings.volume = 20;
            mediaPlayer.controls.play();
            click.URL = ConfigurationManager.AppSettings.Get("musicPath") + "click.mp3";
            last10s.settings.volume = 10;
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

        public void ChangeFlashCard(string content, int id)
        {
            lbMain.Text = content;
            pbMain.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + id.ToString() + ".jpg");
            InitAnswer();

            isPress = 0;
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

        private void InitMonster()
        {
            monsters = new List<MonsterMaze>();
            MonsterMaze mon1, mon2, mon3, mon4, mon5, mon6, monLast;
            Image image1 = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Monsters/a_1.png");
            Image image2 = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Monsters/a_2.png");
            Image image3 = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Monsters/a_4.png");
            Image image4 = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Monsters/a_5.png");
            Image imageLast = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Monsters/5.png");
            Size size = new Size(50,50);
           
            int s1 = wall2.Location.X - panel2.Width;
            Size size1 = new Size(s1, s1);
            int s2 = panel8.Location.X - wall1.Location.X - wall1.Width;
            Size size2 = new Size(s2, s2);
            int s3 = panel6.Location.Y - panel4.Location.Y -panel4.Height;
            Size size3 = new Size(s3, s3);
            int s4 = panel9.Location.X - panel8.Location.X - panel8.Width;
            Size size4 = new Size(s4, s4);
            int s5 = 75;
            Size size5 = new Size(s5, s5);
            int s6 = panel12.Location.X - panel13.Location.X - panel13.Width;
            Size size6 = new Size(s6, s6);
            int sLast = panel14.Width;
            Size sizeLast = new Size(sLast, panel5.Location.Y - panel11.Location.Y - panel11.Height);

            Point location1 = new Point(panel2.Location.X + panel2.Width, wall2.Location.Y);
            Point location2 = new Point(wall1.Location.X + wall1.Width, panel8.Location.Y);
            Point location3 = new Point(panel6.Location.X + panel6.Width, panel4.Location.Y+panel4.Height);
            Point location4 = new Point(panel9.Location.X - size4.Height, panel9.Location.Y);
            Point location5 = new Point(panel15.Location.X + panel15.Width, panel9.Location.Y + panel9.Height);
            Point location6 = new Point(panel13.Location.X + panel13.Width,panel12.Location.Y);
            Point locationLast = new Point(panel12.Location.X, panel11.Location.Y+panel11.Height);

            mon1 = new MonsterMaze(image1, location1, size1, 1, null, false);
            mon2 = new MonsterMaze(image2, location2, size2, 1, null, false);
            mon3 = new MonsterMaze(image3, location3, size3, 1, null, false);
            mon4 = new MonsterMaze(image4, location4, size4, 1, null, false);
            mon5 = new MonsterMaze(image1, location5, size5, 1, null, false);
            mon6 = new MonsterMaze(image2, location6, size6, 1, null, false);
            monLast = new MonsterMaze(imageLast, locationLast, sizeLast, 0, null, true);

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
            Treasure trea1, trea2, trea3, trea4, trea5, trea6, treaLast;
            Image image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Treasure/treasure.png");
            Size size = new Size(50, 50);

            int s1 = panel5.Location.Y - panel1.Location.Y - panel1.Height;
            Size size1 = new Size(s1,s1);
            Point location1 = new Point(panel7.Location.X - size1.Width, panel1.Location.Y + panel1.Height);
            trea1 = new Treasure(image, location1, size1, 0, false);

            int s2 = panel1.Location.Y - panel10.Location.Y - panel10.Height;
            Size size2 = new Size(s2, s2);
            Point location2 = new Point(panel11.Location.X - size2.Height, panel10.Location.Y + panel10.Height);
            trea2 = new Treasure(image, location2, size2, 0, false);

            int s3 = panel15.Location.X - panel8.Location.X - panel8.Width;
            Size size3 = new Size(s3, s3);
            Point location3 = new Point(panel8.Location.X + panel8.Width, panel10.Location.Y -size3.Height);
            trea3 = new Treasure(image, location3, size3, 0, false);

            int s4 = panel9.Location.Y - panel6.Location.Y - panel6.Height;
            Size size4 = new Size(s4, s4);
            Point location4 = new Point(panel12.Location.X,panel8.Location.Y);
            trea4 = new Treasure(image, location4, size4, 0, false);

            int s5 = panel13.Location.X - panel10.Location.X - panel10.Width;
            Size size5 = new Size(s5, s5);
            Point location5 = new Point(panel10.Location.X + panel10.Width, panel11.Location.Y - size5.Width);
            trea5 = new Treasure(image, location5, size5, 0, false);

            int s6 = panel12.Location.Y - panel9.Location.Y - panel9.Height;
            Size size6 = new Size(s6, s6);
            Point location6 = new Point(panel3.Location.X-size6.Width,panel13.Location.Y);
            trea6 = new Treasure(image, location6, size6, 0, false);
            
            int sLast = panel5.Location.Y - panel11.Location.Y - panel11.Height;
            Size sizeLast = new Size(sLast - 10, sLast);
            Point locationLast = new Point(panel1.Location.X + panel1.Width, panel11.Location.Y + panel11.Height);
            Image imageLast = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Treasure/LastTreasure.png");
            treaLast = new Treasure(imageLast, locationLast, sizeLast, 0, true);
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
            if (inFighting == false)
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

                // Lật hình của nhân vật theo hướng di chuyển
                if (goLeft && curDir == Direction.Right)
                {
                    player.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    curDir = Direction.Left;
                }
                else if (goRight && curDir != Direction.Right)
                {
                    player.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    curDir = Direction.Right;
                }
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            player.HandleOutsideClient(this);
            HandleNotThroughtWall();
            this.Focus();
            if (mediaPlayer.status == "Stopped")
            {
                mediaPlayer.controls.play();
            }
            if (!isGameOver)
            {
                for (int i = 0; i < monsters.Count; i++)
                {
                    if (player.isCollision(monsters[i]))
                    {
                        this.Focus();
                        if (monsters[i].IsDeath == false)
                            inFighting = true;
                        else
                            inFighting = false;

                        if (monsters[i].IsDeath == true)
                        {
                            monsters[i].Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Treasure/rip.png");
                        }
                        else if (monsters[i].IsBoss == true)
                        {
                            isBoss = true;
                            if (isCorrect == 1)
                            {
                                isCorrect = -1;
                                if (isBossCorrect == 5)
                                {
                                    monsters[i].IsDeath = true;
                                    monsters[i].Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Treasure/rip.png");
                                    
                                }

                                timerUpdate.Start();
                            }
                            else if (isCorrect == 0)
                            {
                                currentHealth -= 1;
                                inFighting = false;
                                
                            }

                            if (monsters[i].IsDeath == false)
                            {
                                timerUpdate.Stop();
                                if (currentHealth > 0)
                                {
                                    ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
                                    timerQuestion.Start();
                                    guna2Transition.ShowSync(pnlQuestion);
                                }
                                else
                                {
                                    isGameOver = true;
                                    isWin = false;
                                }    
                                time = 0;
                                lbTimer.Text = (30).ToString();
                            }
                            
                            

                        }
                        else
                        {   
                            timerUpdate.Stop();
                            if (isCorrect >= 0)
                            {
                                if (isCorrect == 1)
                                {
                                    monsters[i].IsDeath = true;
                                    monsters[i].Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Treasure/rip.png");                                    
                                }
                                else
                                {
                                    int s = wall1.Location.X - (panel2.Location.X + panel2.Width);
                                    Size size = new Size(s - 5, s - 5);
                                    currentHealth -= 1;
                                    inFighting = false;
                                    player.Location = new Point(wall1.Location.X - size.Width, panel4.Location.Y + panel4.Size.Height);
                                }

                                isCorrect = -1;
                                timerUpdate.Start();
                            }
                            else
                            {
                                if (currentHealth > 0)
                                {
                                    ChangeFlashCard(questions[currentQuiz].GetFlashCard().Viet, questions[currentQuiz].GetFlashCard().IdCard);
                                    guna2Transition.ShowSync(pnlQuestion);
                                    lbTimer.Text = (30).ToString();
                                    timerQuestion.Start();
                                }
                                time = 0;
                            }
                        }
                    }
                }

                for (int i = 0; i < treasures.Count; i++)
                {
                    if (player.isCollision(treasures[i]))
                    {
                        if (treasures[i].IsLastTreasure == true)
                        {
                            mediaPlayer.controls.stop();
                            treasures.Remove(treasures[i]);
                            mediaPlayer.controls.stop();
                            music.URL = ConfigurationManager.AppSettings.Get("musicPath") + "win1.mp3";
                            music.controls.play();
                                
                            isWin = true;
                            btnClose.Show();
                            btnDetails.Show();
                            timerUpdate.Stop();
                            this.Focus();
                            ManageUserAction.UpdateDiamond(ManageUserAction.GetDiamond() + 10);
                            lbFinal.Text = "Congratulations!";
                            lbFinal.ForeColor = Color.Lime;
                            pnlFinal.Location = new Point(this.ClientSize.Width / 2 - pnlFinal.Size.Width / 2, this.ClientSize.Height / 2 - pnlFinal.Size.Height / 2);
                            guna2Transition.ShowSync(pnlFinal);
                        }
                        else
                        {
                            music.URL = ConfigurationManager.AppSettings.Get("musicPath") + "coin.mp3";
                            music.controls.play();
                            treasures.Remove(treasures[i]);
                            ManageUserAction.UpdateDiamond(ManageUserAction.GetDiamond() + 1);

                        }
                        
                    }
                }
            }

            
            if (currentHealth <= 0 )
            {
                isGameOver = true;

                mediaPlayer.controls.stop();

                music.URL = ConfigurationManager.AppSettings.Get("musicPath") + "lose1.mp3";
                music.controls.play();
                btnClose.Show();
                btnDetails.Show();
                this.AcceptButton = btnClose;
                timerUpdate.Stop();
                guna2Transition.ShowSync(pnlFinal);
                this.Focus();
            }    
             

            //di chuyen cua monster 0
            if (monsters[0].IsDeath == false)
            {
                monsters[0].Move(monsters[0].Cur);
                if (monsters[0].Y < wall1.Location.Y + wall1.Height)
                    monsters[0].Cur = Direction1.Down;
                else if (monsters[0].Y > panel5.Location.Y - monsters[0].Size.Width)
                    monsters[0].Cur = Direction1.Up;
                        
            }    

            //di chuyen cua monster 1
            if (monsters[1].IsDeath == false)
            {
                monsters[1].Move(monsters[1].Cur);
                if (monsters[1].Y < panel6.Location.Y)
                    monsters[1].Cur = Direction1.Down;
                else if (monsters[1].Y > panel1.Location.Y - monsters[1].Size.Height)
                    monsters[1].Cur = Direction1.Up;
            }
            //di chuyen cua monster 2
            if (monsters[2].IsDeath == false)
            {
                monsters[2].Move(monsters[2].Cur);
                if (monsters[2].Y < panel4.Location.Y + panel4.Height)
                    monsters[2].Cur = Direction1.Down;
                else if (monsters[2].Y > panel9.Location.Y - monsters[2].Size.Height)
                    monsters[2].Cur = Direction1.Up;
            }
            //di chuyen của monster 3
            if (monsters[3].IsDeath == false)
            {
                monsters[3].Move(monsters[3].Cur);
                if (monsters[3].Y < panel8.Location.Y)
                    monsters[3].Cur = Direction1.Down;
                else if (monsters[3].Y > panel12.Location.Y - monsters[3].Size.Height)
                    monsters[3].Cur = Direction1.Up;

            }

            //di chuyen cua monster 4
            if (monsters[4].IsDeath == false)
            {
                monsters[4].Move(monsters[4].Cur);
                if (monsters[4].Y < panel9.Location.Y + panel9.Height)
                    monsters[4].Cur = Direction1.Down;
                else if (monsters[4].Y > panel10.Location.Y - monsters[3].Size.Height)
                    monsters[4].Cur = Direction1.Up;
            }

            //di chuyen cua monster 5
            if (monsters[5].IsDeath == false)
            {
                monsters[5].Move(monsters[5].Cur);
                if (monsters[5].Y < panel9.Location.Y + panel9.Height)
                    monsters[5].Cur = Direction1.Down;
                else if (monsters[5].Y > panel11.Location.Y - monsters[4].Size.Height)
                    monsters[5].Cur = Direction1.Up;
            }

            double percent = (((double)currentHealth) / player.Health) * 100;
            pgbHealth.Value = (int)percent;
            lbDiamond.Text = ManageUserAction.GetDiamond().ToString();
            this.Invalidate();
        }

        public void LoadBackGround()
        {
            this.BackgroundImage = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Backgrounds/mazeReal.jpg");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            click.controls.play();
            last10s.controls.stop();
            music.controls.stop();
            mediaPlayer.controls.stop();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            click.controls.play();
            btnA.BorderThickness = 0;
            btnB.BorderThickness = 0;
            btnC.BorderThickness = 0;
            btnD.BorderThickness = 0;
            userChoices[currentQuiz].CorrectAns = questions[currentQuiz].GetFlashCard().Eng;
            if (userChoices[currentQuiz].IsDone == false && isPress == 1)
            {
                if (isBoss == false)
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
                else
                {
                    userChoices[currentQuiz].IsDone = true;
                    if (userChoices[currentQuiz].Selected == userChoices[currentQuiz].Correct)
                    {
                        if (isBossCorrect == -1)
                        {
                            isBossCorrect = isBossCorrect + 2;
                        }
                        else 
                            isBossCorrect++;
                        isCorrect = 1;
                        music.URL = ConfigurationManager.AppSettings.Get("musicPath") + "correct.mp3";
                        music.controls.play();  

                    }
                    else
                    {
                        music.URL = ConfigurationManager.AppSettings.Get("musicPath") + "incorrect.mp3";
                        music.controls.play();
                        isCorrect = 0;
                    }
                }    
            }

            if (userChoices[currentQuiz].Selected != -1)
            {
                timerQuestion.Stop();
                pnlQuestion.Hide();
                timerUpdate.Start();
                timerQuestion.Stop();
                time = 0;
                currentQuiz++;
                inFighting = false;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            click.controls.play();
            last10s.controls.stop();
            music.controls.stop();
            mediaPlayer.controls.stop();
            this.Close();
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

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            if (timerQuestion.Enabled == false)
                return;

            time++;
            if (time == 19)
            {
                last10s.URL = ConfigurationManager.AppSettings.Get("musicPath") + "10s.mp3";
                last10s.settings.volume = 30;
                last10s.controls.play();
            }    
            lbTimer.Text = (30 - time).ToString();
            if (time < 20)
            {
                lbTimer.ForeColor = Color.Black;
            }
            else
            {
                lbTimer.ForeColor = Color.Red;
            }
            if (time == 30)
            {
                last10s.controls.pause();
                timerQuestion.Stop();
                pnlQuestion.Hide();
                currentHealth -= 1;
                pnlQuestion.Hide();
                timerUpdate.Start();
                inFighting = false;
                if (isBoss == false)
                {
                    int s = wall1.Location.X - (panel2.Location.X + panel2.Width);
                    Size size = new Size(s - 5, s - 5);
                    player.Location = new Point(wall1.Location.X - size.Width, panel4.Location.Y + panel4.Size.Height);
                }
                last10s.controls.stop();
                currentQuiz++;
                
                time = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            click.controls.play();
            if (sound == 1)
            {
                pictureBox1.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_icons") + "sound-off.png");
                mediaPlayer.settings.volume = 0;
                music.settings.volume = 0;
                last10s.settings.volume = 0;
                sound = 0;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_icons") + "sound.png");
                mediaPlayer.settings.volume = 20;
                music.settings.volume = 100;
                last10s.settings.volume = 20;
                sound = 1;
            }
        }

        public void InitPlayer(int idSkin)
        {
            Image image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath_database") + "Characters/" + idSkin.ToString() + ".png");
            int s = wall1.Location.X - (panel2.Location.X + panel2.Width);
            Size size = new Size(s-5,s-5);           
            Point location = new Point(wall1.Location.X - size.Width, panel4.Location.Y + panel4.Size.Height);

            player = new PlayerMaze(image, location, size, 10);

            ManageUserAction.LoadPlayerMazeStat(idSkin, player);

            curDir = Direction.Right;
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

        public void OpenTrashTalk(int idMonster, string charTrashTalk, string monTrashTalk)
        {
            Form backgroundForm = new Form();
            Image image = monsters[idMonster].Image;

            try
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                using (trashTalking = new TrashTalkingForm(player.Image, image , charTrashTalk, monTrashTalk))
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

                    trashTalking.Owner = backgroundForm;
                    trashTalking.ShowDialog();

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

    }
}
