using Domain;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Domain.Funcoes funcoes = new Funcoes();

            // item 1 da avaliação
            funcoes.ImprimeNumerosDe1a100();

            // item 2 da avaliação
            funcoes.RealizaSomaDeQuadrados();

            // item 3 da avaliação
            funcoes.PrimeiroElemento5DigFibonacci();

        }

    }
}
