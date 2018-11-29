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
using Microsoft.Extensions.Options;

namespace Final_Project.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private Settings _MySettings;

        public LocationRepository(IOptions<Settings> settings)
        {
            _MySettings = settings.Value;
        }

        public void Delete(double lat, double lon, string UserID)
        {
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Remove_Location", newConnection))
                {
                    command.Parameters.AddWithValue("@Latitude", lat);
                    command.Parameters.AddWithValue("@Longitude", lon);
                    command.Parameters.AddWithValue("@UserID", UserID);
 
                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit(LocationObject location)
        {
            throw new NotImplementedException();
        }

        public List<LocationObject> GetList(string UserID)
        {
            List<LocationObject> Locations = new List<LocationObject>();
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Location_GetList", newConnection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LocationObject location = new LocationObject();
                            location.ID = (int)reader["ID"];
                            location.Country = reader["Country"].ToString();
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
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Location_Insert", newConnection))
                {
                    command.Parameters.AddWithValue("@Country", location.Country);
                    command.Parameters.AddWithValue("@Latitude", location.Latitude);
                    command.Parameters.AddWithValue("@Longitude", location.Longitude);
                    command.Parameters.AddWithValue("@Name", location.Name);
                    command.Parameters.AddWithValue("@Description", location.Description);
                    command.Parameters.AddWithValue("@Category", location.Category);
                    command.Parameters.AddWithValue("@UserID", location.UserID);


                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public int GetNumberOfLocationsForUser(string UserId)
        {
            int numLocations = 0;
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("GetNumberOfLocations", newConnection))
                {
                    command.Parameters.AddWithValue("@UserID", UserId);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            numLocations = (int)reader["LocCount"];
                        }
                        reader.Close();
                    }
                }
            }
            return numLocations;
        }
    }
}
