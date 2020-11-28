namespace VocabularyUp
{
    partial class FillBlankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillBlankForm));
            this.pnlQuizFB = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.txtAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlFlashCard_FB = new System.Windows.Forms.Panel();
            this.pnlTab_FB = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbMain_FB = new System.Windows.Forms.Label();
            this.pbMain_FB = new System.Windows.Forms.PictureBox();
            this.pnlDash_FB = new System.Windows.Forms.Panel();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.pnlQuizFB.SuspendLayout();
            this.pnlFlashCard_FB.SuspendLayout();
            this.pnlTab_FB.SuspendLayout();
            this.guna2CustomGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain_FB)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuizFB
            // 
            this.pnlQuizFB.BorderRadius = 20;
            this.pnlQuizFB.Controls.Add(this.lbCorrectAnswer);
            this.pnlQuizFB.Controls.Add(this.btnPrevious);
            this.pnlQuizFB.Controls.Add(this.btnNext);
            this.pnlQuizFB.Controls.Add(this.btnConfirm);
            this.pnlQuizFB.Controls.Add(this.txtAnswer);
            this.pnlQuizFB.Controls.Add(this.pnlFlashCard_FB);
            this.pnlQuizFB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuizFB.Location = new System.Drawing.Point(0, 0);
            this.pnlQuizFB.Name = "pnlQuizFB";
            this.pnlQuizFB.ShadowDecoration.Parent = this.pnlQuizFB;
            this.pnlQuizFB.Size = new System.Drawing.Size(1000, 520);
            this.pnlQuizFB.TabIndex = 11;
            this.pnlQuizFB.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirm.BorderRadius = 15;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageSize = new System.Drawing.Size(70, 45);
            this.btnConfirm.Location = new System.Drawing.Point(587, 296);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(268, 70);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.Transparent;
            this.txtAnswer.BorderRadius = 10;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.DefaultText = "";
            this.txtAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.DisabledState.Parent = this.txtAnswer;
            this.txtAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.FillColor = System.Drawing.Color.MintCream;
            this.txtAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.FocusedState.Parent = this.txtAnswer;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.HoverState.Parent = this.txtAnswer;
            this.txtAnswer.Location = new System.Drawing.Point(587, 208);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.PlaceholderText = "Enter your answer";
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.ShadowDecoration.Parent = this.txtAnswer;
            this.txtAnswer.Size = new System.Drawing.Size(268, 70);
            this.txtAnswer.TabIndex = 10;
            // 
            // pnlFlashCard_FB
            // 
            this.pnlFlashCard_FB.BackColor = System.Drawing.Color.Transparent;
            this.pnlFlashCard_FB.Controls.Add(this.pnlTab_FB);
            this.pnlFlashCard_FB.Location = new System.Drawing.Point(60, 3);
            this.pnlFlashCard_FB.Name = "pnlFlashCard_FB";
            this.pnlFlashCard_FB.Size = new System.Drawing.Size(394, 520);
            this.pnlFlashCard_FB.TabIndex = 9;
            // 
            // pnlTab_FB
            // 
            this.pnlTab_FB.BorderRadius = 20;
            this.pnlTab_FB.Controls.Add(this.guna2CustomGradientPanel4);
            this.pnlTab_FB.FillColor3 = System.Drawing.Color.Snow;
            this.pnlTab_FB.FillColor4 = System.Drawing.Color.Snow;
            this.pnlTab_FB.Location = new System.Drawing.Point(0, 45);
            this.pnlTab_FB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTab_FB.Name = "pnlTab_FB";
            this.pnlTab_FB.ShadowDecoration.Parent = this.pnlTab_FB;
            this.pnlTab_FB.Size = new System.Drawing.Size(394, 430);
            this.pnlTab_FB.TabIndex = 0;
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.BorderRadius = 20;
            this.guna2CustomGradientPanel4.Controls.Add(this.lbMain_FB);
            this.guna2CustomGradientPanel4.Controls.Add(this.pbMain_FB);
            this.guna2CustomGradientPanel4.Controls.Add(this.pnlDash_FB);
            this.guna2CustomGradientPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.LightGreen;
            this.guna2CustomGradientPanel4.FillColor3 = System.Drawing.Color.LightGreen;
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.ShadowDecoration.Parent = this.guna2CustomGradientPanel4;
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(394, 420);
            this.guna2CustomGradientPanel4.TabIndex = 1;
            // 
            // lbMain_FB
            // 
            this.lbMain_FB.BackColor = System.Drawing.Color.Transparent;
            this.lbMain_FB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbMain_FB.Location = new System.Drawing.Point(0, 362);
            this.lbMain_FB.Name = "lbMain_FB";
            this.lbMain_FB.Size = new System.Drawing.Size(391, 38);
            this.lbMain_FB.TabIndex = 7;
            this.lbMain_FB.Text = "Welcome";
            this.lbMain_FB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMain_FB
            // 
            this.pbMain_FB.Image = ((System.Drawing.Image)(resources.GetObject("pbMain_FB.Image")));
            this.pbMain_FB.Location = new System.Drawing.Point(19, 21);
            this.pbMain_FB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMain_FB.Name = "pbMain_FB";
            this.pbMain_FB.Size = new System.Drawing.Size(354, 320);
            this.pbMain_FB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain_FB.TabIndex = 8;
            this.pbMain_FB.TabStop = false;
            // 
            // pnlDash_FB
            // 
            this.pnlDash_FB.BackColor = System.Drawing.Color.White;
            this.pnlDash_FB.Location = new System.Drawing.Point(19, 345);
            this.pnlDash_FB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDash_FB.Name = "pnlDash_FB";
            this.pnlDash_FB.Size = new System.Drawing.Size(354, 5);
            this.pnlDash_FB.TabIndex = 11;
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
            this.btnPrevious.Location = new System.Drawing.Point(501, 296);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ShadowDecoration.Parent = this.btnPrevious;
            this.btnPrevious.Size = new System.Drawing.Size(67, 72);
            this.btnPrevious.TabIndex = 18;
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 15;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.Enabled = false;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(30, 45);
            this.btnNext.Location = new System.Drawing.Point(875, 296);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(67, 72);
            this.btnNext.TabIndex = 17;
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbCorrectAnswer.Location = new System.Drawing.Point(524, 116);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(391, 38);
            this.lbCorrectAnswer.TabIndex = 12;
            this.lbCorrectAnswer.Text = "Welcome";
            this.lbCorrectAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FillBlankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.pnlQuizFB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FillBlankForm";
            this.Text = "FillBlankForm";
            this.pnlQuizFB.ResumeLayout(false);
            this.pnlFlashCard_FB.ResumeLayout(false);
            this.pnlTab_FB.ResumeLayout(false);
            this.guna2CustomGradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain_FB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlQuizFB;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtAnswer;
        private System.Windows.Forms.Panel pnlFlashCard_FB;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTab_FB;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private System.Windows.Forms.Label lbMain_FB;
        private System.Windows.Forms.PictureBox pbMain_FB;
        private System.Windows.Forms.Panel pnlDash_FB;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Label lbCorrectAnswer;
    }
}