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

        virtual public void Delete(double lat, double lon, string UserID)
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

        virtual public List<LocationObject> GetList(string UserID)
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
                            location.Category = reader["Category"].ToString();
                            location.DateVisited = reader["DateVisited"].ToString();

                            Locations.Add(location);
                        }
                        reader.Close();
                    }
                }
            }
            return Locations;
        }

        virtual public void Insert(LocationModel location)
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
                    command.Parameters.AddWithValue("@UserID", location.UserID);
                    command.Parameters.AddWithValue("@DateVisited", location.DateVisited);
                    command.Parameters.AddWithValue("@Category", location.Category);


                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        virtual public int GetNumberOfLocationsForUser(string UserId)
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

        public void AddLocationWithLatLon(string UserID, double Latitude, double Longitude, string country)
        {
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("AddMarkerWithLatLon", newConnection))
                {
                    command.Parameters.AddWithValue("@UserId", UserID);
                    command.Parameters.AddWithValue("@Latitude", Latitude);
                    command.Parameters.AddWithValue("@Longitude", Longitude);
                    command.Parameters.AddWithValue("@Country", country);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public LocationModel GetTitleAndDescription(string UserID, double Latitude, double Longitude)
        {
            LocationModel model = new LocationModel();
            string Image = string.Empty;
            model.Images = new List<string>();
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("GetTitleAndDescription", newConnection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Latitude", Latitude);
                    command.Parameters.AddWithValue("@Longitude", Longitude);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.Name = reader["Name"].ToString();
                            model.Description = reader["Description"].ToString();
                            model.DateVisited = reader["DateVisited"].ToString();
                            model.Category = reader["Category"].ToString();
                            Image = reader["Image"].ToString();
                            model.Images.Add(Image);
                        }
                        reader.Close();
                    }
                }
            }
            return model;
        }

        public void Update_Location(string UserID, string Title, string Description, string DateVisited, string Category, double lat, double lon)
        {
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Update_Location", newConnection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@DateVisited", DateVisited);
                    command.Parameters.AddWithValue("@Category", Category);
                    command.Parameters.AddWithValue("@Latitude", lat);
                    command.Parameters.AddWithValue("@Longitude", lon);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddImage(string Image, double Latitude, double Longitude, string UserID)
        {
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("AddImage", newConnection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Latitude", Latitude);
                    command.Parameters.AddWithValue("@Longitude", Longitude);
                    command.Parameters.AddWithValue("@Image", Image);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        //these dont really beling in this repository, but it makes no difference
        public void InsertOrUpdateTheme(string Theme, string UserID)
        {
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("InsertOrUpdateTheme", newConnection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Theme", Theme);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public string GetTheme(string UserID)
        {
            string Theme = string.Empty;
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("GetTheme", newConnection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Theme = reader["Theme"].ToString();
                        }
                        reader.Close();
                    }
                }
            }
            return Theme;
        }
    }
}
