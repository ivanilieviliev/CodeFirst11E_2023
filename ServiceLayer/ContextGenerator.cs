using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ContextGenerator
    {
        private static Shop11JDBContext dbContext;
        private static BrandsContext brandsContext;
        private static ProductsContext productsContext;

        public static Shop11JDBContext GetDbContext()
        {
            if (dbContext == null)
            {
                SetDbContext();
            }
            return dbContext;
        }

        public static void SetDbContext()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
            
            dbContext = new Shop11JDBContext();
        }

        public static BrandsContext GetBrandsContext()
        {
            if (brandsContext == null)
            {
                SetBrandsContext();
            }

            return brandsContext;
        }

        public static void SetBrandsContext()
        {
            brandsContext = new BrandsContext(GetDbContext());
        }

        public static ProductsContext GetProductsContext()
        {
            if (productsContext == null)
            {
                SetProductsContext();
            }

            return productsContext;
        }

        public static void SetProductsContext()
        {
            productsContext = new ProductsContext(GetDbContext());
        }

    }
}
