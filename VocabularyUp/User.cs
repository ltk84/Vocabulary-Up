using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyUp
{
    class User
    {
        int idUser;
        string username;
        string password;
        List<FlashCard> reFlashCard;

        public User(int idUser, string username, string password)
        {
            this.idUser = idUser;
            this.username = username;
            this.password = password;
            reFlashCard = new List<FlashCard>();
        }

        public int IdUser { get => idUser; set => idUser = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
