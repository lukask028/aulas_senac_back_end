// Solicite
// ao usuário um número N que representa a quantidade de termos da
// sequência de Fibonacci que ele deseja gerar.
// Gere
// e mostre os N primeiros termos da sequência de Fibonacci.
// Informe
// a porcentagem de números ímpares na sequência gerada.
// Mostre
// o valor médio dos termos gerados.



// Instruções:


// Use
// um loop for para gerar a sequência de Fibonacci até o N-ésimo
// termo.
// Utilize
// condicionais if-else para verificar se um número é ímpar ou par.
// Mantenha
// contadores para o total de termos, o total de termos ímpares e a soma dos
// termos.
// Após
// o término do loop, calcule e exiba a porcentagem de números ímpares e o
// valor médio dos termos.



// Dicas:


// Comece
// definindo e inicializando as variáveis que representam os dois termos
// anteriores da sequência e as variáveis de contagem.
// Dentro
// do loop, atualize os termos da sequência e as variáveis de contagem
// conforme necessário.
// Este
// desafio visa reforçar o uso de loops e condicionais e também a manipulação
// de sequências numéricas.
using System;
using System.Collections.Generic;

namespace fibonacci
{
    class Program
    {
    static void Main(string[] args)
    {
        int n_atual , n_prox, soma_fib;
        float porc_impar, limite_termos, n_impar, media;
        
        List<int> numero_lista = new List<int>();
        
        soma_fib = 0;
        limite_termos = 0;
        n_atual = 0;
        n_prox = 1;
        n_impar = 0;
        Console.WriteLine("Fibonacci");

        Console.WriteLine("Insira a quantidade de termos em fibonacci :");
        limite_termos = Convert.ToInt32(Console.ReadLine());
        // controle de quantidade de termos:
        for (int i = 0; i < limite_termos; i++)
        {   
            soma_fib = n_atual + n_prox;
            // verifica se o numero atual é impar
            if (n_atual % 2 != 0)
            {
            n_impar = n_impar+1;
            }
            n_atual = n_prox;
            n_prox = soma_fib;
            numero_lista.Add(soma_fib);
            } 
           
        Console.Write("\nElementos da lista:");
            foreach(var elemento in numero_lista)
            {
                Console.Write($" {elemento}  ", + elemento);
                   
            }
            Console.WriteLine(" ");   
            Console.WriteLine($"\nNumeros impares: {n_impar}");
            porc_impar = (n_impar / limite_termos * 100);
            string s = porc_impar.ToString("0.00");
            Console.WriteLine($"\nPorcentagem de impar: {s} %");
            
            media = (soma_fib/limite_termos);
            string m = media.ToString("0.00");
            Console.WriteLine($"\nmedia dos termos: {media}");

        
    }
    }
}