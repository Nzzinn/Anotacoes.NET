namespace Aula46;

public class ConversorDeMoeda
{
    public static double Iof = 6.0;
    public static double DolarToReal(double quantia, double cotacao)
    {
        double total = quantia * cotacao;
        return total + total * Iof / 100;
    }
}