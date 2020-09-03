# Teste.MarcioCoelhoSocorro

- Solução composta dos seguintes projetos:
  . ConsoleApp
  . Domain
  . Services
  . Website

- O projeto Website é o projeto de inicialização. Ao executar a solução no Visual Studio 2019, e iniciar a depuração, o projeto Website será inicializado.

- Caso o usuário queira verificar a avaliação técnica do ConsoleApp, deve clicar com o botão direito nesse projeto, e defini-lo como projeto de inicialização. Ao executar a solução, abre a tela do console já com o primeiro item da avaliação.

Os itens da avaliação serão executados um após o outro e o usuário será informado através de mensagens no console.

  1. Escreva uma função que imprima os números de 1 a 100 e, ao lado dos números múltiplos de 3 imprima “<Nome>”, ao lado dos múltiplos de 5 imprima “<SobreNome>” e ao lado dos múltiplos de 3 e 5 imprima “<Nome><SobreNome>”.
  
  2. Implemente a função somaDeQuadrados que retorna a soma de quadrados de uma lista.
  
  3. Sequência de Fibonacci - Escreva uma função que retorna o primeiro elemento da sequência de Fibonacci com 5 dígitos.
  
  4. Escrever uma função que recebe uma árvore e um id e retorna um vetor com os ids do caminho desde o nó raiz até o nó passado como parâmetro.
  
  5. Utilizando a função:
    function acumular(combiner, nullValue, list)
    {
      if (list.length == 0)
      {
        return nullValue;
      }
      var primeiro = list.removePrimeiro();
      return combiner(primeiro, acumular (combiner, nullValue, list));
    }
    Neste caso a função acumular deve ser utilizada. A variável “combiner” é um “ponteiro para função”. A implementação da função “combiner” faz parte da solução.
    
  6. Escreva uma função que retorna à posição da sequência dado uma palavra ou -1 se a palavra não for uma palavra triângulo.
  
