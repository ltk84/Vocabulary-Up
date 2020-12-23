namespace VocabularyUp
{
    partial class DetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsForm));
            this.pnlTopicSelection = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lvCorrectWord = new System.Windows.Forms.ListView();
            this.columnIndexCorrect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameCorrect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvWrongWord = new System.Windows.Forms.ListView();
            this.columnIndexWrong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameWrong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pnlToCollection = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cbCollection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnToCollection = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTab = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnPronun = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pnlDash = new System.Windows.Forms.Panel();
            this.timerSpeaker = new System.Windows.Forms.Timer(this.components);
            this.pnlTopicSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlToCollection.SuspendLayout();
            this.pnlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopicSelection
            // 
            this.pnlTopicSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlTopicSelection.BorderRadius = 20;
            this.pnlTopicSelection.Controls.Add(this.splitContainer1);
            this.pnlTopicSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopicSelection.Location = new System.Drawing.Point(0, 0);
            this.pnlTopicSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopicSelection.Name = "pnlTopicSelection";
            this.pnlTopicSelection.ShadowDecoration.Parent = this.pnlTopicSelection;
            this.pnlTopicSelection.Size = new System.Drawing.Size(1000, 519);
            this.pnlTopicSelection.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(4, 12);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.pnlDetails);
            this.splitContainer1.Size = new System.Drawing.Size(983, 505);
            this.splitContainer1.SplitterDistance = 496;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnBack);
            this.splitContainer2.Panel1.Controls.Add(this.lvCorrectWord);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvWrongWord);
            this.splitContainer2.Size = new System.Drawing.Size(496, 505);
            this.splitContainer2.SplitterDistance = 251;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 15;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBack.Location = new System.Drawing.Point(8, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(37, 39);
            this.btnBack.TabIndex = 15;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvCorrectWord
            // 
            this.lvCorrectWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIndexCorrect,
            this.columnNameCorrect});
            this.lvCorrectWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCorrectWord.ForeColor = System.Drawing.Color.LawnGreen;
            this.lvCorrectWord.FullRowSelect = true;
            this.lvCorrectWord.HideSelection = false;
            this.lvCorrectWord.Location = new System.Drawing.Point(53, 26);
            this.lvCorrectWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvCorrectWord.Name = "lvCorrectWord";
            this.lvCorrectWord.Size = new System.Drawing.Size(412, 200);
            this.lvCorrectWord.TabIndex = 0;
            this.lvCorrectWord.UseCompatibleStateImageBehavior = false;
            this.lvCorrectWord.View = System.Windows.Forms.View.Details;
            this.lvCorrectWord.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvWrongWord_ItemSelectionChanged);
            // 
            // columnIndexCorrect
            // 
            this.columnIndexCorrect.Text = "Index";
            this.columnIndexCorrect.Width = 90;
            // 
            // columnNameCorrect
            // 
            this.columnNameCorrect.Text = "Name";
            this.columnNameCorrect.Width = 318;
            // 
            // lvWrongWord
            // 
            this.lvWrongWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIndexWrong,
            this.columnNameWrong});
            this.lvWrongWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvWrongWord.ForeColor = System.Drawing.Color.Red;
            this.lvWrongWord.FullRowSelect = true;
            this.lvWrongWord.HideSelection = false;
            this.lvWrongWord.Location = new System.Drawing.Point(53, 26);
            this.lvWrongWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvWrongWord.Name = "lvWrongWord";
            this.lvWrongWord.Size = new System.Drawing.Size(412, 200);
            this.lvWrongWord.TabIndex = 1;
            this.lvWrongWord.UseCompatibleStateImageBehavior = false;
            this.lvWrongWord.View = System.Windows.Forms.View.Details;
            this.lvWrongWord.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvWrongWord_ItemSelectionChanged);
            // 
            // columnIndexWrong
            // 
            this.columnIndexWrong.Text = "Index";
            this.columnIndexWrong.Width = 92;
            // 
            // columnNameWrong
            // 
            this.columnNameWrong.Text = "Name";
            this.columnNameWrong.Width = 316;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetails.Controls.Add(this.pnlToCollection);
            this.pnlDetails.Controls.Add(this.pnlTab);
            this.pnlDetails.Location = new System.Drawing.Point(31, 15);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(397, 470);
            this.pnlDetails.TabIndex = 10;
            // 
            // pnlToCollection
            // 
            this.pnlToCollection.Controls.Add(this.cbCollection);
            this.pnlToCollection.Controls.Add(this.btnToCollection);
            this.pnlToCollection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlToCollection.Location = new System.Drawing.Point(0, 432);
            this.pnlToCollection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlToCollection.Name = "pnlToCollection";
            this.pnlToCollection.ShadowDecoration.Parent = this.pnlToCollection;
            this.pnlToCollection.Size = new System.Drawing.Size(397, 38);
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
            this.cbCollection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCollection.Name = "cbCollection";
            this.cbCollection.ShadowDecoration.Parent = this.cbCollection;
            this.cbCollection.Size = new System.Drawing.Size(351, 36);
            this.cbCollection.TabIndex = 13;
            // 
            // btnToCollection
            // 
            this.btnToCollection.BackColor = System.Drawing.Color.Transparent;
            this.btnToCollection.BorderRadius = 15;
            this.btnToCollection.CheckedState.Parent = this.btnToCollection;
            this.btnToCollection.CustomImages.Parent = this.btnToCollection;
            this.btnToCollection.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToCollection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnToCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCollection.ForeColor = System.Drawing.Color.Black;
            this.btnToCollection.HoverState.Parent = this.btnToCollection;
            this.btnToCollection.Image = ((System.Drawing.Image)(resources.GetObject("btnToCollection.Image")));
            this.btnToCollection.Location = new System.Drawing.Point(357, 0);
            this.btnToCollection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToCollection.Name = "btnToCollection";
            this.btnToCollection.ShadowDecoration.Parent = this.btnToCollection;
            this.btnToCollection.Size = new System.Drawing.Size(40, 38);
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
            this.pnlTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlTab.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlTab.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlTab.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlTab.Location = new System.Drawing.Point(3, 2);
            this.pnlTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.ShadowDecoration.Parent = this.pnlTab;
            this.pnlTab.Size = new System.Drawing.Size(395, 420);
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
            this.btnPronun.Location = new System.Drawing.Point(343, 366);
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
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbMain.ForeColor = System.Drawing.Color.White;
            this.lbMain.Location = new System.Drawing.Point(1, 354);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(391, 49);
            this.lbMain.TabIndex = 7;
            this.lbMain.Text = "Welcome";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMain.Click += new System.EventHandler(this.lbMain_Click);
            // 
            // pbMain
            // 
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(20, 23);
            this.pbMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(355, 320);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 8;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            // 
            // pnlDash
            // 
            this.pnlDash.BackColor = System.Drawing.Color.White;
            this.pnlDash.Location = new System.Drawing.Point(21, 347);
            this.pnlDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(355, 5);
            this.pnlDash.TabIndex = 11;
            // 
            // timerSpeaker
            // 
            this.timerSpeaker.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.pnlTopicSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.pnlTopicSelection.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlToCollection.ResumeLayout(false);
            this.pnlTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTopicSelection;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lvCorrectWord;
        private System.Windows.Forms.ListView lvWrongWord;
        private System.Windows.Forms.ColumnHeader columnIndexCorrect;
        private System.Windows.Forms.ColumnHeader columnNameCorrect;
        private System.Windows.Forms.ColumnHeader columnIndexWrong;
        private System.Windows.Forms.ColumnHeader columnNameWrong;
        private System.Windows.Forms.Panel pnlDetails;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlToCollection;
        private Guna.UI2.WinForms.Guna2ComboBox cbCollection;
        private Guna.UI2.WinForms.Guna2Button btnToCollection;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTab;
        private Guna.UI2.WinForms.Guna2ImageButton btnPronun;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Panel pnlDash;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Timer timerSpeaker;
    }
}