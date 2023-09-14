// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Insira sua nota:");

using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

        //Ex : peça para o sistema solicitar a nota
        // de 5 estudante em portugues, matematica, 
        // e historia. Se o aluno tirou notas maiores 
        // que 7, ele é aprovado
        // caso ao contrario retorne as disciplinas
        // que ele ficou de recuperação

        int notaport, notamat, notahis;
        Console.WriteLine("Sistemas de notas");
        int i = 1;

        
            // interporlação de strings "$" permite a construção de textos de maneira
            // dinâmica, inserindo a variavel com valor, dentro de um texto. 

            while (i <= 5)
            {
                Console.WriteLine($"Aluno {i}");    
                Console.WriteLine("Insira a nota de portugues:");
                notaport = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira a nota de matematica:");
                notamat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira a nota de historia:");
                notahis = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"A nota do aluno {i} de portugues e: " + notaport);
                Console.WriteLine($"A nota do aluno {i} de matematica e: " + notamat);
                Console.WriteLine($"A nota do aluno {i} de historia e: " + notahis);
            try 
            {
                if (notaport < 0 || notaport > 10 || notamat < 0 || notamat > 10 || notahis < 0 || notahis > 10)
                { 
                    Console.WriteLine("Por favor insira uma nota de 0 a 10!!");
                    continue;
                }  
                if (notaport < 7 || notamat < 7 || notahis < 7)
                    { 
                    Console.WriteLine($"O aluno {i} esta reprovado!!");
                    }
                else
                { 
                    Console.WriteLine($"O aluno {i} esta esta aprovado!!");
                }
            }
             catch(FormatException)
             {
                Console.WriteLine("Por favor insira somente nummeros inteiros nas notas.");
             }
                i++; 
            }
        }
    }
}