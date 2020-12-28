namespace VocabularyUp
{
    partial class ItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            this.lbOwned = new System.Windows.Forms.Label();
            this.pbCurrency = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pbChar = new System.Windows.Forms.PictureBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.pnlItem = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).BeginInit();
            this.pnlItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOwned
            // 
            this.lbOwned.BackColor = System.Drawing.Color.ForestGreen;
            this.lbOwned.Font = new System.Drawing.Font("Montserrat Alternates Medium", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOwned.ForeColor = System.Drawing.Color.White;
            this.lbOwned.Location = new System.Drawing.Point(12, 180);
            this.lbOwned.Name = "lbOwned";
            this.lbOwned.Size = new System.Drawing.Size(91, 23);
            this.lbOwned.TabIndex = 5;
            this.lbOwned.Text = "Owned";
            this.lbOwned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOwned.Visible = false;
            // 
            // pbCurrency
            // 
            this.pbCurrency.Image = ((System.Drawing.Image)(resources.GetObject("pbCurrency.Image")));
            this.pbCurrency.Location = new System.Drawing.Point(67, 149);
            this.pbCurrency.Name = "pbCurrency";
            this.pbCurrency.Size = new System.Drawing.Size(30, 25);
            this.pbCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrency.TabIndex = 4;
            this.pbCurrency.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Montserrat Alternates", 7.8F);
            this.lbPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPrice.Location = new System.Drawing.Point(12, 149);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 25);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "100";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Montserrat Alternates", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 133);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(111, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbChar
            // 
            this.pbChar.BackColor = System.Drawing.Color.Transparent;
            this.pbChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbChar.Location = new System.Drawing.Point(12, 16);
            this.pbChar.Name = "pbChar";
            this.pbChar.Size = new System.Drawing.Size(91, 110);
            this.pbChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChar.TabIndex = 0;
            this.pbChar.TabStop = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Montserrat Alternates Medium", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(12, 180);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(91, 23);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlItem
            // 
            this.pnlItem.BackColor = System.Drawing.Color.Transparent;
            this.pnlItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(96)))), ((int)(((byte)(68)))));
            this.pnlItem.BorderRadius = 20;
            this.pnlItem.BorderThickness = 2;
            this.pnlItem.Controls.Add(this.pbCurrency);
            this.pnlItem.Controls.Add(this.lbOwned);
            this.pnlItem.Controls.Add(this.btnBuy);
            this.pnlItem.Controls.Add(this.pbChar);
            this.pnlItem.Controls.Add(this.lbPrice);
            this.pnlItem.Controls.Add(this.lbName);
            this.pnlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlItem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlItem.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlItem.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlItem.Location = new System.Drawing.Point(0, 0);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.ShadowDecoration.Parent = this.pnlItem;
            this.pnlItem.Size = new System.Drawing.Size(114, 224);
            this.pnlItem.TabIndex = 2;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(114, 224);
            this.Controls.Add(this.pnlItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).EndInit();
            this.pnlItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox pbChar;
        private System.Windows.Forms.PictureBox pbCurrency;
        private System.Windows.Forms.Label lbOwned;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlItem;
    }
}