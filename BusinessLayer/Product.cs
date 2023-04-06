using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Product
    {
        [Key]
        public string Barcode { get; set; }

        [Required]
        public string Name { get; set; }

        // Value type => no need for [Required]
        [Range(0, 10000, ErrorMessage = "Quantity must be [0;10000]!")]
        public int Quantity { get; set; }

        [Range(0, 100000, ErrorMessage = "Price must be [0;100000]")]
        public decimal Price { get; set; }

        public DateTime? BestBefore { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        [Required]
        public Brand Brand { get; set; }

        public List<Customer> Customers { get; set; }

        public List<ProductsOrders> Orders { get; set; }

        private Product()
        {
            Customers = new List<Customer>();
            Orders = new List<ProductsOrders>();
        }

        public Product(string barcode, string name, int quantity, decimal price, Brand brand, DateTime? bestBefore = null)
        {
            Barcode = barcode;
            Name = name;
            Quantity = quantity;
            Price = price;
            BestBefore = bestBefore;
            Brand = brand;
            Customers = new List<Customer>();
            Orders = new List<ProductsOrders>();
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
