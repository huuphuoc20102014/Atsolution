using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AT.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet("tin-tuc")]
        public IActionResult Index()
        {
            return View();
        }
    }
}