using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.BusinessObjects;
using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public IActionResult Index(LocationModel locList)
        {
            //insert into DB 

            return View(locList);
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

        [HttpPost]
        public IActionResult AddLocation(double lat, double lon) //not used yet
        {
            //_LocationRepo.Insert(lat,lon); //this wont work until add proc
            string ID = User.Claims.ElementAt(0).Value;

            return View(_LocationRepo.GetList(ID));
        }

    }
}