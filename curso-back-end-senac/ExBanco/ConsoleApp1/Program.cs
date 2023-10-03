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
    public string operacao_saque { get; set; }
}

// classe principal dos metodos
class principal
{

    public static void Main(string[] args)
    {

        //string[] list_clients = new string[0];

        // adicionando clientes a lista
        //for (int i = 0; i < list_clients.Length; i++)
        //{
        // instanciando o objeto da classe cliente
        Cliente c = new Cliente();

        // recebendo os dados do usuario
        Console.WriteLine($"Digite o nome do cliente :");
        c.nome = Console.ReadLine();

        Console.WriteLine($"Digite o numero da conta do cliente:");
        c.n_conta = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"Insira o saldo do cliente :");
        c.saldo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Insira um valor para saque do clinete :");
        c.valor_saque = Convert.ToDouble(Console.ReadLine());

        c.operacao_saque = saque(c.saldo, c.valor_saque);
        Console.WriteLine($"{c.operacao_saque}");





        //}
    }

    static string saque(double saldo, double valor_saque)
    {

        // o tipo de retorno do metodo deve ser 
        // igual ao seu tipo
        double valor_pos_saque = saldo - valor_saque;
        string retorno_positivo = "Não foi possível efetuar a operação, valor indisponível para saque!!!";
        string retorno_negativo = $"O valor pos saque foi de {valor_pos_saque.ToString("0.00")} ";

        // conferindo se o valor de saque esta disponivel
        if (valor_saque >= saldo)
        {
            return retorno_positivo;
        }
        else
        {
            return retorno_negativo;
        }
    }
}




