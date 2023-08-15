
namespace CourseDotNet
{
    class Program
    {
        static void Main(string[] args) {
            bool completo = false;
            char genero = 'f';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //O L no final serve simplesmente para específicar que o número é Long;
            float n5 = 4.5f;
            double n6 = 7.1;
            string nome = "Nathan Ferreira";
            int idade = 19;
            double saldo = 2435.760981981;
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("f2"));

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2} reais");
            //Se eu quiser usar o separador como . ao invés da , eu posso usar saldo.toString("f2", CultureInfo.InvariantCulture);
        }
    }
}