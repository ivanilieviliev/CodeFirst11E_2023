using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        
        [MaxLength(30, ErrorMessage = "Name cannot be more than 30 symbols!")]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Email cannot be more than 30 symbols!")]
        public string Email { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Telephone cannot be more than 20 symbols!")]
        public string Phone { get; set; }

        public List<Product> Products { get; set; }

        private Brand()
        {
            Products = new List<Product>();
        }

        public Brand(int id, string name, string email, string phone, string address = "")
            : this(name, email, phone, address)
        {
            Id = id;
        }

        public Brand(string name, string email, string phone, string address = "")
        {
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
            Products = new List<Product>();
        }

        public override string ToString()
        {
            return $"{Name} {Email} {Phone} {Address}:" +
                string.Join(", ", Products);
        }
    }
}
