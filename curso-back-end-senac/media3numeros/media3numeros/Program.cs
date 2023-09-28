using System;
using System.Runtime.CompilerServices;

namespace media3numeros;

class Program
{
    static void Main(string[] args)
    {

        //Ex : media de 3 numeros
        // entrada de 3 numeros,e o nome do usuario

        // criacao do array com notas 
        double[] notas = new double[5];

        // var para soma dos elementos
        double soma = 0;

        // declaracao da varicao nome 
        string nome;


        
        // adicionando notas no array 
        for (int i = 0; i < notas.Length; i++)
        {
            // interporlação de strings "$" permite a construção de textos de maneira
            // dinâmica, inserindo a variavel com valor, dentro de um texto.
            Console.WriteLine($"Digite a nota{i} :");
            notas[i] = Convert.ToDouble(Console.ReadLine());
        }

        // percorrendo o array 
        for (int i = 0; i < notas.Length; i++)
        {   
            soma += notas[i];
        }

        Console.WriteLine("Algoritmo nome e medias:");

        // entrada do nome
        Console.WriteLine("digite seu nome:");
        nome = Console.ReadLine();

        // media dos arrays
        double media = soma / notas.Length;

        // formata a media 
        string m = media.ToString("0.00");

        // exibe o nome
        Console.WriteLine("\nSeu nome: " + nome);

        // Exibe a media do array
        Console.WriteLine("media das notas:  " + m);
    }
}