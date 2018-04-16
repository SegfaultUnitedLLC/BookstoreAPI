using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreAPI.Controllers
{
    [Route("book/[controller]")]
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}