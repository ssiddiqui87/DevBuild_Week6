using System;
using System.Collections.Generic;
using System.Text;

namespace POS_Terminal
{
    public class Receipt
    {
        private Dictionary<string, int> rec = new Dictionary<string, int>();
        private string item;
        private int quantity;
        private double subTotal;
        private double tax;
        private double grandTotal;

        public Receipt()
        {
            this.rec = new Dictionary<string, int>();
        }
        public Receipt(string item, int quantity, double subTotal, double tax, double grandTotal)
        {
            this.item = item;
            this.quantity = quantity;
            this.subTotal = subTotal;
            this.tax = tax;
            this.grandTotal = grandTotal;
        }

        public string Item { get => item; set => item = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }
        public double Tax { get => tax; set => tax = value; }
        public double GrandTotal { get => grandTotal; set => grandTotal = value; }
        public Dictionary<string, int> Rec { get => rec; set => rec = value; }

        public static double GetGrandTotal(double subTotal, double tax)
        {
            return subTotal + tax;
        }

        public static double GetTax(double subTotal)
        {
            double tax = subTotal * 0.06;
            return tax;
        }

        public static double GetSubTotal(double subTotal)
        {
          
            return subTotal;
        }

    }
}
