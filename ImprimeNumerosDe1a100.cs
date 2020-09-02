using System;

namespace Domain
{
	public class ImprimeNumerosDe1a100
	{
        public static void ImprimeNumerosDe1a100()
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

    }
}