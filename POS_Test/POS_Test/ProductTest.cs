using System;
using System.Collections.Generic;
using Xunit;
using POS_Terminal;

namespace POS_Test
{
    public class ProductTest
    {
        [Fact]
        public void Instantiation()
        {

            Product prod = new Product();
        }

        [Fact]
        public void AddProductTest()
        {

            Product prod = new Product("Hamburger", "Food", "8000 calories", 17.99);

        }
    }
}
