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
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.pbChar = new System.Windows.Forms.PictureBox();
            this.pbCurrency = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbCurrency);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Controls.Add(this.pbChar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 224);
            this.panel1.TabIndex = 1;
            // 
            // lbPrice
            // 
            this.lbPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPrice.Location = new System.Drawing.Point(12, 158);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 25);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "100";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(39, 136);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(12, 198);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(94, 23);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbChar
            // 
            this.pbChar.BackColor = System.Drawing.Color.Transparent;
            this.pbChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbChar.Location = new System.Drawing.Point(3, 3);
            this.pbChar.Name = "pbChar";
            this.pbChar.Size = new System.Drawing.Size(108, 130);
            this.pbChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChar.TabIndex = 0;
            this.pbChar.TabStop = false;
            // 
            // pbCurrency
            // 
            this.pbCurrency.Image = ((System.Drawing.Image)(resources.GetObject("pbCurrency.Image")));
            this.pbCurrency.Location = new System.Drawing.Point(81, 158);
            this.pbCurrency.Name = "pbCurrency";
            this.pbCurrency.Size = new System.Drawing.Size(30, 25);
            this.pbCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrency.TabIndex = 4;
            this.pbCurrency.TabStop = false;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(114, 224);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox pbChar;
        private System.Windows.Forms.PictureBox pbCurrency;
    }
}