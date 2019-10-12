﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Data
{
    public class DBInitializer
    {
        private DBContext _dbContext;
        private UserManager<IdentityUser> _userManager;

        public DBInitializer(DBContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task seedDatabase()
        {
            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {

            }
        }
    }
}
