namespace VocabularyUp
{
    partial class MazeGameFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeGameFrom));
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.btnB = new Guna.UI2.WinForms.Guna2Button();
            this.btnA = new Guna.UI2.WinForms.Guna2Button();
            this.btnD = new Guna.UI2.WinForms.Guna2Button();
            this.btnC = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFlashCard = new System.Windows.Forms.Panel();
            this.pnlDash = new System.Windows.Forms.Panel();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.aaa = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lbDiamond = new System.Windows.Forms.Label();
            this.pbDiamond = new System.Windows.Forms.PictureBox();
            this.pgbHealth = new VocabularyUp.SuperProgressBar();
            this.pbIconHealth = new System.Windows.Forms.PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.wall1 = new System.Windows.Forms.Panel();
            this.wall2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Transition = new Guna.UI2.WinForms.Guna2Transition();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetails = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFinal = new System.Windows.Forms.Panel();
            this.lbFinal = new System.Windows.Forms.Label();
            this.timerQuestion = new System.Windows.Forms.Timer(this.components);
            this.pnlQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlFlashCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.aaa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconHealth)).BeginInit();
            this.pnlFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 10;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.BackColor = System.Drawing.Color.Tan;
            this.pnlQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlQuestion.BackgroundImage")));
            this.pnlQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlQuestion.Controls.Add(this.pictureBox2);
            this.pnlQuestion.Controls.Add(this.lbTimer);
            this.pnlQuestion.Controls.Add(this.btnConfirm);
            this.pnlQuestion.Controls.Add(this.btnB);
            this.pnlQuestion.Controls.Add(this.btnA);
            this.pnlQuestion.Controls.Add(this.btnD);
            this.pnlQuestion.Controls.Add(this.btnC);
            this.pnlQuestion.Controls.Add(this.pnlFlashCard);
            this.guna2Transition.SetDecoration(this.pnlQuestion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlQuestion.Location = new System.Drawing.Point(54, 156);
            this.pnlQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(914, 437);
            this.pnlQuestion.TabIndex = 35;
            this.pnlQuestion.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(621, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // lbTimer
            // 
            this.lbTimer.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition.SetDecoration(this.lbTimer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(639, 57);
            this.lbTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(93, 28);
            this.lbTimer.TabIndex = 51;
            this.lbTimer.Text = "60";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.guna2Transition.SetDecoration(this.btnConfirm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnConfirm.FillColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageSize = new System.Drawing.Size(60, 45);
            this.btnConfirm.Location = new System.Drawing.Point(611, 303);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(144, 71);
            this.btnConfirm.TabIndex = 50;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnB
            // 
            this.btnB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnB.BackColor = System.Drawing.Color.Transparent;
            this.btnB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnB.BackgroundImage")));
            this.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB.BorderColor = System.Drawing.Color.White;
            this.btnB.CheckedState.Parent = this.btnB;
            this.btnB.CustomImages.Parent = this.btnB;
            this.guna2Transition.SetDecoration(this.btnB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnB.FillColor = System.Drawing.Color.Transparent;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.HoverState.Parent = this.btnB;
            this.btnB.Location = new System.Drawing.Point(692, 108);
            this.btnB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB.Name = "btnB";
            this.btnB.ShadowDecoration.Parent = this.btnB;
            this.btnB.Size = new System.Drawing.Size(180, 71);
            this.btnB.TabIndex = 48;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnA.BackColor = System.Drawing.Color.Transparent;
            this.btnA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnA.BackgroundImage")));
            this.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnA.BorderColor = System.Drawing.Color.White;
            this.btnA.CheckedState.Parent = this.btnA;
            this.btnA.CustomImages.Parent = this.btnA;
            this.guna2Transition.SetDecoration(this.btnA, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnA.FillColor = System.Drawing.Color.Transparent;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.HoverState.Parent = this.btnA;
            this.btnA.Location = new System.Drawing.Point(493, 108);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA.Name = "btnA";
            this.btnA.ShadowDecoration.Parent = this.btnA;
            this.btnA.Size = new System.Drawing.Size(180, 71);
            this.btnA.TabIndex = 46;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnD
            // 
            this.btnD.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnD.BackColor = System.Drawing.Color.Transparent;
            this.btnD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnD.BackgroundImage")));
            this.btnD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnD.BorderColor = System.Drawing.Color.White;
            this.btnD.CheckedState.Parent = this.btnD;
            this.btnD.CustomImages.Parent = this.btnD;
            this.guna2Transition.SetDecoration(this.btnD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnD.FillColor = System.Drawing.Color.Transparent;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.HoverState.Parent = this.btnD;
            this.btnD.Location = new System.Drawing.Point(692, 206);
            this.btnD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD.Name = "btnD";
            this.btnD.ShadowDecoration.Parent = this.btnD;
            this.btnD.Size = new System.Drawing.Size(180, 71);
            this.btnD.TabIndex = 49;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnC.BackColor = System.Drawing.Color.Transparent;
            this.btnC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnC.BackgroundImage")));
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnC.BorderColor = System.Drawing.Color.White;
            this.btnC.CheckedState.Parent = this.btnC;
            this.btnC.CustomImages.Parent = this.btnC;
            this.guna2Transition.SetDecoration(this.btnC, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnC.FillColor = System.Drawing.Color.Transparent;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.HoverState.Parent = this.btnC;
            this.btnC.Location = new System.Drawing.Point(493, 206);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC.Name = "btnC";
            this.btnC.ShadowDecoration.Parent = this.btnC;
            this.btnC.Size = new System.Drawing.Size(180, 71);
            this.btnC.TabIndex = 47;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // pnlFlashCard
            // 
            this.pnlFlashCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlFlashCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFlashCard.BackgroundImage")));
            this.pnlFlashCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFlashCard.Controls.Add(this.pnlDash);
            this.pnlFlashCard.Controls.Add(this.lbMain);
            this.pnlFlashCard.Controls.Add(this.pbMain);
            this.guna2Transition.SetDecoration(this.pnlFlashCard, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlFlashCard.Location = new System.Drawing.Point(34, 31);
            this.pnlFlashCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFlashCard.Name = "pnlFlashCard";
            this.pnlFlashCard.Size = new System.Drawing.Size(352, 398);
            this.pnlFlashCard.TabIndex = 45;
            // 
            // pnlDash
            // 
            this.pnlDash.BackColor = System.Drawing.Color.White;
            this.guna2Transition.SetDecoration(this.pnlDash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlDash.Location = new System.Drawing.Point(29, 263);
            this.pnlDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(289, 5);
            this.pnlDash.TabIndex = 14;
            // 
            // lbMain
            // 
            this.lbMain.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition.SetDecoration(this.lbMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbMain.ForeColor = System.Drawing.Color.White;
            this.lbMain.Location = new System.Drawing.Point(3, 279);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(347, 95);
            this.lbMain.TabIndex = 12;
            this.lbMain.Text = "Welcome";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMain
            // 
            this.guna2Transition.SetDecoration(this.pbMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(29, 23);
            this.pbMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(289, 226);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 13;
            this.pbMain.TabStop = false;
            // 
            // aaa
            // 
            this.aaa.BackColor = System.Drawing.SystemColors.Control;
            this.aaa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aaa.BackgroundImage")));
            this.aaa.Controls.Add(this.pictureBox1);
            this.aaa.Controls.Add(this.btnReturn);
            this.aaa.Controls.Add(this.pnlInfo);
            this.guna2Transition.SetDecoration(this.aaa, Guna.UI2.AnimatorNS.DecorationType.None);
            this.aaa.Location = new System.Drawing.Point(0, 0);
            this.aaa.Margin = new System.Windows.Forms.Padding(4);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(1000, 100);
            this.aaa.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition.SetDecoration(this.btnReturn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnReturn.FillColor = System.Drawing.Color.Transparent;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.ShadowDecoration.Parent = this.btnReturn;
            this.btnReturn.Size = new System.Drawing.Size(48, 33);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReturn.TabIndex = 19;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInfo.BackgroundImage")));
            this.pnlInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInfo.Controls.Add(this.lbDiamond);
            this.pnlInfo.Controls.Add(this.pbDiamond);
            this.pnlInfo.Controls.Add(this.pgbHealth);
            this.pnlInfo.Controls.Add(this.pbIconHealth);
            this.guna2Transition.SetDecoration(this.pnlInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlInfo.Location = new System.Drawing.Point(596, 12);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(379, 60);
            this.pnlInfo.TabIndex = 6;
            // 
            // lbDiamond
            // 
            this.lbDiamond.AutoSize = true;
            this.lbDiamond.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition.SetDecoration(this.lbDiamond, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbDiamond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDiamond.ForeColor = System.Drawing.Color.White;
            this.lbDiamond.Location = new System.Drawing.Point(318, 14);
            this.lbDiamond.Name = "lbDiamond";
            this.lbDiamond.Size = new System.Drawing.Size(23, 25);
            this.lbDiamond.TabIndex = 5;
            this.lbDiamond.Text = "0";
            // 
            // pbDiamond
            // 
            this.pbDiamond.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition.SetDecoration(this.pbDiamond, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbDiamond.Image = ((System.Drawing.Image)(resources.GetObject("pbDiamond.Image")));
            this.pbDiamond.Location = new System.Drawing.Point(282, 14);
            this.pbDiamond.Name = "pbDiamond";
            this.pbDiamond.Size = new System.Drawing.Size(30, 30);
            this.pbDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiamond.TabIndex = 4;
            this.pbDiamond.TabStop = false;
            // 
            // pgbHealth
            // 
            this.pgbHealth.BackColor = System.Drawing.Color.White;
            this.guna2Transition.SetDecoration(this.pgbHealth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pgbHealth.Location = new System.Drawing.Point(48, 14);
            this.pgbHealth.Name = "pgbHealth";
            this.pgbHealth.Size = new System.Drawing.Size(199, 25);
            this.pgbHealth.TabIndex = 3;
            // 
            // pbIconHealth
            // 
            this.pbIconHealth.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition.SetDecoration(this.pbIconHealth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbIconHealth.Image = ((System.Drawing.Image)(resources.GetObject("pbIconHealth.Image")));
            this.pbIconHealth.Location = new System.Drawing.Point(12, 14);
            this.pbIconHealth.Name = "pbIconHealth";
            this.pbIconHealth.Size = new System.Drawing.Size(30, 30);
            this.pbIconHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconHealth.TabIndex = 1;
            this.pbIconHealth.TabStop = false;
            // 
            // panel15
            // 
            this.panel15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel15.BackgroundImage")));
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition.SetDecoration(this.panel15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel15.Location = new System.Drawing.Point(307, 419);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(72, 43);
            this.panel15.TabIndex = 33;
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel13.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel13.Location = new System.Drawing.Point(612, 349);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(72, 97);
            this.panel13.TabIndex = 31;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel10.Location = new System.Drawing.Point(242, 461);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(305, 53);
            this.panel10.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel8.Location = new System.Drawing.Point(192, 235);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(50, 279);
            this.panel8.TabIndex = 26;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition.SetDecoration(this.panel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel7.Location = new System.Drawing.Point(581, 624);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(50, 56);
            this.panel7.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(131, 575);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 50);
            this.panel1.TabIndex = 23;
            // 
            // panel14
            // 
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel14.Location = new System.Drawing.Point(908, 609);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(67, 71);
            this.panel14.TabIndex = 32;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel12.Location = new System.Drawing.Point(751, 405);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(224, 51);
            this.panel12.TabIndex = 30;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel11.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel11.Location = new System.Drawing.Point(547, 514);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(285, 62);
            this.panel11.TabIndex = 29;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel9.Location = new System.Drawing.Point(307, 294);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(668, 55);
            this.panel9.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(192, 185);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(671, 50);
            this.panel6.TabIndex = 24;
            // 
            // wall1
            // 
            this.wall1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wall1.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.wall1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.wall1.Location = new System.Drawing.Point(81, 124);
            this.wall1.Margin = new System.Windows.Forms.Padding(4);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(50, 240);
            this.wall1.TabIndex = 17;
            // 
            // wall2
            // 
            this.wall2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wall2.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.wall2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.wall2.Location = new System.Drawing.Point(81, 427);
            this.wall2.Margin = new System.Windows.Forms.Padding(4);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(50, 198);
            this.wall2.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(25, 675);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(950, 25);
            this.panel5.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(25, 100);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(950, 25);
            this.panel4.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(975, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 600);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.guna2Transition.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 600);
            this.panel2.TabIndex = 18;
            // 
            // guna2Transition
            // 
            this.guna2Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.guna2Transition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 1F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.guna2Transition.DefaultAnimation = animation3;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.guna2Transition.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(60, 45);
            this.btnClose.Location = new System.Drawing.Point(94, 155);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(144, 71);
            this.btnClose.TabIndex = 55;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetails.BackgroundImage")));
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetails.CheckedState.Parent = this.btnDetails;
            this.btnDetails.CustomImages.Parent = this.btnDetails;
            this.guna2Transition.SetDecoration(this.btnDetails, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDetails.FillColor = System.Drawing.Color.Transparent;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetails.ForeColor = System.Drawing.Color.Black;
            this.btnDetails.HoverState.Parent = this.btnDetails;
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.ImageSize = new System.Drawing.Size(50, 40);
            this.btnDetails.Location = new System.Drawing.Point(316, 155);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ShadowDecoration.Parent = this.btnDetails;
            this.btnDetails.Size = new System.Drawing.Size(144, 71);
            this.btnDetails.TabIndex = 56;
            this.btnDetails.Visible = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // pnlFinal
            // 
            this.pnlFinal.BackColor = System.Drawing.Color.Transparent;
            this.pnlFinal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFinal.BackgroundImage")));
            this.pnlFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFinal.Controls.Add(this.btnDetails);
            this.pnlFinal.Controls.Add(this.btnClose);
            this.pnlFinal.Controls.Add(this.lbFinal);
            this.guna2Transition.SetDecoration(this.pnlFinal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlFinal.Location = new System.Drawing.Point(265, 250);
            this.pnlFinal.Name = "pnlFinal";
            this.pnlFinal.Size = new System.Drawing.Size(567, 288);
            this.pnlFinal.TabIndex = 52;
            this.pnlFinal.Visible = false;
            // 
            // lbFinal
            // 
            this.guna2Transition.SetDecoration(this.lbFinal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinal.ForeColor = System.Drawing.Color.Red;
            this.lbFinal.Location = new System.Drawing.Point(0, 52);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(564, 62);
            this.lbFinal.TabIndex = 0;
            this.lbFinal.Text = "Game Over";
            this.lbFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerQuestion
            // 
            this.timerQuestion.Interval = 1000;
            this.timerQuestion.Tick += new System.EventHandler(this.timerQuestion_Tick);
            // 
            // MazeGameFrom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlFinal);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.guna2Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MazeGameFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MazeGameFrom";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PlayerMaze_PriviewKeyDown);
            this.pnlQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlFlashCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.aaa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconHealth)).EndInit();
            this.pnlFinal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel wall1;
        private System.Windows.Forms.Panel wall2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel aaa;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lbDiamond;
        private System.Windows.Forms.PictureBox pbDiamond;
        private SuperProgressBar pgbHealth;
        private System.Windows.Forms.PictureBox pbIconHealth;
        private Guna.UI2.WinForms.Guna2PictureBox btnReturn;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Label lbTimer;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnB;
        private Guna.UI2.WinForms.Guna2Button btnA;
        private Guna.UI2.WinForms.Guna2Button btnD;
        private Guna.UI2.WinForms.Guna2Button btnC;
        private System.Windows.Forms.Panel pnlFlashCard;
        private System.Windows.Forms.Panel pnlDash;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbMain;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnDetails;
        private System.Windows.Forms.Timer timerQuestion;
        private System.Windows.Forms.Panel pnlFinal;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}