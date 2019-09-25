using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AT.Controllers
{
    public class GsControllerBase <T> : Controller
    {
        protected readonly WebAtSolutionContext _webContext;

        public GsControllerBase(WebAtSolutionContext webContext)
        {
            _webContext = webContext;
        }

        protected void HandleError(Exception ex)
        {

        }
    }
}