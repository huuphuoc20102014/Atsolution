using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using System.Web;
using AT.Models;
using Microsoft.EntityFrameworkCore;

namespace AT.Controllers
{
    public class BlogController : Controller
    {
        WebAtSolutionContext _context = new WebAtSolutionContext();
        [HttpGet("tin-tuc")]
        public async Task<IActionResult> Index(int? pageNumber)
        {
            if (pageNumber == null)
            {
                pageNumber = 1;
            }

            var students = from s in _context.News.OrderByDescending(p => p.CreatedDate)
                           select s;

            int pageSize = 3;
            return View(await PaginatedList<News>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
    }
}