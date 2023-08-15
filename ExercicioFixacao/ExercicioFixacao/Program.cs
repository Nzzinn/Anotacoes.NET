using System.Globalization;

namespace ExercicioFixacao
{
    internal class ExercicioFixacao
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos:\n{produto1}, cujo o preço é $ {preco1:f2} \n{produto2}, cujo preço é $ {preco2:f2}\n");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");

            Console.WriteLine($"Medida com oito casas decimais: {medida:f8}\nArredondado (três casas decimais): {medida:f3}");
            Console.WriteLine("Separador decimal invariant culture:" + medida.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}