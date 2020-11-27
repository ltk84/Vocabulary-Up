namespace VocabularyUp
{
    partial class CollectionLib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionLib));
            this.pnlMainNav = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlLib = new System.Windows.Forms.Panel();
            this.btnRemoveFromCollection = new Guna.UI2.WinForms.Guna2Button();
            this.lbCollectionName = new System.Windows.Forms.Label();
            this.pbCollectionIcon = new System.Windows.Forms.PictureBox();
            this.pnlTab = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pnlDash = new System.Windows.Forms.Panel();
            this.pnlSearching = new System.Windows.Forms.Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearching = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLeft = new Guna.UI2.WinForms.Guna2Button();
            this.btnRight = new Guna.UI2.WinForms.Guna2Button();
            this.btnPronun = new Guna.UI2.WinForms.Guna2ImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMainNav.SuspendLayout();
            this.pnlLib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollectionIcon)).BeginInit();
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
            this.pnlMainNav.Name = "pnlMainNav";
            this.pnlMainNav.ShadowDecoration.Parent = this.pnlMainNav;
            this.pnlMainNav.Size = new System.Drawing.Size(1000, 520);
            this.pnlMainNav.TabIndex = 13;
            // 
            // pnlLib
            // 
            this.pnlLib.BackColor = System.Drawing.Color.Transparent;
            this.pnlLib.Controls.Add(this.btnRemoveFromCollection);
            this.pnlLib.Controls.Add(this.lbCollectionName);
            this.pnlLib.Controls.Add(this.pbCollectionIcon);
            this.pnlLib.Controls.Add(this.pnlTab);
            this.pnlLib.Controls.Add(this.pnlSearching);
            this.pnlLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLib.Location = new System.Drawing.Point(303, 0);
            this.pnlLib.Name = "pnlLib";
            this.pnlLib.Size = new System.Drawing.Size(394, 520);
            this.pnlLib.TabIndex = 9;
            // 
            // btnRemoveFromCollection
            // 
            this.btnRemoveFromCollection.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveFromCollection.BorderRadius = 15;
            this.btnRemoveFromCollection.CheckedState.Parent = this.btnRemoveFromCollection;
            this.btnRemoveFromCollection.CustomImages.Parent = this.btnRemoveFromCollection;
            this.btnRemoveFromCollection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRemoveFromCollection.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCollection.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveFromCollection.HoverState.Parent = this.btnRemoveFromCollection;
            this.btnRemoveFromCollection.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveFromCollection.Image")));
            this.btnRemoveFromCollection.Location = new System.Drawing.Point(335, 470);
            this.btnRemoveFromCollection.Name = "btnRemoveFromCollection";
            this.btnRemoveFromCollection.ShadowDecoration.Parent = this.btnRemoveFromCollection;
            this.btnRemoveFromCollection.Size = new System.Drawing.Size(45, 42);
            this.btnRemoveFromCollection.TabIndex = 13;
            this.btnRemoveFromCollection.Click += new System.EventHandler(this.btnRemoveFromCollection_Click);
            // 
            // lbCollectionName
            // 
            this.lbCollectionName.BackColor = System.Drawing.Color.Transparent;
            this.lbCollectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCollectionName.Location = new System.Drawing.Point(71, 470);
            this.lbCollectionName.Name = "lbCollectionName";
            this.lbCollectionName.Size = new System.Drawing.Size(257, 42);
            this.lbCollectionName.TabIndex = 12;
            this.lbCollectionName.Text = "Collection Name";
            this.lbCollectionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbCollectionIcon
            // 
            this.pbCollectionIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCollectionIcon.BackgroundImage")));
            this.pbCollectionIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCollectionIcon.InitialImage = null;
            this.pbCollectionIcon.Location = new System.Drawing.Point(19, 470);
            this.pbCollectionIcon.Name = "pbCollectionIcon";
            this.pbCollectionIcon.Size = new System.Drawing.Size(46, 42);
            this.pbCollectionIcon.TabIndex = 1;
            this.pbCollectionIcon.TabStop = false;
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
            this.pnlTab.Location = new System.Drawing.Point(0, 45);
            this.pnlTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.ShadowDecoration.Parent = this.pnlTab;
            this.pnlTab.Size = new System.Drawing.Size(394, 420);
            this.pnlTab.TabIndex = 0;
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
            // pnlSearching
            // 
            this.pnlSearching.Controls.Add(this.btnBack);
            this.pnlSearching.Controls.Add(this.btnSearch);
            this.pnlSearching.Controls.Add(this.txtSearching);
            this.pnlSearching.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearching.Location = new System.Drawing.Point(0, 0);
            this.pnlSearching.Name = "pnlSearching";
            this.pnlSearching.Size = new System.Drawing.Size(394, 45);
            this.pnlSearching.TabIndex = 0;
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
            this.btnBack.Location = new System.Drawing.Point(19, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(46, 39);
            this.btnBack.TabIndex = 14;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnSearch.ImageSize = new System.Drawing.Size(23, 23);
            this.btnSearch.Location = new System.Drawing.Point(353, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(27, 31);
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
            this.txtSearching.ForeColor = System.Drawing.Color.Black;
            this.txtSearching.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearching.HoverState.Parent = this.txtSearching;
            this.txtSearching.Location = new System.Drawing.Point(68, 13);
            this.txtSearching.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearching.Name = "txtSearching";
            this.txtSearching.PasswordChar = '\0';
            this.txtSearching.PlaceholderText = "Search flashcard";
            this.txtSearching.SelectedText = "";
            this.txtSearching.ShadowDecoration.Parent = this.txtSearching;
            this.txtSearching.Size = new System.Drawing.Size(278, 26);
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
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.ShadowDecoration.Parent = this.btnLeft;
            this.btnLeft.Size = new System.Drawing.Size(303, 520);
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
            this.btnRight.Location = new System.Drawing.Point(697, 0);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.ShadowDecoration.Parent = this.btnRight;
            this.btnRight.Size = new System.Drawing.Size(303, 520);
            this.btnRight.TabIndex = 8;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CollectionLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.pnlMainNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CollectionLib";
            this.Text = "CollectionLib";
            this.pnlMainNav.ResumeLayout(false);
            this.pnlLib.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCollectionIcon)).EndInit();
            this.pnlTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.pnlSearching.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2ImageButton btnPronun;
        private System.Windows.Forms.Timer timer1;
    }
}