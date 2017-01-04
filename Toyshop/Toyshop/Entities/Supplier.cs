using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Toyshop.Entities
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public List<Product> Products { get; set; }

    }
}