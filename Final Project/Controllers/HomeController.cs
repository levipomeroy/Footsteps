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

        //This is the thing Allan wrote for you to get the list for js without 
        //doing it the sketchy way you were doing it before. Its a service that
        //you can call from js but still need to figure out.
        [HttpGet]
        public IActionResult GetLocationList()
        {
            return Json(_LocationRepo.GetList());
        }
    }
}