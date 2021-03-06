﻿namespace VocabularyUp
{
    partial class RevisionForm
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevisionForm));
            this.pnlRevision = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbNotification = new System.Windows.Forms.Label();
            this.pnlChoosePlay = new System.Windows.Forms.Panel();
            this.btnLeft2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnRight2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlType = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlType_1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbWalkthrough = new System.Windows.Forms.Label();
            this.pnlType_2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbMaze = new System.Windows.Forms.Label();
            this.pbWeapon = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.btnChooseType = new Guna.UI2.WinForms.Guna2Button();
            this.pbCurrency = new System.Windows.Forms.PictureBox();
            this.lbDiamond = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.btnShop = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlRevision.SuspendLayout();
            this.pnlChoosePlay.SuspendLayout();
            this.pnlType.SuspendLayout();
            this.pnlType_1.SuspendLayout();
            this.pnlType_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRevision
            // 
            this.pnlRevision.BorderRadius = 20;
            this.pnlRevision.Controls.Add(this.lbNotification);
            this.pnlRevision.Controls.Add(this.pnlChoosePlay);
            this.guna2Transition1.SetDecoration(this.pnlRevision, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlRevision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevision.Location = new System.Drawing.Point(0, 0);
            this.pnlRevision.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRevision.Name = "pnlRevision";
            this.pnlRevision.ShadowDecoration.Parent = this.pnlRevision;
            this.pnlRevision.Size = new System.Drawing.Size(750, 422);
            this.pnlRevision.TabIndex = 0;
            // 
            // lbNotification
            // 
            this.lbNotification.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbNotification, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbNotification.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.lbNotification.ForeColor = System.Drawing.Color.Black;
            this.lbNotification.Location = new System.Drawing.Point(205, 9);
            this.lbNotification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(347, 54);
            this.lbNotification.TabIndex = 30;
            this.lbNotification.Text = "Bạn cần ít nhất 20 từ để bắt đầu ôn";
            this.lbNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNotification.Visible = false;
            // 
            // pnlChoosePlay
            // 
            this.pnlChoosePlay.BackColor = System.Drawing.Color.Transparent;
            this.pnlChoosePlay.Controls.Add(this.pnlType);
            this.pnlChoosePlay.Controls.Add(this.btnBack);
            this.pnlChoosePlay.Controls.Add(this.btnStart);
            this.pnlChoosePlay.Controls.Add(this.btnChooseType);
            this.pnlChoosePlay.Controls.Add(this.pbCurrency);
            this.pnlChoosePlay.Controls.Add(this.lbDiamond);
            this.pnlChoosePlay.Controls.Add(this.btnToggle);
            this.pnlChoosePlay.Controls.Add(this.btnPrevious);
            this.pnlChoosePlay.Controls.Add(this.btnNext);
            this.pnlChoosePlay.Controls.Add(this.pbCharacter);
            this.pnlChoosePlay.Controls.Add(this.btnShop);
            this.pnlChoosePlay.Controls.Add(this.btnLeft2);
            this.pnlChoosePlay.Controls.Add(this.btnRight2);
            this.pnlChoosePlay.Controls.Add(this.pbWeapon);
            this.pnlChoosePlay.Controls.Add(this.lbName);
            this.guna2Transition1.SetDecoration(this.pnlChoosePlay, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlChoosePlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoosePlay.Location = new System.Drawing.Point(0, 0);
            this.pnlChoosePlay.Name = "pnlChoosePlay";
            this.pnlChoosePlay.Size = new System.Drawing.Size(750, 422);
            this.pnlChoosePlay.TabIndex = 23;
            this.pnlChoosePlay.VisibleChanged += new System.EventHandler(this.pnlChoosePlay_VisibleChanged);
            // 
            // btnLeft2
            // 
            this.btnLeft2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLeft2.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft2.BorderRadius = 15;
            this.btnLeft2.CheckedState.Parent = this.btnLeft2;
            this.btnLeft2.CustomImages.Parent = this.btnLeft2;
            this.guna2Transition1.SetDecoration(this.btnLeft2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLeft2.Enabled = false;
            this.btnLeft2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnLeft2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft2.ForeColor = System.Drawing.Color.Black;
            this.btnLeft2.HoverState.Parent = this.btnLeft2;
            this.btnLeft2.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft2.Image")));
            this.btnLeft2.ImageSize = new System.Drawing.Size(30, 45);
            this.btnLeft2.Location = new System.Drawing.Point(46, 118);
            this.btnLeft2.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft2.Name = "btnLeft2";
            this.btnLeft2.ShadowDecoration.Parent = this.btnLeft2;
            this.btnLeft2.Size = new System.Drawing.Size(50, 45);
            this.btnLeft2.TabIndex = 32;
            this.btnLeft2.Click += new System.EventHandler(this.btnLeft2_Click);
            // 
            // btnRight2
            // 
            this.btnRight2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRight2.BackColor = System.Drawing.Color.Transparent;
            this.btnRight2.BorderRadius = 15;
            this.btnRight2.CheckedState.Parent = this.btnRight2;
            this.btnRight2.CustomImages.Parent = this.btnRight2;
            this.guna2Transition1.SetDecoration(this.btnRight2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRight2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnRight2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight2.ForeColor = System.Drawing.Color.Black;
            this.btnRight2.HoverState.Parent = this.btnRight2;
            this.btnRight2.Image = ((System.Drawing.Image)(resources.GetObject("btnRight2.Image")));
            this.btnRight2.ImageSize = new System.Drawing.Size(30, 45);
            this.btnRight2.Location = new System.Drawing.Point(122, 117);
            this.btnRight2.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight2.Name = "btnRight2";
            this.btnRight2.ShadowDecoration.Parent = this.btnRight2;
            this.btnRight2.Size = new System.Drawing.Size(50, 46);
            this.btnRight2.TabIndex = 31;
            this.btnRight2.Click += new System.EventHandler(this.btnRight2_Click);
            // 
            // pnlType
            // 
            this.pnlType.BorderColor = System.Drawing.Color.Transparent;
            this.pnlType.Controls.Add(this.pnlType_1);
            this.pnlType.Controls.Add(this.pnlType_2);
            this.pnlType.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pnlType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlType.Location = new System.Drawing.Point(46, 39);
            this.pnlType.Margin = new System.Windows.Forms.Padding(2);
            this.pnlType.Name = "pnlType";
            this.pnlType.ShadowDecoration.Parent = this.pnlType;
            this.pnlType.Size = new System.Drawing.Size(658, 313);
            this.pnlType.TabIndex = 26;
            this.pnlType.Visible = false;
            // 
            // pnlType_1
            // 
            this.pnlType_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlType_1.BackgroundImage")));
            this.pnlType_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlType_1.BorderColor = System.Drawing.Color.White;
            this.pnlType_1.Controls.Add(this.lbWalkthrough);
            this.guna2Transition1.SetDecoration(this.pnlType_1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlType_1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlType_1.Location = new System.Drawing.Point(0, 0);
            this.pnlType_1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlType_1.Name = "pnlType_1";
            this.pnlType_1.ShadowDecoration.Parent = this.pnlType_1;
            this.pnlType_1.Size = new System.Drawing.Size(329, 313);
            this.pnlType_1.TabIndex = 0;
            this.pnlType_1.Click += new System.EventHandler(this.pnlType_1_Click);
            // 
            // lbWalkthrough
            // 
            this.lbWalkthrough.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbWalkthrough, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbWalkthrough.Font = new System.Drawing.Font("Montserrat Alternates", 26F, System.Drawing.FontStyle.Bold);
            this.lbWalkthrough.ForeColor = System.Drawing.Color.White;
            this.lbWalkthrough.Location = new System.Drawing.Point(14, 55);
            this.lbWalkthrough.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWalkthrough.Name = "lbWalkthrough";
            this.lbWalkthrough.Size = new System.Drawing.Size(255, 248);
            this.lbWalkthrough.TabIndex = 1;
            this.lbWalkthrough.Text = "The Monster Cave";
            this.lbWalkthrough.Click += new System.EventHandler(this.lbWalkthrough_Click);
            // 
            // pnlType_2
            // 
            this.pnlType_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlType_2.BackgroundImage")));
            this.pnlType_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlType_2.BorderColor = System.Drawing.Color.White;
            this.pnlType_2.Controls.Add(this.lbMaze);
            this.guna2Transition1.SetDecoration(this.pnlType_2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlType_2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlType_2.Location = new System.Drawing.Point(329, 0);
            this.pnlType_2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlType_2.Name = "pnlType_2";
            this.pnlType_2.ShadowDecoration.Parent = this.pnlType_2;
            this.pnlType_2.Size = new System.Drawing.Size(329, 313);
            this.pnlType_2.TabIndex = 1;
            this.pnlType_2.Click += new System.EventHandler(this.pnlType_2_Click);
            // 
            // lbMaze
            // 
            this.lbMaze.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbMaze, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbMaze.Font = new System.Drawing.Font("Montserrat Alternates", 26F, System.Drawing.FontStyle.Bold);
            this.lbMaze.ForeColor = System.Drawing.Color.White;
            this.lbMaze.Location = new System.Drawing.Point(22, 55);
            this.lbMaze.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaze.Name = "lbMaze";
            this.lbMaze.Size = new System.Drawing.Size(291, 239);
            this.lbMaze.TabIndex = 0;
            this.lbMaze.Text = "The Mysterious Maze";
            this.lbMaze.Click += new System.EventHandler(this.lbMaze_Click);
            // 
            // pbWeapon
            // 
            this.guna2Transition1.SetDecoration(this.pbWeapon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbWeapon.Location = new System.Drawing.Point(69, 39);
            this.pbWeapon.Name = "pbWeapon";
            this.pbWeapon.Size = new System.Drawing.Size(82, 73);
            this.pbWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeapon.TabIndex = 30;
            this.pbWeapon.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 20;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.guna2Transition1.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(214, 365);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(135, 37);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 20;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.guna2Transition1.SetDecoration(this.btnStart, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(405, 365);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(135, 37);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnChooseType
            // 
            this.btnChooseType.BorderRadius = 20;
            this.btnChooseType.CheckedState.Parent = this.btnChooseType;
            this.btnChooseType.CustomImages.Parent = this.btnChooseType;
            this.guna2Transition1.SetDecoration(this.btnChooseType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnChooseType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnChooseType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseType.ForeColor = System.Drawing.Color.White;
            this.btnChooseType.HoverState.Parent = this.btnChooseType;
            this.btnChooseType.Location = new System.Drawing.Point(307, 365);
            this.btnChooseType.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseType.Name = "btnChooseType";
            this.btnChooseType.ShadowDecoration.Parent = this.btnChooseType;
            this.btnChooseType.Size = new System.Drawing.Size(135, 37);
            this.btnChooseType.TabIndex = 27;
            this.btnChooseType.Text = "Let\'s play";
            this.btnChooseType.Click += new System.EventHandler(this.btnChooseType_Click);
            // 
            // pbCurrency
            // 
            this.guna2Transition1.SetDecoration(this.pbCurrency, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbCurrency.Image = ((System.Drawing.Image)(resources.GetObject("pbCurrency.Image")));
            this.pbCurrency.Location = new System.Drawing.Point(629, 39);
            this.pbCurrency.Name = "pbCurrency";
            this.pbCurrency.Size = new System.Drawing.Size(21, 19);
            this.pbCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrency.TabIndex = 25;
            this.pbCurrency.TabStop = false;
            // 
            // lbDiamond
            // 
            this.lbDiamond.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbDiamond, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbDiamond.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiamond.Location = new System.Drawing.Point(598, 39);
            this.lbDiamond.Name = "lbDiamond";
            this.lbDiamond.Size = new System.Drawing.Size(33, 19);
            this.lbDiamond.TabIndex = 24;
            this.lbDiamond.Text = "100";
            // 
            // btnToggle
            // 
            this.guna2Transition1.SetDecoration(this.btnToggle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnToggle.Location = new System.Drawing.Point(13, 53);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(10, 10);
            this.btnToggle.TabIndex = 23;
            this.btnToggle.Text = "0";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Visible = false;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbName.Font = new System.Drawing.Font("Montserrat Alternates", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 98);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(750, 30);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            this.btnPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BorderRadius = 15;
            this.btnPrevious.CheckedState.Parent = this.btnPrevious;
            this.btnPrevious.CustomImages.Parent = this.btnPrevious;
            this.guna2Transition1.SetDecoration(this.btnPrevious, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.HoverState.Parent = this.btnPrevious;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageSize = new System.Drawing.Size(30, 45);
            this.btnPrevious.Location = new System.Drawing.Point(170, 192);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ShadowDecoration.Parent = this.btnPrevious;
            this.btnPrevious.Size = new System.Drawing.Size(50, 58);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 15;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.guna2Transition1.SetDecoration(this.btnNext, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(30, 45);
            this.btnNext.Location = new System.Drawing.Point(528, 192);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(50, 58);
            this.btnNext.TabIndex = 19;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pbCharacter
            // 
            this.pbCharacter.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pbCharacter, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbCharacter.Location = new System.Drawing.Point(258, 143);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(229, 142);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCharacter.TabIndex = 0;
            this.pbCharacter.TabStop = false;
            // 
            // btnShop
            // 
            this.btnShop.BorderRadius = 15;
            this.btnShop.CheckedState.Parent = this.btnShop;
            this.btnShop.CustomImages.Parent = this.btnShop;
            this.guna2Transition1.SetDecoration(this.btnShop, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnShop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnShop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.HoverState.Parent = this.btnShop;
            this.btnShop.Image = ((System.Drawing.Image)(resources.GetObject("btnShop.Image")));
            this.btnShop.Location = new System.Drawing.Point(596, 63);
            this.btnShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnShop.Name = "btnShop";
            this.btnShop.ShadowDecoration.Parent = this.btnShop;
            this.btnShop.Size = new System.Drawing.Size(67, 37);
            this.btnShop.TabIndex = 3;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RevisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(750, 422);
            this.Controls.Add(this.pnlRevision);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RevisionForm";
            this.Text = "RevisionForm";
            this.pnlRevision.ResumeLayout(false);
            this.pnlChoosePlay.ResumeLayout(false);
            this.pnlChoosePlay.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlType_1.ResumeLayout(false);
            this.pnlType_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlRevision;
        private System.Windows.Forms.Panel pnlChoosePlay;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlType;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlType_2;
        private System.Windows.Forms.Label lbWalkthrough;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlType_1;
        private System.Windows.Forms.Label lbMaze;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Button btnChooseType;
        private System.Windows.Forms.PictureBox pbCurrency;
        private System.Windows.Forms.Label lbDiamond;
        public System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.PictureBox pbCharacter;
        private Guna.UI2.WinForms.Guna2Button btnShop;
        private System.Windows.Forms.Label lbNotification;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnLeft2;
        private Guna.UI2.WinForms.Guna2Button btnRight2;
        private System.Windows.Forms.PictureBox pbWeapon;
    }
}