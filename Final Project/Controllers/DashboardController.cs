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

        //service to get number of countires for user
        public JsonResult GetCountryCount()
        {
            string ID = User.Claims.ElementAt(0).Value;
            int count = _DashbaordRepo.GetNumberOfCountriesVisited(ID);
            return Json(count);
        }

        public JsonResult GetCategoryCount()
        {
            string ID = User.Claims.ElementAt(0).Value;
            List<KeyValuePair<string, int>> CategoryCount = _DashbaordRepo.GetCategoryCount(ID);
            return Json(CategoryCount);
        }

        //service to get leaderboard for most pins
        public JsonResult GetMostPinsLeaderboard()
        {
            List<string> PinLeaderboard = _DashbaordRepo.GetUserWithMostPinsLeaderboard();
            return Json(PinLeaderboard);
        }

        //service to get leaderboard for most countries
        public JsonResult GetMostCountriesLeaderboard()
        {
            List<string> CountryLeaderboard = _DashbaordRepo.GetUsersWithMostCountries();
            return Json(CountryLeaderboard);
        }

        //service to get leaderboard for most locations this month
        public JsonResult GetUsersWithMostLocationsThisMonth()
        {
            List<string> MonthLeaderboard = _DashbaordRepo.GetUsersWithMostLocationsThisMonth();
            return Json(MonthLeaderboard);
        }

        //service to get dates of trips for trips over time graph
        public JsonResult GetDatesOfTrips()
        {
            string ID = User.Claims.ElementAt(0).Value;

            List<string> Dates = _DashbaordRepo.GetDatesOfTrips(ID);
            return Json(Dates);
        }
    }
}