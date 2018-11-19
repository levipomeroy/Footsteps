using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class LocationFormController : Controller
    {
        private ILocationRepository _LocationRepo;
        public LocationFormController(ILocationRepository LocationRepo)
        {
            _LocationRepo = LocationRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new LocationModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LocationModel loc)
        {
            //insert into DB 
            if (ModelState.IsValid)
            {
                _LocationRepo.Insert(loc);
                ModelState.Clear();
            }

            return View();
        }
    }
}