using ApppLiderAviacao.Interface;
using System;

namespace ApppLiderAviacao
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCustoFinal calculadora = new CalculadoraCustoFinal();
            calculadora.Valor = 70000;

            Imposto imp = new Imposto(calculadora.Valor);
            Distribuidor dist = new Distribuidor(calculadora.Valor);

            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("|Custo de Fabricação | " + string.Format("{0:##,##0.00}", calculadora.Valor).PadLeft(10));
            Console.WriteLine("|Distribuição        | " + string.Format("{0:##,##0.00}", dist.Calcular()).PadLeft(10));
            Console.WriteLine("|Imposto             | " + string.Format("{0:##,##0.00}", imp.Calcular()).PadLeft(10));
            Console.WriteLine("|--------------------------------------------");
            Console.WriteLine($" Total                 " + string.Format("{0:##,##0.00}", (calculadora.Valor + dist.Calcular() + imp.Calcular())).PadLeft(10));
            Console.ReadKey();
        }
    }
}
