using System;
using System.Collections.Generic;
using System.Text;

namespace POS_Terminal
{
    public class Product
    {
        private string name;
        private string category;
        private string description;
        private double price;

        public Product(string name, string category, string description, double price)
        {
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Price = price;
        }

        public Product()
        {
        }

        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return $"Item: {name}\nCategory: {category}\nCalories: {description}\nPrice: {price}";
        }
    }
}
