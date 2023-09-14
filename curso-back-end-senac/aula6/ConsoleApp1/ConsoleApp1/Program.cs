// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;


public class Program
{


    public static void Main()
    {

        List<string> nomes = new List<string>();

        bool continuar = true;


        while (continuar)
        {
            Console.WriteLine("\nMenu ");
            Console.WriteLine("1. Adicionar o nome ");
            Console.WriteLine("2. Listar nome ");
            Console.WriteLine("3. Sair ");
            Console.Write("Escolha uma opção: ");

            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. ");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o nome: ");
                    nomes.Add(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Nomes: ");
                    foreach (var nome in nomes)
                    {
                        Console.WriteLine(nome);
                    }

                    break;

                case 3:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. ");
                    break;




            }
        }
    }
}