namespace VocabularyUp
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.pnlResultForm = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.lbWrong = new System.Windows.Forms.Label();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.lbWrongWord = new System.Windows.Forms.Label();
            this.lbCorrectWord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlResultForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResultForm
            // 
            this.pnlResultForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlResultForm.BorderRadius = 20;
            this.pnlResultForm.Controls.Add(this.label1);
            this.pnlResultForm.Controls.Add(this.label4);
            this.pnlResultForm.Controls.Add(this.btnDetails);
            this.pnlResultForm.Controls.Add(this.btnOK);
            this.pnlResultForm.Controls.Add(this.lbWrong);
            this.pnlResultForm.Controls.Add(this.lbCorrect);
            this.pnlResultForm.Controls.Add(this.lbWrongWord);
            this.pnlResultForm.Controls.Add(this.lbCorrectWord);
            this.pnlResultForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultForm.Font = new System.Drawing.Font("Montserrat Alternates", 19.8F);
            this.pnlResultForm.Location = new System.Drawing.Point(0, 0);
            this.pnlResultForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlResultForm.Name = "pnlResultForm";
            this.pnlResultForm.ShadowDecoration.Parent = this.pnlResultForm;
            this.pnlResultForm.Size = new System.Drawing.Size(1000, 519);
            this.pnlResultForm.TabIndex = 13;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnDetails.BorderRadius = 16;
            this.btnDetails.CheckedState.Parent = this.btnDetails;
            this.btnDetails.CustomImages.Parent = this.btnDetails;
            this.btnDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetails.ForeColor = System.Drawing.Color.Black;
            this.btnDetails.HoverState.Parent = this.btnDetails;
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.ImageSize = new System.Drawing.Size(40, 30);
            this.btnDetails.Location = new System.Drawing.Point(483, 421);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ShadowDecoration.Parent = this.btnDetails;
            this.btnDetails.Size = new System.Drawing.Size(112, 63);
            this.btnDetails.TabIndex = 13;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BorderRadius = 16;
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.CustomImages.Parent = this.btnOK;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageSize = new System.Drawing.Size(50, 40);
            this.btnOK.Location = new System.Drawing.Point(319, 421);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.Parent = this.btnOK;
            this.btnOK.Size = new System.Drawing.Size(112, 63);
            this.btnOK.TabIndex = 12;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbWrong
            // 
            this.lbWrong.AutoSize = true;
            this.lbWrong.BackColor = System.Drawing.Color.Transparent;
            this.lbWrong.Font = new System.Drawing.Font("Montserrat Alternates", 19.8F);
            this.lbWrong.Location = new System.Drawing.Point(685, 323);
            this.lbWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWrong.Name = "lbWrong";
            this.lbWrong.Size = new System.Drawing.Size(32, 46);
            this.lbWrong.TabIndex = 3;
            this.lbWrong.Text = "1";
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lbCorrect.Font = new System.Drawing.Font("Montserrat Alternates", 19.8F);
            this.lbCorrect.Location = new System.Drawing.Point(685, 222);
            this.lbCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(32, 46);
            this.lbCorrect.TabIndex = 2;
            this.lbCorrect.Text = "1";
            // 
            // lbWrongWord
            // 
            this.lbWrongWord.AutoSize = true;
            this.lbWrongWord.BackColor = System.Drawing.Color.Transparent;
            this.lbWrongWord.Font = new System.Drawing.Font("Montserrat Alternates", 19.8F);
            this.lbWrongWord.Location = new System.Drawing.Point(195, 323);
            this.lbWrongWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWrongWord.Name = "lbWrongWord";
            this.lbWrongWord.Size = new System.Drawing.Size(333, 46);
            this.lbWrongWord.TabIndex = 1;
            this.lbWrongWord.Text = "Number of Wrong:";
            // 
            // lbCorrectWord
            // 
            this.lbCorrectWord.AutoSize = true;
            this.lbCorrectWord.BackColor = System.Drawing.Color.Transparent;
            this.lbCorrectWord.Font = new System.Drawing.Font("Montserrat Alternates", 19.8F);
            this.lbCorrectWord.Location = new System.Drawing.Point(195, 222);
            this.lbCorrectWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCorrectWord.Name = "lbCorrectWord";
            this.lbCorrectWord.Size = new System.Drawing.Size(337, 46);
            this.lbCorrectWord.TabIndex = 0;
            this.lbCorrectWord.Text = "Number of Correct:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(238, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 61);
            this.label4.TabIndex = 16;
            this.label4.Text = "Congratulations!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Alternates", 16F);
            this.label1.Location = new System.Drawing.Point(633, 438);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Let\'s see what you got.";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.pnlResultForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.pnlResultForm.ResumeLayout(false);
            this.pnlResultForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlResultForm;
        private System.Windows.Forms.Label lbWrong;
        private System.Windows.Forms.Label lbCorrect;
        private System.Windows.Forms.Label lbWrongWord;
        private System.Windows.Forms.Label lbCorrectWord;
        private Guna.UI2.WinForms.Guna2Button btnDetails;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}