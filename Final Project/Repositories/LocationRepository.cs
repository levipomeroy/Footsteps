using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.BusinessObjects;
using Final_Project.Models;
using Microsoft.Extensions.Configuration;

namespace Final_Project.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        SqlConnection connection;
        public LocationRepository()
        {
            connection = new SqlConnection(new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build()
            .GetConnectionString("DefaultConnection"));
        }

        public void Delete(LocationObject location)
        {
            throw new NotImplementedException();
        }

        public void Edit(LocationObject location)
        {
            throw new NotImplementedException();
        }

        public List<LocationObject> GetList()
        {
            List<LocationObject> Locations = new List<LocationObject>();
            using (connection)
            {
                using (SqlCommand command = new SqlCommand("Location_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LocationObject location = new LocationObject();
                            location.ID = (int)reader["ID"];
                            location.Country = reader["Country"].ToString();
                            location.StateCode = reader["StateCode"].ToString();
                            location.City = reader["City"].ToString();
                            location.ZipCode = reader["ZipCode"].ToString();
                            location.Address = reader["Address"].ToString();
                            location.Latitude =(double)reader["Latitude"];
                            location.Longitude = (double)reader["Longitude"];
                            location.Name = reader["Name"].ToString();
                            location.Description = reader["Description"].ToString();
                            location.Category = (int)reader["Category"];

                            Locations.Add(location);
                        }
                        reader.Close();
                    }
                }
            }
            return Locations;
        }

        public void Insert(LocationModel location)
        {
            using (connection)
            {
                using (SqlCommand command = new SqlCommand("Location_Insert", connection))
                {
                    command.Parameters.AddWithValue("@Country", location.Country);
                    command.Parameters.AddWithValue("@StateCode", location.StateCode);
                    command.Parameters.AddWithValue("@City", location.City);
                    command.Parameters.AddWithValue("@ZipCode", location.ZipCode);
                    command.Parameters.AddWithValue("@Address", location.Address);
                    command.Parameters.AddWithValue("@Latitude", location.Latitude);
                    command.Parameters.AddWithValue("@Longitude", location.Longitude);
                    command.Parameters.AddWithValue("@Name", location.Name);
                    command.Parameters.AddWithValue("@Description", location.Description);
                    command.Parameters.AddWithValue("@Category", location.Category);

                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
