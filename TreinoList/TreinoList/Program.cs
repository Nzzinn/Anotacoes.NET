
namespace TreinoList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProductManegement p = new ProductManegement();
            
            p.CreateProducts();
            
            p.UpdateProduct();

            p.RemoveProduct();
            
            p.ListProducts();
        }
    }
}