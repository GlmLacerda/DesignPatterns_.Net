using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura_DesignPatterns.NET.Patters.Strategy;

namespace Alura_DesignPatterns.NET.Patters.ChainOfResponsibility.Cadeias
{
    public class SemDesconto : Desconto
    {
        public Desconto ProximoDesconto { get ; set ; }

        public float Descontar(Orcamento o)
        {
            return 0;
        }

        public SemDesconto()
        {
            
        }
    }
}