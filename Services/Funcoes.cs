using System;
using System.Collections.Generic;
using System.Text;

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

        public void NumerosTriangulo()
        {
            // Declara a variavel string de palavra
            // e pede ao usuario que digite a palavra
            Console.WriteLine("Digite uma palavra e pressione Enter");
            string palavra = Convert.ToString(Console.ReadLine());

            int retorno = palavraTriangulo(palavra);

            // Mostra a posição da sequência dado uma palavra como resultado, ou -1 se a palavra não for uma "palavra triângulo"
            Console.Write("\n\nRetorno: " + retorno);

            // Espera o usuário digitar algo para fechar a aplicação
            Console.Write("\n\nPressione qualquer tecla para fechar a aplicação...");
            Console.ReadKey();
        }

        private static int valorDaPalavra(string palavra)
        {
            int ret = 0;
            if (palavra.Length > 0)
            {
                byte[] arrayASCII = Encoding.ASCII.GetBytes(palavra.ToUpper());

                foreach (object letra in arrayASCII)
                {
                    ret += (Convert.ToInt32(letra.ToString()) - 64);
                }

            }
            return ret;
        }

        public int palavraTriangulo(string palavra)
        {
            // Converte cada letra da palavra em um número correspondendo a posição no alfabeto
            // e adiciona os valores, obtendo o resultado - "o valor da palavra"
            int resultadoValorPalavra = valorDaPalavra(palavra);

            // Verifica se a palavra é uma "palavra triângulo", 
            // obedecendo a fórmula 𝑡(𝑛) = 𝑛 ∗ (𝑛 +1) / 2
            // Assim os primeiros números da sequência são: 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
            int ret = -1;
            double n = 1;
            while (true)
            {
                double num = (n * (n + 1)) / 2;
                if (num == Convert.ToDouble(resultadoValorPalavra))
                {
                    ret = Convert.ToInt32(n);
                    break;
                }
                else if (num > resultadoValorPalavra)
                {
                    break;
                }
                n++;
            }

            return ret;
        }

    }

}