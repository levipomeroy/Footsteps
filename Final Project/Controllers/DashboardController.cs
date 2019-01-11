using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class DashboardController : Controller
    {
        private IDashboardRepository _DashbaordRepo;

        public DashboardController(IDashboardRepository DashbaordRepo)
        {
            _DashbaordRepo = DashbaordRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetCountryCount()
        {
            string ID = User.Claims.ElementAt(0).Value;
            int count = _DashbaordRepo.GetNumberOfCountriesVisited(ID);
            return Json(count);
        }

        public JsonResult GetMostPinsLeaderboard()
        {
            List<string> PinLeaderboard = _DashbaordRepo.GetUserWithMostPinsLeaderboard();
            return Json(PinLeaderboard);
        }
    }
}