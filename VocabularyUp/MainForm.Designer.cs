namespace VocabularyUp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cardMain = new Bunifu.Framework.UI.BunifuCards();
            this.lbMain = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sepMain = new Bunifu.Framework.UI.BunifuSeparator();
            this.SuspendLayout();
            // 
            // cardMain
            // 
            this.cardMain.BackColor = System.Drawing.Color.DimGray;
            this.cardMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardMain.BackgroundImage")));
            this.cardMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardMain.BorderRadius = 60;
            this.cardMain.BottomSahddow = true;
            this.cardMain.color = System.Drawing.Color.Teal;
            this.cardMain.LeftSahddow = false;
            this.cardMain.Location = new System.Drawing.Point(11, 6);
            this.cardMain.Name = "cardMain";
            this.cardMain.RightSahddow = true;
            this.cardMain.ShadowDepth = 20;
            this.cardMain.Size = new System.Drawing.Size(357, 390);
            this.cardMain.TabIndex = 5;
            // 
            // lbMain
            // 
            this.lbMain.BackColor = System.Drawing.Color.Transparent;
            this.lbMain.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.Location = new System.Drawing.Point(136, 418);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(108, 34);
            this.lbMain.TabIndex = 1;
            this.lbMain.Text = "Window";
            // 
            // sepMain
            // 
            this.sepMain.BackColor = System.Drawing.Color.Transparent;
            this.sepMain.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.sepMain.LineThickness = 5;
            this.sepMain.Location = new System.Drawing.Point(0, 402);
            this.sepMain.Name = "sepMain";
            this.sepMain.Size = new System.Drawing.Size(378, 10);
            this.sepMain.TabIndex = 6;
            this.sepMain.Transparency = 255;
            this.sepMain.Vertical = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 464);
            this.ControlBox = false;
            this.Controls.Add(this.sepMain);
            this.Controls.Add(this.cardMain);
            this.Controls.Add(this.lbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocabulary Up";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardMain;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbMain;
        private Bunifu.Framework.UI.BunifuSeparator sepMain;
    }
}

