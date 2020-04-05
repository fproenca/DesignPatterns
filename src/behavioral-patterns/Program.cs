using System;

namespace behavioral_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Padrão Strategy
            behavioral_patterns.Problema.Application.Execute();
            behavioral_patterns.DesignPatternAplicado.Application.Execute();
            
            Console.ReadLine();
        }
    }
}
