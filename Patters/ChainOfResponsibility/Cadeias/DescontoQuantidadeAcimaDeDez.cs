using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura_DesignPatterns.NET.Patters.Strategy;

namespace Alura_DesignPatterns.NET.Patters.ChainOfResponsibility.Cadeias
{
    public class DescontoQuantidadeAcimaDeDez : Desconto
    {
        public Desconto ProximoDesconto { get ; set ; }

        public float Descontar(Orcamento o)
        {
            if(o.Itens.Count() > 10){                
                return  o.Valor * ((float) 0.1);
            }
            return this.ProximoDesconto.Descontar(o);
        }

        public DescontoQuantidadeAcimaDeDez(Desconto Proximo)
        {
            this.ProximoDesconto = Proximo;
        }
    }
}