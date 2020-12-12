using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    class ManageSystem
    {
        private static List<User> users = new List<User>();
        private static int numOfUser;
        private static MD5 md5Hash = MD5.Create();
        private static String connString = @ConfigurationManager.AppSettings.Get("connectString");
        private static List<FlashCard> allFlashCards = new List<FlashCard>();
        private static List<Character> allCharacters = new List<Character>();
        private static string OldPass;
        private static string TaiKhoan;

        //KẾT NỐI VỚI DATABASE
        public static void ConnectDatabase()
        {
            //ket noi csdl bang Sqlconnection 
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            //Chuan bi cau lenh query viet bang SQL 
            String sqlQuery = "select ID,USERNAME,PASS,EMAIL,NGSINH,BEGINDATE,NAME,TOTALWORD,HIGHEST_WORDS_COUNT,RECENT_WORDS_COUNT,GIOITINH from USERS, USER_INFO where USERS.ID = USER_INFO.ID_USER";
            //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai 
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
            SqlDataReader reader = command.ExecuteReader();

            //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len 
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                User u = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),reader.GetString(4), reader.GetDateTime(5),reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9),reader.GetString(10));
                users.Add(u);
            }
            numOfUser = users.Count()+1;
        }

        // KHỞI TẠO THƯ VIỆN CÁC FLASHCARDS
        public static void InitLibrary()
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            //Chuan bi cau lenh query viet bang SQL 
            String sqlQuery = "select * from FLASHCARD";
            //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai 
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
            SqlDataReader reader = command.ExecuteReader();

            //Su dung reader de doc tung dong du lieu va cho vao list allFlashCards 
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                FlashCard f = new FlashCard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                allFlashCards.Add(f);
            }
        }

        // THÊM THÔNG TIN CỦA USER VÀO TRONG DATABASE
        public static void AddSingleUserToDatabase(string username, string password)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "insert into users(id, username, pass) values(@id, @username, @pass)";
                //SqlCommand commandExt = new SqlCommand(sqlQueryExt, connection);
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@id", numOfUser);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@pass", password);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                int rs = command.ExecuteNonQuery();
                //command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }

                AddCollectionToUser(numOfUser);
                InitCharacter(numOfUser);
            }
            catch (Exception)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                connection.Close();
            }
        }

        public static void AddCollectionToUser(int currentID)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "insert into user_flashcard (id_user, id_card, id_collection, collection_name) values ( @id, 0, 0, 'HOCED')";
                //String sqlQueryExt = "insert into user_flashcard (id_user, id_card, id_collection, collection_name) values (" + numOfUser + ", 0, 0, 'HOCED')";
                //SqlCommand commandExt = new SqlCommand(sqlQueryExt, connection);
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@id", currentID);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                int rs = command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                connection.Close();
            }
        }

        //Lấy thông tin user
        public static List<string> UserInfoPersonal(int ID)
        {
            List<string> ls = new List<string>();
            SqlConnection conection = new SqlConnection(connString);
            conection.Open();

            string sqlQuery = "select NGSINH,NAME,GIOITINH,EMAIL,BEGINDATE,TOTALWORD,HIGHEST_WORDS_COUNT,RECENT_WORDS_COUNT from USER_INFO where ID_USER = " + ID.ToString();

            SqlCommand command = new SqlCommand(sqlQuery, conection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                    ls.Add(reader[0].ToString());
                    ls.Add(reader[1].ToString());
                    ls.Add(reader[2].ToString());
                    ls.Add(reader[3].ToString());
                    ls.Add(reader[4].ToString());
                    ls.Add(reader[5].ToString());
                    ls.Add(reader[6].ToString());
                    ls.Add(reader[7].ToString());
                   return ls;
            }
            reader.Close();
            conection.Close();
            return ls;

        }



        // THÊM NHỮNG THÔNG TIN PHỤ CỦA USER VÀO TRONG DATABASE
        public static void AddUserInfoToDatabase(string email, string ngSinh, DateTime beginDate, string name,int totalWord, int hiWCount, int reWCount,string gioiTinh)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "insert into USER_INFO(ID_USER, EMAIL,NGSINH, BEGINDATE,NAME, TOTALWORD, HIGHEST_WORDS_COUNT, RECENT_WORDS_COUNT,GIOITINH) values(@ID_USER, @EMAIL, @NGSINH, @BEGINDATE,@NAME, @TOTALWORD, @HIGHEST_WORDS_COUNT, @RECENT_WORDS_COUNT,@GIOITINH)";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID_USER", numOfUser);
                command.Parameters.AddWithValue("@EMAIL", email);
                command.Parameters.AddWithValue("@NGSINH", ngSinh);
                command.Parameters.AddWithValue("@BEGINDATE", beginDate.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                command.Parameters.AddWithValue("@NAME", name);
                command.Parameters.AddWithValue("@TOTALWORD", totalWord);
                command.Parameters.AddWithValue("@HIGHEST_WORDS_COUNT", hiWCount);
                command.Parameters.AddWithValue("@RECENT_WORDS_COUNT", reWCount);
                command.Parameters.AddWithValue("@GIOITINH", gioiTinh);

                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                int rs = command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
            }
            catch (InvalidCastException)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                connection.Close();
            }
        }

        // KIỂM TRA ĐĂNG NHẬP 
        public static bool CheckSignIn(string username, string password)
        {
            foreach (var u in users)
            {
                // Đúng username và password thì cho đăng nhập
                if (u.Username == username && u.Password == password)
                {
                    TaiKhoan = username;
                    OldPass = password;                   
                    return true;
                }
            }

            // Ngược lại thì không
            return false;
        }
        public static string TK()
        {
            return TaiKhoan;
        }
        public static bool Pass(string pass)
        {
            if (pass == OldPass) return true;
            else return false;
            
        }
        public static void UpdatePass(string pass)
        {
            OldPass = pass;
        }
        // LẤY SỐ USER TRONG MẢNG
        public static int GetNumberOfUser()
        {
            return users.Count();
        }

        // KIÊM TRA HỢP LỆ KHI ĐĂNG NHẬP
        public static bool CheckLoginIfValid(string username, string password)
        {
            if (username == "" || password == "")
            {
                if (username == "")
                {
                    MessageBox.Show("Username can not be empty", "Notification");
                }
                else
                {
                    MessageBox.Show("Password can not be empty", "Notification");
                }
                return false;
            }

            return true;
        }

        // KIỂM TRA HỢP LỆ EMAIL
       static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // KIỂM TRA ĐĂNG KÝ
        public static bool CheckSignUp(string username, string email, string password, string rePassword)
        {
            foreach (var u in users)
            {
                // Nếu trùng username thì không cho đăng ký
                if (u.Username == username  || u.Email == email)
                {
                    MessageBox.Show("Username or Email has existed", "Notification");
                    return false;
                }
                else if (password != rePassword)
                {
                    MessageBox.Show("Password is not match Repassword", "Notification");
                    return false;
                }

            }
            TaiKhoan = username;
            // Không trùng thì cho đăng ký
            return true;
        }

        // KIỂM TRA HỢP LỆ ĐĂNG KÝ
        public static bool CheckSignUpIfValid(string username, string email, string password, string rePassword)
        {
            if (username == "" || email == "" || password == "" || rePassword == "")
            {
                if (username == "")
                    MessageBox.Show("Username can not be empty", "Notification");
                else if (email == "")
                    MessageBox.Show("Email can not be empty", "Notification");
                else if (rePassword == "")
                    MessageBox.Show("Re-password can not be empty", "Notification");
                else
                    MessageBox.Show("Password can not be empty", "Notification");
                return false;
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Email is not valid", "Notification");
                return false;
            }

            return true;
        }

        // THÊM USER (THÔNG TIN ĐẦY ĐỦ) VÀO MẢNG VÀ DATABASE
        public static void AddUser(string username, string email, string password)
        {
            numOfUser = GetNumberOfUser();
            numOfUser++;
            users.Add(new User(numOfUser, username, password, email,"None", DateTime.Now,"None", 0, 0, 0,"None"));
            AddSingleUserToDatabase(username, password);
            AddUserInfoToDatabase(email, "None",DateTime.Now,"None", 0, 0, 0,"None");
        }

        // Chỉnh sữa thuộc tính của personal info
        public static void AddInfoPersonal(int id,string NGSINH,string NAME,string GIOITINH)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                string sqlQuery = "update USER_INFO set NGSINH = @NGSINH,NAME = @NAME,GIOITINH = @GIOITINH where ID_USER = " + id.ToString();
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@NGSINH", NGSINH);
                command.Parameters.AddWithValue("@NAME", NAME);
                command.Parameters.AddWithValue("@GIOITINH", GIOITINH);
                //THUC HIỆN CÂU TRUY VẤN
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //dong ket noi sao khi ket thuc
                connection.Close();
            }

        }

    

        // LẤY ID CỦA USER THÔNG QUA USERNAME
        public static int GetUserID(string username)
        {
            foreach (var user in users)
            {
                if (user.Username == username)
                    return user.IdUser;
            }
            return -1;
            // Cải tiến thuật toán bằng bảng băm
        }

        public static int GetUserID_Email(string email)
        {
            foreach (var user in users)
            {
                if (user.Email == email)
                    return user.IdUser;
            }
            return -1;
            // Cải tiến thuật toán bằng bảng băm
        }

        // MÃ HÓA PASSWORD
        public static string GetMd5HashWithMySecurityAlgo(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.  
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes  
            // and create a string.  
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string.  
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.  
            return sBuilder.ToString();
        }

        public static string EncryptPassword(string password)
        {
            return GetMd5HashWithMySecurityAlgo(md5Hash, password);
        }

        // LẤY THÔNG TIN CỦA USER THÔNG QUA ID
        public static User GetUserInfo(int idUser)
        {
            return users[idUser];
        }

        public static FlashCard GetFlashCard(int index)
        {
            return allFlashCards[index];
        }
        
        public static int CountAllFlashCards()
        {
            return allFlashCards.Count();
        }

        public static FlashCard SearchFlashCardEng(string content)
        {
            int index = allFlashCards.FindIndex(f => f.Eng == content);
            if (index >= 0)
                return allFlashCards[index];
            return null;
        }

        public static FlashCard SearchFlashCardVie(string content)
        {
            int index = allFlashCards.FindIndex(f => f.Viet == content); 
            if (index >= 0)
                return allFlashCards[index];
            return null;
        }

        public static int SearchEmail(string content)
        {
            return users.FindIndex(u => u.Email == content);
        }

        public static void UpdateNewPassword(int id, string newPass)
        {
            string encrytedPass = GetMd5HashWithMySecurityAlgo(md5Hash, newPass);
            users[id-1].Password = encrytedPass;
        }

        public static void UpdateNewPasswordToDatabase(int id, string newPass)
        {
            string encrytedPass = GetMd5HashWithMySecurityAlgo(md5Hash, newPass);

            //string constr = @"Server=DESKTOP-52N97T0\SQLEXPRESS;Database=todo;User Id=sa;Password=*****;";
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "update users set pass= @pass where id = " + id.ToString();
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@pass", encrytedPass);
                //Thuc hien cau truy van
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
  
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                connection.Close();
            }
        }

        // Load list allEquipment
        public static void LoadCharacter()
        {
            allCharacters.Clear();
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            String sqlQuery = "SELECT ID, NAME, HEALTH, DAMAGE, PRICE FROM CHARACTER";
            
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                Character e = new Character(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4));
                allCharacters.Add(e);
            }
        }

        public static List<Character> GetAllCharacter()
        {
            return allCharacters;
        }

        public static void InitCharacter(int currentId)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "insert into user_character (id_user, id_char) values ( @id, 0)";
                //String sqlQueryExt = "insert into user_flashcard (id_user, id_card, id_collection, collection_name) values (" + numOfUser + ", 0, 0, 'HOCED')";
                //SqlCommand commandExt = new SqlCommand(sqlQueryExt, connection);
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@id", currentId);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                int rs = command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                connection.Close();
            }
        }
    }
}
