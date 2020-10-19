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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviseForm));
            this.lbRevise = new System.Windows.Forms.Label();
            this.pbRevise = new System.Windows.Forms.PictureBox();
            this.pnlDash = new System.Windows.Forms.Panel();
            this.pnlRevise = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.elipseRevForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRevise)).BeginInit();
            this.pnlRevise.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRevise
            // 
            this.lbRevise.BackColor = System.Drawing.Color.Transparent;
            this.lbRevise.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbRevise.Location = new System.Drawing.Point(23, 411);
            this.lbRevise.Name = "lbRevise";
            this.lbRevise.Size = new System.Drawing.Size(392, 38);
            this.lbRevise.TabIndex = 9;
            this.lbRevise.Text = "Welcome";
            this.lbRevise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbRevise
            // 
            this.pbRevise.Image = ((System.Drawing.Image)(resources.GetObject("pbRevise.Image")));
            this.pbRevise.Location = new System.Drawing.Point(23, 23);
            this.pbRevise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRevise.Name = "pbRevise";
            this.pbRevise.Size = new System.Drawing.Size(392, 354);
            this.pbRevise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRevise.TabIndex = 10;
            this.pbRevise.TabStop = false;
            // 
            // pnlDash
            // 
            this.pnlDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlDash.Location = new System.Drawing.Point(23, 391);
            this.pnlDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(392, 4);
            this.pnlDash.TabIndex = 11;
            // 
            // pnlRevise
            // 
            this.pnlRevise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlRevise.BorderRadius = 20;
            this.pnlRevise.Controls.Add(this.pbRevise);
            this.pnlRevise.Controls.Add(this.pnlDash);
            this.pnlRevise.Controls.Add(this.lbRevise);
            this.pnlRevise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevise.Location = new System.Drawing.Point(0, 0);
            this.pnlRevise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRevise.Name = "pnlRevise";
            this.pnlRevise.ShadowDecoration.Parent = this.pnlRevise;
            this.pnlRevise.Size = new System.Drawing.Size(435, 479);
            this.pnlRevise.TabIndex = 12;
            // 
            // elipseRevForm
            // 
            this.elipseRevForm.BorderRadius = 20;
            this.elipseRevForm.TargetControl = this.pbRevise;
            // 
            // ReviseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 479);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRevise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReviseForm";
            this.Text = "ReviseForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbRevise)).EndInit();
            this.pnlRevise.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbRevise;
        private System.Windows.Forms.PictureBox pbRevise;
        private System.Windows.Forms.Panel pnlDash;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlRevise;
        private Guna.UI2.WinForms.Guna2Elipse elipseRevForm;
    }
}