﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace doremi.Controllers
{
    [Authorize(Roles = Pages.MainMenu.VendorType.RoleName)]
    public class VendorTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}