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
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearching = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlFlashCard_FB = new System.Windows.Forms.Panel();
            this.pnlTab_FB = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbMain_FB = new System.Windows.Forms.Label();
            this.pbMain_FB = new System.Windows.Forms.PictureBox();
            this.pnlDash_FB = new System.Windows.Forms.Panel();
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
            this.pnlQuizFB.Controls.Add(this.btnOK);
            this.pnlQuizFB.Controls.Add(this.txtSearching);
            this.pnlQuizFB.Controls.Add(this.pnlFlashCard_FB);
            this.pnlQuizFB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuizFB.Location = new System.Drawing.Point(0, 0);
            this.pnlQuizFB.Name = "pnlQuizFB";
            this.pnlQuizFB.ShadowDecoration.Parent = this.pnlQuizFB;
            this.pnlQuizFB.Size = new System.Drawing.Size(1000, 520);
            this.pnlQuizFB.TabIndex = 11;
            this.pnlQuizFB.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.BorderRadius = 15;
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.CustomImages.Parent = this.btnOK;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageSize = new System.Drawing.Size(70, 45);
            this.btnOK.Location = new System.Drawing.Point(587, 296);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.Parent = this.btnOK;
            this.btnOK.Size = new System.Drawing.Size(268, 70);
            this.btnOK.TabIndex = 11;
            // 
            // txtSearching
            // 
            this.txtSearching.BackColor = System.Drawing.Color.Transparent;
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
            this.txtSearching.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearching.ForeColor = System.Drawing.Color.Black;
            this.txtSearching.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearching.HoverState.Parent = this.txtSearching;
            this.txtSearching.Location = new System.Drawing.Point(587, 208);
            this.txtSearching.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearching.Name = "txtSearching";
            this.txtSearching.PasswordChar = '\0';
            this.txtSearching.PlaceholderText = "Enter your answer";
            this.txtSearching.SelectedText = "";
            this.txtSearching.ShadowDecoration.Parent = this.txtSearching;
            this.txtSearching.Size = new System.Drawing.Size(268, 70);
            this.txtSearching.TabIndex = 10;
            // 
            // pnlFlashCard_FB
            // 
            this.pnlFlashCard_FB.BackColor = System.Drawing.Color.Transparent;
            this.pnlFlashCard_FB.Controls.Add(this.pnlTab_FB);
            this.pnlFlashCard_FB.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFlashCard_FB.Location = new System.Drawing.Point(0, 0);
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
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2TextBox txtSearching;
        private System.Windows.Forms.Panel pnlFlashCard_FB;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTab_FB;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private System.Windows.Forms.Label lbMain_FB;
        private System.Windows.Forms.PictureBox pbMain_FB;
        private System.Windows.Forms.Panel pnlDash_FB;
    }
}