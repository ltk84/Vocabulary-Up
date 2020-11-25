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
        public CollectionForm()
        {
            InitializeComponent();
        }

        public void LoadImageListView()
        {
            imageList1.Images.Add("Collection", Image.FromFile("../../icons/book-icon.png"));
        }

        public void LoadListView()
        {
            lvCollection.Items.Clear();
            imageList1.Images.Add("Collection", Image.FromFile("../../icons/book-icon.png"));
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

            lvCollection.Items.Add(new ListViewItem(nameCol));
            ManageUserAction.AddCollection(nameCol);
            UpdateListView();

            lvCollection.SelectedItems.Clear();
            lvCollection.Items[lvCollection.Items.Count - 1].Selected = true;

            lvCollection.LabelEdit = true;
            lvCollection.Items[lvCollection.Items.Count - 1].BeginEdit();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (lvCollection.SelectedItems.Count != 0)
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
                for (int i = 0; i< lvCollection.SelectedItems.Count; i++)
                {
                    int id = ManageUserAction.GetCollectionId(lvCollection.SelectedItems[i].Text);
                    if (id != 0)
                    {
                        ManageUserAction.DeleteCollection(id);
                        for (int j = id + 1; j <= ManageUserAction.CollectionCount() + 1; j++)
                        {
                            ManageUserAction.AfterDelete(j);
                            ManageUserAction.InitAllCollections();
                        }
                    }
                }
                UpdateListView();
            }
        }

        private void lvCollection_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            string newName = e.Label;
            string oldName = lvCollection.SelectedItems[0].Text;
            if (newName != null && newName.Length != 0)
            {
                if (ManageUserAction.GetCollectionId(newName) != -1)
                    newName = oldName;
                ManageUserAction.RenameCollection(oldName, newName);
            }    
            lvCollection.BeginInvoke(new MethodInvoker(() => UpdateListView()));
            

        }
        private void UpdateListView()
        {
            ManageUserAction.InitAllCollections();
            LoadListView();
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
    }
}
