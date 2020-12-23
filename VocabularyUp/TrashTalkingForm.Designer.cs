namespace VocabularyUp
{
    partial class TrashTalkingForm
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
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.pbMonster = new System.Windows.Forms.PictureBox();
            this.pnlTrashTalk = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbTrashTalk = new System.Windows.Forms.Label();
            this.tmTrashTalk = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster)).BeginInit();
            this.pnlTrashTalk.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCharacter
            // 
            this.pbCharacter.Location = new System.Drawing.Point(59, 167);
            this.pbCharacter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(399, 448);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCharacter.TabIndex = 0;
            this.pbCharacter.TabStop = false;
            // 
            // pbMonster
            // 
            this.pbMonster.Location = new System.Drawing.Point(1037, 167);
            this.pbMonster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMonster.Name = "pbMonster";
            this.pbMonster.Size = new System.Drawing.Size(399, 448);
            this.pbMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMonster.TabIndex = 1;
            this.pbMonster.TabStop = false;
            // 
            // pnlTrashTalk
            // 
            this.pnlTrashTalk.BackColor = System.Drawing.Color.Transparent;
            this.pnlTrashTalk.BorderRadius = 20;
            this.pnlTrashTalk.Controls.Add(this.lbTrashTalk);
            this.pnlTrashTalk.FillColor = System.Drawing.Color.White;
            this.pnlTrashTalk.FillColor2 = System.Drawing.Color.White;
            this.pnlTrashTalk.Location = new System.Drawing.Point(59, 658);
            this.pnlTrashTalk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTrashTalk.Name = "pnlTrashTalk";
            this.pnlTrashTalk.ShadowDecoration.Parent = this.pnlTrashTalk;
            this.pnlTrashTalk.Size = new System.Drawing.Size(1379, 212);
            this.pnlTrashTalk.TabIndex = 2;
            this.pnlTrashTalk.Click += new System.EventHandler(this.pnlTrashTalk_Click);
            // 
            // lbTrashTalk
            // 
            this.lbTrashTalk.BackColor = System.Drawing.Color.Transparent;
            this.lbTrashTalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTrashTalk.Font = new System.Drawing.Font("Montserrat Alternates", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrashTalk.Location = new System.Drawing.Point(35, 28);
            this.lbTrashTalk.Name = "lbTrashTalk";
            this.lbTrashTalk.Size = new System.Drawing.Size(1307, 158);
            this.lbTrashTalk.TabIndex = 3;
            this.lbTrashTalk.Click += new System.EventHandler(this.lbTrashTalk_Click);
            // 
            // tmTrashTalk
            // 
            this.tmTrashTalk.Enabled = true;
            this.tmTrashTalk.Tick += new System.EventHandler(this.tmTrashTalk_Tick);
            // 
            // TrashTalkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1500, 908);
            this.Controls.Add(this.pnlTrashTalk);
            this.Controls.Add(this.pbMonster);
            this.Controls.Add(this.pbCharacter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrashTalkingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TrashTalkingForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Turquoise;
            this.Load += new System.EventHandler(this.TrashTalkingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster)).EndInit();
            this.pnlTrashTalk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.PictureBox pbMonster;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlTrashTalk;
        private System.Windows.Forms.Label lbTrashTalk;
        private System.Windows.Forms.Timer tmTrashTalk;
    }
}