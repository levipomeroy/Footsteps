using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace Final_Project.Controllers
{
    [Authorize]
    //[InitializeSimpleMembership]
    public class ContactController : Controller
    {
        private IContactRepository _ContactRepo;

        public ContactController(IContactRepository ContactRepo)
        {
            _ContactRepo = ContactRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                //if (User.IsInRole("Admins"))
                //{
                //    ContactModel model = new ContactModel();
                //    return View("AdminContact", model);
                //}
                //else
                //{
                    ContactModel model = new ContactModel();
                    return View(model);
                //}
            }
            return View();
        }

        [Authorize(Roles = "Admins")]
        [HttpGet]
        public IActionResult AdminContact()
        {
            var Messages = _ContactRepo.GetList();

            //ContactModel model = new ContactModel();
            return View(Messages);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactModel model)
        {
            //send email to me w/ user email who submitted message - future addition

            //store in db
            if (ModelState.IsValid && User.Identity.IsAuthenticated)
            {
                ModelState.Clear();
                _ContactRepo.Insert(model);
            }
            return View();
        }
    }
}