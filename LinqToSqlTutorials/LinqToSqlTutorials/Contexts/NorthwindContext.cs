using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LinqToSqlTutorials.Entities;

namespace LinqToSqlTutorials.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
            :base
                ("NorthwindConnectionString")
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}