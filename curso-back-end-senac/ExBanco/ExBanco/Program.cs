/*
 * Agencia bancaria com as operacoes de cadastro do cliente,
 * saque, deposito e extrato. 
 * 
 * Pode utilizar array ou lista para varios clientes. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exbanco;
// classe base cliente
public class Cliente
{
    //private static void Main(string[] args)
    public int n_conta;
    public float saldo;
    public string nome;
}

// classe principal dos metodos
class principal
{

        private static void adiciona_cliente(string[] args)
        {
        
        string[] list_clients = new string[5];

        // adicionando clientes a lista
        for (int i = 0; i < list_clients.Length; i++)
            {
                // instanciando o objeto da classe cliente
                Cliente c = new Cliente();

                // recebendo os dados do usuario
                Console.WriteLine($"Digite o nome do cliente {i}:");
                c.nome = Console.ReadLine();

                Console.WriteLine($"Digite o numero da conta do cliente{i}:");
                c.n_conta = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine($"Insira o saldo do cliente {i}:");
                c.saldo = Convert.ToInt16(Console.ReadLine());

            }
        }

        private static void saque(double saldo, double valor_pos_saque)
        {
            // inserindo valor de saque
            Console.WriteLine("Insira o valor do saque:");
            double valor_saque = Convert.ToDouble(Console.ReadLine());

            valor_pos_saque = saldo - valor_saque;
            // conferindo se o valor de saque esta disponivel
            if (valor_saque > saldo)
        {
            Console.WriteLine("Não foi possível efetuar a operação, valor indisponível para saque!!!");
        }
        else
        {
            Console.WriteLine($"O valor pos saque foi de {valor_pos_saque.ToString("0.00")} ");
        }
            

        


        }
}
    


