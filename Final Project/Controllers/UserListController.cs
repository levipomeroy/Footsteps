using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [Authorize]
    public class UserListController : Controller
    {
        IListRepository _ListRepo;
        public UserListController(IListRepository ListRepo)
        {
            _ListRepo = ListRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                string ID = User.Claims.ElementAt(0).Value;
                var UserLists = _ListRepo.GetUserLists(ID);

                return View(UserLists);
            }
            else
            {
                return View();
            }
        }

        //Service to add list
        [HttpPost]
        public void AddList(string Name)
        {
            if (User.Identity.IsAuthenticated)
            {
                string ID = User.Claims.ElementAt(0).Value;
                _ListRepo.AddList(Name, ID);
            }
        }

        //Service to get list items for a specific list
        [HttpPost]
        public JsonResult GetListItemsForList(int ID)
        {
            if (User.Identity.IsAuthenticated)
            {
                string UserID = User.Claims.ElementAt(0).Value;

                var ItemList = _ListRepo.GetUserListItems(ID, UserID);
                return Json(ItemList);
            }
            else
            {
                return null;
            }
        }

        //Service to add a new list item to a list
        [HttpPost]
        public void AddListItem(int ID, string Item)
        {
            if (User.Identity.IsAuthenticated)
            {
                string UserID = User.Claims.ElementAt(0).Value;
                _ListRepo.AddListItem(ID, Item, UserID);
            }
        }

    }
}