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
        string NGSINH;
        string name;
        List<FlashCard> reFlashCard;
        DateTime beginDate;
        int totalWord;
        int highestWordsCount;
        int recentWordsCount;
        string GIOITINH;

        public User(int idUser, string username, string password, string email,string NGSINH, DateTime beginDate,string name, int totalWord, int highestWordsCount, int recentWordsCount,string GIOITINH)
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
            this.NGSINH = NGSINH;
            this.name = name;
            this.GIOITINH = GIOITINH;
        }

        public int IdUser { get => idUser; set => idUser = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Ngsinh { get => NGSINH; set => NGSINH = value; }
        public string Name { get => name; set => name = value; }
        public string GioiTinh { get => GIOITINH; set => GIOITINH = value; }
        public DateTime BeginDate { get => beginDate; set => beginDate = value; }
        public int TotalWord { get => totalWord; set => totalWord = value; }
        public int HighestWordsCount { get => highestWordsCount; set => highestWordsCount = value; }
        public int RecentWordsCount { get => recentWordsCount; set => recentWordsCount = value; }
        public List<FlashCard> ReFlashCard { get => reFlashCard; set => reFlashCard = value; }
    }
}
