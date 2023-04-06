using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public decimal Price { get; set; }

        [MaxLength(50, ErrorMessage = "Address cannot be more than 50 symbols!")]
        public string Address { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(20)]
        public OrderStatus Status { get; set; }

        [Required]
        public Customer Customer { get; set; }

        public List<ProductsOrders> Products { get; set; }

        private Order()
        {
            Products = new List<ProductsOrders>();
        }

        public Order(string address, Customer customer, List<ProductsOrders> products)
        {
            Address = address;
            Date = DateTime.Now;
            Status = OrderStatus.New;
            Customer = customer;
            Products = products;
        }

    }
}
