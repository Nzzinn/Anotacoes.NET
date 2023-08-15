using System.Globalization;

namespace Aula41 
{
    internal class MyApp
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtd);

            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}