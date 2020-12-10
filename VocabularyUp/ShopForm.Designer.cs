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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbCurrency = new System.Windows.Forms.PictureBox();
            this.lbDiamond = new System.Windows.Forms.Label();
            this.btnWeapon = new Guna.UI2.WinForms.Guna2Button();
            this.btnBody = new Guna.UI2.WinForms.Guna2Button();
            this.btnCate_Head = new Guna.UI2.WinForms.Guna2Button();
            this.flpShop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbCurrency);
            this.splitContainer1.Panel1.Controls.Add(this.lbDiamond);
            this.splitContainer1.Panel1.Controls.Add(this.btnWeapon);
            this.splitContainer1.Panel1.Controls.Add(this.btnBody);
            this.splitContainer1.Panel1.Controls.Add(this.btnCate_Head);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flpShop);
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Size = new System.Drawing.Size(750, 422);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 0;
            // 
            // pbCurrency
            // 
            this.pbCurrency.Image = ((System.Drawing.Image)(resources.GetObject("pbCurrency.Image")));
            this.pbCurrency.Location = new System.Drawing.Point(55, 12);
            this.pbCurrency.Name = "pbCurrency";
            this.pbCurrency.Size = new System.Drawing.Size(30, 25);
            this.pbCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrency.TabIndex = 5;
            this.pbCurrency.TabStop = false;
            // 
            // lbDiamond
            // 
            this.lbDiamond.AutoSize = true;
            this.lbDiamond.Location = new System.Drawing.Point(24, 12);
            this.lbDiamond.Name = "lbDiamond";
            this.lbDiamond.Size = new System.Drawing.Size(25, 13);
            this.lbDiamond.TabIndex = 4;
            this.lbDiamond.Text = "100";
            // 
            // btnWeapon
            // 
            this.btnWeapon.CheckedState.Parent = this.btnWeapon;
            this.btnWeapon.CustomImages.Parent = this.btnWeapon;
            this.btnWeapon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWeapon.ForeColor = System.Drawing.Color.White;
            this.btnWeapon.HoverState.Parent = this.btnWeapon;
            this.btnWeapon.Location = new System.Drawing.Point(3, 193);
            this.btnWeapon.Name = "btnWeapon";
            this.btnWeapon.ShadowDecoration.Parent = this.btnWeapon;
            this.btnWeapon.Size = new System.Drawing.Size(180, 45);
            this.btnWeapon.TabIndex = 2;
            this.btnWeapon.Text = "Weapon";
            // 
            // btnBody
            // 
            this.btnBody.CheckedState.Parent = this.btnBody;
            this.btnBody.CustomImages.Parent = this.btnBody;
            this.btnBody.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBody.ForeColor = System.Drawing.Color.White;
            this.btnBody.HoverState.Parent = this.btnBody;
            this.btnBody.Location = new System.Drawing.Point(3, 130);
            this.btnBody.Name = "btnBody";
            this.btnBody.ShadowDecoration.Parent = this.btnBody;
            this.btnBody.Size = new System.Drawing.Size(180, 45);
            this.btnBody.TabIndex = 1;
            this.btnBody.Text = "Body";
            // 
            // btnCate_Head
            // 
            this.btnCate_Head.CheckedState.Parent = this.btnCate_Head;
            this.btnCate_Head.CustomImages.Parent = this.btnCate_Head;
            this.btnCate_Head.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCate_Head.ForeColor = System.Drawing.Color.White;
            this.btnCate_Head.HoverState.Parent = this.btnCate_Head;
            this.btnCate_Head.Location = new System.Drawing.Point(3, 68);
            this.btnCate_Head.Name = "btnCate_Head";
            this.btnCate_Head.ShadowDecoration.Parent = this.btnCate_Head;
            this.btnCate_Head.Size = new System.Drawing.Size(180, 45);
            this.btnCate_Head.TabIndex = 0;
            this.btnCate_Head.Text = "Head";
            // 
            // flpShop
            // 
            this.flpShop.AutoScroll = true;
            this.flpShop.BackColor = System.Drawing.Color.White;
            this.flpShop.Location = new System.Drawing.Point(18, 12);
            this.flpShop.Name = "flpShop";
            this.flpShop.Size = new System.Drawing.Size(493, 347);
            this.flpShop.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(404, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(95, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 422);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2Button btnWeapon;
        private Guna.UI2.WinForms.Guna2Button btnBody;
        private Guna.UI2.WinForms.Guna2Button btnCate_Head;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.FlowLayoutPanel flpShop;
        private System.Windows.Forms.Label lbDiamond;
        private System.Windows.Forms.PictureBox pbCurrency;
    }
}