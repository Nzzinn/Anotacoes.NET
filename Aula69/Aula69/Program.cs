using System;
using System.Globalization;

namespace Aula69
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] v = new double [n];

            for (int i = 0; i < n; i++)
            {
                v[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += v[i];
            }

            double media = soma / n;

            Console.WriteLine("AVERAGE HEIGHT: " + media.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}