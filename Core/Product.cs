using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsureThat;

namespace Core
{
    public class Product
    {
        public string Name { get; set;}

        public decimal Price { get; set; }

        public Product()
        {   
        }

        public Product(string name, decimal price)
        {
            EnsureArg.IsNotNullOrWhiteSpace(name, "", options => options.WithMessage("The product must have a name."));
            EnsureArg.IsTrue(price > 0.0m, "", options => options.WithMessage("The item must have a price greater then 0."));
            Name = name;
            Price = price;
        }
    }
}
