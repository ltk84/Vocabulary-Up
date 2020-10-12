namespace VocabularyUp
{
    partial class ReviseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviseForm));
            this.sepRevise = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbRevise = new System.Windows.Forms.Label();
            this.cardRevise = new Bunifu.Framework.UI.BunifuCards();
            this.SuspendLayout();
            // 
            // sepRevise
            // 
            this.sepRevise.BackColor = System.Drawing.Color.Transparent;
            this.sepRevise.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.sepRevise.LineThickness = 5;
            this.sepRevise.Location = new System.Drawing.Point(-1, 402);
            this.sepRevise.Name = "sepRevise";
            this.sepRevise.Size = new System.Drawing.Size(375, 8);
            this.sepRevise.TabIndex = 0;
            this.sepRevise.Transparency = 255;
            this.sepRevise.Vertical = false;
            // 
            // lbRevise
            // 
            this.lbRevise.AutoSize = true;
            this.lbRevise.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbRevise.Location = new System.Drawing.Point(157, 413);
            this.lbRevise.Name = "lbRevise";
            this.lbRevise.Size = new System.Drawing.Size(61, 32);
            this.lbRevise.TabIndex = 1;
            this.lbRevise.Text = "Car";
            // 
            // cardRevise
            // 
            this.cardRevise.BackColor = System.Drawing.Color.Transparent;
            this.cardRevise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardRevise.BackgroundImage")));
            this.cardRevise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardRevise.BorderRadius = 60;
            this.cardRevise.BottomSahddow = true;
            this.cardRevise.color = System.Drawing.Color.LightBlue;
            this.cardRevise.LeftSahddow = false;
            this.cardRevise.Location = new System.Drawing.Point(12, 12);
            this.cardRevise.Name = "cardRevise";
            this.cardRevise.RightSahddow = true;
            this.cardRevise.ShadowDepth = 20;
            this.cardRevise.Size = new System.Drawing.Size(351, 384);
            this.cardRevise.TabIndex = 2;
            // 
            // ReviseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 454);
            this.ControlBox = false;
            this.Controls.Add(this.cardRevise);
            this.Controls.Add(this.lbRevise);
            this.Controls.Add(this.sepRevise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReviseForm";
            this.Text = "ReviseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator sepRevise;
        private System.Windows.Forms.Label lbRevise;
        private Bunifu.Framework.UI.BunifuCards cardRevise;
    }
}