using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Shouldly.ShouldlyExtensionMethods;

namespace Core.Tests
{

    public class ProductTests
    {
        [TestClass]
        public class Constructor
        {

            //Arrange
            //Act
            //Assert
            [TestMethod]
            public void ConstructorProduct_NoParam_ShouldCreateEmptyProduct()
            {
                //Arrange
                var product = new Product();

                //Act

                //Assert
                product.Name.ShouldBe(null);
                product.Price.ShouldBe(0);
            }

            [TestMethod]
            public void ConstructorProduct_NoNameParam_ShouldThrowException()
            {

                //Arrange

                //Act

                //Assert
                Should.Throw<ArgumentException>(() => new Product("", 1.0m)).Message.ShouldBe("The product must have a name.");
            }

            [TestMethod]
            public void ConstructorProduct_PriceEqualOrLessThenZero_ShouldThrowException()
            {

                //Arrange

                //Act

                //Assert
                Should.Throw<ArgumentException>(() => new Product("A", 0.0m)).Message.ShouldBe("The item must have a price greater then 0.");
                Should.Throw<ArgumentException>(() => new Product("A", -1.0m)).Message.ShouldBe("The item must have a price greater then 0.");
            }

            [TestMethod]
            public void ConstructorProduct_WithNameAndPrice_ShouldCreateProduct()
            {

                //Arrange
                var product = new Product("A", 1.0m);

                //Act

                //Assert
                product.Name.ShouldBe("A");
                product.Price.ShouldBe(1.0m);
               }

        }
    }
}
