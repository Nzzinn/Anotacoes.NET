using System.Globalization;

namespace Aula45
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
       
        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return "AREA = " + Area().ToString(CultureInfo.InvariantCulture)
                + "\nPERÍMETRO = " + Perimetro().ToString(CultureInfo.InvariantCulture)
                + "\nDIAGONAL = " + Diagonal().ToString(CultureInfo.InvariantCulture);
        }
    }
}
