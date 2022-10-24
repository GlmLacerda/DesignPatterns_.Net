using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura_DesignPatterns.NET.Patters.Strategy;

namespace Alura_DesignPatterns.NET.Patters.ChainOfResponsibility.Cadeias
{
    public class DescontoValorAcimaDeQuinhentos : Desconto
    {
        public Desconto ProximoDesconto { get; set; }

        public DescontoValorAcimaDeQuinhentos(Desconto proximoDesconto)
        {
            this.ProximoDesconto = proximoDesconto;
        }

        public float Descontar(Orcamento o)
        {
            if(o.Valor > 500){
                return o.Valor * ((float) .05);
            }

            return this.ProximoDesconto.Descontar(o);
        }

    }
}