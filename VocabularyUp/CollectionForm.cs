using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    public partial class CollectionForm : Form
    {
        Color primary = Color.FromArgb(50, 74, 95);
        Color secondary = Color.FromArgb(27, 42, 65);
        int darkMode = 0;
        public CollectionForm()
        {
            InitializeComponent();
            if (darkMode == 1)
                UpdateTheme();
        }

        private void UpdateTheme()
        {
            this.pnlCollection.BackColor = primary;
            this.btnAdd.FillColor = primary;
            this.btnRename.FillColor = primary;
            this.btnDel.FillColor = primary;
        }

        public void LoadImageListView()
        {
            imageList1.Images.Add("Collection", Image.FromFile("../../icons/book_80px.png"));
        }

        public void LoadListView()
        {
            lvCollection.Items.Clear();
            imageList1.Images.Add("Collection", Image.FromFile("../../icons/book_80px.png"));
            lvCollection.SmallImageList = imageList1;
            lvCollection.LargeImageList = imageList1;
            for (int i = 0; i < ManageUserAction.CollectionCount(); i++)
            {
                lvCollection.Items.Add(ManageUserAction.GetItemOfAllCollection(i).NameCollection);
            }

            for (int i = 0; i < lvCollection.Items.Count; i++)
            {
                lvCollection.Items[i].ImageIndex = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int diffNameCount = ManageUserAction.CollectionCount();
            string nameCol = "New collection " + diffNameCount.ToString();
            while (ManageUserAction.GetCollectionId(nameCol) != -1)
            {
                diffNameCount++;
                nameCol = "New collection " + diffNameCount.ToString();
            }    

            lvCollection.Items.Add(nameCol, 0);
            ManageUserAction.AddCollection(nameCol);
            ManageUserAction.InitAllCollections();

            lvCollection.SelectedItems.Clear();
            lvCollection.Items[lvCollection.Items.Count - 1].Selected = true;

            lvCollection.LabelEdit = true;
            lvCollection.Items[lvCollection.Items.Count - 1].BeginEdit();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (lvCollection.SelectedItems.Count == 1)
            {
                int id = ManageUserAction.GetCollectionId(lvCollection.SelectedItems[0].Text);
                if (id != 0)
                {
                    lvCollection.LabelEdit = true;
                    lvCollection.SelectedItems[0].BeginEdit();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvCollection.SelectedItems.Count != 0)
            {
                if (lvCollection.SelectedItems[0].Text == ManageUserAction.GetItemOfAllCollection(0).NameCollection)
                {
                    int size = lvCollection.SelectedItems.Count;
                    for (int i = 1; i < size ; i++)
                    {
                        int id;
                        id = ManageUserAction.GetCollectionId(lvCollection.SelectedItems[1].Text);

                        if (id != 0)
                        {
                            lvCollection.Items.Remove(lvCollection.SelectedItems[1]);

                            ManageUserAction.DeleteCollection(id);

                            for (int j = id + 1; j <= ManageUserAction.CollectionCount() + 1; j++)
                            {
                                ManageUserAction.AfterDelete(j);
                                ManageUserAction.InitAllCollections();
                            }
                        }
                    }
                }
                else
                {
                    int size = lvCollection.SelectedItems.Count;
                    for (int i = 0; i < size ; i++)
                    {
                        int id;
                        id = ManageUserAction.GetCollectionId(lvCollection.SelectedItems[0].Text);
                      
                        if (id != 0)
                        {
                            lvCollection.Items.Remove(lvCollection.SelectedItems[0]);
                         
                            ManageUserAction.DeleteCollection(id);

                            for (int j = id + 1; j <= ManageUserAction.CollectionCount() + 1; j++)
                            {
                                ManageUserAction.AfterDelete(j);
                                ManageUserAction.InitAllCollections();
                            }
                        }
                    }
                }

            }
        }

        private void lvCollection_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            string newName = e.Label;
            string oldName = lvCollection.SelectedItems[0].Text;

            int index = ManageUserAction.GetCollectionId(newName);

            if (newName == ManageUserAction.GetItemOfAllCollection(0).NameCollection)
            {
                e.CancelEdit = true;
                return;
            }

            if (newName != null && newName.Length != 0)
            {
                if (index != -1)
                {
                    newName = oldName;
                    e.CancelEdit = true;
                }
                ManageUserAction.RenameCollection(oldName, newName);
            }
            ManageUserAction.InitAllCollections();
            //lvCollection.BeginInvoke(new MethodInvoker(() => UpdateListView()));
            

        }
        private void UpdateListView()
        {
            ManageUserAction.InitAllCollections();
            LoadListView();
        }

        private void lvCollection_DoubleClick(object sender, EventArgs e)
        {
            if (lvCollection.SelectedItems.Count == 1)
            {
                ToCollectionLib(ManageUserAction.GetCollectionId(lvCollection.SelectedItems[0].Text));
            }    
        }
        private void ToCollectionLib(int idCollection)
        {
            CollectionLib library = new CollectionLib(this, idCollection);
            library.TopLevel = false;
            pnlCollection.Hide();
            //pnlCollection.Controls.Clear();
            pnlTab.Controls.Clear();
            pnlTab.Controls.Add(library);
            library.FormBorderStyle = FormBorderStyle.None;
            pnlTab.Visible = true;
            pnlTab.Show();
            library.Show();
        }
        public void ProShow()
        {
            this.Show();
            pnlCollection.Show();
            pnlTab.Visible = false;
            pnlTab.Hide();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchingText = txtSearching.Text;
            List<Collection> findedCol = ManageUserAction.SearchCollectionName(searchingText);
            lvCollection.Items.Clear();
            foreach (var col in findedCol)
            {
                lvCollection.Items.Add(col.NameCollection);
            }

            for (int i = 0; i < lvCollection.Items.Count; i++)
            {
                lvCollection.Items[i].ImageIndex = 0;
            }

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
