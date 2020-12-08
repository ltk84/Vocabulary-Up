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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbCharacter = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCate_Head = new Guna.UI2.WinForms.Guna2Button();
            this.btnBody = new Guna.UI2.WinForms.Guna2Button();
            this.btnWeapon = new Guna.UI2.WinForms.Guna2Button();
            this.lvShop = new System.Windows.Forms.ListView();
            this.btnBuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnWeapon);
            this.splitContainer1.Panel1.Controls.Add(this.btnBody);
            this.splitContainer1.Panel1.Controls.Add(this.btnCate_Head);
            this.splitContainer1.Panel1.Controls.Add(this.pbCharacter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Panel2.Controls.Add(this.btnBuy);
            this.splitContainer1.Panel2.Controls.Add(this.lvShop);
            this.splitContainer1.Size = new System.Drawing.Size(750, 422);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // pbCharacter
            // 
            this.pbCharacter.BackColor = System.Drawing.Color.Black;
            this.pbCharacter.Location = new System.Drawing.Point(12, 12);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.ShadowDecoration.Parent = this.pbCharacter;
            this.pbCharacter.Size = new System.Drawing.Size(224, 191);
            this.pbCharacter.TabIndex = 0;
            this.pbCharacter.TabStop = false;
            // 
            // btnCate_Head
            // 
            this.btnCate_Head.CheckedState.Parent = this.btnCate_Head;
            this.btnCate_Head.CustomImages.Parent = this.btnCate_Head;
            this.btnCate_Head.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCate_Head.ForeColor = System.Drawing.Color.White;
            this.btnCate_Head.HoverState.Parent = this.btnCate_Head;
            this.btnCate_Head.Location = new System.Drawing.Point(12, 235);
            this.btnCate_Head.Name = "btnCate_Head";
            this.btnCate_Head.ShadowDecoration.Parent = this.btnCate_Head;
            this.btnCate_Head.Size = new System.Drawing.Size(180, 45);
            this.btnCate_Head.TabIndex = 0;
            this.btnCate_Head.Text = "Head";
            // 
            // btnBody
            // 
            this.btnBody.CheckedState.Parent = this.btnBody;
            this.btnBody.CustomImages.Parent = this.btnBody;
            this.btnBody.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBody.ForeColor = System.Drawing.Color.White;
            this.btnBody.HoverState.Parent = this.btnBody;
            this.btnBody.Location = new System.Drawing.Point(12, 286);
            this.btnBody.Name = "btnBody";
            this.btnBody.ShadowDecoration.Parent = this.btnBody;
            this.btnBody.Size = new System.Drawing.Size(180, 45);
            this.btnBody.TabIndex = 1;
            this.btnBody.Text = "Body";
            // 
            // btnWeapon
            // 
            this.btnWeapon.CheckedState.Parent = this.btnWeapon;
            this.btnWeapon.CustomImages.Parent = this.btnWeapon;
            this.btnWeapon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWeapon.ForeColor = System.Drawing.Color.White;
            this.btnWeapon.HoverState.Parent = this.btnWeapon;
            this.btnWeapon.Location = new System.Drawing.Point(12, 337);
            this.btnWeapon.Name = "btnWeapon";
            this.btnWeapon.ShadowDecoration.Parent = this.btnWeapon;
            this.btnWeapon.Size = new System.Drawing.Size(180, 45);
            this.btnWeapon.TabIndex = 2;
            this.btnWeapon.Text = "Weapon";
            // 
            // lvShop
            // 
            this.lvShop.HideSelection = false;
            this.lvShop.Location = new System.Drawing.Point(12, 35);
            this.lvShop.Name = "lvShop";
            this.lvShop.Size = new System.Drawing.Size(461, 278);
            this.lvShop.TabIndex = 0;
            this.lvShop.UseCompatibleStateImageBehavior = false;
            // 
            // btnBuy
            // 
            this.btnBuy.CheckedState.Parent = this.btnBuy;
            this.btnBuy.CustomImages.Parent = this.btnBuy;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.HoverState.Parent = this.btnBuy;
            this.btnBuy.Location = new System.Drawing.Point(236, 348);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.ShadowDecoration.Parent = this.btnBuy;
            this.btnBuy.Size = new System.Drawing.Size(107, 45);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(377, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(107, 45);
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
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2Button btnWeapon;
        private Guna.UI2.WinForms.Guna2Button btnBody;
        private Guna.UI2.WinForms.Guna2Button btnCate_Head;
        private Guna.UI2.WinForms.Guna2PictureBox pbCharacter;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnBuy;
        private System.Windows.Forms.ListView lvShop;
    }
}