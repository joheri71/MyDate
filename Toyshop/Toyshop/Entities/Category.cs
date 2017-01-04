using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toyshop.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }

    }
}