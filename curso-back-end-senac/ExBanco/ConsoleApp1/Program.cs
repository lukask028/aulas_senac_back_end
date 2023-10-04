/*
 * Agencia bancaria com as operacoes de cadastro do cliente,
 * saque, deposito e extrato. 
 * 
 * Pode utilizar array ou lista para varios clientes. 
*/
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Exbanco;
// classe base cliente
public class Cliente
{

    public int n_conta { get; set; }
    public string nome { get; set; }
    public double saldo { get; set; }
    public double valor_saque { get; set; }

    public double valor_deposito { get; set; }
    

    public double operacao_saque { get; set; }
    public double operacao_deposito { get; set; }

    public string saida_extrato { get; set; }

}

// classe principal dos metodos
class principal
{

    public static void Main(string[] args)
    {

        string[] list_clients = new string[2];

        // adicionando clientes a lista
        for (int i = 0; i < list_clients.Length; i++)
        {
            // instanciando o objeto da classe cliente
            Cliente c = new Cliente();

            // recebendo os dados do usuario
            Console.WriteLine($"Digite o nome do cliente {i} :");
            c.nome = Console.ReadLine();

            Console.WriteLine($"Digite o numero da conta do cliente {i}:");
            c.n_conta = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Insira o saldo do cliente {i} :");
            c.saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Insira um valor para saque do clinete {i} :");
            c.valor_saque = Convert.ToDouble(Console.ReadLine());

            // variavel para armazenar retorno do metodo


            if (c.valor_saque > c.saldo)
            {
                Console.WriteLine("Não foi possível executar o saque, saldo insuficiente!!!");

                c.saida_extrato = extrato(c.nome, c.n_conta, c.saldo);
                Console.WriteLine($"{c.saida_extrato}");

            }

            else
            {
                c.operacao_saque = saque(c.saldo, c.valor_saque);
                Console.WriteLine($"O valor pos saque é de: {c.operacao_saque}");

                Console.WriteLine($"Insira um valor para deposito do clinete {i} :");
                c.valor_deposito = Convert.ToDouble(Console.ReadLine());

                c.operacao_deposito = deposito(c.operacao_saque, c.valor_deposito);
                Console.WriteLine($"O valor pos deposito: {c.operacao_deposito}");

                c.saida_extrato = extrato(c.nome, c.n_conta, c.operacao_deposito);
                Console.WriteLine($"{c.saida_extrato}");
            }

            //}


            Console.WriteLine("\n\n\n");


        }


    }
        // metodo saque
        static double saque(double saldo, double valor_saque)
        {
            double valor_pos_saque = saldo - valor_saque;

            return valor_pos_saque;
        }

        // metodo deposito 
        static double deposito(double saldo, double valor_deposito)
        {
            double valor_pos_deposito = saldo + valor_deposito;


            return valor_pos_deposito;
        }

        static string extrato(string nome, int n_conta, double saldo)
        {

            string resultado = ($"Cliente: {nome}\n Número da conta: {n_conta}\n Saldo: {saldo}\n");
            return resultado;

        }
}




