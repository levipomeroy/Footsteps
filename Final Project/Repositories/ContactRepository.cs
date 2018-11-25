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
    public class ContactRepository : IContactRepository
    {
        private Settings _MySettings;

        public ContactRepository(IOptions<Settings> settings)
        {
            _MySettings = settings.Value;
        }

        public List<ContactModel> GetList()
        {
            List<ContactModel> Messages = new List<ContactModel>();
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Messages_GetList", newConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();

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
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Messages_Insert", newConnection))
                {
                    command.Parameters.AddWithValue("@Name", model.UserName);
                    command.Parameters.AddWithValue("@Type", model.Type);
                    command.Parameters.AddWithValue("@Message", model.Message);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
