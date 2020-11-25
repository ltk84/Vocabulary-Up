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
            int diffNameCount = lvCollection.Items.Count;
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
            if (lvCollection.Items[0].Text == lvCollection.SelectedItems[0].Text)
                return;

            if (lvCollection.SelectedItems.Count == 1)
            {
                lvCollection.LabelEdit = true;
                lvCollection.SelectedItems[0].BeginEdit();
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
            /*lvCollection.BeginInvoke(new MethodInvoker(() => UpdateListView()))*/;
            lvCollection.BeginInvoke(new MethodInvoker(() => UpdateListView()));
            

            //UpdateListView();
        }
        private void UpdateListView()
        {
            ManageUserAction.InitAllCollections();
            LoadListView();
        }
    }
}
