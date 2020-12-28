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
    public partial class TrashTalkingForm : Form
    {
        Image imgCharacter;
        Image imgMonster;
        string charTrashTalk;
        string monTrashTalk;
        string current;
        int count = 0;
        int length = 0;
        public TrashTalkingForm(Image imgCharacter, Image imgMonster, string charTrashTalk, string monTrashTalk)
        {
            InitializeComponent();
            this.imgCharacter = imgCharacter;
            this.imgMonster = imgMonster;
            this.charTrashTalk = charTrashTalk;
            this.monTrashTalk = monTrashTalk;
        }
        private void LoadCharacter()
        {
            pbCharacter.Image = imgCharacter;
        }
        private void LoadMonster()
        {
            pbMonster.Image = imgMonster;
        }

        private void TrashTalkingForm_Load(object sender, EventArgs e)
        {
            LoadCharacter();
            LoadMonster();
            pbMonster.Visible = false;
            lbTrashTalk.Text = "";
            current = charTrashTalk;
            length = current.Length;
            tmTrashTalk.Start();
        }

        private void tmTrashTalk_Tick(object sender, EventArgs e)
        {
            lbTrashTalk.Text = current.Substring(0, count);
            count++;
            if (count > length)
                tmTrashTalk.Stop();
        }

        private void lbTrashTalk_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void pnlTrashTalk_Click(object sender, EventArgs e)
        {
            Next();
        }
        private void Next()
        {
            if (lbTrashTalk.Text == monTrashTalk)
                this.Close();
            if (count > length)
            {
                pbCharacter.Hide();
                pbMonster.Show();
                current = monTrashTalk;
                count = 0;
                length = current.Length;
                lbTrashTalk.Text = "";
                tmTrashTalk.Start(); 
            }
            else
            {
                tmTrashTalk.Stop();
                lbTrashTalk.Text = current;
                count = length + 1;
            }   
        }
    }
}
