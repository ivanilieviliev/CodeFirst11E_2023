using BusinessLayer;
using DataLayer2;
using System;
using System.Collections.Generic;

namespace TestingLayer1
{
    class Program
    {
        static Shop11JDBContext dbContext;
        static BrandsContext brandsContext;

        static void Main(string[] args)
        {
            try
            {
                dbContext = new Shop11JDBContext();
                brandsContext = new BrandsContext(dbContext);

                //TestBrandContextCreate();
                //TestBrandContextRead();
                //TestBrandContextReadWithInnerJoin();
                //TestBrandContextReadAll();
                //TestBrandContextReadAllWithInnerJoin();
                //TestBrandContextUpdate();
                TestBrandContextDelete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " :(");
            }
            
        }

        static void TestBrandContextCreate()
        {
            Brand brand = new Brand("Dqdo Pesho ET", "pesho60@abv.bg", "032506070", "Sergiqta na Grebnata baza v Plovdiv");
            brandsContext.Create(brand);
            Console.WriteLine("Brand created successfully! :)");
        }

        static void TestBrandContextRead()
        {
            Brand brand = brandsContext.Read(2);

            Console.WriteLine(brand);
        }

        static void TestBrandContextReadWithInnerJoin()
        {
            Brand brand = brandsContext.Read(2, true);

            Console.WriteLine(brand);
        }

        static void TestBrandContextReadAll()
        {
            IEnumerable<Brand> brands = brandsContext.ReadAll();

            foreach (Brand brand in brands)
            {
                Console.WriteLine(brand);
            }
        }

        static void TestBrandContextReadAllWithInnerJoin()
        {
            IEnumerable<Brand> brands = brandsContext.ReadAll(true);

            foreach (Brand brand in brands)
            {
                Console.WriteLine(brand);
            }
        }

        static void TestBrandContextUpdate()
        {
            Brand brandFromDb = brandsContext.Read(3);
            Console.WriteLine("Before: ");
            Console.WriteLine(brandFromDb);

            brandFromDb.Name = "TOshko ot 11J";
            brandsContext.Update(brandFromDb);

            Brand updatedBrandFromDb = brandsContext.Read(3);
            Console.WriteLine("After: ");
            Console.WriteLine(updatedBrandFromDb);
        }

        static void TestBrandContextUpdateWithInnerJoin()
        {
            // Toshko ot 11J klas shte proveri svoqta implementaciq 🏴‍☠️

        }

        static void TestBrandContextDelete()
        {
            Console.Write("Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Brand brandFromDb = brandsContext.Read(id);

            Console.WriteLine("Before: {0}", brandFromDb);
            brandsContext.Delete(id);

            brandFromDb = brandsContext.Read(id);

            if (brandFromDb == null)
            {
                Console.WriteLine($"Brand with Id {id} deleted successfully!");
            }
        }

    }
}
