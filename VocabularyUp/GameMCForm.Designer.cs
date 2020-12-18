
namespace VocabularyUp
{
    partial class GameMCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMCForm));
            this.pnlFlashCard = new System.Windows.Forms.Panel();
            this.pnlTab = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlDash = new System.Windows.Forms.Panel();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.btnB = new Guna.UI2.WinForms.Guna2Button();
            this.btnA = new Guna.UI2.WinForms.Guna2Button();
            this.btnD = new Guna.UI2.WinForms.Guna2Button();
            this.btnC = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFlashCard.SuspendLayout();
            this.pnlTab.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFlashCard
            // 
            this.pnlFlashCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlFlashCard.Controls.Add(this.pnlTab);
            this.pnlFlashCard.Location = new System.Drawing.Point(11, 1);
            this.pnlFlashCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFlashCard.Name = "pnlFlashCard";
            this.pnlFlashCard.Size = new System.Drawing.Size(272, 402);
            this.pnlFlashCard.TabIndex = 10;
            // 
            // pnlTab
            // 
            this.pnlTab.BorderRadius = 20;
            this.pnlTab.Controls.Add(this.guna2CustomGradientPanel1);
            this.pnlTab.FillColor3 = System.Drawing.Color.Snow;
            this.pnlTab.FillColor4 = System.Drawing.Color.Snow;
            this.pnlTab.Location = new System.Drawing.Point(0, 37);
            this.pnlTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.ShadowDecoration.Parent = this.pnlTab;
            this.pnlTab.Size = new System.Drawing.Size(272, 338);
            this.pnlTab.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.pnlDash);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbMain);
            this.guna2CustomGradientPanel1.Controls.Add(this.pbMain);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(272, 338);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // pnlDash
            // 
            this.pnlDash.BackColor = System.Drawing.Color.White;
            this.pnlDash.Location = new System.Drawing.Point(14, 274);
            this.pnlDash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(240, 4);
            this.pnlDash.TabIndex = 11;
            // 
            // lbMain
            // 
            this.lbMain.BackColor = System.Drawing.Color.Transparent;
            this.lbMain.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbMain.ForeColor = System.Drawing.Color.White;
            this.lbMain.Location = new System.Drawing.Point(2, 280);
            this.lbMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(267, 48);
            this.lbMain.TabIndex = 7;
            this.lbMain.Text = "Welcome";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMain
            // 
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(14, 17);
            this.pbMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(240, 249);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 8;
            this.pbMain.TabStop = false;
            // 
            // lbTimer
            // 
            this.lbTimer.BackColor = System.Drawing.Color.White;
            this.lbTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(442, 68);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(70, 23);
            this.lbTimer.TabIndex = 44;
            this.lbTimer.Text = "60";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BorderRadius = 15;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageSize = new System.Drawing.Size(60, 45);
            this.btnConfirm.Location = new System.Drawing.Point(428, 300);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(108, 58);
            this.btnConfirm.TabIndex = 43;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnB
            // 
            this.btnB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnB.BackColor = System.Drawing.Color.Transparent;
            this.btnB.BorderRadius = 15;
            this.btnB.CheckedState.Parent = this.btnB;
            this.btnB.CustomImages.Parent = this.btnB;
            this.btnB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnB.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.HoverState.Parent = this.btnB;
            this.btnB.Location = new System.Drawing.Point(489, 121);
            this.btnB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnB.Name = "btnB";
            this.btnB.ShadowDecoration.Parent = this.btnB;
            this.btnB.Size = new System.Drawing.Size(135, 58);
            this.btnB.TabIndex = 41;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnA.BackColor = System.Drawing.Color.Transparent;
            this.btnA.BorderRadius = 15;
            this.btnA.CheckedState.Parent = this.btnA;
            this.btnA.CustomImages.Parent = this.btnA;
            this.btnA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnA.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.HoverState.Parent = this.btnA;
            this.btnA.Location = new System.Drawing.Point(340, 121);
            this.btnA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnA.Name = "btnA";
            this.btnA.ShadowDecoration.Parent = this.btnA;
            this.btnA.Size = new System.Drawing.Size(135, 58);
            this.btnA.TabIndex = 39;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnD
            // 
            this.btnD.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnD.BackColor = System.Drawing.Color.Transparent;
            this.btnD.BorderRadius = 15;
            this.btnD.CheckedState.Parent = this.btnD;
            this.btnD.CustomImages.Parent = this.btnD;
            this.btnD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnD.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.HoverState.Parent = this.btnD;
            this.btnD.Location = new System.Drawing.Point(489, 200);
            this.btnD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnD.Name = "btnD";
            this.btnD.ShadowDecoration.Parent = this.btnD;
            this.btnD.Size = new System.Drawing.Size(135, 58);
            this.btnD.TabIndex = 42;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnC.BackColor = System.Drawing.Color.Transparent;
            this.btnC.BorderRadius = 15;
            this.btnC.CheckedState.Parent = this.btnC;
            this.btnC.CustomImages.Parent = this.btnC;
            this.btnC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnC.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.HoverState.Parent = this.btnC;
            this.btnC.Location = new System.Drawing.Point(340, 200);
            this.btnC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnC.Name = "btnC";
            this.btnC.ShadowDecoration.Parent = this.btnC;
            this.btnC.Size = new System.Drawing.Size(135, 58);
            this.btnC.TabIndex = 40;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // GameMCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(684, 401);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.pnlFlashCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameMCForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Turquoise;
            this.pnlFlashCard.ResumeLayout(false);
            this.pnlTab.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFlashCard;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTab;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Panel pnlDash;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label lbTimer;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnB;
        private Guna.UI2.WinForms.Guna2Button btnA;
        private Guna.UI2.WinForms.Guna2Button btnD;
        private Guna.UI2.WinForms.Guna2Button btnC;
    }
}