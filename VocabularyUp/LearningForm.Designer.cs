namespace VocabularyUp
{
    partial class LearningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearningForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLeft = new Guna.UI2.WinForms.Guna2Button();
            this.btnPronun = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pnlDash = new System.Windows.Forms.Panel();
            this.pnlLib = new System.Windows.Forms.Panel();
            this.pnlToCollection = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cbCollection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnToCollection = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTab = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlMainNav = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnRight = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.pnlLib.SuspendLayout();
            this.pnlToCollection.SuspendLayout();
            this.pnlTab.SuspendLayout();
            this.pnlMainNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLeft.CheckedState.Parent = this.btnLeft;
            this.btnLeft.CustomImages.Parent = this.btnLeft;
            this.btnLeft.FillColor = System.Drawing.Color.Transparent;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.HoverState.Parent = this.btnLeft;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.ImageSize = new System.Drawing.Size(115, 130);
            this.btnLeft.Location = new System.Drawing.Point(0, 45);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.ShadowDecoration.Parent = this.btnLeft;
            this.btnLeft.Size = new System.Drawing.Size(303, 475);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnPronun
            // 
            this.btnPronun.BackColor = System.Drawing.Color.Transparent;
            this.btnPronun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPronun.CheckedState.Parent = this.btnPronun;
            this.btnPronun.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnPronun.HoverState.Image")));
            this.btnPronun.HoverState.Parent = this.btnPronun;
            this.btnPronun.Image = ((System.Drawing.Image)(resources.GetObject("btnPronun.Image")));
            this.btnPronun.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPronun.Location = new System.Drawing.Point(341, 362);
            this.btnPronun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPronun.Name = "btnPronun";
            this.btnPronun.PressedState.Parent = this.btnPronun;
            this.btnPronun.Size = new System.Drawing.Size(32, 38);
            this.btnPronun.TabIndex = 14;
            this.btnPronun.Click += new System.EventHandler(this.btnPronun_Click);
            // 
            // lbMain
            // 
            this.lbMain.BackColor = System.Drawing.Color.Transparent;
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbMain.Location = new System.Drawing.Point(-3, 362);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(394, 38);
            this.lbMain.TabIndex = 7;
            this.lbMain.Text = "Welcome";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMain
            // 
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(19, 21);
            this.pbMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(354, 320);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 8;
            this.pbMain.TabStop = false;
            // 
            // pnlDash
            // 
            this.pnlDash.BackColor = System.Drawing.Color.White;
            this.pnlDash.Location = new System.Drawing.Point(19, 345);
            this.pnlDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(354, 5);
            this.pnlDash.TabIndex = 11;
            // 
            // pnlLib
            // 
            this.pnlLib.BackColor = System.Drawing.Color.Transparent;
            this.pnlLib.Controls.Add(this.pnlToCollection);
            this.pnlLib.Controls.Add(this.pnlTab);
            this.pnlLib.Location = new System.Drawing.Point(303, 45);
            this.pnlLib.Name = "pnlLib";
            this.pnlLib.Size = new System.Drawing.Size(394, 475);
            this.pnlLib.TabIndex = 9;
            // 
            // pnlToCollection
            // 
            this.pnlToCollection.Controls.Add(this.cbCollection);
            this.pnlToCollection.Controls.Add(this.btnToCollection);
            this.pnlToCollection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlToCollection.Location = new System.Drawing.Point(0, 425);
            this.pnlToCollection.Name = "pnlToCollection";
            this.pnlToCollection.ShadowDecoration.Parent = this.pnlToCollection;
            this.pnlToCollection.Size = new System.Drawing.Size(394, 50);
            this.pnlToCollection.TabIndex = 11;
            // 
            // cbCollection
            // 
            this.cbCollection.BackColor = System.Drawing.Color.Transparent;
            this.cbCollection.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbCollection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCollection.FocusedColor = System.Drawing.Color.Empty;
            this.cbCollection.FocusedState.Parent = this.cbCollection;
            this.cbCollection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCollection.FormattingEnabled = true;
            this.cbCollection.HoverState.Parent = this.cbCollection;
            this.cbCollection.ItemHeight = 30;
            this.cbCollection.ItemsAppearance.Parent = this.cbCollection;
            this.cbCollection.Location = new System.Drawing.Point(0, 0);
            this.cbCollection.Name = "cbCollection";
            this.cbCollection.ShadowDecoration.Parent = this.cbCollection;
            this.cbCollection.Size = new System.Drawing.Size(343, 36);
            this.cbCollection.TabIndex = 13;
            // 
            // btnToCollection
            // 
            this.btnToCollection.BackColor = System.Drawing.Color.Transparent;
            this.btnToCollection.BorderRadius = 15;
            this.btnToCollection.CheckedState.Parent = this.btnToCollection;
            this.btnToCollection.CustomImages.Parent = this.btnToCollection;
            this.btnToCollection.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToCollection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnToCollection.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCollection.ForeColor = System.Drawing.Color.Black;
            this.btnToCollection.HoverState.Parent = this.btnToCollection;
            this.btnToCollection.Image = ((System.Drawing.Image)(resources.GetObject("btnToCollection.Image")));
            this.btnToCollection.Location = new System.Drawing.Point(349, 0);
            this.btnToCollection.Name = "btnToCollection";
            this.btnToCollection.ShadowDecoration.Parent = this.btnToCollection;
            this.btnToCollection.Size = new System.Drawing.Size(45, 50);
            this.btnToCollection.TabIndex = 0;
            this.btnToCollection.Click += new System.EventHandler(this.btnToCollection_Click);
            // 
            // pnlTab
            // 
            this.pnlTab.BorderRadius = 20;
            this.pnlTab.Controls.Add(this.btnPronun);
            this.pnlTab.Controls.Add(this.lbMain);
            this.pnlTab.Controls.Add(this.pbMain);
            this.pnlTab.Controls.Add(this.pnlDash);
            this.pnlTab.FillColor2 = System.Drawing.Color.LightGreen;
            this.pnlTab.FillColor3 = System.Drawing.Color.LightGreen;
            this.pnlTab.Location = new System.Drawing.Point(3, 2);
            this.pnlTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.ShadowDecoration.Parent = this.pnlTab;
            this.pnlTab.Size = new System.Drawing.Size(394, 420);
            this.pnlTab.TabIndex = 0;
            // 
            // pnlMainNav
            // 
            this.pnlMainNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlMainNav.BorderRadius = 20;
            this.pnlMainNav.Controls.Add(this.btnDone);
            this.pnlMainNav.Controls.Add(this.btnBack);
            this.pnlMainNav.Controls.Add(this.pnlLib);
            this.pnlMainNav.Controls.Add(this.btnLeft);
            this.pnlMainNav.Controls.Add(this.btnRight);
            this.pnlMainNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainNav.Location = new System.Drawing.Point(0, 0);
            this.pnlMainNav.Name = "pnlMainNav";
            this.pnlMainNav.ShadowDecoration.Parent = this.pnlMainNav;
            this.pnlMainNav.Size = new System.Drawing.Size(1000, 520);
            this.pnlMainNav.TabIndex = 14;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.BorderRadius = 15;
            this.btnDone.CheckedState.Parent = this.btnDone;
            this.btnDone.CustomImages.Parent = this.btnDone;
            this.btnDone.FillColor = System.Drawing.Color.Transparent;
            this.btnDone.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.HoverState.Parent = this.btnDone;
            this.btnDone.Image = ((System.Drawing.Image)(resources.GetObject("btnDone.Image")));
            this.btnDone.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDone.Location = new System.Drawing.Point(868, 6);
            this.btnDone.Name = "btnDone";
            this.btnDone.ShadowDecoration.Parent = this.btnDone;
            this.btnDone.Size = new System.Drawing.Size(46, 39);
            this.btnDone.TabIndex = 59;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 15;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBack.Location = new System.Drawing.Point(26, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(46, 39);
            this.btnBack.TabIndex = 14;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.CheckedState.Parent = this.btnRight;
            this.btnRight.CustomImages.Parent = this.btnRight;
            this.btnRight.FillColor = System.Drawing.Color.Transparent;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.HoverState.Parent = this.btnRight;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.ImageSize = new System.Drawing.Size(115, 130);
            this.btnRight.Location = new System.Drawing.Point(697, 45);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.ShadowDecoration.Parent = this.btnRight;
            this.btnRight.Size = new System.Drawing.Size(303, 475);
            this.btnRight.TabIndex = 8;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // LearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.pnlMainNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LearningForm";
            this.Text = "LearningForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.pnlLib.ResumeLayout(false);
            this.pnlToCollection.ResumeLayout(false);
            this.pnlTab.ResumeLayout(false);
            this.pnlMainNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMainNav;
        private System.Windows.Forms.Panel pnlLib;
        private System.Windows.Forms.Panel pnlSearching;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearching;
        private Guna.UI2.WinForms.Guna2Button btnLeft;
        private Guna.UI2.WinForms.Guna2Button btnRight;
        private System.Windows.Forms.Label lbCollectionName;
        private System.Windows.Forms.PictureBox pbCollectionIcon;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTab;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Panel pnlDash;
        private Guna.UI2.WinForms.Guna2Button btnRemoveFromCollection;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnDone;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ImageButton btnPronun;
        private System.Windows.Forms.Timer timer1; 
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlToCollection;
        private Guna.UI2.WinForms.Guna2ComboBox cbCollection;
        private Guna.UI2.WinForms.Guna2Button btnToCollection;
    }
}