using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private ILocationRepository _LocationRepo;
        private RoleManager<IdentityRole> _RoleManager;
        private UserManager<IdentityUser> _UserManager;

        public AccountController(ILocationRepository LocationRepo, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _LocationRepo = LocationRepo;
            _RoleManager = roleManager;
            _UserManager = userManager;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUserToRole(string Email, string RoleName)
        {
            //IdentityRole role = new IdentityRole();
            //role.Name = "Admins";
            //IdentityResult role_result = _RoleManager.CreateAsync(role).Result;

            IdentityUser user = _UserManager.FindByEmailAsync(Email).Result;
            IdentityResult result = _UserManager.AddToRoleAsync(user, RoleName).Result;

            //Check the status of the result
            if (!result.Succeeded)
            {
             //   throw new Exception(result.Errors.Select(e => e.Description).Aggregate((a, b) => a + "," + b));
            }
            return RedirectToAction("Index");
        }
    }
}