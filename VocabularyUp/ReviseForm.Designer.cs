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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDash = new System.Windows.Forms.Panel();
            this.pnlRevise = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRevise.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(178, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pnlDash
            // 
            this.pnlDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlDash.Location = new System.Drawing.Point(23, 391);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(392, 4);
            this.pnlDash.TabIndex = 11;
            // 
            // pnlRevise
            // 
            this.pnlRevise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlRevise.BorderRadius = 20;
            this.pnlRevise.Controls.Add(this.pictureBox1);
            this.pnlRevise.Controls.Add(this.pnlDash);
            this.pnlRevise.Controls.Add(this.label1);
            this.pnlRevise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevise.Location = new System.Drawing.Point(0, 0);
            this.pnlRevise.Name = "pnlRevise";
            this.pnlRevise.ShadowDecoration.Parent = this.pnlRevise;
            this.pnlRevise.Size = new System.Drawing.Size(434, 479);
            this.pnlRevise.TabIndex = 12;
            // 
            // ReviseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 479);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRevise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReviseForm";
            this.Text = "ReviseForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRevise.ResumeLayout(false);
            this.pnlRevise.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlDash;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlRevise;
    }
}