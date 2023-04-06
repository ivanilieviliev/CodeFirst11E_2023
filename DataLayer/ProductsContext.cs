using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductsContext : IDb<Product, string>
    {
        private readonly Shop11JDBContext dbContext;

        public ProductsContext(Shop11JDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Product item)
        {
            try
            {
                Brand brandFromDb = dbContext.Brands.Find(item.BrandId);

                if (brandFromDb != null)
                {
                    item.Brand = brandFromDb;
                }

                dbContext.Products.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Product Read(string key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Product> query = dbContext.Products;

                if (useNavigationalProperties)
                {
                    query = query.Include(p => p.Brand)
                        .Include(p => p.Customers)
                        .Include(p => p.Orders);
                }

                return query.FirstOrDefault(p => p.Barcode == key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Product> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Product> query = dbContext.Products;

                if (useNavigationalProperties)
                {
                    query = query.Include(p => p.Brand)
                        .Include(p => p.Customers)
                        .Include(p => p.Orders);
                }

                return query.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Product item, bool useNavigationalProperties = false)
        {
            try
            {
                Product productFromDb = Read(item.Barcode, useNavigationalProperties);

                if (productFromDb == null)
                {
                    Create(item);
                    return;
                }

                productFromDb.BestBefore = item.BestBefore;
                productFromDb.Name = item.Name;
                productFromDb.Price = item.Price;
                productFromDb.Quantity = item.Quantity;

                if (useNavigationalProperties)
                {
                    Brand brandFromDb = dbContext.Brands.Find(item.BrandId);

                    if (brandFromDb != null)
                    {
                        productFromDb.Brand = brandFromDb;
                    }
                    else
                    {
                        //Mariela: Chakaite...
                        productFromDb.Brand = item.Brand;
                    }

                    // Toshe, ne dobavihme logika za Customers, zashtoto v CustomersContext.Update()
                    // potrebitelqt shte reshava koi product mu e liybim!
                    // 🙌😎🎂✔🎃🚗⛄

                    List<ProductsOrders> productsOrders = new List<ProductsOrders>();

                    foreach (ProductsOrders po in item.Orders)
                    {
                        ProductsOrders poFromDb = dbContext.ProductsOrders.Find(po.ProductBarcode, po.OrderId);

                        if (poFromDb != null)
                        {
                            productsOrders.Add(poFromDb);
                        }
                        else
                        {
                            productsOrders.Add(po);
                        }
                    }

                    //Mariela: moment, samo sega....
                    productFromDb.Orders = productsOrders;
                }

                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(string key)
        {
            try
            {
                Product productFromDb = Read(key);

                if (productFromDb != null)
                {
                    dbContext.Products.Remove(productFromDb);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("Product with that barcode does not exist!");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
