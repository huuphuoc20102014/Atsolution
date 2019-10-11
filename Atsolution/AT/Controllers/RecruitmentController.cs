using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AT.Controllers
{
    public class RecruitmentController : Controller
    {
        WebAtSolutionContext _context = new WebAtSolutionContext();
        [HttpGet("tuyen-dung")]
        public async Task<IActionResult> Index(int? pageNumber,string id)
        {
            if (pageNumber == null)
            {
                pageNumber = 1;
            }

            var students = from s in _context.News.OrderByDescending(p => p.CreatedDate)
                           select s;

            int pageSize = 3;
            return View(await PaginatedList<News>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize,id));
        }
    }
}
