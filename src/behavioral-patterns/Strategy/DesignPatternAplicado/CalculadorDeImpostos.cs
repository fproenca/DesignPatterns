using System;

namespace behavioral_patterns.DesignPatternAplicado
{
    public class CalculadorDeImpostos
    {
        public double RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcula(orcamento);
        }
    }
}
