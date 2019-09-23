﻿using AT.Efs.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Helpers
{
    public class MenuHelper
    {
        public static async Task<List<Menu>> GetDataMenu(WebAtSolutionContext webContext)
        {
            return await webContext.Menu.ToListAsync();
        }
    }
}
