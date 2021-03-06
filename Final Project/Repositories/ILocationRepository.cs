﻿using Final_Project.BusinessObjects;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Repositories
{
    public interface ILocationRepository
    {
        List<LocationObject> GetList(string UserID);
        void Insert(LocationModel location);
        void Delete(double lat, double lon, string UserID);
        void Edit(LocationObject location);

        int GetNumberOfLocationsForUser(string UserId);
        void AddLocationWithLatLon(string UserID, double Latitude, double Longitude, string country);
        LocationModel GetTitleAndDescription(string UserID, double Latitude, double Longitude);
        void Update_Location(string UserID, string Title, string Description, string DateVisited, string Category, double lat, double lon);

        void AddImage(string Image, double Latitude, double Longitude, string UserID);

        //these dont really beling in this repository, but it makes no difference
        void InsertOrUpdateTheme(string Theme, string UserID);
        string GetTheme(string UserID);
    }
}
