using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura_DesignPatterns.NET.Patters.ChainOfResponsibility;

namespace Alura_DesignPatterns.NET.Patters.Strategy
{
    public class Orcamento
    {
        public float Valor { get; set; }    
        public IList<Item> Itens { get; set; } = new List<Item>();
    }

    
}