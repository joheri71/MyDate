using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LinqToSqlTutorials.Contexts;
using LinqToSqlTutorials.Entities;

namespace LinqToSqlTutorials
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // one();
            //two();

            using (NorthwindContext db = new NorthwindContext())
            {
                var result = from i in db.Products
                    where i.CategoryID == 1
                    select i;

                GridView1.DataSource = result.ToList();
                GridView1.DataBind();


            }
            



        }

        private void two()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var result = from i in db.Categories
                    select new
                    {
                        i.CategoryId,
                        i.CategoryName,
                        i.Products
                    };

                CategoryList.DataSource = result.ToList();
                CategoryList.DataBind();
            }
        }

        private void one()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var result = from i in db.Products
                    select new
                    {
                        i.ProductID,
                        i.ProductName,
                        i.Category.CategoryName
                    };

                GridView1.DataSource = result.ToList();
                GridView1.DataBind();
            }
        }
    }
}