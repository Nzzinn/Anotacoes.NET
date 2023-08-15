using System.Globalization;

namespace ListaExercicioClasses 
{
    internal class ListaExercicioClasses
    {
        static void Main(string[] args)
        {
            //Exercicio 1:
            //Pessoa p1, p2;

            //p1 = new Pessoa();
            //p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa: ");
            //Console.Write("Nome: ");
            //p1.nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p1.idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa: ");
            //Console.Write("Nome: ");
            //p2.nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p2.idade = int.Parse(Console.ReadLine());

            //if (p1.idade > p2.idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p1.nome);
            //} else
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p2.nome);
            //}

            //Exercicio 2:
            Funcionario p1, p2;
            p1 = new Funcionario();
            p2 = new Funcionario();
            
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double media = (p1.salario + p2.salario) / 2;
            
            Console.WriteLine("Salário médio: " +  media.ToString("f2", CultureInfo.InvariantCulture));
        }   
    }
}