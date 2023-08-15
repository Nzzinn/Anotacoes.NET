using System;
using System.Globalization;

namespace TreinoList
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int code, string name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Code: " + Code + "\nName: " + Name + "\nPrice: " +
                   Price.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}