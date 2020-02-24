using System;
using System.Collections.Generic;
using Xunit;
using POS_Terminal;

namespace POS_Test
{
    public class InventoryTest
    {
        [Fact]
        public void Instantiation()
        {

            Inventory inv = new Inventory();
        }

        [Fact]
        public void AddItemTest()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            Inventory inv = new Inventory();
            inventory.Add("Hamburger", 120);
            Assert.Equal(inventory, inv.AddProduct("Hamburger", 120));
        }

        [Fact]
        public void RemoveItemTest()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            Inventory inv = new Inventory();
            inventory.Add("Hamburger", 119);

            //inventory.Remove("Hamburger");
            inv.AddProduct("Hamburger", 120);
            Assert.Equal(inventory, inv.RemoveProduct("Hamburger", 1));
        }
    }
}
