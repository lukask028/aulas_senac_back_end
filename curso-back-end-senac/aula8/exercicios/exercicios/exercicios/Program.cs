using System;

namespace exercicios;

// 1 - crie um algoritmo some, divide,  multiplique, subtraia,
// exiba o resto da divisao de 2 numeros

// 2 - exiba 10 porcento de um numero

// 3 - Ao digitar 5 numeros exiba a média

// 4 - Exiba a primeira letra do nome e sobrenome

// 5 - uma calculadora com 2 numeros 

// exiba a media de 4 notas, nome do aluno, caso seja menor que 6 apareça
// reprovado senão aprovado.
internal class Program
{
    private static void Main(string[] args)
    {
        // 1
        Console.WriteLine("Algoritmo calculadora");

         //declaracao de variavel
         int a, b, soma, subtracao, multi, div;
         string operador;

         //msg do que fazer
         Console.WriteLine("Calculadora com as 4 operações");

         // pede o primeiro o valor
         Console.WriteLine("Insira o valor de a:");
         a = Convert.ToInt32(Console.ReadLine());

         // pede o segundo valor
         Console.WriteLine("Insira o valor de b");
         b = Convert.ToInt32(Console.ReadLine());

        // escolhe um operador :
        Console.WriteLine("Insira um operador:");
        operador = Convert.ToString(Console.ReadLine());


        switch (operador)
        { 
            case "+":
            
                soma = a + b;
                Console.WriteLine("Soma:" + soma.ToString("0.00"));
                
            break;
            case "-":

                subtracao = a - b;
                Console.WriteLine("Subtracao:" + subtracao.ToString("0.00"));

                break;
            case "*":

                multi = a * b;
                Console.WriteLine("multi:" + multi.ToString("0.00"));

                break;
            case "/":

                div = a / b;
                Console.WriteLine("div:" + div.ToString("0.00"));

                break;
            default:

                Console.WriteLine("Operador Inválido");

                break;
        } 
         


        // 2
        /*Console.WriteLine("Algoritmo 10% de um número: ");

        
        Console.WriteLine("Digite um número:");

        double a = Convert.ToDouble(Console.ReadLine());

        double porc = a * 0.1;

        Console.WriteLine($"10% do número {a}: " + porc);*/



        // 3
        /* Console.WriteLine("Algoritmo media de valores:");

         // criacao da lista
         double[] valores = new double[5];

         // var para soma dos elementos da lista
         double soma = 0;

         // adiciona valores ao array
         for (int i = 0; i < valores.Length; i++)
         {
             Console.WriteLine($"Digite valor {i}: ");
             valores[i] = Convert.ToDouble(Console.ReadLine());
         }

         // soma todos os valores do array
         for (int i = 0; i < valores.Length; i++)
         {
             soma += valores[i];
         }

         // media dos arrays
         double media = soma / valores.Length;

         // formata a media 
         string m = media.ToString("0.00");

         // Exibe a media do array
         Console.WriteLine("Media das notas:" + m);*/




        // 4 
        // Toda string é um array
        // logo para pegar posicao de uma letra num palavra
        // usa a palavra de exemplo seguida da posicao : exemplo[1]
        // retorno "e"
        /* Console.WriteLine("Algoritmo exibe a primeira letra do nome e sobrenome");

         Console.WriteLine("Digite seu nome: ");
         string nome = Convert.ToString(Console.ReadLine());
         Console.WriteLine($"Primeira letra do nome: {nome[0]}");

         Console.WriteLine("Digite seu sobrenome: ");
         string sobrenome = Convert.ToString(Console.ReadLine());
         Console.WriteLine($"Primeira letra do sobrenome: {sobrenome[0]}");*/



        // 5 
       /*Console.WriteLine("Algoritmo media de valores:");

       // criacao da lista
       double[] valores = new double[5];

       // var para soma dos elementos da lista
       double soma = 0;

       // adiciona valores ao array
       for (int i = 0; i < valores.Length; i++)
       {
           Console.WriteLine($"Digite valor {i}: ");
           valores[i] = Convert.ToDouble(Console.ReadLine());
       }

       // soma todos os valores do array
       for (int i = 0; i < valores.Length; i++)
       {
           soma += valores[i];
       }

       // media dos arrays
       double media = soma / valores.Length;

        // comparacao da media caso se aprovado ou nao
        if (media >= 6)
        {
            Console.WriteLine($"O aluno foi aprovado com nota {media}");
        }
        else
        {
            Console.WriteLine($"O aluno foi reprovado com nota {media}");
        }

       // formata a media 
       string m = media.ToString("0.00");

       // Exibe a media do array
       Console.WriteLine("Media das notas:" + m);*/



       

    }
}
