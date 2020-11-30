using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class Collection
    {
        private int idCollection;
        private string nameCollection;
        List<FlashCard> listFL = new List<FlashCard>();

        public Collection(int idCollection, string nameCollection, List<FlashCard> listFL)
        {
            this.idCollection = idCollection;
            this.nameCollection = nameCollection;
            this.listFL = listFL;
        }

        public int IdCollection { get => idCollection; set => value = idCollection; }
        public string NameCollection { get => nameCollection; set => value = nameCollection; }
        public List<FlashCard> ListFL { get => listFL; set => value = listFL; }
    }
}
