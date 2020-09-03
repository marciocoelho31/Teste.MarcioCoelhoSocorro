using Services;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcoes funcoes = new Funcoes();

            // item 1 da avaliação
            Console.WriteLine("ITEM 1 DA AVALIAÇÃO");
            Console.WriteLine("===================");
            funcoes.ImprimeNumerosDe1a100();

            // item 2 da avaliação
            Console.WriteLine("ITEM 2 DA AVALIAÇÃO");
            Console.WriteLine("===================");
            funcoes.RealizaSomaDeQuadrados();

            // item 3 da avaliação
            Console.WriteLine("ITEM 3 DA AVALIAÇÃO");
            Console.WriteLine("===================");
            funcoes.PrimeiroElemento5DigFibonacci();

            // item 4 da avaliação
            Console.WriteLine("ITEM 4 DA AVALIAÇÃO");
            Console.WriteLine("===================");
            funcoes.Arvore();

            // item 5 da avaliação
            Console.WriteLine("ITEM 5 DA AVALIAÇÃO");
            Console.WriteLine("===================");
            funcoes.QuestaoCombiner();

            // item 6 da avaliação
            Console.WriteLine("ITEM 6 DA AVALIAÇÃO");
            Console.WriteLine("===================");
            funcoes.NumerosTriangulo();

        }

    }
}
