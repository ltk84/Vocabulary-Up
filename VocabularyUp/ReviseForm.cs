using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    public partial class ReviseForm : Form
    {
        public ReviseForm()
        {
            InitializeComponent();
        }

        public void ChangeLabelRevise(string content, int id)
        {
            lbRevise.Text = content;
            pbRevise.Image = Image.FromFile(ConfigurationManager.AppSettings.Get("imgPath") + id.ToString() + ".jpg");
        }
    }
}
