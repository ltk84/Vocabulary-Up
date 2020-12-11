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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevisionForm));
            this.pnlRevision = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnShop = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRevision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRevision
            // 
            this.pnlRevision.BorderRadius = 20;
            this.pnlRevision.Controls.Add(this.panel1);
            this.pnlRevision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevision.Location = new System.Drawing.Point(0, 0);
            this.pnlRevision.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRevision.Name = "pnlRevision";
            this.pnlRevision.ShadowDecoration.Parent = this.pnlRevision;
            this.pnlRevision.Size = new System.Drawing.Size(750, 422);
            this.pnlRevision.TabIndex = 0;
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(596, 70);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(75, 23);
            this.btnShop.TabIndex = 22;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Location = new System.Drawing.Point(355, 328);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Name";
            // 
            // btnPrevious
            // 
            this.btnPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BorderRadius = 15;
            this.btnPrevious.CheckedState.Parent = this.btnPrevious;
            this.btnPrevious.CustomImages.Parent = this.btnPrevious;
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.HoverState.Parent = this.btnPrevious;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageSize = new System.Drawing.Size(30, 45);
            this.btnPrevious.Location = new System.Drawing.Point(170, 192);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ShadowDecoration.Parent = this.btnPrevious;
            this.btnPrevious.Size = new System.Drawing.Size(50, 58);
            this.btnPrevious.TabIndex = 20;
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 15;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.Enabled = false;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(30, 45);
            this.btnNext.Location = new System.Drawing.Point(528, 192);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(50, 58);
            this.btnNext.TabIndex = 19;
            // 
            // pbCharacter
            // 
            this.pbCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pbCharacter.Location = new System.Drawing.Point(258, 143);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(229, 142);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCharacter.TabIndex = 0;
            this.pbCharacter.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnShop);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.pbCharacter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 422);
            this.panel1.TabIndex = 23;
            // 
            // RevisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(750, 422);
            this.Controls.Add(this.pnlRevision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RevisionForm";
            this.Text = "RevisionForm";
            this.pnlRevision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlRevision;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Panel panel1;
    }
}