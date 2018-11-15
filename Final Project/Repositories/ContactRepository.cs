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
    public class ContactRepository : IContactRepository
    {
        SqlConnection connection;
        public ContactRepository()
        {
            connection = new SqlConnection(new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build()
            .GetConnectionString("DefaultConnection"));
        }

        public List<ContactModel> GetList()
        {
            List<ContactModel> Messages = new List<ContactModel>();
            using (connection)
            {
                using (SqlCommand command = new SqlCommand("Messages_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ContactModel model = new ContactModel();
                            model.UserName = reader["Name"].ToString();
                            model.Type = reader["Type"].ToString();
                            model.Message = reader["Message"].ToString();

                            Messages.Add(model);
                        }
                        reader.Close();
                    }
                }
            }
            return Messages;
        }

        public void Insert(ContactModel model)
        {
            using (connection)
            {
                using (SqlCommand command = new SqlCommand("Messages_Insert", connection))
                {
                    command.Parameters.AddWithValue("@Name", model.UserName);
                    command.Parameters.AddWithValue("@Type", model.Type);
                    command.Parameters.AddWithValue("@Message", model.Message);

                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
