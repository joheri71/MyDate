using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyDate.Models;

namespace MyDate
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Users> Users { get; set; }
    }
}