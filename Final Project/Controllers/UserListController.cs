﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
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
            var UserLists = _ListRepo.GetUserLists();
            foreach (var list in UserLists)
            {
                list.ItemsList = _ListRepo.GetUserListItems(list.ID);
            }

            return View(UserLists);
        }

        [HttpPost]
        public IActionResult Index(UserListModel model)
        {
            //model.Selected = true;
            var UserLists = _ListRepo.GetUserLists();
            foreach (var list in UserLists)
            {
                list.ItemsList = _ListRepo.GetUserListItems(list.ID);
                if (list.ID == model.ID)
                {
                    list.Selected = true;
                }
            }
            return View(UserLists);
        }
    }
}