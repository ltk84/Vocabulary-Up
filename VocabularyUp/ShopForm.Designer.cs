namespace VocabularyUp
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.pnlShop = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbCurrency = new System.Windows.Forms.PictureBox();
            this.lbDiamond = new System.Windows.Forms.Label();
            this.flpShop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.pnlShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShop
            // 
            this.pnlShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlShop.BorderRadius = 20;
            this.pnlShop.Controls.Add(this.splitContainer1);
            this.pnlShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShop.Location = new System.Drawing.Point(0, 0);
            this.pnlShop.Name = "pnlShop";
            this.pnlShop.ShadowDecoration.Parent = this.pnlShop;
            this.pnlShop.Size = new System.Drawing.Size(1000, 519);
            this.pnlShop.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(14, 13);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbCurrency);
            this.splitContainer1.Panel1.Controls.Add(this.lbDiamond);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flpShop);
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Size = new System.Drawing.Size(973, 493);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // pbCurrency
            // 
            this.pbCurrency.Image = ((System.Drawing.Image)(resources.GetObject("pbCurrency.Image")));
            this.pbCurrency.Location = new System.Drawing.Point(104, 31);
            this.pbCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.pbCurrency.Name = "pbCurrency";
            this.pbCurrency.Size = new System.Drawing.Size(28, 23);
            this.pbCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrency.TabIndex = 5;
            this.pbCurrency.TabStop = false;
            // 
            // lbDiamond
            // 
            this.lbDiamond.AutoSize = true;
            this.lbDiamond.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbDiamond.Location = new System.Drawing.Point(59, 31);
            this.lbDiamond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiamond.Name = "lbDiamond";
            this.lbDiamond.Size = new System.Drawing.Size(37, 23);
            this.lbDiamond.TabIndex = 4;
            this.lbDiamond.Text = "100";
            // 
            // flpShop
            // 
            this.flpShop.AutoScroll = true;
            this.flpShop.BackColor = System.Drawing.Color.White;
            this.flpShop.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpShop.Location = new System.Drawing.Point(24, 15);
            this.flpShop.Margin = new System.Windows.Forms.Padding(4);
            this.flpShop.Name = "flpShop";
            this.flpShop.Size = new System.Drawing.Size(657, 427);
            this.flpShop.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 20;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(554, 446);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(127, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.pnlShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.pnlShop.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlShop;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbCurrency;
        private System.Windows.Forms.Label lbDiamond;
        private System.Windows.Forms.FlowLayoutPanel flpShop;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}