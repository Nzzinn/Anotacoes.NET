using System;
using System.Globalization;

namespace Aula70
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] p = new Product[n];
            
            for(int i= 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Product { Name = name, Price = price };
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += p[i].Price;
            }

            double average = sum / n;
            
            Console.WriteLine("AVERAGE PRICE: " + average.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}