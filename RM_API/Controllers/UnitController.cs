using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RM_API.Controllers
{
    public class UnitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
