using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App_1.Models;

namespace App_1.Data
{
    public class App_1Context : DbContext
    {
        public App_1Context (DbContextOptions<App_1Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<App_1.Models.Employees> Employees { get; set; }
    }
}
