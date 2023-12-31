﻿using System.Globalization;

namespace Aula46 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarToReal(quantia, cotacao);
            
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}