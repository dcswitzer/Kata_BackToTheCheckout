using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Checkout
    {
        public ICollection<ShoppingCart> ShoppingCarts = new List<ShoppingCart>();
        public decimal Total { get; set; }
        public decimal DiscountTotal { get; set; }

        public ICollection<DiscountRule> DiscountRules = new List<DiscountRule>();

        public Checkout()
        {
            
        }

    }
}
