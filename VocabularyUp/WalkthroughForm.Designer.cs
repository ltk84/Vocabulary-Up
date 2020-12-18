
namespace VocabularyUp
{
    partial class WalkthroughForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WalkthroughForm));
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pbIconHealth = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pbDiamond = new System.Windows.Forms.PictureBox();
            this.lbDiamond = new System.Windows.Forms.Label();
            this.pgbHealth = new VocabularyUp.SuperProgressBar();
            this.pgbMonsterHealth = new VocabularyUp.SuperProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconHealth)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamond)).BeginInit();
            this.SuspendLayout();
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // pbIconHealth
            // 
            this.pbIconHealth.BackColor = System.Drawing.Color.Transparent;
            this.pbIconHealth.Image = ((System.Drawing.Image)(resources.GetObject("pbIconHealth.Image")));
            this.pbIconHealth.Location = new System.Drawing.Point(18, 15);
            this.pbIconHealth.Name = "pbIconHealth";
            this.pbIconHealth.Size = new System.Drawing.Size(30, 30);
            this.pbIconHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconHealth.TabIndex = 1;
            this.pbIconHealth.TabStop = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInfo.BackgroundImage")));
            this.pnlInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInfo.Controls.Add(this.lbDiamond);
            this.pnlInfo.Controls.Add(this.pbDiamond);
            this.pnlInfo.Controls.Add(this.pgbHealth);
            this.pnlInfo.Controls.Add(this.pbIconHealth);
            this.pnlInfo.Location = new System.Drawing.Point(26, 27);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(385, 109);
            this.pnlInfo.TabIndex = 5;
            // 
            // pbDiamond
            // 
            this.pbDiamond.BackColor = System.Drawing.Color.Transparent;
            this.pbDiamond.Image = ((System.Drawing.Image)(resources.GetObject("pbDiamond.Image")));
            this.pbDiamond.Location = new System.Drawing.Point(18, 60);
            this.pbDiamond.Name = "pbDiamond";
            this.pbDiamond.Size = new System.Drawing.Size(30, 30);
            this.pbDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiamond.TabIndex = 4;
            this.pbDiamond.TabStop = false;
            // 
            // lbDiamond
            // 
            this.lbDiamond.AutoSize = true;
            this.lbDiamond.BackColor = System.Drawing.Color.Transparent;
            this.lbDiamond.Font = new System.Drawing.Font("Montserrat Alternates", 12F);
            this.lbDiamond.ForeColor = System.Drawing.Color.White;
            this.lbDiamond.Location = new System.Drawing.Point(60, 60);
            this.lbDiamond.Name = "lbDiamond";
            this.lbDiamond.Size = new System.Drawing.Size(25, 28);
            this.lbDiamond.TabIndex = 5;
            this.lbDiamond.Text = "0";
            // 
            // pgbHealth
            // 
            this.pgbHealth.BackColor = System.Drawing.Color.White;
            this.pgbHealth.Location = new System.Drawing.Point(65, 20);
            this.pgbHealth.Name = "pgbHealth";
            this.pgbHealth.Size = new System.Drawing.Size(284, 25);
            this.pgbHealth.TabIndex = 3;
            // 
            // pgbMonsterHealth
            // 
            this.pgbMonsterHealth.Location = new System.Drawing.Point(417, 27);
            this.pgbMonsterHealth.Name = "pgbMonsterHealth";
            this.pgbMonsterHealth.Size = new System.Drawing.Size(618, 30);
            this.pgbMonsterHealth.TabIndex = 4;
            this.pgbMonsterHealth.Visible = false;
            // 
            // WalkthroughForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pgbMonsterHealth);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WalkthroughForm";
            this.Text = "WalkthroughForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.WalkthroughForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconHealth)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.PictureBox pbIconHealth;
        private SuperProgressBar pgbHealth;
        private SuperProgressBar pgbMonsterHealth;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lbDiamond;
        private System.Windows.Forms.PictureBox pbDiamond;
    }
}