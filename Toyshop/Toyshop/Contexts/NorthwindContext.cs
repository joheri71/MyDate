using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Toyshop.Entities;

namespace Toyshop.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
            : base("NorthwindConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}