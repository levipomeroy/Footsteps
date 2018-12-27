using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [Authorize]
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
                return View(new ContactModel());
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactModel model)
        {
            //maybe send email to me w/ user email who submitted message - future addition

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