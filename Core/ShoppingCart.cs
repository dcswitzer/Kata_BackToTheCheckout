
using System;
using System.Collections.Generic;

namespace Core
{

    public class ShoppingCart
    {
        public ICollection<Product> Products { get; set; } = new List<Product>();

        public ShoppingCart()
        {

        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
