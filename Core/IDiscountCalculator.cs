using System;

namespace Core
{
    public interface IDiscountCalculator
    {
        
        decimal CalculateDiscount(ShoppingCart shoppingcart);

    }
}