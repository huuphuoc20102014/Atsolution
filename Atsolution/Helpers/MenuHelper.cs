using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atsolution.Efs.Entities;
using Microsoft.EntityFrameworkCore;

namespace Atsolution.Helpers
{
    public class MenuHelper
    {
        public static async Task<List<Menu>> GetDataMenu(WebAtSolutionContext webContext)
        {
            return await webContext.Menu.ToListAsync();
        }
    }
}
