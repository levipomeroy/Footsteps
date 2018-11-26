using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private ILocationRepository _LocationRepo;
        public AccountController(ILocationRepository LocationRepo)
        {
            _LocationRepo = LocationRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                int num = _LocationRepo.GetNumberOfLocationsForUser(User.Claims.ElementAt(0).Value);
                return View(num);
            }
            else
            {
                return View();
            }
        }
    }
}