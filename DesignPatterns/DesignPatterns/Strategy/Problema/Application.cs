using System;

namespace DesignPatterns.Strategy.Problema
{
    public static class Application
    {
        public static void Execute()
        {
            Console.WriteLine("----------------- Padrão Strategy / Problema -----------------");
            Console.WriteLine("\n");
            
            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            // Calculando o ISS
            Console.WriteLine("Calculando o ISS");
            Console.WriteLine(calculador.RealizaCalculo(orcamento, "ISS"));

            Console.WriteLine("\n");

            // Calculando o ICMS        
            Console.WriteLine("Calculando o ICMS");
            Console.WriteLine(calculador.RealizaCalculo(orcamento, "ICMS"));

            Console.WriteLine("\n");
        }
    }
}
