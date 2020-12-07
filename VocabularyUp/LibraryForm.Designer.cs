namespace VocabularyUp
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.pnlMainNav = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlLib = new System.Windows.Forms.Panel();
            this.pnlToCollection = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cbCollection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnToCollection = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTab = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnPronun = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pnlDash = new System.Windows.Forms.Panel();
            this.pnlSearching = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearching = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLeft = new Guna.UI2.WinForms.Guna2Button();
            this.btnRight = new Guna.UI2.WinForms.Guna2Button();
            this.timerSpeaker = new System.Windows.Forms.Timer(this.components);
            this.pnlMainNav.SuspendLayout();
            this.pnlLib.SuspendLayout();
            this.pnlToCollection.SuspendLayout();
            this.pnlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.pnlSearching.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainNav
            // 
            this.pnlMainNav.BorderRadius = 20;
            this.pnlMainNav.Controls.Add(this.pnlLib);
            this.pnlMainNav.Controls.Add(this.btnLeft);
            this.pnlMainNav.Controls.Add(this.btnRight);
            this.pnlMainNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainNav.Location = new System.Drawing.Point(0, 0);
            this.pnlMainNav.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainNav.Name = "pnlMainNav";
            this.pnlMainNav.ShadowDecoration.Parent = this.pnlMainNav;
            this.pnlMainNav.Size = new System.Drawing.Size(750, 422);
            this.pnlMainNav.TabIndex = 12;
            // 
            // pnlLib
            // 
            this.pnlLib.BackColor = System.Drawing.Color.Transparent;
            this.pnlLib.Controls.Add(this.pnlToCollection);
            this.pnlLib.Controls.Add(this.pnlTab);
            this.pnlLib.Controls.Add(this.pnlSearching);
            this.pnlLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLib.Location = new System.Drawing.Point(227, 0);
            this.pnlLib.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLib.Name = "pnlLib";
            this.pnlLib.Size = new System.Drawing.Size(296, 422);
            this.pnlLib.TabIndex = 9;
            // 
            // pnlToCollection
            // 
            this.pnlToCollection.Controls.Add(this.cbCollection);
            this.pnlToCollection.Controls.Add(this.btnToCollection);
            this.pnlToCollection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlToCollection.Location = new System.Drawing.Point(0, 381);
            this.pnlToCollection.Margin = new System.Windows.Forms.Padding(2);
            this.pnlToCollection.Name = "pnlToCollection";
            this.pnlToCollection.ShadowDecoration.Parent = this.pnlToCollection;
            this.pnlToCollection.Size = new System.Drawing.Size(296, 41);
            this.pnlToCollection.TabIndex = 10;
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
            this.cbCollection.Margin = new System.Windows.Forms.Padding(2);
            this.cbCollection.Name = "cbCollection";
            this.cbCollection.ShadowDecoration.Parent = this.cbCollection;
            this.cbCollection.Size = new System.Drawing.Size(258, 36);
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
            this.btnToCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCollection.ForeColor = System.Drawing.Color.Black;
            this.btnToCollection.HoverState.Parent = this.btnToCollection;
            this.btnToCollection.Image = ((System.Drawing.Image)(resources.GetObject("btnToCollection.Image")));
            this.btnToCollection.Location = new System.Drawing.Point(262, 0);
            this.btnToCollection.Margin = new System.Windows.Forms.Padding(2);
            this.btnToCollection.Name = "btnToCollection";
            this.btnToCollection.ShadowDecoration.Parent = this.btnToCollection;
            this.btnToCollection.Size = new System.Drawing.Size(34, 41);
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
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTab.FillColor2 = System.Drawing.Color.LightGreen;
            this.pnlTab.FillColor3 = System.Drawing.Color.LightGreen;
            this.pnlTab.Location = new System.Drawing.Point(0, 37);
            this.pnlTab.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.ShadowDecoration.Parent = this.pnlTab;
            this.pnlTab.Size = new System.Drawing.Size(296, 341);
            this.pnlTab.TabIndex = 0;
            this.pnlTab.Click += new System.EventHandler(this.pnlTab_Click);
            // 
            // btnPronun
            // 
            this.btnPronun.BackColor = System.Drawing.Color.Transparent;
            this.btnPronun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPronun.CheckedState.Parent = this.btnPronun;
            this.btnPronun.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnPronun.HoverState.Image")));
            this.btnPronun.HoverState.Parent = this.btnPronun;
            this.btnPronun.Image = ((System.Drawing.Image)(resources.GetObject("btnPronun.Image")));
            this.btnPronun.ImageRotate = 0F;
            this.btnPronun.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPronun.Location = new System.Drawing.Point(256, 294);
            this.btnPronun.Margin = new System.Windows.Forms.Padding(2);
            this.btnPronun.Name = "btnPronun";
            this.btnPronun.PressedState.Parent = this.btnPronun;
            this.btnPronun.Size = new System.Drawing.Size(24, 31);
            this.btnPronun.TabIndex = 13;
            this.btnPronun.Click += new System.EventHandler(this.btnPronun_Click);
            // 
            // lbMain
            // 
            this.lbMain.BackColor = System.Drawing.Color.Transparent;
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbMain.Location = new System.Drawing.Point(-2, 294);
            this.lbMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(296, 31);
            this.lbMain.TabIndex = 7;
            this.lbMain.Text = "Welcome";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMain.Click += new System.EventHandler(this.lbMain_Click);
            // 
            // pbMain
            // 
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(14, 17);
            this.pbMain.Margin = new System.Windows.Forms.Padding(2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(266, 260);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 8;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            // 
            // pnlDash
            // 
            this.pnlDash.BackColor = System.Drawing.Color.White;
            this.pnlDash.Location = new System.Drawing.Point(14, 280);
            this.pnlDash.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(266, 4);
            this.pnlDash.TabIndex = 11;
            // 
            // pnlSearching
            // 
            this.pnlSearching.Controls.Add(this.btnSearch);
            this.pnlSearching.Controls.Add(this.txtSearching);
            this.pnlSearching.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearching.Location = new System.Drawing.Point(0, 0);
            this.pnlSearching.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearching.Name = "pnlSearching";
            this.pnlSearching.Size = new System.Drawing.Size(296, 37);
            this.pnlSearching.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnSearch.ImageRotate = 0F;
            this.btnSearch.ImageSize = new System.Drawing.Size(23, 23);
            this.btnSearch.Location = new System.Drawing.Point(243, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(20, 25);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearching
            // 
            this.txtSearching.BorderRadius = 10;
            this.txtSearching.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearching.DefaultText = "";
            this.txtSearching.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearching.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearching.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearching.DisabledState.Parent = this.txtSearching;
            this.txtSearching.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearching.FillColor = System.Drawing.Color.MintCream;
            this.txtSearching.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearching.FocusedState.Parent = this.txtSearching;
            this.txtSearching.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearching.ForeColor = System.Drawing.Color.Black;
            this.txtSearching.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearching.HoverState.Parent = this.txtSearching;
            this.txtSearching.Location = new System.Drawing.Point(29, 8);
            this.txtSearching.Name = "txtSearching";
            this.txtSearching.PasswordChar = '\0';
            this.txtSearching.PlaceholderText = "Search flashcard";
            this.txtSearching.SelectedText = "";
            this.txtSearching.ShadowDecoration.Parent = this.txtSearching;
            this.txtSearching.Size = new System.Drawing.Size(208, 21);
            this.txtSearching.TabIndex = 0;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLeft.CheckedState.Parent = this.btnLeft;
            this.btnLeft.CustomImages.Parent = this.btnLeft;
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLeft.FillColor = System.Drawing.Color.Transparent;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.HoverState.Parent = this.btnLeft;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.ImageSize = new System.Drawing.Size(115, 130);
            this.btnLeft.Location = new System.Drawing.Point(0, 0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.ShadowDecoration.Parent = this.btnLeft;
            this.btnLeft.Size = new System.Drawing.Size(227, 422);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.CheckedState.Parent = this.btnRight;
            this.btnRight.CustomImages.Parent = this.btnRight;
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRight.FillColor = System.Drawing.Color.Transparent;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.HoverState.Parent = this.btnRight;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.ImageSize = new System.Drawing.Size(115, 130);
            this.btnRight.Location = new System.Drawing.Point(523, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.ShadowDecoration.Parent = this.btnRight;
            this.btnRight.Size = new System.Drawing.Size(227, 422);
            this.btnRight.TabIndex = 8;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // timerSpeaker
            // 
            this.timerSpeaker.Enabled = true;
            this.timerSpeaker.Interval = 2000;
            this.timerSpeaker.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LibraryForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(750, 422);
            this.Controls.Add(this.pnlMainNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LibraryForm_KeyUp);
            this.pnlMainNav.ResumeLayout(false);
            this.pnlLib.ResumeLayout(false);
            this.pnlToCollection.ResumeLayout(false);
            this.pnlTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.pnlSearching.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMainNav;
        private System.Windows.Forms.Panel pnlLib;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTab;
        private Guna.UI2.WinForms.Guna2Button btnToCollection;
        private System.Windows.Forms.Panel pnlSearching;
        private Guna.UI2.WinForms.Guna2TextBox txtSearching;
        private Guna.UI2.WinForms.Guna2Button btnLeft;
        private Guna.UI2.WinForms.Guna2Button btnRight;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Panel pnlDash;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlToCollection;
        private Guna.UI2.WinForms.Guna2ComboBox cbCollection;
        private Guna.UI2.WinForms.Guna2ImageButton btnPronun;
        private System.Windows.Forms.Timer timerSpeaker;
    }
}