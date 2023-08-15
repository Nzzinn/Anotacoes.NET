using System.Globalization;

namespace Aula45
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double aumento;

            aumento = SalarioBruto + (SalarioBruto * porcentagem) / 100;

            Console.Write("Dados atualizados: " + Nome+ ", $ " + aumento.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
