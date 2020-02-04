using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
