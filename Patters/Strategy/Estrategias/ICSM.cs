using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura_DesignPatterns.NET.Patters.Strategy.Estrategias
{
    public class ICSM : Imposto
    {
        public float Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * ((float) 0.05);
        }
    }
}