using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Checkout
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal TotalPrice { get; set; }

        public Checkout()
        {
            
        }

        public void CalculateRegularPrice(ShoppingCart shoppingcart)
        {
            foreach (Product p in shoppingcart.Products)
            {
                RegularPrice += p.Price;
            }
        }

    }
}
