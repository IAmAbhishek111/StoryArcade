﻿using Bulky.DataAccess.Repository.IRepository;
using Bulky.DataAccess.Data;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bulky.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {

        private ApplicationDbContext _db;

        //That way, whatever DB context we get here, we will pass to the repository and the error goes away.
        public ApplicationUserRepository(ApplicationDbContext db) : base(db) 
        {

            _db = db;

        }
    }
}
