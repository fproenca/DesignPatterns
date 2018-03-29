using System;

namespace DesignPatterns.Strategy.DesignPatternAplicado
{
    public class CalculadorDeImpostos
    {
        public double RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcula(orcamento);
        }
    }
}
