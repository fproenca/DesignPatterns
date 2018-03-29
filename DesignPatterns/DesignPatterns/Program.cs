using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Padrão Strategy
            Strategy.Problema.Application.Execute();
            Strategy.DesignPatternAplicado.Application.Execute();
            
            Console.ReadLine();
        }
    }
}
