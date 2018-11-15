using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
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
            ContactModel model = new ContactModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactModel model)
        {
            //send email to me 

            //store in db
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                _ContactRepo.Insert(model);
            }
            return View();
        }
    }
}