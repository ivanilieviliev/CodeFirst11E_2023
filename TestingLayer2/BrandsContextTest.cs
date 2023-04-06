using BusinessLayer;
using DataLayer;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer2
{
    [TestFixture]
    public class BrandsContextTest
    {
        private BrandsContext context = new BrandsContext(SetupFixture.dbContext);
        private Brand brand;
        private Product p1, p2;

        [SetUp]
        public void CreateBrand()
        {
            brand = new Brand("Mercedes Benz", "mercedes@gmail.com", "0888999999");
            
            p1 = new Product("USAR9512750", "Mercedes S", 1, 250000, brand, DateTime.Now.AddYears(10));
            p2 = new Product("USAR9090873", "Mercedes E", 1, 150000, brand, DateTime.Now.AddYears(3));

            brand.Products.Add(p1);
            brand.Products.Add(p2);

            context.Create(brand);
        }

        [TearDown]
        public void DropBrand()
        {
            foreach (Brand item in SetupFixture.dbContext.Brands)
            {
                SetupFixture.dbContext.Brands.Remove(item);    
            }

            SetupFixture.dbContext.SaveChanges();
        }

        [Test]
        public void Create()
        {
            // Arrange
            Brand newBrand = new Brand("Honda", "honda@gmail.com", "0888777777");

            // Act
            int brandsBefore = SetupFixture.dbContext.Brands.Count();
            context.Create(newBrand);

            // Assert
            int brandsAfter = SetupFixture.dbContext.Brands.Count();
            Assert.IsTrue(brandsBefore + 1 == brandsAfter, "Create() does not work!");
        }

        [Test]
        public void Read()
        {
            Brand readBrand = context.Read(brand.Id);

            Assert.AreEqual(brand, readBrand, "Read does not return the same object!");
        }

        [Test]
        public void ReadWithNavigationalProperties()
        {
            Brand readBrand = context.Read(brand.Id, true);

            Assert.That(readBrand.Products.Contains(p1) && readBrand.Products.Contains(p2), "P1 and P2 is not in the Products list!");
            //Assert.IsNotNull(readBrand.Products.FirstOrDefault(p => p.Barcode == p1.Barcode), "P1 is not in the Products list!");
        }

        [Test]
        public void ReadAll()
        {
            List<Brand> brands = (List<Brand>)context.ReadAll();

            Assert.That(brands.Count != 0, "ReadAll() does not return brands!");
        }

        [Test]
        public void Update()
        {
            Brand changedBrand = context.Read(brand.Id);

            changedBrand.Name = "Updated " + brand.Name;
            changedBrand.Email = "marti@gmail.com";

            context.Update(changedBrand);

            Assert.AreEqual(changedBrand, brand, "Update() does not work!");
        }

        [Test]
        public void Delete()
        {
            int brandsBefore = SetupFixture.dbContext.Brands.Count();

            context.Delete(brand.Id);
            int brandsAfter = SetupFixture.dbContext.Brands.Count();

            Assert.IsTrue(brandsBefore - 1 == brandsAfter, "Delete() does not work! 👎🏻");
        }

        //[Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }
    }
}
