using System;

namespace ArrayNomeCalculo;

internal class Program
{
    private static void Main(string[] args)
    {



        // Digite 10 numeros
        // Digite 10 nomes 
        // Insira nos arrays , e exiba os 10 calculos e nomes 


        // valores iniciais para os calculos:
        int a, b, resultado, i;
        string nome;
        char operacao;

        // declaracao do array
        string[] array_nome_calculo = { };

        /*Console.WriteLine("Insira o valor de a:");
        a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Insira o valor de b:");
        b = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("a é : "+ a);
        Console.WriteLine("b é : "+ b);*/


        
        for (i = 0; i < 10; i++)
        {   
            Console.WriteLine("Digite o nome:");
            nome= Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite o valor para a:");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite uma operação: ");
            operacao = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Digite o valor para b:");
            b = Convert.ToInt16(Console.ReadLine());

            switch (operacao)
            {
                case "+":
                    resultado = (a + b);
                    Console.WriteLine("Resultado:", resultado);
                    break;

            default:
                Console.WriteLine("Saiu do teste");
                
                  break;

            }
        }

        
        

    }
}
