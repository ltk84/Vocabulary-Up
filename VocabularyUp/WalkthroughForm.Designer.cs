
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WalkthroughForm));
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pbIconHealth = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lbDiamond = new System.Windows.Forms.Label();
            this.pbDiamond = new System.Windows.Forms.PictureBox();
            this.pgbHealth = new VocabularyUp.SuperProgressBar();
            this.pnlQuestion = new System.Windows.Forms.Panel();
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
            this.pgbMonsterHealth = new VocabularyUp.SuperProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconHealth)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamond)).BeginInit();
            this.pnlQuestion.SuspendLayout();
            this.pnlFlashCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // pbIconHealth
            // 
            this.pbIconHealth.BackColor = System.Drawing.Color.Transparent;
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
            this.pbDiamond.Image = ((System.Drawing.Image)(resources.GetObject("pbDiamond.Image")));
            this.pbDiamond.Location = new System.Drawing.Point(14, 49);
            this.pbDiamond.Margin = new System.Windows.Forms.Padding(2);
            this.pbDiamond.Name = "pbDiamond";
            this.pbDiamond.Size = new System.Drawing.Size(22, 24);
            this.pbDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiamond.TabIndex = 4;
            this.pbDiamond.TabStop = false;
            // 
            // pgbHealth
            // 
            this.pgbHealth.BackColor = System.Drawing.Color.White;
            this.pgbHealth.Location = new System.Drawing.Point(49, 16);
            this.pgbHealth.Margin = new System.Windows.Forms.Padding(2);
            this.pgbHealth.Name = "pgbHealth";
            this.pgbHealth.Size = new System.Drawing.Size(213, 20);
            this.pgbHealth.TabIndex = 3;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlQuestion.BackgroundImage")));
            this.pnlQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlQuestion.Controls.Add(this.lbTimer);
            this.pnlQuestion.Controls.Add(this.btnConfirm);
            this.pnlQuestion.Controls.Add(this.btnB);
            this.pnlQuestion.Controls.Add(this.btnA);
            this.pnlQuestion.Controls.Add(this.btnD);
            this.pnlQuestion.Controls.Add(this.btnC);
            this.pnlQuestion.Controls.Add(this.pnlFlashCard);
            this.pnlQuestion.Location = new System.Drawing.Point(51, 2);
            this.pnlQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(746, 364);
            this.pnlQuestion.TabIndex = 6;
            this.pnlQuestion.Visible = false;
            this.pnlQuestion.VisibleChanged += new System.EventHandler(this.pnlQuestion_VisibleChanged);
            // 
            // lbTimer
            // 
            this.lbTimer.BackColor = System.Drawing.Color.Transparent;
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
            this.pnlFlashCard.Location = new System.Drawing.Point(26, 20);
            this.pnlFlashCard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFlashCard.Name = "pnlFlashCard";
            this.pnlFlashCard.Size = new System.Drawing.Size(264, 323);
            this.pnlFlashCard.TabIndex = 45;
            // 
            // pnlDash
            // 
            this.pnlDash.BackColor = System.Drawing.Color.White;
            this.pnlDash.Location = new System.Drawing.Point(22, 214);
            this.pnlDash.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(217, 4);
            this.pnlDash.TabIndex = 14;
            // 
            // lbMain
            // 
            this.lbMain.BackColor = System.Drawing.Color.Transparent;
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
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(22, 19);
            this.pbMain.Margin = new System.Windows.Forms.Padding(2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(217, 184);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 13;
            this.pbMain.TabStop = false;
            // 
            // pgbMonsterHealth
            // 
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
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pgbMonsterHealth);
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
    }
}