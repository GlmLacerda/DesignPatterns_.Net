using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura_DesignPatterns.NET.Patters.Strategy
{
    public interface Imposto
    {
        public float Calcular(Orcamento orcamento);
    }
}