using System;

namespace DesignPatterns.Strategy.Problema
{
    public class CalculadorDeImpostos
    {
        public double RealizaCalculo(Orcamento orcamento, String imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                return orcamento.Valor * 0.1;
            }
            else if ("ISS".Equals(imposto))
            {
                return orcamento.Valor * 0.06;
            }
            return 0;
        }
    }
}
