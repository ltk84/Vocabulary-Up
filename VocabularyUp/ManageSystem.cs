using System;
using System.Collections.Generic;
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



        // DATABASE
        public static void ConnectDatabase()
        {
            //xac dinh duong dan den database 
            String connString = @"Server=DESKTOP-GNVB183;Database=VOCAB_UP;User Id=sa;Password=123456789;";

            //ket noi csdl bang Sqlconnection 
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            //Chuan bi cau lenh query viet bang SQL 
            String sqlQuery = "select * from USERS";
            //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai 
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
            SqlDataReader reader = command.ExecuteReader();

            //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len 
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                User u = new User(reader.GetByte(0), reader.GetString(1), reader.GetString(2));
                users.Add(u);

            }
            numOfUser = users.Count();
        }


        public static void AddSingleUserToDatabase(string username, string password)
        {
            string constr = @"Server=DESKTOP-GNVB183;Database=VOCAB_UP;User Id=sa;Password=123456789;";
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "insert into users(id, username, pass) values(@id, @username, @pass)";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@id", numOfUser++);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@pass", password);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                int rs = command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
            }
            catch (InvalidCastException ex)
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

        //


        // SIGN IN
        public static bool CheckSignIn(string username, string password)
        {
            foreach (var u in users)
            {
                // Đúng username và password thì cho đăng nhập
                if (u.Username == username && u.Password == password)
                {
                    return true;
                }
            }

            // Ngược lại thì không
            return false;
        }

        public static int GetNumberOfUser()
        {
            return users.Count();
        }

        public static bool CheckLoginIfValid(string username, string password)
        {
            if (username == "" || password == "")
            {
                if (username == "")
                {
                    MessageBox.Show("Email can not be empty", "Warning");
                }
                else
                {
                    MessageBox.Show("Password can not be empty", "Warning");
                }
                return false;
            }

            return true;
        }
        //


        // SIGN UP
        public static bool CheckSignUp(string username, string password, string rePassword)
        {
            foreach (var u in users)
            {
                // Nếu trùng username thì không cho đăng ký
                if (u.Username == username || password != rePassword)
                    return false;
            }

            // Không trùng thì cho đăng ký
            return true;
        } 

        public static void AddUser(string username, string password)
        {
            numOfUser = GetNumberOfUser();
            users.Add(new User(numOfUser, username, password));
            numOfUser++;
        }
        // 



        // ENCRYPT PASSWORD
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

        public static bool VerifyMd5HashWithMySecurityAlgo(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.  
            string hashOfInput = GetMd5HashWithMySecurityAlgo(md5Hash, input);
            // Create a StringComparer an compare the hashes.  
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 
    }
}
