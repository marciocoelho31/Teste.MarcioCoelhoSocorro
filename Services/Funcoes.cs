using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class Funcoes
    {
        // método relacionado ao item 1 da avaliação
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

            // Espera o usuário digitar algo para continuar
            Console.Write("\n\nPressione qualquer tecla para continuar...\n\n");
            Console.ReadKey();

        }

        #region métodos relacionados ao item 2 da avaliação
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

            // Espera o usuário digitar algo para continuar
            Console.Write("\n\nPressione qualquer tecla para continuar...\n\n");
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
        #endregion

        // método relacionado ao item 3 da avaliação
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

            // Espera o usuário digitar algo para continuar
            Console.Write("\n\nPressione qualquer tecla para continuar...\n\n");
            Console.ReadKey();
        }

        #region métodos relacionados ao item 4 da avaliação
        public void Arvore()
        {
            string retorno = "[" + string.Join(",", caminho_arvore(geraTree(), 9)) + "]";

            // Mostra a posição da sequência dado uma palavra como resultado, ou -1 se a palavra não for uma "palavra triângulo"
            Console.Write("\n\nRetorno: " + retorno);

            // Espera o usuário digitar algo para continuar
            Console.Write("\n\nPressione qualquer tecla para continuar...\n\n");
            Console.ReadKey();

        }

        public int[] caminho_arvore(Arvore a, int n)
        {
            int node = 0, ct = 0;
            int[] intArr = new int[0];

            // monta a árvore a partir do elemento a, e busca por n como último nó passado
            Arvore arvore = new Arvore();
            while (node != a.Id)
            {
                Array.Resize(ref intArr, intArr.Length + 1);
                intArr[ct] = n;
                ct++;
                verificaGalhos(ref arvore, a, n);
                n = arvore.Id;
                node = arvore.Id;
            }

            // formata a árvore para visualização
            Array.Resize(ref intArr, intArr.Length + 1);
            intArr[ct] = a.Id;

            Array.Reverse(intArr);

            return intArr;
        }

        public static void verificaGalhos(ref Arvore node, Arvore a, int n)
        {
            if (a.Filhos != null)
            {
                if ((a.Filhos[0] != null && a.Filhos[0].Id == n) || (a.Filhos[1] != null && a.Filhos[1].Id == n))
                {
                    node = a;
                }
                else
                {
                    if (a.Filhos[0] != null)
                    {
                        verificaGalhos(ref node, a.Filhos[0], n);
                    }
                    if (a.Filhos[1] != null)
                    {
                        verificaGalhos(ref node, a.Filhos[1], n);
                    }
                }
            }
        }

        public Arvore geraTree()
        {
            var no9 = new Arvore { Id = 9 };
            var no13 = new Arvore { Id = 13, Filhos = tree(no9, null) };
            var no12 = new Arvore { Id = 12, Filhos = tree(null, no13) };
            var no2 = new Arvore { Id = 2, Filhos = tree(no12, null) };
            var no8 = new Arvore { Id = 8 };
            var no10 = new Arvore { Id = 10, Filhos = tree(no8, null) };
            var no4 = new Arvore { Id = 4, Filhos = tree(no10, no2) };
            var no5 = new Arvore { Id = 5 };
            var no3 = new Arvore { Id = 3 };
            var no6 = new Arvore { Id = 6 };
            var no11 = new Arvore { Id = 11, Filhos = tree(no6, no5) };
            var no7 = new Arvore { Id = 7, Filhos = tree(no3, no11) };
            var no1 = new Arvore { Id = 1, Filhos = tree(no4, no7) };
            return no1;
        }

        static Arvore[] tree(Arvore noEsquerda, Arvore noDireita)
        {
            Arvore[] tree = new Arvore[2];
            tree[0] = noEsquerda;
            tree[1] = noDireita;
            return tree;
        }
        #endregion

        #region métodos relacionados ao item 5 da avaliação

        public int acumular(Func<int, int, int> combiner, int nullValue, List<int> list)
        // utilizando o delegate Func para facilitar a manipulação das informações
        {
            if (list.Count == 0)
            {
                return nullValue;
            }

            // removendo o primeiro elemento
            var primeiro = list.First();
            list.RemoveAt(0);

            // alimenta o ponteiro combiner e vai assim até o final da lista fornecida em "List<int> list"
            return combiner(primeiro, acumular(combiner, nullValue, list));
        }

        // implementando a função combiner
        private int combiner(int primeiro, int acumula)
        {
            acumula += primeiro * primeiro;
            return acumula;
        }

        public void QuestaoCombiner()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            int resultado = acumular(combiner, 0, list);

            Console.WriteLine("Resultado questão combiner para lista { 1, 2, 3, 4, 5 }:\n" + resultado.ToString());

            // Espera o usuário digitar algo para continuar
            Console.Write("\n\nPressione qualquer tecla para continuar...\n\n");
            Console.ReadKey();
        }

        #endregion

        #region métodos relacionados ao item 6 da avaliação
        public void NumerosTriangulo()
        {
            string palavra = "";

            // Declara a variavel string de palavra
            // e pede ao usuario que digite a palavra
            while (palavra == "")
            {
                Console.WriteLine("Digite uma palavra e pressione Enter");
                palavra = Convert.ToString(Console.ReadLine());
            }

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
        #endregion


    }

}