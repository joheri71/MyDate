using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LinqToSqlTutorials.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public bool Discontinued { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }


    }
}