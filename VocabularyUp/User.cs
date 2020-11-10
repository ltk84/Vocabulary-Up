using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace VocabularyUp
{
    class User
    {
        int idUser;
        string username;
        string password;
        string email;
        List<FlashCard> reFlashCard;
        DateTime beginDate;
        int totalWord;
        int highestWordsCount;
        int recentWordsCount;

        public User(int idUser, string username, string password, string email, DateTime beginDate, int totalWord, int highestWordsCount, int recentWordsCount)
        {
            this.idUser = idUser;
            this.username = username;
            this.password = password;
            this.email = email;
            this.beginDate = beginDate;
            this.totalWord = totalWord;
            this.highestWordsCount = highestWordsCount;
            this.recentWordsCount = recentWordsCount;
            this.reFlashCard = new List<FlashCard>();
        }

        public int IdUser { get => idUser; set => idUser = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public DateTime BeginDate { get => beginDate; set => beginDate = value; }
        public int TotalWord { get => totalWord; set => totalWord = value; }
        public int HighestWordsCount { get => highestWordsCount; set => highestWordsCount = value; }
        public int RecentWordsCount { get => recentWordsCount; set => recentWordsCount = value; }
        public List<FlashCard> ReFlashCard { get => reFlashCard; set => reFlashCard = value; }
    }
}
