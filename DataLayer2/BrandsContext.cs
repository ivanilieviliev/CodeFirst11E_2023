using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer2
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
                // string name, string email, string phone, string address = null

                string query = "insert into dbo.Brands(name, email, phone, address) values (@name, @email, @phone, @address);";
                SqlParameter name = new SqlParameter("name", item.Name);
                SqlParameter email = new ("email", item.Email);
                SqlParameter phone = new ("phone", item.Phone);
                SqlParameter address = new ("address", item.Address);

                dbContext.CreateCommand(query);
                dbContext.ExecuteNonQuery(name, email, phone, address);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbContext.CloseConnection();
            }
        }

        public Brand Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                string query;
                SqlParameter id = new SqlParameter("id", key);
                
                if (useNavigationalProperties)
                {
                    query = "select b.id, b.name, b.email, b.phone, b.address, p.barcode, p.name, p.quantity, p.price, p.bestBefore" +
                        " from dbo.Brands as b" +
                        " inner join dbo.Products as p" +
                        " on b.id = p.brandId" +
                        " where b.id = @id";
                }
                else
                {
                    query = "select * from dbo.Brands where id = @id";    
                }
                
                dbContext.CreateCommand(query);
                SqlDataReader result = dbContext.ExecuteReader(id);
                
                if (useNavigationalProperties)
                {
                    Brand brand = null;
                    List<Product> products = new List<Product>();
                    while (result.Read())
                    {
                        if (brand == null)
                        {
                            brand = new Brand(Convert.ToInt32(result[0]), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString());
                        }

                        DateTime? dateTime = null;
                        if (result[9] != DBNull.Value)
                        {
                            dateTime = Convert.ToDateTime(result[9]);
                        }

                        Product p = new Product(result[5].ToString(), result[6].ToString(), Convert.ToInt32(result[7]), Convert.ToDecimal(result[8]), brand, dateTime);
                        products.Add(p);
                    }

                    brand.Products = products;
                    return brand;
                }
                else
                {
                    result.Read();
                    return new Brand(Convert.ToInt32(result["id"]), result["name"].ToString(), result["email"].ToString(), result["phone"].ToString(), result["address"].ToString());
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbContext.CloseConnection();
            }
        }

        public IEnumerable<Brand> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                string query;
                if (useNavigationalProperties)
                {
                    query = "select b.id, b.name, b.email, b.phone, b.address, p.barcode, p.name, p.quantity, p.price, p.bestBefore" +
                        " from dbo.Brands as b" +
                        " inner join dbo.Products as p" +
                        " on b.id = p.brandId";
                }
                else
                {
                    query = "select * from dbo.Brands";
                }

                dbContext.CreateCommand(query);
                SqlDataReader result = dbContext.ExecuteReader();

                List<Brand> brands = new List<Brand>();

                if (useNavigationalProperties)
                {
                    Brand lastBrand = null, currentBrand = null;
                    List<Product> products = new List<Product>();
                    while (result.Read())
                    {
                        currentBrand = new Brand(Convert.ToInt32(result[0]), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString());

                        if (lastBrand == null)
                        {
                            lastBrand = new Brand(Convert.ToInt32(result[0]), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString());
                        }
                        else
                        {
                            if (currentBrand.Id != lastBrand.Id)
                            {
                                lastBrand.Products = products;
                                brands.Add(lastBrand);
                                products = new List<Product>();
                                lastBrand = new Brand(Convert.ToInt32(result[0]), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString());
                            }
                        }

                        DateTime? dateTime = null;
                        if (result[9] != DBNull.Value)
                        {
                            dateTime = Convert.ToDateTime(result[9]);
                        }

                        Product p = new Product(result[5].ToString(), result[6].ToString(), Convert.ToInt32(result[7]), Convert.ToDecimal(result[8]), currentBrand, dateTime);
                        products.Add(p);
                    }

                    lastBrand.Products = products;
                    brands.Add(lastBrand);
                }
                else
                {
                    while (result.Read())
                    {
                        Brand currentBrand = new Brand(result["name"].ToString(), result["email"].ToString(), result["phone"].ToString(), result["address"].ToString());
                        brands.Add(currentBrand);
                    }
                }

                return brands;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbContext.CloseConnection();
            }
        }

        public void Update(Brand item, bool useNavigationalProperties = false)
        {
            try
            {
                if (useNavigationalProperties)
                {
                    // Toshko ot 11J klas shte go implementira 🏴‍☠️
                    // Da se promenqt produktite na proizvoditelq
                }

                string query = "update dbo.Brands" +
                " set name = @name, email = @email, phone = @phone, address = @address" +
                " where id = @id;";

                SqlParameter name = new SqlParameter("name", item.Name);
                SqlParameter email = new SqlParameter("email", item.Email);
                SqlParameter phone = new SqlParameter("phone", item.Phone);
                SqlParameter address = new SqlParameter("address", item.Address);
                SqlParameter id = new SqlParameter("id", item.Id);

                dbContext.CreateCommand(query);
                dbContext.ExecuteNonQuery(name, email, phone, address, id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbContext.CloseConnection();
            }
        }

        public void Delete(int key)
        {
            try
            {
                string query = "delete from dbo.Brands where id = @id";
                SqlParameter id = new SqlParameter("id", key);

                dbContext.CreateCommand(query);
                dbContext.ExecuteNonQuery(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbContext.CloseConnection();
            }
                                 
        }
    }
}
