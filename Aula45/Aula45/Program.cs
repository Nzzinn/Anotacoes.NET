using System.Globalization;

namespace Aula45 
{
    internal class MyApp
    {
        static void Main(string[] args)
        {
            //Exercicio 1:
            //Retangulo r = new Retangulo();

            //Console.WriteLine("Entre com a largura e altura do retângulo: ");
            //r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine(r);

            //Exercicio 2:
            //Funcionario f = new Funcionario();

            //Console.Write("Nome: ");
            //f.Nome = Console.ReadLine();
            
           // Console.Write("Salário Bruto: ");
           // f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Imposto: ");
            //f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine();
            //Console.WriteLine("Funcionário: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture));
            //Console.WriteLine();
            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine() ;
            //f.AumentarSalario(porcentagem
            
            //Exercicio 3:
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "
                + aluno.NotaFinal().ToString("f2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }
        }
    }
}