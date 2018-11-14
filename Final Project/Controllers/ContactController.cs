using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ContactModel model = new ContactModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            //send email to me and store in db
            return View();
        }
    }
}