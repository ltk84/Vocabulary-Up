namespace VocabularyUp
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.progressCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.listBadge = new System.Windows.Forms.ListView();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.pnlProgressInfo = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnRank = new Guna.UI2.WinForms.Guna2ImageButton();
            this.progressCircle.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressCircle
            // 
            this.progressCircle.BackColor = System.Drawing.Color.Transparent;
            this.progressCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.progressCircle.Controls.Add(this.btnRank);
            this.progressCircle.FillColor = System.Drawing.Color.WhiteSmoke;
            this.progressCircle.FillThickness = 5;
            this.progressCircle.Location = new System.Drawing.Point(671, 27);
            this.progressCircle.Name = "progressCircle";
            this.progressCircle.ProgressColor = System.Drawing.Color.Aqua;
            this.progressCircle.ProgressColor2 = System.Drawing.Color.MediumSpringGreen;
            this.progressCircle.ProgressThickness = 5;
            this.progressCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressCircle.ShadowDecoration.Parent = this.progressCircle;
            this.progressCircle.Size = new System.Drawing.Size(182, 174);
            this.progressCircle.TabIndex = 0;
            this.progressCircle.Value = 43;
            // 
            // listBadge
            // 
            this.listBadge.HideSelection = false;
            this.listBadge.Location = new System.Drawing.Point(44, 219);
            this.listBadge.Name = "listBadge";
            this.listBadge.Size = new System.Drawing.Size(451, 269);
            this.listBadge.TabIndex = 1;
            this.listBadge.UseCompatibleStateImageBehavior = false;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserInfo.Location = new System.Drawing.Point(44, 27);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(454, 174);
            this.pnlUserInfo.TabIndex = 2;
            // 
            // pnlProgressInfo
            // 
            this.pnlProgressInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlProgressInfo.Location = new System.Drawing.Point(563, 219);
            this.pnlProgressInfo.Name = "pnlProgressInfo";
            this.pnlProgressInfo.Size = new System.Drawing.Size(402, 269);
            this.pnlProgressInfo.TabIndex = 3;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.listBadge);
            this.guna2CustomGradientPanel1.Controls.Add(this.progressCircle);
            this.guna2CustomGradientPanel1.Controls.Add(this.pnlProgressInfo);
            this.guna2CustomGradientPanel1.Controls.Add(this.pnlUserInfo);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1000, 520);
            this.guna2CustomGradientPanel1.TabIndex = 4;
            // 
            // btnRank
            // 
            this.btnRank.BackColor = System.Drawing.Color.Transparent;
            this.btnRank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRank.CheckedState.ImageSize = new System.Drawing.Size(100, 100);
            this.btnRank.CheckedState.Parent = this.btnRank;
            this.btnRank.HoverState.ImageSize = new System.Drawing.Size(100, 100);
            this.btnRank.HoverState.Parent = this.btnRank;
            this.btnRank.Image = ((System.Drawing.Image)(resources.GetObject("btnRank.Image")));
            this.btnRank.ImageSize = new System.Drawing.Size(100, 100);
            this.btnRank.Location = new System.Drawing.Point(32, 22);
            this.btnRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRank.Name = "btnRank";
            this.btnRank.PressedState.ImageSize = new System.Drawing.Size(100, 100);
            this.btnRank.PressedState.Parent = this.btnRank;
            this.btnRank.Size = new System.Drawing.Size(120, 120);
            this.btnRank.TabIndex = 15;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            this.progressCircle.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar progressCircle;
        private System.Windows.Forms.ListView listBadge;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Panel pnlProgressInfo;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnRank;
    }
}