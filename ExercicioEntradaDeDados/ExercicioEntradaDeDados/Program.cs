using System.Globalization;

namespace ExercicioEntradaDeDados
{
    internal class ExercicioEntradaDeDados
    {
        static void Main(string[] args)
        {
            //Exercicio 1:
            //Console.WriteLine("Informe um número: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe outro número: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"SOMA: {num1 + num2}");

            //Exercicio 2:
            //Console.WriteLine("Informe o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double area = 3.14159 * raio * raio;

            //Console.WriteLine($"A= {area:f4}", CultureInfo.InvariantCulture);

            //Exercicio 3:
            //Console.WriteLine("Informe 4 números inteiros (na mesma linha):");
            //string[] v = Console.ReadLine().Split(' ');

            //int num1 = int.Parse(v[0]);
            //int num2 = int.Parse(v[1]);
            //int num3 = int.Parse(v[2]);
            //int num4 = int.Parse(v[3]);

            //int diferenca = (num1 * num2 - num3 * num4);

            //Console.WriteLine(diferenca);

            //Exercicio 4:
            //Console.WriteLine("Informe o ID do funcionário: ");
            //int id = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe as horas trabalhadas pelo usuário: ");
            //int horasTrabalhadas = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor recebido por hora: ");
            //double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double salario = horasTrabalhadas * valorPorHora;

            //Console.WriteLine($"NUMBER = {id} \nSALARY = U${salario:f2}", CultureInfo.InvariantCulture);

            //Exercicio 5:
            //Console.WriteLine("Informe o código da primeira peça, o numero de peças e o valor unitário respectivamente(na mesma linha): ");
            //string[] v1 = Console.ReadLine().Split(' ');

            //Console.WriteLine("Informe o código da segunda peça, o numero de peças e o valor unitário respectivamente(na mesma linha): ");
            //string[] v2 = Console.ReadLine().Split(' ');

            //int idPeca1 = int.Parse(v1[0]);
            //int numPecas1 = int.Parse(v1[1]);
            //double valorUnitarioPeca1 = double.Parse(v1[2], CultureInfo.InvariantCulture);

            //int idPeca2 = int.Parse(v2[0]);
            //int numPecas2 = int.Parse(v2[1]);
            //double valorUnitarioPeca2 = double.Parse(v2[2], CultureInfo.InvariantCulture);

            //double valorPorQtdPecas1 = numPecas1 * valorUnitarioPeca1;
            //double valorPorQtdPecas2 = numPecas2 * valorUnitarioPeca2;

            //double total = valorPorQtdPecas1 + valorPorQtdPecas2;

            //Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("f2", CultureInfo.InvariantCulture));

            //Exercicio 6:
            Console.WriteLine("Entre com 3 números com ponto flutuante (na mesma linha): ");
            string[] v = Console.ReadLine().Split(' ');

            double a = double.Parse(v[0], CultureInfo.InvariantCulture);
            double b = double.Parse(v[1], CultureInfo.InvariantCulture);
            double c = double.Parse(v[2], CultureInfo.InvariantCulture);

            double areaTriangulo = a * c / 2;
            double areaCirculo = 3.14159 * (c * c);
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine($"TRIANGULO: {areaTriangulo:f3}\nCIRCULO: {areaCirculo:f3}\nTRAPEZIO: {areaTrapezio:f3}\nQUADRADO: {areaQuadrado:f3}\nRETANGULO: {areaRetangulo:f3}", CultureInfo.InvariantCulture);
        }
    }
} 