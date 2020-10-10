namespace VocabularyUp
{
    partial class NavForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavForm));
            this.barTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnHide = new Guna.UI2.WinForms.Guna2Button();
            this.btnFullScr = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnLeft = new Guna.UI2.WinForms.Guna2Button();
            this.btnRight = new Guna.UI2.WinForms.Guna2Button();
            this.btnRevise = new Guna.UI2.WinForms.Guna2Button();
            this.btnStatistics = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.navPanel = new System.Windows.Forms.Panel();
            this.barTop.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // barTop
            // 
            this.barTop.Controls.Add(this.btnHide);
            this.barTop.Controls.Add(this.btnFullScr);
            this.barTop.Controls.Add(this.btnExit);
            this.barTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(236)))), ((int)(((byte)(141)))));
            this.barTop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(236)))), ((int)(((byte)(141)))));
            this.barTop.Location = new System.Drawing.Point(0, 0);
            this.barTop.Name = "barTop";
            this.barTop.ShadowDecoration.Parent = this.barTop;
            this.barTop.Size = new System.Drawing.Size(794, 28);
            this.barTop.TabIndex = 0;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHide.CheckedState.Parent = this.btnHide;
            this.btnHide.CustomImages.Parent = this.btnHide;
            this.btnHide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHide.FillColor = System.Drawing.Color.Transparent;
            this.btnHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.HoverState.Parent = this.btnHide;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.ImageOffset = new System.Drawing.Point(1, -1);
            this.btnHide.ImageSize = new System.Drawing.Size(15, 20);
            this.btnHide.Location = new System.Drawing.Point(703, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.ShadowDecoration.Parent = this.btnHide;
            this.btnHide.Size = new System.Drawing.Size(33, 28);
            this.btnHide.TabIndex = 2;
            // 
            // btnFullScr
            // 
            this.btnFullScr.BackColor = System.Drawing.Color.Transparent;
            this.btnFullScr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFullScr.CheckedState.Parent = this.btnFullScr;
            this.btnFullScr.CustomImages.Parent = this.btnFullScr;
            this.btnFullScr.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFullScr.FillColor = System.Drawing.Color.Transparent;
            this.btnFullScr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFullScr.ForeColor = System.Drawing.Color.White;
            this.btnFullScr.HoverState.Parent = this.btnFullScr;
            this.btnFullScr.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScr.Image")));
            this.btnFullScr.ImageSize = new System.Drawing.Size(19, 19);
            this.btnFullScr.Location = new System.Drawing.Point(736, 0);
            this.btnFullScr.Name = "btnFullScr";
            this.btnFullScr.ShadowDecoration.Parent = this.btnFullScr;
            this.btnFullScr.Size = new System.Drawing.Size(33, 28);
            this.btnFullScr.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageOffset = new System.Drawing.Point(-1, -1);
            this.btnExit.ImageSize = new System.Drawing.Size(18, 18);
            this.btnExit.Location = new System.Drawing.Point(769, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(25, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.barTop;
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
            this.btnLeft.ImageSize = new System.Drawing.Size(100, 100);
            this.btnLeft.Location = new System.Drawing.Point(0, 28);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.ShadowDecoration.Parent = this.btnLeft;
            this.btnLeft.Size = new System.Drawing.Size(227, 500);
            this.btnLeft.TabIndex = 7;
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
            this.btnRight.ImageSize = new System.Drawing.Size(120, 100);
            this.btnRight.Location = new System.Drawing.Point(567, 28);
            this.btnRight.Name = "btnRight";
            this.btnRight.ShadowDecoration.Parent = this.btnRight;
            this.btnRight.Size = new System.Drawing.Size(227, 500);
            this.btnRight.TabIndex = 8;
            // 
            // btnRevise
            // 
            this.btnRevise.Animated = true;
            this.btnRevise.AutoRoundedCorners = true;
            this.btnRevise.BackColor = System.Drawing.Color.Transparent;
            this.btnRevise.BorderColor = System.Drawing.Color.Transparent;
            this.btnRevise.BorderRadius = 12;
            this.btnRevise.CheckedState.Parent = this.btnRevise;
            this.btnRevise.CustomImages.Parent = this.btnRevise;
            this.btnRevise.FillColor = System.Drawing.Color.White;
            this.btnRevise.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevise.ForeColor = System.Drawing.Color.Black;
            this.btnRevise.HoverState.Parent = this.btnRevise;
            this.btnRevise.Location = new System.Drawing.Point(191, 0);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.ShadowDecoration.Parent = this.btnRevise;
            this.btnRevise.Size = new System.Drawing.Size(135, 26);
            this.btnRevise.TabIndex = 3;
            this.btnRevise.Text = "Revise";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Animated = true;
            this.btnStatistics.AutoRoundedCorners = true;
            this.btnStatistics.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.BorderColor = System.Drawing.Color.Transparent;
            this.btnStatistics.BorderRadius = 12;
            this.btnStatistics.CheckedState.Parent = this.btnStatistics;
            this.btnStatistics.CustomImages.Parent = this.btnStatistics;
            this.btnStatistics.FillColor = System.Drawing.Color.White;
            this.btnStatistics.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.Black;
            this.btnStatistics.HoverState.Parent = this.btnStatistics;
            this.btnStatistics.Location = new System.Drawing.Point(1, 0);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.ShadowDecoration.Parent = this.btnStatistics;
            this.btnStatistics.Size = new System.Drawing.Size(135, 26);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.Text = "Statistics";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(116, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(105, 26);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Main";
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.guna2Button2);
            this.navPanel.Controls.Add(this.btnStatistics);
            this.navPanel.Controls.Add(this.btnRevise);
            this.navPanel.Location = new System.Drawing.Point(233, 34);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(326, 26);
            this.navPanel.TabIndex = 4;
            // 
            // NavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(794, 528);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.barTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NavForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.barTop.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel barTop;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnFullScr;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnHide;
        private Guna.UI2.WinForms.Guna2Button btnLeft;
        private Guna.UI2.WinForms.Guna2Button btnRight;
        private Guna.UI2.WinForms.Guna2Button btnRevise;
        private Guna.UI2.WinForms.Guna2Button btnStatistics;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel navPanel;
    }
}

