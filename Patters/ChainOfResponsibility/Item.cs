using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura_DesignPatterns.NET.Patters.ChainOfResponsibility
{
    public class Item
    {
        public string Nome { get; set; }
        public float Valor { get; set; }

        public Item(string nome,float valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}