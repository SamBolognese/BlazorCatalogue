using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorExcercise.Data
{
    public class Product
    {
        private string name;
        private double price;
        
        [Required]
        [StringLength(20, ErrorMessage = "The name cannot be longer than 20 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Required]
        [Range(0, 9999)]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return $"Name: {Name} Price: {Price}";
        }
    }
}
