using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LXMessenger
{
    internal static class Actions
    {
        static private string path = "your connection string;";
                                   
        static private string insertPath = "INSERT INTO AccountInfo (ID,UserName,Password) " +
                                                "VALUES (@id,@username,@password)";
        static private string checkUsername = "SELECT COUNT(*) FROM AccountInfo WHERE UserName = @username";
        static private string checkIDS = "SELECT ID FROM AccountInfo";

        static private string loginAccountPath = "SELECT Password FROM AccountInfo WHERE " +
                                                "UserName = @username";
        static private string getUserName = "SELECT COUNT(*) FROM AccountInfo WHERE UserName = @username";
        static private string checkRealName = "SELECT RealName FROM AccountInfo WHERE " +
                                              "UserName = @username";
        static private string setNewUser = "UPDATE AccountInfo SET RealName = @realname , ProfilePicture = @imagedata WHERE UserName = @username";
        static private string getRealName = "SELECT RealName FROM AccountInfo WHERE " +
                                                  "UserName = @username";
        static private string getProfilePicture = "SELECT ProfilePicture FROM AccountInfo WHERE " +
                                                  "UserName = @username";
        static private string getFriendsPath = "SELECT " +
                                                "CASE " +
                                                    "WHEN SendedBy = @username THEN GotBy " +
                                                    "WHEN GotBy = @username THEN SendedBy " +
                                                    "ELSE NULL " +
                                                "END AS Result " +
                                           "FROM Friends " +
                                           "WHERE (SendedBy = @username OR GotBy = @username ) AND Status = 'Accepted'";
        static private string searchFriendPath = "SELECT UserName,RealName FROM AccountInfo WHERE " +
                                                 "(UserName LIKE @text OR RealName LIKE @text) AND Username != @username AND RealName != @username";
        static private string CheckFriendshipus = "SELECT Status FROM Friends WHERE SendedBy = @ourusername AND GotBy = @hisusername";
                                                
        static private string CheckFriendshipthem = "SELECT Status FROM Friends WHERE SendedBy = @hisusername AND GotBy = @ourusername";

        static private string CheckRoomId = "SELECT ChatRoom From Friends";
        static private string createFriendRequestPath = "INSERT INTO Friends (SendedBy,GotBy ,Status ,ChatRoom) VALUES " +
                                                        "(@username , @sentto , @stat , @chatroomid)";
        static private string updateFriendRequestPath = "UPDATE Friends SET Status = @status WHERE " +
                                                        "(SendedBy = @sendedby AND GotBy = @gotby) OR " +
                                                        "(SendedBy = @gotby AND GotBy = @sendedby)";
        static private string GetChatRoomIdPath = "SELECT ChatRoom From Friends WHERE " +
                                                          "(SendedBy = @sendedby AND GotBy = @gotby) OR " +
                                                          "(SendedBy = @gotby AND GotBy = @sendedby)";
        static private string GetChatPathWe = "SELECT * FROM Messages WHERE SentBy =@sendby AND ChatRoom = @chatroomid";
        static private string GetChatPathThem = "SELECT * FROM Messages WHERE SentBy =@sendby AND ChatRoom = @chatroomid";
        static private string GetFriendWithBoth = "SELECT " +
                                                "CASE " +
                                                    "WHEN Status = @stat AND SendedBy = @username THEN GotBy " +
                                                    "WHEN Status = @stat AND GotBy = @username THEN SendedBy " +
                                                    "ELSE NULL " +
                                                "END AS Result " +
                                           "FROM Friends " +
                                           "WHERE (SendedBy LIKE @text OR GotBy LIKE @text ) AND Status = @stat";
        static private string SendMessagePath = "INSERT INTO Messages (SentBy , SentTo, Message, SentTime ,ChatRoom) VALUES " +
                                                "(@sentby,@sentto ,@message ,@senttime ,@chatroom)";
        static private string UpdateUserPath = "UPDATE AccountInfo SET RealName = @realname " +
                                               "WHERE UserName =@username";

        public static int CheckUsernameExist(string uncompletedusername )
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using(SqlCommand checkusernamecmd =new SqlCommand(checkUsername, connection))
                {
                    checkusernamecmd.Parameters.AddWithValue("@username", uncompletedusername);
                    count = Convert.ToInt32(checkusernamecmd.ExecuteScalar());                   
                }
            }
            return count;
        }


        public static bool RegisterAccount(string username , string password)
        {
            bool stat = false;
            int newid = 0;
            List<int> ids = new List<int>();
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using (SqlCommand checkcmd = new SqlCommand(checkIDS, connection))
                {
                    using (SqlDataReader reader = checkcmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);
                            ids.Add(id);
                        }
                    }
                    while (ids.Contains(newid))
                    {
                        newid++;
                    }
                }
                
                using (SqlCommand insertcmd = new SqlCommand(insertPath,connection))
                {
                    string encryptedpassword = BCrypt.Net.BCrypt.HashPassword(password);
                    insertcmd.Parameters.AddWithValue("@id", newid);
                    insertcmd.Parameters.AddWithValue("@username", username);
                    insertcmd.Parameters.AddWithValue("@password", encryptedpassword);
                    insertcmd.ExecuteNonQuery();
                }
                stat = true;
            }
            return stat;
        }  
        
        public static bool LoginAccount(string username , string password)
        {
            bool stat = false;
            int count;
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using (SqlCommand lookcmd = new SqlCommand(getUserName, connection))
                {
                    lookcmd.Parameters.AddWithValue("@username", username);
                    count = Convert.ToInt32(lookcmd.ExecuteScalar());
                }
                if (count == 1)
                {
                    using (SqlCommand loginaccountcmd = new SqlCommand(loginAccountPath, connection))
                    {
                        loginaccountcmd.Parameters.AddWithValue("@username", username);
                        string encryptedpassword = loginaccountcmd.ExecuteScalar()?.ToString();
                        if (encryptedpassword != DBNull.Value.ToString())
                        {
                            if (BCrypt.Net.BCrypt.Verify(password, encryptedpassword) == true)
                            {
                                stat = true;
                            }
                        }
                    }
                }                
            }
            return stat;
        }
        public static object CheckNewUser(string username)
        {
            object realname = "";
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using (SqlCommand checkcmd = new SqlCommand(checkRealName, connection))
                {
                    checkcmd.Parameters.AddWithValue("@username", username);
                    realname = checkcmd.ExecuteScalar();
                }
            }
            return realname;
        }
        public static void SetNewUser(string username , string realname, byte[] imagedata)
        {
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using (SqlCommand setnewusercmd = new SqlCommand(setNewUser, connection))
                {
                    setnewusercmd.Parameters.AddWithValue("@username", username);
                    setnewusercmd.Parameters.AddWithValue("@realname", realname);
                    setnewusercmd.Parameters.AddWithValue("@imagedata", imagedata);
                    setnewusercmd.ExecuteNonQuery();
                }                
            }
        }
        public static void GetEverything(string username , out object realname , out byte[] profilepicture)
        {
            realname = new object();
            profilepicture = new byte[0];
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using (SqlCommand getrealnamecmd = new SqlCommand(getRealName, connection))
                {
                    getrealnamecmd.Parameters.AddWithValue("@username", username);
                    realname = getrealnamecmd.ExecuteScalar();
                }
                using (SqlCommand getpicturecmd = new SqlCommand(getProfilePicture, connection))
                {
                    getpicturecmd.Parameters.AddWithValue("@username", username);
                    profilepicture = (byte[])getpicturecmd.ExecuteScalar();
                }
            }
        }
        public static List<string> GetFriends(string username  )
        {

            List<string> allfriends = new List<string>();
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using (SqlCommand getfriendscmd = new SqlCommand(getFriendsPath , connection))
                {
                    getfriendscmd.Parameters.AddWithValue("@username",username);
                    
                    using (SqlDataReader reader = getfriendscmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object friend = reader["Result"];
                            
                            allfriends.Add((string)friend);
                        }
                    }
                }
            }
            return allfriends;
            
        }
        public static void GetFriendWithSearch(string username , string text , out List<string> friends)
        {
            friends = new List<string>();
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using(SqlCommand  getfriendscmd = new SqlCommand(GetFriendWithBoth , connection))
                {
                    getfriendscmd.Parameters.AddWithValue("@stat", "Accepted");
                    getfriendscmd.Parameters.AddWithValue("@username", username);
                    getfriendscmd.Parameters.AddWithValue("@text", "%" + text + "%");
                    using (SqlDataReader reader = getfriendscmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string friend = (string)reader["Result"];
                            friends.Add(friend);
                        }
                    }
                }
            }
        }
        public static void SearchFriends ( string ourusername ,string text , out List<string> result, out List<string> usernames)
        {
            result = new List<string>();
            usernames = new List<string>();
            using(SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using(SqlCommand searchcmd = new SqlCommand(searchFriendPath, connection))
                {
                    searchcmd.Parameters.AddWithValue("@text", "%" + text + "%");
                    searchcmd.Parameters.AddWithValue("@username", ourusername);
                    using (SqlDataReader reader = searchcmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string username = reader["UserName"].ToString();
                            string realname = reader["RealName"].ToString();
                            if (realname != DBNull.Value.ToString())
                            {
                                result.Add($"Username : {username}\nRealname : {realname}");
                                usernames.Add(username);
                            }                           
                        }
                    }
                }
            }
        }
        public static void CheckFriendShip (string ourusername , string hisusername , out string stat , out object result)
        {
            stat = "";
            result = null;
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using (SqlCommand  checkcmd = new SqlCommand(CheckFriendshipus, connection))
                {
                    checkcmd.Parameters.AddWithValue("@ourusername", ourusername);
                    checkcmd.Parameters.AddWithValue("@hisusername", hisusername);
                    result = checkcmd.ExecuteScalar();
                    if (result == null)
                    {                       
                        using (SqlCommand checkcmd1 = new SqlCommand(CheckFriendshipthem, connection))
                        {
                            checkcmd1.Parameters.AddWithValue("@ourusername", ourusername);
                            checkcmd1.Parameters.AddWithValue("@hisusername", hisusername);
                            result = checkcmd1.ExecuteScalar();
                            if (result != null)
                            {
                                stat = "they sent";
                            }
                            else
                            {                               
                                stat = "";
                               
                            }
                        }
                    }
                    else
                    {
                        stat = "we sent";
                    }
                }
            }            
        }
        public static void CreateFriendRequest(string username , string sentto)
        {
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                int newroomid = 1;
                List<int> roomids = new List<int>();
                using (SqlCommand checkcmd = new SqlCommand(CheckRoomId, connection))
                {
                    using(SqlDataReader reader = checkcmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int roomid = Convert.ToInt32(reader["ChatRoom"]);
                            roomids.Add(roomid);                        
                        }
                    }
                }
                while (roomids.Contains(newroomid))
                {
                    newroomid++;
                }
                using (SqlCommand createcmd = new SqlCommand (createFriendRequestPath , connection))
                {
                    createcmd.Parameters.AddWithValue("@username", username);
                    createcmd.Parameters.AddWithValue("@sentto", sentto);
                    createcmd.Parameters.AddWithValue("@stat", "Waiting");
                    createcmd.Parameters.AddWithValue("@chatroomid", newroomid);
                    createcmd.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateFriendRequest(string username , string sentto , string stat)
        {
            using(SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using (SqlCommand updatecmd = new SqlCommand(updateFriendRequestPath, connection))
                {
                    updatecmd.Parameters.AddWithValue("@status", stat);
                    updatecmd.Parameters.AddWithValue("@sendedby", username);
                    updatecmd.Parameters.AddWithValue("@gotby", sentto);
                    updatecmd.ExecuteNonQuery();
                }
            }
        }
        public static int GetChatRoomId (string username , string usernamethem)
        {
            int roomid = -1;
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using (SqlCommand findcmd = new SqlCommand(GetChatRoomIdPath, connection))
                {
                    findcmd.Parameters.AddWithValue("@sendedby", username);
                    findcmd.Parameters.AddWithValue("@gotby", usernamethem);
                    roomid = Convert.ToInt32(findcmd.ExecuteScalar());
                }
            }
            return roomid;
        }
        public static void UpdateUser(string username, string newname)
        {
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using (SqlCommand updatecmd = new SqlCommand(UpdateUserPath, connection))
                {
                    updatecmd.Parameters.AddWithValue("@username",username);
                    updatecmd.Parameters.AddWithValue("@realname",newname);
                    
                    updatecmd.ExecuteNonQuery();
                }

            }
        }
        public static List<ChatMessage> ShowMessages(string usernameus ,string usernamethem , int chatroomid  )
        {
            List<ChatMessage> messages = new List<ChatMessage>();
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using(SqlCommand getourmessagecmd = new SqlCommand(GetChatPathWe, connection))
                {
                    getourmessagecmd.Parameters.AddWithValue("@sendby", usernameus);
                    getourmessagecmd.Parameters.AddWithValue("@chatroomid", chatroomid);
                    using (SqlDataReader reader = getourmessagecmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            messages.Add(new ChatMessage
                            {
                                Message = (string)reader["Message"],
                                SentBy = (string)reader["SentBy"],
                                Date = (DateTime)reader["SentTime"]                                
                            });
                        }
                    }
                }
                using (SqlCommand gettheirmessagecmd = new SqlCommand(GetChatPathThem, connection))
                {
                    gettheirmessagecmd.Parameters.AddWithValue("@sendby", usernamethem);
                    gettheirmessagecmd.Parameters.AddWithValue("@chatroomid", chatroomid);
                    using (SqlDataReader reader = gettheirmessagecmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            messages.Add(new ChatMessage
                            {
                                Message = (string)reader["Message"],
                                SentBy = (string)reader["SentBy"],
                                Date = (DateTime)reader["SentTime"]
                            });
                        }
                    }
                }
            }
            var orgenizedmessages = messages.OrderBy(messages => messages.Date).ToList();
            return orgenizedmessages;
        }
        public static void SendMessages(string sentby , string sentto ,string message , DateTime senttime , int chatroomid)
        {
            using(SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                using(SqlCommand newmessage = new SqlCommand(SendMessagePath, connection))
                {
                    newmessage.Parameters.AddWithValue("@sentby", sentby);
                    newmessage.Parameters.AddWithValue("@sentto", sentto);
                    newmessage.Parameters.AddWithValue("@message", message);
                    newmessage.Parameters.AddWithValue("@senttime", senttime);
                    newmessage.Parameters.AddWithValue("@chatroom", chatroomid);
                    newmessage.ExecuteNonQuery();
                }
            }
        }
    }
    public class ChatMessage 
    {
        public string Message { get; set; }
        public string SentBy { get; set; }
        public  DateTime Date { get; set; }
    }

}
