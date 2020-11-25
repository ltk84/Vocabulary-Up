using System.Drawing;
using System.Windows.Forms;

namespace VocabularyUp
{
    partial class CollectionForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Your damn Collection here!", "book-icon.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionForm));
            this.lvCollection = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearching = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlCollection = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnRename = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlCollection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCollection
            // 
            this.lvCollection.BackColor = System.Drawing.Color.White;
            this.lvCollection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCollection.HideSelection = false;
            this.lvCollection.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvCollection.LargeImageList = this.imageList1;
            this.lvCollection.Location = new System.Drawing.Point(27, 62);
            this.lvCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvCollection.Name = "lvCollection";
            this.lvCollection.Size = new System.Drawing.Size(603, 340);
            this.lvCollection.SmallImageList = this.imageList1;
            this.lvCollection.TabIndex = 0;
            this.lvCollection.UseCompatibleStateImageBehavior = false;
            this.lvCollection.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvCollection_AfterLabelEdit);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "book-icon.png");
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(634, 73);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(87, 62);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BorderRadius = 15;
            this.btnDel.CheckedState.Parent = this.btnDel;
            this.btnDel.CustomImages.Parent = this.btnDel;
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.HoverState.Parent = this.btnDel;
            this.btnDel.Location = new System.Drawing.Point(634, 233);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.ShadowDecoration.Parent = this.btnDel;
            this.btnDel.Size = new System.Drawing.Size(87, 62);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Delete";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtSearching
            // 
            this.txtSearching.BackColor = System.Drawing.Color.Transparent;
            this.txtSearching.BorderRadius = 15;
            this.txtSearching.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearching.DefaultText = "";
            this.txtSearching.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearching.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearching.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearching.DisabledState.Parent = this.txtSearching;
            this.txtSearching.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearching.FillColor = System.Drawing.Color.MintCream;
            this.txtSearching.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearching.FocusedState.Parent = this.txtSearching;
            this.txtSearching.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearching.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearching.HoverState.Parent = this.txtSearching;
            this.txtSearching.Location = new System.Drawing.Point(38, 22);
            this.txtSearching.Name = "txtSearching";
            this.txtSearching.PasswordChar = '\0';
            this.txtSearching.PlaceholderText = "Search collection";
            this.txtSearching.SelectedText = "";
            this.txtSearching.ShadowDecoration.Parent = this.txtSearching;
            this.txtSearching.Size = new System.Drawing.Size(459, 25);
            this.txtSearching.TabIndex = 3;
            // 
            // pnlCollection
            // 
            this.pnlCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.pnlCollection.BorderRadius = 20;
            this.pnlCollection.Controls.Add(this.btnRename);
            this.pnlCollection.Controls.Add(this.btnSearch);
            this.pnlCollection.Controls.Add(this.lvCollection);
            this.pnlCollection.Controls.Add(this.btnDel);
            this.pnlCollection.Controls.Add(this.txtSearching);
            this.pnlCollection.Controls.Add(this.btnAdd);
            this.pnlCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCollection.Location = new System.Drawing.Point(0, 0);
            this.pnlCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCollection.Name = "pnlCollection";
            this.pnlCollection.ShadowDecoration.Parent = this.pnlCollection;
            this.pnlCollection.Size = new System.Drawing.Size(750, 422);
            this.pnlCollection.TabIndex = 4;
            // 
            // btnRename
            // 
            this.btnRename.BackColor = System.Drawing.Color.Transparent;
            this.btnRename.BorderRadius = 15;
            this.btnRename.CheckedState.Parent = this.btnRename;
            this.btnRename.CustomImages.Parent = this.btnRename;
            this.btnRename.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRename.ForeColor = System.Drawing.Color.Black;
            this.btnRename.HoverState.Parent = this.btnRename;
            this.btnRename.Location = new System.Drawing.Point(634, 153);
            this.btnRename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRename.Name = "btnRename";
            this.btnRename.ShadowDecoration.Parent = this.btnRename;
            this.btnRename.Size = new System.Drawing.Size(87, 62);
            this.btnRename.TabIndex = 12;
            this.btnRename.Text = "Rename";
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnSearch.ImageSize = new System.Drawing.Size(23, 23);
            this.btnSearch.Location = new System.Drawing.Point(502, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(20, 25);
            this.btnSearch.TabIndex = 11;
            // 
            // CollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 422);
            this.Controls.Add(this.pnlCollection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CollectionForm";
            this.Text = "CollectionForm";
            this.pnlCollection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCollection;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2TextBox txtSearching;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlCollection;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnRename;
    }
}