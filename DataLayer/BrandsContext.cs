using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BrandsContext : IDb<Brand, int>
    {
        private readonly Shop11JDBContext dbContext;

        public BrandsContext(Shop11JDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Brand item)
        {
            try
            {
                dbContext.Brands.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public Brand Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                if (useNavigationalProperties)
                {
                    return dbContext.Brands.Include(b => b.Products).FirstOrDefault(b => b.Id == key);
                }
                else
                {
                    return dbContext.Brands.Find(key);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Brand> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Brand> query = dbContext.Brands;

                if (useNavigationalProperties)
                {
                    query = query.Include(b => b.Products);
                }

                return query.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Brand item, bool useNavigationalProperties = false)
        {
            try
            {
                Brand brandFromDb = Read(item.Id, useNavigationalProperties);

                if (brandFromDb == null)
                {
                    Create(item);
                    return;
                }

                brandFromDb.Name = item.Name;
                brandFromDb.Phone = item.Phone;
                brandFromDb.Email = item.Email;
                brandFromDb.Address = item.Address;

                if (useNavigationalProperties)
                {
                    List<Product> products = new List<Product>();

                    foreach (Product p in item.Products)
                    {
                        Product productFromDb = dbContext.Products.Find(p.Barcode);

                        if (productFromDb != null)
                        {
                            products.Add(productFromDb);
                        }
                        else
                        {
                            products.Add(p);
                        }

                    }

                    brandFromDb.Products = products;
                }

                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Brand brandFromDb = Read(key);

                if (brandFromDb != null)
                {
                    dbContext.Brands.Remove(brandFromDb);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("Brand with that key does not exist!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
