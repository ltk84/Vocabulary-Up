namespace VocabularyUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevisionForm));
            this.pnlRevision = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlChoosePlay = new System.Windows.Forms.Panel();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.pbCurrency = new System.Windows.Forms.PictureBox();
            this.lbDiamond = new System.Windows.Forms.Label();
            this.pnlRevision.SuspendLayout();
            this.pnlChoosePlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRevision
            // 
            this.pnlRevision.BorderRadius = 20;
            this.pnlRevision.Controls.Add(this.pnlChoosePlay);
            this.pnlRevision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevision.Location = new System.Drawing.Point(0, 0);
            this.pnlRevision.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRevision.Name = "pnlRevision";
            this.pnlRevision.ShadowDecoration.Parent = this.pnlRevision;
            this.pnlRevision.Size = new System.Drawing.Size(750, 422);
            this.pnlRevision.TabIndex = 0;
            // 
            // pnlChoosePlay
            // 
            this.pnlChoosePlay.BackColor = System.Drawing.Color.Transparent;
            this.pnlChoosePlay.Controls.Add(this.pbCurrency);
            this.pnlChoosePlay.Controls.Add(this.lbDiamond);
            this.pnlChoosePlay.Controls.Add(this.btnToggle);
            this.pnlChoosePlay.Controls.Add(this.btnShop);
            this.pnlChoosePlay.Controls.Add(this.lbName);
            this.pnlChoosePlay.Controls.Add(this.btnPrevious);
            this.pnlChoosePlay.Controls.Add(this.btnNext);
            this.pnlChoosePlay.Controls.Add(this.pbCharacter);
            this.pnlChoosePlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoosePlay.Location = new System.Drawing.Point(0, 0);
            this.pnlChoosePlay.Name = "pnlChoosePlay";
            this.pnlChoosePlay.Size = new System.Drawing.Size(750, 422);
            this.pnlChoosePlay.TabIndex = 23;
            this.pnlChoosePlay.VisibleChanged += new System.EventHandler(this.pnlChoosePlay_VisibleChanged);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(13, 53);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(10, 10);
            this.btnToggle.TabIndex = 23;
            this.btnToggle.Text = "0";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Visible = false;
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(596, 70);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(75, 23);
            this.btnShop.TabIndex = 22;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Location = new System.Drawing.Point(355, 328);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Name";
            // 
            // btnPrevious
            // 
            this.btnPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BorderRadius = 15;
            this.btnPrevious.CheckedState.Parent = this.btnPrevious;
            this.btnPrevious.CustomImages.Parent = this.btnPrevious;
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.pbCharacter.Location = new System.Drawing.Point(258, 143);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(229, 142);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCharacter.TabIndex = 0;
            this.pbCharacter.TabStop = false;
            // 
            // pbCurrency
            // 
            this.pbCurrency.Image = ((System.Drawing.Image)(resources.GetObject("pbCurrency.Image")));
            this.pbCurrency.Location = new System.Drawing.Point(629, 39);
            this.pbCurrency.Name = "pbCurrency";
            this.pbCurrency.Size = new System.Drawing.Size(30, 25);
            this.pbCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrency.TabIndex = 25;
            this.pbCurrency.TabStop = false;
            // 
            // lbDiamond
            // 
            this.lbDiamond.AutoSize = true;
            this.lbDiamond.Location = new System.Drawing.Point(598, 39);
            this.lbDiamond.Name = "lbDiamond";
            this.lbDiamond.Size = new System.Drawing.Size(25, 13);
            this.lbDiamond.TabIndex = 24;
            this.lbDiamond.Text = "100";
            // 
            // RevisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(750, 422);
            this.Controls.Add(this.pnlRevision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RevisionForm";
            this.Text = "RevisionForm";
            this.pnlRevision.ResumeLayout(false);
            this.pnlChoosePlay.ResumeLayout(false);
            this.pnlChoosePlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlRevision;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Panel pnlChoosePlay;
        public System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.PictureBox pbCurrency;
        private System.Windows.Forms.Label lbDiamond;
    }
}