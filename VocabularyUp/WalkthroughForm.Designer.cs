
namespace VocabularyUp
{
    partial class WalkthroughForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WalkthroughForm));
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pbIconHealth = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lbDiamond = new System.Windows.Forms.Label();
            this.pbDiamond = new System.Windows.Forms.PictureBox();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetails = new Guna.UI2.WinForms.Guna2Button();
            this.timerBullet = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.timerQuestion = new System.Windows.Forms.Timer(this.components);
            this.timerEffect = new System.Windows.Forms.Timer(this.components);
            this.pgbHealth = new VocabularyUp.SuperProgressBar();
            this.pgbMonsterHealth = new VocabularyUp.SuperProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconHealth)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamond)).BeginInit();
            this.pnlQuestion.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFlashCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 50;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // pbIconHealth
            // 
            this.pbIconHealth.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pbIconHealth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbIconHealth.Image = ((System.Drawing.Image)(resources.GetObject("pbIconHealth.Image")));
            this.pbIconHealth.Location = new System.Drawing.Point(14, 12);
            this.pbIconHealth.Margin = new System.Windows.Forms.Padding(2);
            this.pbIconHealth.Name = "pbIconHealth";
            this.pbIconHealth.Size = new System.Drawing.Size(22, 24);
            this.pbIconHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconHealth.TabIndex = 1;
            this.pbIconHealth.TabStop = false;
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
            this.guna2Transition1.SetDecoration(this.pnlInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlInfo.Location = new System.Drawing.Point(20, 22);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(289, 89);
            this.pnlInfo.TabIndex = 5;
            // 
            // lbDiamond
            // 
            this.lbDiamond.AutoSize = true;
            this.lbDiamond.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbDiamond, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbDiamond.Font = new System.Drawing.Font("Montserrat Alternates", 12F);
            this.lbDiamond.ForeColor = System.Drawing.Color.White;
            this.lbDiamond.Location = new System.Drawing.Point(45, 49);
            this.lbDiamond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiamond.Name = "lbDiamond";
            this.lbDiamond.Size = new System.Drawing.Size(21, 22);
            this.lbDiamond.TabIndex = 5;
            this.lbDiamond.Text = "0";
            // 
            // pbDiamond
            // 
            this.pbDiamond.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pbDiamond, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbDiamond.Image = ((System.Drawing.Image)(resources.GetObject("pbDiamond.Image")));
            this.pbDiamond.Location = new System.Drawing.Point(14, 49);
            this.pbDiamond.Margin = new System.Windows.Forms.Padding(2);
            this.pbDiamond.Name = "pbDiamond";
            this.pbDiamond.Size = new System.Drawing.Size(22, 24);
            this.pbDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiamond.TabIndex = 4;
            this.pbDiamond.TabStop = false;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlQuestion.BackgroundImage")));
            this.pnlQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlQuestion.Controls.Add(this.panel4);
            this.pnlQuestion.Controls.Add(this.panel1);
            this.pnlQuestion.Controls.Add(this.lbTimer);
            this.pnlQuestion.Controls.Add(this.btnConfirm);
            this.pnlQuestion.Controls.Add(this.btnB);
            this.pnlQuestion.Controls.Add(this.btnA);
            this.pnlQuestion.Controls.Add(this.btnD);
            this.pnlQuestion.Controls.Add(this.btnC);
            this.pnlQuestion.Controls.Add(this.pnlFlashCard);
            this.guna2Transition1.SetDecoration(this.pnlQuestion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlQuestion.Location = new System.Drawing.Point(51, 2);
            this.pnlQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(746, 364);
            this.pnlQuestion.TabIndex = 6;
            this.pnlQuestion.Visible = false;
            this.pnlQuestion.VisibleChanged += new System.EventHandler(this.pnlQuestion_VisibleChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.guna2Button12);
            this.panel4.Controls.Add(this.guna2Button13);
            this.panel4.Controls.Add(this.guna2Button14);
            this.panel4.Controls.Add(this.guna2Button15);
            this.panel4.Controls.Add(this.guna2Button16);
            this.panel4.Controls.Add(this.panel8);
            this.guna2Transition1.SetDecoration(this.panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(746, 364);
            this.panel4.TabIndex = 53;
            this.panel4.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(479, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "60";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button12
            // 
            this.guna2Button12.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button12.BackgroundImage")));
            this.guna2Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button12.CheckedState.Parent = this.guna2Button12;
            this.guna2Button12.CustomImages.Parent = this.guna2Button12;
            this.guna2Transition1.SetDecoration(this.guna2Button12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button12.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button12.ForeColor = System.Drawing.Color.Black;
            this.guna2Button12.HoverState.Parent = this.guna2Button12;
            this.guna2Button12.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button12.Image")));
            this.guna2Button12.ImageSize = new System.Drawing.Size(60, 45);
            this.guna2Button12.Location = new System.Drawing.Point(458, 246);
            this.guna2Button12.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.ShadowDecoration.Parent = this.guna2Button12;
            this.guna2Button12.Size = new System.Drawing.Size(108, 58);
            this.guna2Button12.TabIndex = 50;
            // 
            // guna2Button13
            // 
            this.guna2Button13.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button13.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button13.BackgroundImage")));
            this.guna2Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button13.BorderColor = System.Drawing.Color.White;
            this.guna2Button13.CheckedState.Parent = this.guna2Button13;
            this.guna2Button13.CustomImages.Parent = this.guna2Button13;
            this.guna2Transition1.SetDecoration(this.guna2Button13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button13.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button13.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button13.ForeColor = System.Drawing.Color.White;
            this.guna2Button13.HoverState.Parent = this.guna2Button13;
            this.guna2Button13.Location = new System.Drawing.Point(519, 88);
            this.guna2Button13.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button13.Name = "guna2Button13";
            this.guna2Button13.ShadowDecoration.Parent = this.guna2Button13;
            this.guna2Button13.Size = new System.Drawing.Size(135, 58);
            this.guna2Button13.TabIndex = 48;
            // 
            // guna2Button14
            // 
            this.guna2Button14.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button14.BackgroundImage")));
            this.guna2Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button14.BorderColor = System.Drawing.Color.White;
            this.guna2Button14.CheckedState.Parent = this.guna2Button14;
            this.guna2Button14.CustomImages.Parent = this.guna2Button14;
            this.guna2Transition1.SetDecoration(this.guna2Button14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button14.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button14.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button14.ForeColor = System.Drawing.Color.White;
            this.guna2Button14.HoverState.Parent = this.guna2Button14;
            this.guna2Button14.Location = new System.Drawing.Point(370, 88);
            this.guna2Button14.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.ShadowDecoration.Parent = this.guna2Button14;
            this.guna2Button14.Size = new System.Drawing.Size(135, 58);
            this.guna2Button14.TabIndex = 46;
            // 
            // guna2Button15
            // 
            this.guna2Button15.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button15.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button15.BackgroundImage")));
            this.guna2Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button15.BorderColor = System.Drawing.Color.White;
            this.guna2Button15.CheckedState.Parent = this.guna2Button15;
            this.guna2Button15.CustomImages.Parent = this.guna2Button15;
            this.guna2Transition1.SetDecoration(this.guna2Button15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button15.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button15.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button15.ForeColor = System.Drawing.Color.White;
            this.guna2Button15.HoverState.Parent = this.guna2Button15;
            this.guna2Button15.Location = new System.Drawing.Point(519, 167);
            this.guna2Button15.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.ShadowDecoration.Parent = this.guna2Button15;
            this.guna2Button15.Size = new System.Drawing.Size(135, 58);
            this.guna2Button15.TabIndex = 49;
            // 
            // guna2Button16
            // 
            this.guna2Button16.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button16.BackgroundImage")));
            this.guna2Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button16.BorderColor = System.Drawing.Color.White;
            this.guna2Button16.CheckedState.Parent = this.guna2Button16;
            this.guna2Button16.CustomImages.Parent = this.guna2Button16;
            this.guna2Transition1.SetDecoration(this.guna2Button16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button16.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button16.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button16.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.HoverState.Parent = this.guna2Button16;
            this.guna2Button16.Location = new System.Drawing.Point(370, 167);
            this.guna2Button16.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.ShadowDecoration.Parent = this.guna2Button16;
            this.guna2Button16.Size = new System.Drawing.Size(135, 58);
            this.guna2Button16.TabIndex = 47;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.pictureBox3);
            this.guna2Transition1.SetDecoration(this.panel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel8.Location = new System.Drawing.Point(26, 20);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(264, 323);
            this.panel8.TabIndex = 45;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.panel9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel9.Location = new System.Drawing.Point(22, 214);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(217, 4);
            this.panel9.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 77);
            this.label6.TabIndex = 12;
            this.label6.Text = "Welcome";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 19);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(217, 184);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.panel2);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 364);
            this.panel1.TabIndex = 52;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(479, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "60";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button1.BackgroundImage")));
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(60, 45);
            this.guna2Button1.Location = new System.Drawing.Point(458, 246);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(108, 58);
            this.guna2Button1.TabIndex = 50;
            // 
            // guna2Button2
            // 
            this.guna2Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button2.BackgroundImage")));
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Transition1.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(519, 88);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(135, 58);
            this.guna2Button2.TabIndex = 48;
            // 
            // guna2Button3
            // 
            this.guna2Button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button3.BackgroundImage")));
            this.guna2Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Transition1.SetDecoration(this.guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(370, 88);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(135, 58);
            this.guna2Button3.TabIndex = 46;
            // 
            // guna2Button4
            // 
            this.guna2Button4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button4.BackgroundImage")));
            this.guna2Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button4.BorderColor = System.Drawing.Color.White;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Transition1.SetDecoration(this.guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(519, 167);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(135, 58);
            this.guna2Button4.TabIndex = 49;
            // 
            // guna2Button5
            // 
            this.guna2Button5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button5.BackgroundImage")));
            this.guna2Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button5.BorderColor = System.Drawing.Color.White;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Transition1.SetDecoration(this.guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(370, 167);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(135, 58);
            this.guna2Button5.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(26, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 323);
            this.panel2.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(22, 214);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 4);
            this.panel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 77);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbTimer
            // 
            this.lbTimer.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbTimer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(479, 46);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(70, 23);
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
            this.guna2Transition1.SetDecoration(this.btnConfirm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnConfirm.FillColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageSize = new System.Drawing.Size(60, 45);
            this.btnConfirm.Location = new System.Drawing.Point(458, 246);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(108, 58);
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
            this.guna2Transition1.SetDecoration(this.btnB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnB.FillColor = System.Drawing.Color.Transparent;
            this.btnB.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.HoverState.Parent = this.btnB;
            this.btnB.Location = new System.Drawing.Point(519, 88);
            this.btnB.Margin = new System.Windows.Forms.Padding(2);
            this.btnB.Name = "btnB";
            this.btnB.ShadowDecoration.Parent = this.btnB;
            this.btnB.Size = new System.Drawing.Size(135, 58);
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
            this.guna2Transition1.SetDecoration(this.btnA, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnA.FillColor = System.Drawing.Color.Transparent;
            this.btnA.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.HoverState.Parent = this.btnA;
            this.btnA.Location = new System.Drawing.Point(370, 88);
            this.btnA.Margin = new System.Windows.Forms.Padding(2);
            this.btnA.Name = "btnA";
            this.btnA.ShadowDecoration.Parent = this.btnA;
            this.btnA.Size = new System.Drawing.Size(135, 58);
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
            this.guna2Transition1.SetDecoration(this.btnD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnD.FillColor = System.Drawing.Color.Transparent;
            this.btnD.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.HoverState.Parent = this.btnD;
            this.btnD.Location = new System.Drawing.Point(519, 167);
            this.btnD.Margin = new System.Windows.Forms.Padding(2);
            this.btnD.Name = "btnD";
            this.btnD.ShadowDecoration.Parent = this.btnD;
            this.btnD.Size = new System.Drawing.Size(135, 58);
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
            this.guna2Transition1.SetDecoration(this.btnC, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnC.FillColor = System.Drawing.Color.Transparent;
            this.btnC.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.HoverState.Parent = this.btnC;
            this.btnC.Location = new System.Drawing.Point(370, 167);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.ShadowDecoration.Parent = this.btnC;
            this.btnC.Size = new System.Drawing.Size(135, 58);
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
            this.guna2Transition1.SetDecoration(this.pnlFlashCard, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlFlashCard.Location = new System.Drawing.Point(26, 20);
            this.pnlFlashCard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFlashCard.Name = "pnlFlashCard";
            this.pnlFlashCard.Size = new System.Drawing.Size(264, 323);
            this.pnlFlashCard.TabIndex = 45;
            // 
            // pnlDash
            // 
            this.pnlDash.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.pnlDash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlDash.Location = new System.Drawing.Point(22, 214);
            this.pnlDash.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(217, 4);
            this.pnlDash.TabIndex = 14;
            // 
            // lbMain
            // 
            this.lbMain.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbMain.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbMain.ForeColor = System.Drawing.Color.White;
            this.lbMain.Location = new System.Drawing.Point(2, 227);
            this.lbMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(260, 77);
            this.lbMain.TabIndex = 12;
            this.lbMain.Text = "Welcome";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMain
            // 
            this.guna2Transition1.SetDecoration(this.pbMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(22, 19);
            this.pbMain.Margin = new System.Windows.Forms.Padding(2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(217, 184);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 13;
            this.pbMain.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.guna2Transition1.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(60, 45);
            this.btnClose.Location = new System.Drawing.Point(210, 405);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(108, 58);
            this.btnClose.TabIndex = 53;
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
            this.guna2Transition1.SetDecoration(this.btnDetails, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDetails.FillColor = System.Drawing.Color.Transparent;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetails.ForeColor = System.Drawing.Color.Black;
            this.btnDetails.HoverState.Parent = this.btnDetails;
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.ImageSize = new System.Drawing.Size(50, 40);
            this.btnDetails.Location = new System.Drawing.Point(453, 405);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ShadowDecoration.Parent = this.btnDetails;
            this.btnDetails.Size = new System.Drawing.Size(108, 58);
            this.btnDetails.TabIndex = 54;
            this.btnDetails.Visible = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // timerBullet
            // 
            this.timerBullet.Tick += new System.EventHandler(this.timerBullet_Tick);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
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
            // timerQuestion
            // 
            this.timerQuestion.Interval = 1000;
            this.timerQuestion.Tick += new System.EventHandler(this.timerQuestion_Tick);
            // 
            // timerEffect
            // 
            this.timerEffect.Interval = 50;
            this.timerEffect.Tick += new System.EventHandler(this.timerEffect_Tick);
            // 
            // pgbHealth
            // 
            this.pgbHealth.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.pgbHealth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pgbHealth.Location = new System.Drawing.Point(49, 16);
            this.pgbHealth.Margin = new System.Windows.Forms.Padding(2);
            this.pgbHealth.Name = "pgbHealth";
            this.pgbHealth.Size = new System.Drawing.Size(213, 20);
            this.pgbHealth.TabIndex = 3;
            // 
            // pgbMonsterHealth
            // 
            this.guna2Transition1.SetDecoration(this.pgbMonsterHealth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pgbMonsterHealth.Location = new System.Drawing.Point(313, 22);
            this.pgbMonsterHealth.Margin = new System.Windows.Forms.Padding(2);
            this.pgbMonsterHealth.Name = "pgbMonsterHealth";
            this.pgbMonsterHealth.Size = new System.Drawing.Size(464, 24);
            this.pgbMonsterHealth.TabIndex = 4;
            this.pgbMonsterHealth.Visible = false;
            // 
            // WalkthroughForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 533);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pgbMonsterHealth);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "WalkthroughForm";
            this.Text = "WalkthroughForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.WalkthroughForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconHealth)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamond)).EndInit();
            this.pnlQuestion.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFlashCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.PictureBox pbIconHealth;
        private SuperProgressBar pgbHealth;
        private SuperProgressBar pgbMonsterHealth;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lbDiamond;
        private System.Windows.Forms.PictureBox pbDiamond;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button12;
        private Guna.UI2.WinForms.Guna2Button guna2Button13;
        private Guna.UI2.WinForms.Guna2Button guna2Button14;
        private Guna.UI2.WinForms.Guna2Button guna2Button15;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnDetails;
        private System.Windows.Forms.Timer timerBullet;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Timer timerQuestion;
        private System.Windows.Forms.Timer timerEffect;
    }
}