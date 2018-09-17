
using System;
using System.Collections.Generic;

namespace Core
{

    public class Shoppingcart
    {
        public ICollection<Product> Products { get; set; } = new List<Product>();


    }
}
