using System;
using System.Collections.Generic;
using System.Configuration;
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
        private static List<Collection> allCollections = new List<Collection>();
        private static string constr = @ConfigurationManager.AppSettings.Get("connectString");

        // Add collection
        public static void AddCollection(string name)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "insert into USER_FLASHCARD (ID_USER, ID_CARD, ID_COLLECTION, COLLECTION_NAME) values (@ID_USER, @ID_CARD, @ID_COLLECTION, @COLLECTION_NAME)";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID_USER", currentUser.IdUser);
                command.Parameters.AddWithValue("@ID_CARD", 0);
                command.Parameters.AddWithValue("@ID_COLLECTION", allCollections.Count);
                command.Parameters.AddWithValue("@COLLECTION_NAME", name);

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

        // Delete collection
        public static void DeleteCollection(int id)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "delete from USER_FLASHCARD where ID_COLLECTION = " + id.ToString();
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
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

        public static void AfterDelete(int id)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "UPDATE USER_FLASHCARD SET ID_COLLECTION = @NEWID WHERE ID_COLLECTION = @OLDID";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@NEWID", id - 1);
                command.Parameters.AddWithValue("@OLDID", id);

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

        // Load All Connections
        public static void InitAllCollections()
        {
            allCollections.Clear();
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();

            //Chuan bi cau lenh query viet bang SQL 
            String sqlQuery = "select distinct ID_COLLECTION, COLLECTION_NAME from USER_FLASHCARD where ID_USER = " + currentUser.IdUser.ToString();
            //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai 
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
            SqlDataReader reader = command.ExecuteReader();

            //Su dung reader de doc tung dong du lieu va cho vao list allFlashCards 
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;

                Collection c = new Collection(reader.GetInt32(0), reader.GetString(1), UpdateFlashCardOfCollection(reader.GetInt32(0)));

                allCollections.Add(c);
            }
        }

        public static List<FlashCard> UpdateFlashCardOfCollection(int idCollection)
        {
            List<FlashCard> flashCards = new List<FlashCard>();

            SqlConnection connection = new SqlConnection(constr);
            connection.Open();

            //Chuan bi cau lenh query viet bang SQL 
            String sqlQuery = "select id_card, eng, vie, pronunciation, field from USER_FLASHCARD, flashcard where USER_FLASHCARD.ID_CARD = FLASHCARD.ID and ID_USER = " + currentUser.IdUser.ToString() + " and id_collection = " + idCollection.ToString();
            //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai 
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
            SqlDataReader reader = command.ExecuteReader();

            //Su dung reader de doc tung dong du lieu va cho vao list allFlashCards 
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                FlashCard f = new FlashCard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));

                flashCards.Add(f);
            }
            return flashCards;
        }

        // CONNECT ĐẾN DATABASE ĐỂ LOAD REVISE FLASHCARD
        public static void UpdateReFlashCard(int idUser)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "select fl.ID, fl.ENG, fl.VIE, fl.PRONUNCIATION, fl.FIELD from FLASHCARD fl, USER_FLASHCARD u_fl where u_fl.ID_CARD = fl.ID and u_fl.ID_USER = " + idUser.ToString();
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
    
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();

                //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len 
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    FlashCard fl = new FlashCard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
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

        // LẤY ID USER VÀ UPDATE REVISE FLASHCARD 
        public static void UpdateUserInfo(int idUser)
        {
            currentUser = ManageSystem.GetUserInfo(idUser-1);
            //UpdateReFlashCard(idUser);
        }

        // CONNECT ĐẾN DATABASE ĐỂ LOAD MAIN FLASHCARD
        public static void UpdateMainFlashCard(int currentTopic)
        {
            string nameTopic = null;
            switch (currentTopic)
            {
                case 1:
                    nameTopic = "Animals"; //
                    break;
                case 2:
                    nameTopic = "Plants";
                    break;
                case 3:
                    nameTopic = "Fruits";
                    break;
                case 4:
                    nameTopic = "Hobbies";
                    break;
                case 5:
                    nameTopic = "Character"; // khac
                    break;
                case 6:
                    nameTopic = "Sport"; // khac
                    break;
                case 7:
                    nameTopic = "Clothing"; //
                    break;
                case 8:
                    nameTopic = "Technology"; //
                    break;
                default:
                    nameTopic = "";
                    break;
            }
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "	select top 10 * from FLASHCARD fl_m where not exists(select fl.ID from FLASHCARD fl, USER_FLASHCARD u_fl where u_fl.ID_CARD = fl.ID and fl.ID = fl_m.ID and u_fl.ID_USER = " + currentUser.IdUser.ToString() + " and u_fl.ID_COLLECTION = 0) and fl_m.FIELD = " + nameTopic + " order by NEWID()";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);


                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();

                //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len 
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    FlashCard fl = new FlashCard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
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

        // TẠO 1 RANDOM FLASHCARD TRONG MAINFLASHCARD
        public static FlashCard RandomMainFlashCard()
        {
            if (mainFlashCard.Count == 0)
            {
                FlashCard phaDaoFl = new FlashCard(-1, "I love you", "Anh yêu em!", "Thật đó!", "");
                return phaDaoFl;
            }
            var rd = new Random();
            int i = rd.Next(0, mainFlashCard.Count);
            return mainFlashCard[i];
        }

        // TẠO 1 RANDOM FLASHCARD TRONG REVISEFLASHCARD
        public static FlashCard RandomReviseFlashCard()
        {
            if (currentUser.ReFlashCard.Count == 0)
            {
                FlashCard phaDaoFl = new FlashCard(-1, "Learn more", "Chăm chỉ lên nào!", "Có làm mới có ăn.",  "");
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

        // INSERT FLASHCARD VÀO DATABASE
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
        
        // REMOVE FLASHCARD KHỎI DATABASE
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

        public static void UpdateTotalWord()
        {
            currentUser.TotalWord = ManageSystem.GetUserInfo(currentUser.IdUser - 1).ReFlashCard.Count();
        }

        public static Collection GetItemOfAllCollection(int id)
        {
            return allCollections[id];
        }
        public static int GetCollectionId(string name)
        {
            foreach (var collection in allCollections)
            {
                if (collection.NameCollection == name)
                    return collection.IdCollection;
            }
            return -1;
        }

        public static int CollectionCount()
        {
            return allCollections.Count;
        }

        public static void AddFlashCardToCollection(int idCollection, FlashCard fl)
        {
            allCollections[idCollection].ListFL.Add(fl);
        }
        
        public static void RemoveFlashCardFromCollection(int idCollection, FlashCard fl)
        {
            allCollections[idCollection].ListFL.Remove(fl);
        }

        public static void AddFlashCardToDatabase(int idCollection, string collectionName, FlashCard fl)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "insert into USER_FLASHCARD (ID_USER, ID_CARD, ID_COLLECTION, COLLECTION_NAME) values(@ID_USER, @ID_CARD, @ID_COLLECTION, @COLLECTION_NAME)";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID_USER", currentUser.IdUser);
                command.Parameters.AddWithValue("@ID_CARD", fl.IdCard);
                command.Parameters.AddWithValue("@ID_COLLECTION", idCollection);
                command.Parameters.AddWithValue("@COLLECTION_NAME", collectionName);


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
        public static void DeleteFlashCardFromDatabase(int idCollection, FlashCard fl)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "delete from USER_FLASHCARD where ID_CARD = @ID_CARD and ID_USER = @ID_USER and ID_COLLECTION = @ID_COLLECTION";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID_CARD", fl.IdCard);
                command.Parameters.AddWithValue("@ID_USER", currentUser.IdUser);
                command.Parameters.AddWithValue("@ID_COLLECTION", idCollection);

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

        public static bool IsFlashCardExist(int idCollection,  int idFlashCard)
        {
            if (allCollections[idCollection].ListFL.FindIndex(f => f.IdCard == idFlashCard) == -1)
                return false;
            return true;
        }

        public static void RenameCollection(string oldName, string newName)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "UPDATE USER_FLASHCARD SET COLLECTION_NAME = N'" + newName + "' " + " WHERE COLLECTION_NAME = N'" + oldName + "' AND ID_COLLECTION <> 0";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                

                //Thuc hien cau truy van
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                //MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                connection.Close();
            }
        }

        // Search Collection
        public static List<Collection> SearchCollectionName(string text)
        {
            List<Collection> findedList = new List<Collection>();
            foreach (var col in allCollections)
            {
                string upperCaseText = text.ToUpper();
                string lowerCaseText = text.ToLower();
                if (col.NameCollection.IndexOf(upperCaseText) >= 0 || col.NameCollection.IndexOf(lowerCaseText) >= 0)
                {
                    findedList.Add(col);
                }
            }
            return findedList;
        }

        
    }
}
