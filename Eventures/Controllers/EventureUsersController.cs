using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.App.Controllers
{
    public class EventureUsersController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
