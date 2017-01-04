using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toyshop.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public double UnitPrice { get; set; }

        public int Stock { get; set; }

        public bool Discontinued { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int SupplierId { get; set; }

        public string ProductCode { get; set; }
    }
}