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
            this.pnlMainNav = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlLib = new System.Windows.Forms.Panel();
            this.pnlTab = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlSearching = new System.Windows.Forms.Panel();
            this.txtAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlMainNav.SuspendLayout();
            this.pnlLib.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainNav
            // 
            this.pnlMainNav.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnlMainNav.BorderRadius = 20;
            this.pnlMainNav.Controls.Add(this.txtAnswer);
            this.pnlMainNav.Controls.Add(this.pnlLib);
            this.pnlMainNav.Controls.Add(this.pnlSearching);
            this.pnlMainNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainNav.Location = new System.Drawing.Point(0, 0);
            this.pnlMainNav.Name = "pnlMainNav";
            this.pnlMainNav.ShadowDecoration.Parent = this.pnlMainNav;
            this.pnlMainNav.Size = new System.Drawing.Size(1000, 520);
            this.pnlMainNav.TabIndex = 16;
            // 
            // pnlLib
            // 
            this.pnlLib.BackColor = System.Drawing.Color.Transparent;
            this.pnlLib.Controls.Add(this.pnlTab);
            this.pnlLib.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLib.Location = new System.Drawing.Point(54, 0);
            this.pnlLib.Name = "pnlLib";
            this.pnlLib.Size = new System.Drawing.Size(394, 520);
            this.pnlLib.TabIndex = 9;
            // 
            // pnlTab
            // 
            this.pnlTab.BorderRadius = 20;
            this.pnlTab.FillColor3 = System.Drawing.Color.Snow;
            this.pnlTab.FillColor4 = System.Drawing.Color.Snow;
            this.pnlTab.Location = new System.Drawing.Point(0, 45);
            this.pnlTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.ShadowDecoration.Parent = this.pnlTab;
            this.pnlTab.Size = new System.Drawing.Size(394, 430);
            this.pnlTab.TabIndex = 0;
            // 
            // pnlSearching
            // 
            this.pnlSearching.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSearching.Location = new System.Drawing.Point(0, 0);
            this.pnlSearching.Name = "pnlSearching";
            this.pnlSearching.Size = new System.Drawing.Size(54, 520);
            this.pnlSearching.TabIndex = 0;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.Transparent;
            this.txtAnswer.BorderColor = System.Drawing.Color.Transparent;
            this.txtAnswer.BorderRadius = 20;
            this.txtAnswer.BorderThickness = 0;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.DefaultText = "";
            this.txtAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.DisabledState.Parent = this.txtAnswer;
            this.txtAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.FocusedState.Parent = this.txtAnswer;
            this.txtAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.HoverState.Parent = this.txtAnswer;
            this.txtAnswer.Location = new System.Drawing.Point(599, 211);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.PlaceholderText = "";
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.ShadowDecoration.Parent = this.txtAnswer;
            this.txtAnswer.Size = new System.Drawing.Size(267, 84);
            this.txtAnswer.TabIndex = 10;
            // 
            // FillBlankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.pnlMainNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FillBlankForm";
            this.Text = "FillBlankForm";
            this.pnlMainNav.ResumeLayout(false);
            this.pnlLib.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMainNav;
        private System.Windows.Forms.Panel pnlLib;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTab;
        private System.Windows.Forms.Panel pnlSearching;
        private Guna.UI2.WinForms.Guna2TextBox txtAnswer;
    }
}