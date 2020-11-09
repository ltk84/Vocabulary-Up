namespace VocabularyUp
{
    partial class RevisionForm
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
            this.pnlRevision = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SuspendLayout();
            // 
            // pnlRevision
            // 
            this.pnlRevision.BorderRadius = 20;
            this.pnlRevision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevision.Location = new System.Drawing.Point(0, 0);
            this.pnlRevision.Name = "pnlRevision";
            this.pnlRevision.ShadowDecoration.Parent = this.pnlRevision;
            this.pnlRevision.Size = new System.Drawing.Size(1000, 520);
            this.pnlRevision.TabIndex = 0;
            // 
            // RevisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.pnlRevision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevisionForm";
            this.Text = "RevisionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlRevision;
    }
}