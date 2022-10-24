using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura_DesignPatterns.NET.Patters.Strategy;

namespace Alura_DesignPatterns.NET.Patters.ChainOfResponsibility
{
    public interface Desconto
    {
        public float Descontar(Orcamento o);
        public Desconto ProximoDesconto {get;set;}
    }
}