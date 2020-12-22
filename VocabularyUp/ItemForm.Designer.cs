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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbOwned = new System.Windows.Forms.Label();
            this.pbCurrency = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.pbChar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbOwned);
            this.panel1.Controls.Add(this.pbCurrency);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.pbChar);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 276);
            this.panel1.TabIndex = 1;
            // 
            // lbOwned
            // 
            this.lbOwned.BackColor = System.Drawing.Color.ForestGreen;
            this.lbOwned.Font = new System.Drawing.Font("Montserrat Alternates Medium", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOwned.ForeColor = System.Drawing.Color.White;
            this.lbOwned.Location = new System.Drawing.Point(8, 244);
            this.lbOwned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOwned.Name = "lbOwned";
            this.lbOwned.Size = new System.Drawing.Size(133, 28);
            this.lbOwned.TabIndex = 5;
            this.lbOwned.Text = "Owned";
            this.lbOwned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOwned.Visible = false;
            // 
            // pbCurrency
            // 
            this.pbCurrency.Image = ((System.Drawing.Image)(resources.GetObject("pbCurrency.Image")));
            this.pbCurrency.Location = new System.Drawing.Point(108, 194);
            this.pbCurrency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCurrency.Name = "pbCurrency";
            this.pbCurrency.Size = new System.Drawing.Size(40, 31);
            this.pbCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrency.TabIndex = 4;
            this.pbCurrency.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Montserrat Alternates", 7.8F);
            this.lbPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPrice.Location = new System.Drawing.Point(16, 194);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(61, 31);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "100";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Montserrat Alternates", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 167);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(148, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Montserrat Alternates Medium", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(16, 244);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(125, 28);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbChar
            // 
            this.pbChar.BackColor = System.Drawing.Color.Transparent;
            this.pbChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbChar.Location = new System.Drawing.Point(4, 4);
            this.pbChar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbChar.Name = "pbChar";
            this.pbChar.Size = new System.Drawing.Size(144, 160);
            this.pbChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChar.TabIndex = 0;
            this.pbChar.TabStop = false;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 276);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox pbChar;
        private System.Windows.Forms.PictureBox pbCurrency;
        private System.Windows.Forms.Label lbOwned;
    }
}