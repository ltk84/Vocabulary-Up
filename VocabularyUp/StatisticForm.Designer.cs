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
            this.progressCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.listBadge = new System.Windows.Forms.ListView();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.pnlProgressInfo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // progressCircle
            // 
            this.progressCircle.FillThickness = 18;
            this.progressCircle.Location = new System.Drawing.Point(667, 20);
            this.progressCircle.Name = "progressCircle";
            this.progressCircle.ProgressThickness = 18;
            this.progressCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressCircle.ShadowDecoration.Parent = this.progressCircle;
            this.progressCircle.Size = new System.Drawing.Size(182, 174);
            this.progressCircle.TabIndex = 0;
            // 
            // listBadge
            // 
            this.listBadge.HideSelection = false;
            this.listBadge.Location = new System.Drawing.Point(54, 213);
            this.listBadge.Name = "listBadge";
            this.listBadge.Size = new System.Drawing.Size(451, 269);
            this.listBadge.TabIndex = 1;
            this.listBadge.UseCompatibleStateImageBehavior = false;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Location = new System.Drawing.Point(50, 20);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(454, 174);
            this.pnlUserInfo.TabIndex = 2;
            // 
            // pnlProgressInfo
            // 
            this.pnlProgressInfo.Location = new System.Drawing.Point(546, 213);
            this.pnlProgressInfo.Name = "pnlProgressInfo";
            this.pnlProgressInfo.Size = new System.Drawing.Size(402, 269);
            this.pnlProgressInfo.TabIndex = 3;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.pnlProgressInfo);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.listBadge);
            this.Controls.Add(this.progressCircle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar progressCircle;
        private System.Windows.Forms.ListView listBadge;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Panel pnlProgressInfo;
    }
}