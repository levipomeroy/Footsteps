using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.BusinessObjects;
using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
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
            LocationModel locationModel = new LocationModel();
            locationModel.LocationList = _LocationRepo.GetList();

            return View(locationModel);
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
            return Json(_LocationRepo.GetList());
        }

        [HttpPost]
        public IActionResult AddLocation(double lat, double lon)
        {
            //_LocationRepo.Insert(lat,lon); //this wont work until add proc
            return View(_LocationRepo.GetList());
        }

    }
}