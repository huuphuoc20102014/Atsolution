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
        public async Task<IActionResult> Index(int? Trang, string id)
        {
            if (Trang == null)
            {
                Trang = 1;
            }
            var students = from s in _context.News.OrderByDescending(p => p.CreatedDate)
                           select s;
            if (id == null)
            {
            }
            else
            {
                students = from s in _context.News.OrderByDescending(p => p.CreatedDate).Where(p => p.FkNewsTypeId == id)
                           select s;
            }

            int pageSize = 3;
            return View(await PaginatedList<News>.CreateAsync(students.AsNoTracking(), Trang ?? 1, pageSize,id));
        }
    }
}