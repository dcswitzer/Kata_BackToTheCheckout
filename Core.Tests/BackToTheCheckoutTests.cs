using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Shouldly.ShouldlyExtensionMethods;

//Arrange
//Act
//Assert

namespace Core.Tests
{

    public class BackToTheCheckoutTests
    {
        [TestClass]
        public class ProductConstructor
        {


            [TestMethod]
            public void ProductConstructor_NoParam_ShouldCreateEmptyProduct()
            {
                //Arrange
                var product = new Product();

                //Act

                //Assert
                product.Name.ShouldBe(null);
                product.Price.ShouldBe(0);
            }

            [TestMethod]
            public void ProductConstructor_NoNameParam_ShouldThrowException()
            {

                //Arrange

                //Act

                //Assert
                Should.Throw<ArgumentException>(() => new Product("", 1.0m)).Message.ShouldBe("The product must have a name.");
            }

            [TestMethod]
            public void ProductConstructor_PriceEqualOrLessThenZero_ShouldThrowException()
            {

                //Arrange

                //Act

                //Assert
                Should.Throw<ArgumentException>(() => new Product("A", 0.0m)).Message.ShouldBe("The item must have a price greater then 0.");
                Should.Throw<ArgumentException>(() => new Product("A", -1.0m)).Message.ShouldBe("The item must have a price greater then 0.");
            }

            [TestMethod]
            public void ProductConstructor_WithNameAndPrice_ShouldCreateProduct()
            {

                //Arrange
                var product = new Product("A", 1.0m);

                //Act

                //Assert
                product.Name.ShouldBe("A");
                product.Price.ShouldBe(1.0m);
               }

        }

        [TestClass]
        public class ShoppingCartConstructorTest
        {
            [TestMethod]
            public void ShoppingCartConstructor_NoParam_ShouldCreateEmtpyShoppingCart()
            {
                //Arrange
                var shoppingCart = new ShoppingCart();

                //Act

                //Assert
                shoppingCart.Products.Count.ShouldBe(0);

            }
        }

        [TestClass]
        public class AddProductToShoppingCart
        {
            [TestMethod]
            public void AddProductToShoppingCart_AddProductToShoppingCart_ShouldAddProduct()
            {
                //Arrange
                var shoppingcart = new ShoppingCart();
                var product =  new Product("A", 1.0m);           

                //Act
                shoppingcart.AddProduct(product);

                //Assert
                shoppingcart.Products.Count.ShouldBe(1);
                shoppingcart.Products.First().Name.ShouldBe("A");
                shoppingcart.Products.First().Price.ShouldBe(1.0m);
            }

            [TestMethod]
            public void AddProductToShoppingCart_AddMultipleProductsToShoppingCart_ShouldAddAllProducts()
            {
                //Arrange
                var shoppingcart = new ShoppingCart();
                var product = new Product("A", 1.0m);
                var product1 = new Product("B", 2.0m);
                var product2 = new Product("C", 1.5m);

                //Act
                shoppingcart.AddProduct(product);
                shoppingcart.AddProduct(product1);
                shoppingcart.AddProduct(product2);

                //Assert
                shoppingcart.Products.Count.ShouldBe(3);
                shoppingcart.Products.First().Name.ShouldBe("A");
                shoppingcart.Products.First().Price.ShouldBe(1.0m);
                shoppingcart.Products.Skip(1).First().Name.ShouldBe("B");
                shoppingcart.Products.Skip(1).First().Price.ShouldBe(2.0m);
                shoppingcart.Products.Skip(2).First().Name.ShouldBe("C");
                shoppingcart.Products.Skip(2).First().Price.ShouldBe(1.5m);

            }
        }
    }
}
