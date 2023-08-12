using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppEncapsulation.Model
{
    internal class Product
    {
        private int id;
        private string name;
        private double price;
        private double discountPercentage;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double DiscountPercentage
        {
            get { return discountPercentage; }
            set { discountPercentage = value; }
        }

        public Product(int id, string name, double price, double discountPercentage)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        public double CalculateDiscountedPrice()
        {
            return Price - (Price * (DiscountPercentage / 100));
        }

        public string ShowProductDetails()
        {
            return $"ID: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Actual Price: {Price}\n" +
                   $"Discount Percentage: {DiscountPercentage}\n" +
                   $"Discounted Price: {CalculateDiscountedPrice()}";
        }

    }
}
