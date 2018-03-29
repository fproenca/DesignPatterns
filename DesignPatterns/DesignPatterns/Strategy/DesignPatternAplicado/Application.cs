using System;

namespace DesignPatterns.Strategy.DesignPatternAplicado
{
    public static class Application
    {
        public static void Execute()
        {
            Console.WriteLine("----------------- Padrão Strategy / Design Pattern Applicado -----------------");
            Console.WriteLine("\n");
            
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            // Calculando o ISS
            Console.WriteLine("Calculando o ISS");
            Console.WriteLine(calculador.RealizaCalculo(orcamento, iss));

            Console.WriteLine("\n");

            // Calculando o ICMS        
            Console.WriteLine("Calculando o ICMS");
            Console.WriteLine(calculador.RealizaCalculo(orcamento, icms));

            Console.WriteLine("\n");
        }
    }
}
