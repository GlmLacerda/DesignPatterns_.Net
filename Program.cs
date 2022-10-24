// See https://aka.ms/new-console-template for more information

using Alura_DesignPatterns.NET.Patters.ChainOfResponsibility;
using Alura_DesignPatterns.NET.Patters.ChainOfResponsibility.Cadeias;
using Alura_DesignPatterns.NET.Patters.Strategy;
using Alura_DesignPatterns.NET.Patters.Strategy.Estrategias;

//STRATEGY
var orcamento = new Orcamento();
var icms = new ICSM();
var iss = new ISS();

Console.WriteLine(new CalculadoraDeImpostos().RealizarCalculo(orcamento,icms));

//CHAIN OF RESPONSIBILITY
var CalculadorDeDesconto = new CalculadorDeDescontos();
orcamento.Itens.Add(new Item("Caneta",250));
orcamento.Itens.Add(new Item("Lapis",300));

var d1 = new DescontoQuantidadeAcimaDeDez(new SemDesconto());
var d2 = new DescontoValorAcimaDeQuinhentos(d1);

Console.Write(CalculadorDeDesconto.CalcularDesconto(orcamento,d2));

Console.ReadKey();