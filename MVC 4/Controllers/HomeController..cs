﻿using Microsoft.AspNetCore.Mvc;

namespace MVC_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
