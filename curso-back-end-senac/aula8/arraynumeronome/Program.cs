using System;
using System.Collections.Generic;


// array de numero e nomes
// array separados 
// adicione 10 nomes e numeros em cada array
// controle a quantidade com o for

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // criacao do array nome
            string[] nome = new string[10];

            // criacao do array numero
            int[] numero = new int[10];

            // adicionando dados no array nome
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um nome:");
                nome[i] = Console.ReadLine();

            }

            // adicionando dados no array numero
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero:");
                numero[i] = Convert.ToInt16(Console.ReadLine());
            }

            // saida na tela dos arrays nome e numero
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("nome:" + nome[i]);
                Console.WriteLine("numero: " + numero[i]);
            }


        }
    }
}