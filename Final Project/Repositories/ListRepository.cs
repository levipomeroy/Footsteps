using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Final_Project.Repositories
{
    public class ListRepository : IListRepository
    {
        private Settings _MySettings;

        public ListRepository(IOptions<Settings> settings)
        {
            _MySettings = settings.Value;
        }

        virtual public void AddList(string Name, string UserID)
        {
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("AddList", newConnection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        virtual public void AddListItem(int ListID, string ItemName, string UserID)
        {
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("AddListItem", newConnection))
                {
                    command.Parameters.AddWithValue("@ListID", ListID);
                    command.Parameters.AddWithValue("@ItemName", ItemName);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        virtual public int GetIDFromName(string Name, string UserID)
        {
            int ID = 0;
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("GetListIDByName", newConnection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            ID = (int)reader["ID"];
                        }
                        reader.Close();
                    }
                }
            }
            return ID;
        }

        virtual public List<UserListItem> GetUserListItems(int ListID, string UserID)
        {
            List<UserListItem> UserListsItems = new List<UserListItem>();
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Get_List_Items", newConnection))
                {
                    command.Parameters.AddWithValue("@ListID", ListID);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserListItem model = new UserListItem();
                           // model.ID = (int)reader["ID"];
                            model.Item = reader["Item"].ToString();
                            model.IsChecked = (bool)reader["IsChecked"];

                            UserListsItems.Add(model);
                        }
                        reader.Close();
                    }
                }
            }
            return UserListsItems;

        }

        virtual public List<UserListModel> GetUserLists(string UserID)
        {
            List<UserListModel> UserLists = new List<UserListModel>();
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Get_Lists", newConnection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserListModel model = new UserListModel();
                            model.ID = (int)reader["ID"];
                            model.Name = reader["Name"].ToString();

                            UserLists.Add(model);
                        }
                        reader.Close();
                    }
                }
            }
            return UserLists;
        }
    }
}
