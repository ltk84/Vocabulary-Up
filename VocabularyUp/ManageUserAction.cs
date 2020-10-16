using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyUp
{
    class ManageUserAction
    {
        private static User currentUser;
        private static List<FlashCard> mainFlashCard = new List<FlashCard>();
        private static string constr = @"Server=DESKTOP-GNVB183;Database=VOCAB_UP;User Id=sa;Password=123456789;";

      
        public static void UpdateReFlashCard(int idUser)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "select fl.ID, fl.ENG, fl.VIE, fl.MEAN, fl.PRONUNCIATION, fl.IMGPATH, fl.EXAMPLE, fl.FIELD from FLASHCARD fl, USER_FLASHCARD u_fl where u_fl.ID_CARD = fl.ID and u_fl.ID_USER = " + idUser.ToString();
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
    

                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();

                //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len 
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    FlashCard fl = new FlashCard(reader.GetByte(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                    currentUser.ReFlashCard.Add(fl);
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

        public static void UpdateUserInfo(int idUser)
        {
            currentUser = ManageSystem.GetUserInfo(idUser-1);
            UpdateReFlashCard(idUser);
        }

        public static void UpdateMainFlashCard(int idUser)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "	select * from FLASHCARD fl_m where not exists(select fl.ID from FLASHCARD fl, USER_FLASHCARD u_fl where u_fl.ID_CARD = fl.ID and fl.ID = fl_m.ID and u_fl.ID_USER = " + idUser.ToString() + ')';
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);


                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();

                //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len 
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    FlashCard fl = new FlashCard(reader.GetByte(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                    mainFlashCard.Add(fl);
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

        public static FlashCard RandomMainFlashCard()
        {
            if (mainFlashCard.Count == 0)
            {
                FlashCard phaDaoFl = new FlashCard(-1, "Congratulations", "Chuc mung", "may thang roi do", "", "", "", "");
                return phaDaoFl;
            }
            var rd = new Random();
            int i = rd.Next(0, mainFlashCard.Count);
            return mainFlashCard[i];
        }

        public static FlashCard RandomReviseFlashCard()
        {
            if (currentUser.ReFlashCard.Count == 0)
            {
                FlashCard phaDaoFl = new FlashCard(-1, "Learn more baby", "Chuc mung", "may thang roi do", "", "", "", "");
                return phaDaoFl;
            }
            var rd = new Random();
            int i = rd.Next(0, currentUser.ReFlashCard.Count);
            return currentUser.ReFlashCard[i];
        }

        // an trai revise
        public static void AddMain(FlashCard fl)
        {
            mainFlashCard.Add(fl);
        }

        // an phai main
        public static void RemoveMain(FlashCard fl)
        {
            mainFlashCard.Remove(fl);
        }

        // an phai main
        public static void AddRevise(FlashCard fl)
        {
            currentUser.ReFlashCard.Add(fl);
            InsertIntoDB(fl);
        }

        // an trai revise
        public static void RemoveRevise(FlashCard fl)
        {
            currentUser.ReFlashCard.Remove(fl);
            DeleteFromDB(fl);
        }

        public static void InsertIntoDB(FlashCard fl)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "insert into USER_FLASHCARD (ID_USER, ID_CARD) values(@ID_USER, @ID_CARD)";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID_USER", currentUser.IdUser);
                command.Parameters.AddWithValue("@ID_CARD", fl.IdCard);

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
        
        public static void DeleteFromDB(FlashCard fl)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "delete from USER_FLASHCARD where ID_CARD = @ID_CARD and ID_USER = @ID_USER";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID_CARD", fl.IdCard);
                command.Parameters.AddWithValue("@ID_USER", currentUser.IdUser);

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

    }
}
