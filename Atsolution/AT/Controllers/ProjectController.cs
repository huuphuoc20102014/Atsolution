﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AT.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet("trang-chu")]
        public IActionResult Index()
        {

            return View();
        }
    }
}