﻿using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private Settings _MySettings;

        public DashboardRepository(IOptions<Settings> settings)
        {
            _MySettings = settings.Value;
        }

        //This function gets the number of unique countries visited for a specific user
        public int GetNumberOfCountriesVisited(string UserID)
        {
            int count = 0;
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("GetNumberOfCountries", newConnection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            count = (int)reader["CountryCount"];
                        }
                        reader.Close();
                    }
                }
            }
            return count;
        }

        //This function gets a list of the top 5 users based on number of locations
        public List<string> GetUserWithMostPinsLeaderboard()
        {
            List<string> PinLeaderBoard = new List<string>();
            string userName = string.Empty;
            using (SqlConnection newConnection = new SqlConnection(_MySettings.ConnectionStrings["DefaultConnection"]))
            {
                using (SqlCommand command = new SqlCommand("GetMostPinsUsers", newConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    newConnection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userName = reader["UserName"].ToString();
                            PinLeaderBoard.Add(userName);
                        }
                        reader.Close();
                    }
                }
            }
            return PinLeaderBoard;
        }
    }
}
