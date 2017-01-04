using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toyshop.Contexts
{
    public class NorthwindInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<NorthwindContext>
    {
        protected override void Seed(NorthwindContext context)
        {
            

        }
    }
}