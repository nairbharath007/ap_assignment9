using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Product
    {
        public int id;
        public string name;
        public double price;
        public double discountPercentage;

        public Product(int idValue, string nameValue, double priceValue, double discountValue)
        {
            id = idValue;
            name = nameValue;
            price = priceValue;
            discountPercentage = discountValue;
        }

        public double CalculateDiscountedPrice()
        {
            return price - (price * (discountPercentage / 100));
        }

        public string ShowProductDetails()
        {
            return $"ID: {id}\nName: {name}\nActual Price: {price}\nDiscounted Price: {CalculateDiscountedPrice()}";
        }
    }
}
