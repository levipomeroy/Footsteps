using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.BusinessObjects;
using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Final_Project.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ILocationRepository _LocationRepo;
        public HomeController(ILocationRepository LocationRepo)
        {
            
            _LocationRepo = LocationRepo;
        }

        [HttpGet]
        public IActionResult test()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                string ID = User.Claims.ElementAt(0).Value;
                LocationModel locationModel = new LocationModel();
                locationModel.LocationList = _LocationRepo.GetList(ID);

                return View(locationModel);
            }
            else
            {
                return View();
            }
        }

        //Service to get location list from js
        [HttpGet]
        public IActionResult GetLocationList()
        {
            if (User.Identity.IsAuthenticated)
            {
                string ID = User.Claims.ElementAt(0).Value;
                return Json(_LocationRepo.GetList(ID));
            }
            else
            {
                return Json(null);
            }
        }

        //Service to remove a selected marker
        [HttpPost]
        public void Remove_Location(double lat, double lon)
        {
            string ID = User.Claims.ElementAt(0).Value;
            _LocationRepo.Delete(lat, lon, ID);
        }

        //Service to add location from click anywhere on the map
        [HttpPost]
        public void AddLocationWithLatLon(double lat, double lon) //not used yet
        {
            string ID = User.Claims.ElementAt(0).Value;
            _LocationRepo.AddLocationWithLatLon(ID, lat, lon);
        }

        //Service to get title and description from db for infowindow on marker on map
        [HttpPost]
        public JsonResult GetTitleAndDescription(double lat, double lon)
        {
            string ID = User.Claims.ElementAt(0).Value;
            LocationModel model = _LocationRepo.GetTitleAndDescription(ID, lat, lon);
            string title = string.Empty;
            string desription = string.Empty;

            if(model.Name != null)
            {
                title = model.Name;
            }
            if(model.Description != null)
            {
                desription = model.Description;
            }
            var result = new { title = title, description = desription };
            return Json(result);
        }

        public void Update_Location(string Title, string Description, double lat, double lon)
        {
            string ID = User.Claims.ElementAt(0).Value;
            _LocationRepo.Update_Location(ID, Title, Description, lat, lon);
        }
    }
}