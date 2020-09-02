using System;
using System.Collections.Generic;

namespace Services
{
    public class Funcoes
    {
        public void ImprimeNumerosDe1a100()
        {
            // Declara as variaveis string de nome e sobrenome
            string nome, sobrenome;

            // Pede ao usuario que digite um nome, e em seguida um sobrenome
            Console.WriteLine("Digite o nome e pressione Enter");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o sobrenome e pressione Enter");
            sobrenome = Convert.ToString(Console.ReadLine());

            // explora os números de 1 a 100
            for (int num = 1; num <= 100; num++)
            {
                // verifica se o número é múltiplo de 3 e/ou 5
                bool bMultiplo3 = Convert.ToDouble(num) % 3 == 0;
                bool bMultiplo5 = Convert.ToDouble(num) % 5 == 0;

                // formata a informação a ser mostrada
                string linha = num.ToString();
                if (bMultiplo3 && bMultiplo5)
                {
                    linha += " " + nome + " " + sobrenome;
                }
                else if (bMultiplo3)
                {
                    linha += " " + nome;
                }
                else if (bMultiplo5)
                {
                    linha += " " + sobrenome;
                }

                // mostra a informação na tela
                Console.WriteLine(linha);

            }

            // Espera o usuário digitar algo para fechar a aplicação
            Console.Write("\n\nPressione qualquer tecla para fechar a aplicação...");
            Console.ReadKey();

        }

        public void RealizaSomaDeQuadrados()
        {
            // Cria a lista que vai guardar os números informados
            List<int> lista = new List<int>();

            // Pede ao usuario que digite um numero, e em seguida Enter,
            // e caso queira interromper a adição de elementos, pressione a tecla = e em seguida Enter
            while (true)
            {
                Console.WriteLine("Digite um número e pressione Enter, ou = e depois Enter para concluir:");

                var numero = Console.ReadLine();

                // Confere se o usuário deseja concluir a operação pressionando =
                if (numero == "=") break;

                // Valida o número e adiciona na lista se validado, ou avisa que o número é inválido
                int numeroTeste;
                if (int.TryParse(numero, out numeroTeste))
                {
                    lista.Add(numeroTeste);
                }
                else
                {
                    Console.WriteLine("[[ NÚMERO INVÁLIDO ]]");
                }
            }

            // Calcula o resultado chamando a função somaDeQuadrados
            int resultado = somaDeQuadrados(lista);

            // Mostra o resultado na tela
            Console.Write("\n\nResultado da soma dos quadrados: " + resultado.ToString() + "\n\n");

            // Espera o usuário digitar algo para fechar a aplicação
            Console.Write("\n\nPressione qualquer tecla para fechar a aplicação...");
            Console.ReadKey();

        }

        private static int somaDeQuadrados(List<int> lista)
        {
            int soma = 0;
            if (lista != null)
            {
                if (lista.Count > 0)
                {
                    foreach (int b in lista)
                    {
                        soma += b * b;
                    }
                }
            }
            return soma;
        }

        public void PrimeiroElemento5DigFibonacci()
        {
            // Inicializa variáveis
            int f1 = 0, f2 = 1, f3;

            // Entra num loop até encontrar o primeiro elemento da sequência de Fibonacci com 5 dígitos
            while (true)
            {
                // calcula qual o próximo elemento
                f3 = f1 + f2;

                // testa o tamanho do número convertendo-o em string
                if (f3.ToString().Length == 5)
                {
                    // chegou no número, mostra na tela e interrompe o loop
                    Console.WriteLine("O primeiro elemento da sequência de Fibonacci com 5 dígitos é:\n"
                        + f3.ToString());
                    break;
                }
                else
                {
                    // continua seguindo a sequência renovando os valores das variáveis
                    f1 = f2;
                    f2 = f3;
                }
            }

            // Espera o usuário digitar algo para fechar a aplicação
            Console.Write("\n\nPressione qualquer tecla para fechar a aplicação...");
            Console.ReadKey();
        }

    }

}