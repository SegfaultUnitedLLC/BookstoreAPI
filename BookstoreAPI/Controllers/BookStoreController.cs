﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreAPI.Controllers
{
    public class BookStoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}