using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura_DesignPatterns.NET.Patters.Strategy;

namespace Alura_DesignPatterns.NET.Patters.ChainOfResponsibility
{
    public class CalculadorDeDescontos
    {
        public float CalcularDesconto(Orcamento o, Desconto d){
            return d.Descontar(o);
        }
    }
}