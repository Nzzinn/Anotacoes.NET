using System;
using System.Globalization;
using System.Collections.Generic;

namespace TreinoList
{
    public class ProductManegement
    {
        public List<Product> Products = new List<Product>();

        public ProductManegement()
        {
            
        }
        public ProductManegement(List<Product> products)
        {
            Products = products;
        }
        
        public void CreateProducts()
        {
            Console.Write("Enter the code: ");
            int code = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the name product: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter the price product: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Products.Add(new Product(code, name, price));
            
            Console.WriteLine("Product Add with success!");
        }

        public void UpdateProduct()
        {
            Console.Write("Enter the code product for update: ");
            int findCode = int.Parse(Console.ReadLine());

            Product p = Products.Find(x => x.Code == findCode);

            if (p != null)
            {
                Console.Write("Enter with new name: ");
                p.Name = Console.ReadLine();
                
                Console.Write("Enter with new price: ");
                p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.WriteLine("Product updated with success!");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Enter the code product for remove: ");
            int findCodeDelete = int.Parse(Console.ReadLine());

            Product p = Products.Find(x => x.Code == findCodeDelete);

            if (p != null)
            {
                Products.Remove(p);
            
                Console.WriteLine("Product removed with success!");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        public void ListProducts()
        {
            Console.WriteLine("List all Products: ");
            foreach (Product p in Products)
            {
                Console.WriteLine(p);
            }
        }
    }
}