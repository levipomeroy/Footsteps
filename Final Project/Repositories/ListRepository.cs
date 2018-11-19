using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Microsoft.Extensions.Configuration;

namespace Final_Project.Repositories
{
    public class ListRepository : IListRepository
    {
        SqlConnection connection;
        public ListRepository()
        {
            connection = new SqlConnection(new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build()
            .GetConnectionString("DefaultConnection"));
        }

        public List<UserListItem> GetUserListItems(int ListID)
        {
            SqlConnection newConnection = new SqlConnection(new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build()
            .GetConnectionString("DefaultConnection"));

            List<UserListItem> UserListsItems = new List<UserListItem>();
            using (newConnection)
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
            using (connection)
            {
                using (SqlCommand command = new SqlCommand("Get_Lists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

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
