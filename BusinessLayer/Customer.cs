using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Customer
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public int? Age { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Telephone { get; set; }

        public List<Product> FavouriteProducts { get; set; }

        private Customer()
        {
            FavouriteProducts = new List<Product>();
        }

        public Customer(string name, string email, string telephone, string address = "", int? age = null)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Address = address;
            Age = age;
            Email = email;
            Telephone = telephone;
            FavouriteProducts = new List<Product>();
        }

    }
}
