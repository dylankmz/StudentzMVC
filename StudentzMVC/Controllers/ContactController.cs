using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentz.Controllers
{
    public class ContactController : Controller
    {
        [Authorize(Roles = "User, Admin, Manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
