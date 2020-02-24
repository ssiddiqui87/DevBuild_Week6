using System;
using System.Collections.Generic;
using Xunit;
using POS_Terminal;

namespace POS_Test
{
    public class ReceiptTest
    {
        [Fact]
        public void Instantiation()
        {

            Receipt rec = new Receipt();
        }

        [Fact]
        public void GrandTotalTest()
        {
            double subTotal = 1.5;
            double tax = 0.25;
            double grandTotal = subTotal + tax;

            Assert.Equal(grandTotal, Receipt.GetGrandTotal(subTotal, tax)); ;
        }
        [Fact]
        public void TaxTest()
        {
            double subTotal = 1.5;
            double tax = subTotal * 0.06;
            

            Assert.Equal(tax, Receipt.GetTax(subTotal)); ;
        }
        [Fact]
        public void SubTotalTest()
        {
            double subTotal = 1.5;
            


            Assert.Equal(subTotal, Receipt.GetSubTotal(subTotal)); ;
        }
    }
}
