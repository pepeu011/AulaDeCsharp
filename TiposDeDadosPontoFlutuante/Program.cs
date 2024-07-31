using System.Collections.Concurrent;

namespace TiposDeDadosPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Valores do Tipo de Ponto Flutuante
            float valor_float1 = 1.234f;
            float valor_float2 = 1.234f;
            decimal valor_decimal1 = 1.2345m;
            decimal valor_decimal2 = 1.2345m;
            double valor_double1 = 1.2345; 
            double valor_double2 = 1.2345d; 
            double valor_double3 = 1.2345d;

            float x = 1.0f / 3.0f;
            double y = 1.0d / 3.0d;
            decimal z = 1.0m / 3.0m;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
