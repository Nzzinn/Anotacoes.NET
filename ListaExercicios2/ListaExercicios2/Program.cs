using System.Globalization;

namespace ListaExercicios2
{
    internal class ListaExercicios2
    {
        static void Main(string[] args)
        {
            //Exercicio 1:
            //Console.WriteLine("Informe um número inteiro: ");
            //int num = int.Parse(Console.ReadLine());

            //if(num < 0 )
            //{
            //    Console.WriteLine("NEGATIVO");
            //}
            //else
            //{
            //    Console.WriteLine("NÃO NEGATIVO");
            //}

            //Exercicio 2:
            //Console.WriteLine("Informe um número inteiro: ");
            //int num = int.Parse(Console.ReadLine());

            //if(num % 2 == 0 )
            //{
            //    Console.WriteLine("PAR");
            //}
            //else
            //{
            //    Console.WriteLine("ÍMPAR");
            //}

            //Exercicio 3:
            //Console.WriteLine("Informe dois números inteiros (na mesma linha): ");
            //string[] v = Console.ReadLine().Split(' ');
            //int num1 = int.Parse(v[0]);
            //int num2 = int.Parse(v[1]);

            //if(num1 % num2 == 0 || num2 % num1 == 0) 
            //{ 
            //    Console.WriteLine("Sao Multiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Nao sao Multiplos");
            //}

            //Exercicio 4:
            //Console.WriteLine("Informe a hora de inicio e a hora de término de um jogo com números inteiros (na mesma linha): ");
            //string[] v = Console.ReadLine().Split(' ');
            //int horaInicio = int.Parse(v[0]);
            //int horaTermino = int.Parse(v[1]);
            //int duracao;

            //if(horaInicio < horaTermino) 
            //{
            //    duracao = horaTermino - horaInicio;
            //}
            //else
            //{
            //    duracao = 24 - horaInicio + horaTermino;
            //}

            //Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

            //Exercicio 5:
            //Console.WriteLine("1- Cachorro Quente   R$4.00\n2- X-Salada   R$4.50\n3- X-Bacon   R$5.00\n4- Torrada Simples   R$2.00\n5- Refrigerante   R$1.50");
            //Console.WriteLine("Informe o código do produto e quantidade que deseja comprar: ");
            //string[] v = Console.ReadLine().Split(' ');
            //int codigo = int.Parse(v[0]);
            //int qtd = int.Parse(v[1]);
            //double total;

            //if (codigo == 1)
            //{
            //    total = qtd * 4;
            //}
            //else if (codigo == 2)
            //{
            //    total = qtd * 4.50;
            //}
            //else if (codigo == 3)
            //{
            //    total = qtd * 5;
            //}
            //else if (codigo == 4)
            //{
            //    total = qtd * 2;
            //}
            //else
            //{
            //    total = qtd * 1.50;
            //}

            //Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));

            //Exercicio 6:
            //Console.WriteLine("Informe qualquer número: ");
            //double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if(num > 0 && num <= 25)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}else if(num >= 25.01 && num <= 50)
            //{
            //    Console.WriteLine("Intervalo [25,50]");
            //}else if (num >= 50.01 && num <= 75)
            //{
            //   Console.WriteLine("Intervalo [50,75]");
            //}else if (num >= 75.01 && num <= 100)
            //{
            //    Console.WriteLine("Intervalo [75,100]");
            //}
            //else
            //{
            //    Console.WriteLine("Fora de intervalo");
            //}

            //Exercicio 7:
            //Console.WriteLine("Informe dois valores com uma casa decimal: ");
            //string[] v = Console.ReadLine().Split(' ');
            //double x = double.Parse(v[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(v[1], CultureInfo.InvariantCulture);

            //if(x == 0 && y == 0)
            //{
            //    Console.WriteLine("Origem");
            //}else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("Q4");
            //}else if(x < 0 && y < 0)
            //{
            //    Console.WriteLine("Q3");
            //}else if(x < 0 && y > 0)
            //{
            //    Console.WriteLine("Q2");
            //}else if(x > 0 && y > 0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else
            //{
            //    Console.WriteLine("Isso não faz parte do escopo de um plano cartesiano");
            //}

            //Exercicio 8:
            Console.WriteLine("Informe o seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if(salario >= 0 && salario <= 2000)
            {
                imposto = 0;
            }else if(salario >= 2000.01 && salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
            }else if(salario >= 3000.01 && salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (imposto == 0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("f2", CultureInfo.InvariantCulture));
            }
        }   
    }
}