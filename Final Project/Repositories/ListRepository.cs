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

        public List<UserListItem> GetUserListItems(int ListID)
        {
            List<UserListItem> UserListsItems = new List<UserListItem>();
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Get_List_Items", newConnection))
                {
                    command.Parameters.AddWithValue("@ListID", ListID);

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

        public List<UserListModel> GetUserLists()
        {
            List<UserListModel> UserLists = new List<UserListModel>();
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Get_Lists", newConnection))
                {
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
