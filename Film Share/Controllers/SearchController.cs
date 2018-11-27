﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmShare.Models.Storage;
using FilmShare.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FilmShare.Controllers
{
    public class SearchController : Controller
    {
        private readonly IStorage _storage;

        public SearchController(IStorage storage)
        {
            _storage = storage;
        }

        [Authorize]
        public IActionResult Index(TabViewModel tab)
        {
            if (tab == null)
            {
                tab = new TabViewModel
                {
                    ActiveTab = Tab.Friends
                };
            }

            return View(tab);
        }

        public IActionResult SwitchTabs(string tabname)
        {
            var tab = new TabViewModel();

            switch (tabname) {
                case "Friends":
                    tab.ActiveTab = Tab.Friends;
                    break;
                case "Actors":
                    tab.ActiveTab = Tab.Actors;
                    break;
                case "Films":
                    tab.ActiveTab = Tab.Films;
                    break;
            }

            return RedirectToAction("Index", tab);
        }

        public JsonResult Friends()
        {
            var users = _storage.GetAllProfileModelsWithoutFriends(User.Identity.Name);
            return Json(users);
        }
    }
}