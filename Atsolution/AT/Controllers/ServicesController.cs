using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using AT.Models;
using Microsoft.AspNetCore.Mvc;

namespace AT.Controllers
{
    public class ServicesController : Controller
    {
        [HttpGet("dich-vu")]
        public IActionResult Index()
        {
            return View();
        }
    }
}