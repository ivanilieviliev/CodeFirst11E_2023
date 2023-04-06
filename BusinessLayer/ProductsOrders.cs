using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductsOrders
    {
        [ForeignKey("Product")]
        public string ProductBarcode { get; set; }

        //[ForeignKey("Order")] => Look in OnModelCreating() in ShopDbContext, DataLayer!
        public int OrderId { get; set; }

        public int Quantity { get; set; }

        public Product Product { get; set; }

        public Order Order { get; set; }

        private ProductsOrders()
        {

        }

        public ProductsOrders(string barcode, int id, int quantity)
        {
            ProductBarcode = barcode;
            OrderId = id;
            Quantity = quantity;
        }
    }
}
