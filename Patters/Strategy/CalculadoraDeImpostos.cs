using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura_DesignPatterns.NET.Patters.Strategy
{
    public class CalculadoraDeImpostos
    {
        public float RealizarCalculo(Orcamento o,Imposto i){
            return i.Calcular(o);
        }
    }
}