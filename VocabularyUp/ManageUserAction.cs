﻿using System;
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
        private static List<Skin> ownSkin = new List<Skin>();
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
            try
            {
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
            finally
            {
                connection.Close();
            }
            
        }

        public static List<FlashCard> UpdateFlashCardOfCollection(int idCollection)
        {
            List<FlashCard> flashCards = new List<FlashCard>();
            SqlConnection connection = new SqlConnection(constr);
            try 
            {
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
            finally
            {
                connection.Close();
            }
            
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
        public static int UpdateMainFlashCard(int currentTopic)
        {
            mainFlashCard.Clear();
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
                    nameTopic = "Job";
                    break;
                case 5:
                    nameTopic = "Food and Drinks"; // khac
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
            }
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "select top 10 * from FLASHCARD fl_m where not exists(select fl.ID from FLASHCARD fl, USER_FLASHCARD u_fl where u_fl.ID_CARD = fl.ID and fl.ID = fl_m.ID and u_fl.ID_USER = " + currentUser.IdUser.ToString() + " and u_fl.ID_COLLECTION = 0) and fl_m.FIELD = '" + nameTopic + "' order by NEWID()";
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

            if (mainFlashCard.Count == 0)
            {
                return 0;
            }
            return 1;
        }

        public static void UpdateGameMainFlashCards()
        {
            mainFlashCard.Clear();
            Random rd = new Random();
            while (mainFlashCard.Count < 25)
            {
                int index = rd.Next(1, ManageUserAction.GetItemOfAllCollection(0).ListFL.Count);
                if (mainFlashCard.IndexOf(ManageUserAction.GetItemOfAllCollection(0).ListFL[index]) < 0)
                    mainFlashCard.Add(ManageUserAction.GetItemOfAllCollection(0).ListFL[index]);
            }
        }
        public static int CalculateProgress(int currentTopic, int id)
        {
            string nameTopic = null;
            int countL = 0;
            int countA = 0;
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
                    nameTopic = "Job";
                    break;
                case 5:
                    nameTopic = "Food and Drinks"; 
                    break;
                case 6:
                    nameTopic = "Sport"; 
                    break;
                case 7:
                    nameTopic = "Clothing"; 
                    break;
                case 8:
                    nameTopic = "Technology"; 
                    break;
            }
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "select count(*) as CL from FLASHCARD fl_m where exists(select fl.ID from FLASHCARD fl, USER_FLASHCARD u_fl where u_fl.ID_CARD = fl.ID and fl.ID = fl_m.ID and u_fl.ID_USER = " + id.ToString() + " and u_fl.ID_COLLECTION = 0) and fl_m.FIELD = '" + nameTopic + "'";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();

                //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len 
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    countL = reader.GetInt32(0);
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
            countA = CalculateAllByField(currentTopic);
            return (countL*100) / countA;
        }
        public static int CalculateAllByField(int currentTopic)
        {
            string nameTopic = null;
            int countA = 0;
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
                    nameTopic = "Job";
                    break;
                case 5:
                    nameTopic = "Food and Drinks";
                    break;
                case 6:
                    nameTopic = "Sport";
                    break;
                case 7:
                    nameTopic = "Clothing"; 
                    break;
                case 8:
                    nameTopic = "Technology"; 
                    break;
            }
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQueryExt = "select count(*) as CA from FLASHCARD fl_m where fl_m.FIELD = '" + nameTopic + "'";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand commandExt = new SqlCommand(sqlQueryExt, connection);

                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader readerExt = commandExt.ExecuteReader();

                //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len         
                while (readerExt.HasRows)
                {
                    if (readerExt.Read() == false) break;
                    countA = readerExt.GetInt32(0);
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
            return countA;
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
            catch (Exception)
            {
                MessageBox.Show("Kết nối có vấn đề!");
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

        //
        public static List<FlashCard> GetMainFlashCards()
        {
            return mainFlashCard;
        }
        
        public static void UpdateOwnCharacter()
        {
            ownSkin.Clear();
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();

                //Chuan bi cau lenh query viet bang SQL 
                String sqlQuery = "select c.ID, c.NAME, c.PRICE from USER_character u_c, CHARACTER c where u_c.id_char = c.id and ID_USER = " + currentUser.IdUser.ToString();

                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai 
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();

                //Su dung reader de doc tung dong du lieu va cho vao list allFlashCards 
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;

                    Skin c = new Skin(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));

                    ownSkin.Add(c);
                }
            }
            finally
            {
                connection.Close();
            }
           
        }

        public static List<Skin> GetOwnCharacterList()
        {
            return ownSkin;
        }

        public static bool CheckExistCharacter(Skin ch)
        {
            foreach (var cha in ownSkin)
            {
                if (cha.ID == ch.ID)
                    return true;
            }
            return false;
        }

        public static void AddToOwnCharacterList(string name)
        {
            foreach (var c in ManageSystem.GetAllCharacter())
            {
                if (c.Name == name)
                {
                    ownSkin.Add(c);
                    InsertIntoOwnCharacter(c);
                    return;
                }
            }
        }

        public static void InsertIntoOwnCharacter(Skin ch)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();
                String sqlQuery = "insert into USER_CHARACTER (ID_USER, ID_CHAR) values(@ID_USER, @ID_CHARACTER)";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID_USER", currentUser.IdUser);
                command.Parameters.AddWithValue("@ID_CHARACTER", ch.ID);

                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                connection.Close();
            }
        }

        public static void LoadCurrency()
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();

                String sqlQuery = "SELECT DIAMOND FROM USER_INFO WHERE ID_user = @ID";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID", currentUser.IdUser);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;

                    currentUser.Diamond = reader.GetInt32(0);
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public static int GetDiamond()
        {
            return currentUser.Diamond;
        }

        public static void UpdateDiamond(int d)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "UPDATE USER_INFO SET DIAMOND = @D WHERE ID_USER = @ID";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@D", d);
                command.Parameters.AddWithValue("@ID", currentUser.IdUser);

                //Thuc hien cau truy van
                command.ExecuteNonQuery();
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
            currentUser.Diamond = d;
        }

        public static void UpdateDiamondAfterBuy(int num)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "UPDATE USER_INFO SET DIAMOND = @D WHERE ID_USER = @ID";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@D", currentUser.Diamond - num);
                command.Parameters.AddWithValue("@ID", currentUser.IdUser);

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

            currentUser.Diamond = currentUser.Diamond - num;
        }

        public static void LoadPlayerStat(int id, Player player)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();

                String sqlQuery = "SELECT NAME, HEALTH, DAMAGE FROM CHARACTER WHERE ID = @ID";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID", id);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    player.Name = reader.GetString(0);
                    player.Health = reader.GetInt32(1);
                    player.Damage = reader.GetInt32(2);
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public static void LoadPlayerMazeStat(int id, PlayerMaze player)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();

                String sqlQuery = "SELECT NAME, HEALTH, DAMAGE FROM CHARACTER WHERE ID = @ID";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID", id);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    player.Name = reader.GetString(0);
                    player.Health = reader.GetInt32(1);
                    player.Damage = reader.GetInt32(2);
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool GetDarkMode()
        {
            return currentUser.DarkMode;
        }

        public static void ChangeDarkMode(bool check)
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "UPDATE USER_INFO SET DARKMODE = @DARKMODE WHERE ID_USER = @ID";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@DARKMODE", check);
                command.Parameters.AddWithValue("@ID", currentUser.IdUser);

                //Thuc hien cau truy van
                command.ExecuteNonQuery();
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
            currentUser.DarkMode = check;
        }
    }
}
