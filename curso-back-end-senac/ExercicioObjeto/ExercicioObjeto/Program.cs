using System;
using System.Runtime.CompilerServices;



/////////////// Classe objeto Carro

/*class Program
{
    public static void Main(string[] args)
    {
        ObjCarro carro = new ObjCarro();
        // Escolha da Marca
        byte m = 0;
        if (m == 1)
        {
            carro.marca = "Fiat";
        }
        else if (m == 2)
        {
            carro.marca = "Ford";
        }
        else
        {
            carro.marca = "Genérico";
        }

        //Modelo
        byte md = 2;
        switch (md)
        {
            case 1:
                carro.modelo = "SUV";
                break;

            case 2:
                carro.modelo = "Sedan";
                break;

            case 3:
                carro.modelo = "Hatch";
                break;

            case 4:
                carro.modelo = "Picape";
                break;

            default:
                carro.modelo = "Inexistente";
                break;
        }

        carro.ano = 1981;

        carro.cor = "Azul";

        carro.valorFipe = 2000.99;

        Console.WriteLine(carro.marca + "-" + carro.modelo + "-" + carro.ano + "-" + carro.cor + "-" + carro.valorFipe);


    }
} /*

/*class ObjCarro
{
    public string marca { get; set; }
    public string modelo { get; set; }
    public int ano { get; set; }
    public string cor { get; set; }
    public double valorFipe { get; set; }
}*/


// classe de formatação do objeto
class pega_numero
{
    // atributo do objeto
    public int numeroVerificado { get; set; }
    public int num1 {  get; set; }
    public int num2 { get; set; }
    public int soma { get; set; }

    public string verificaNumero { get; set; }
}


// classe principal
class Program
{
    public static void Main(string[] args)
    {
        pega_numero n = new pega_numero();
        Console.WriteLine("Algoritmo impar par \n");

        
        Console.WriteLine("Insira o numero para verificacao:");
        n.numeroVerificado = Convert.ToInt16(Console.ReadLine());
        
        n.verificaNumero = verificaNumeros(n.numeroVerificado);
        Console.WriteLine($"O numero verificado é \n {n.verificaNumero}");
        

         // foi passado para um metodo chamado verificaNumeros, fora da classe principal 

        /*if (n.numeroVerificado % 2 == 0)
        {
            Console.WriteLine($"O numero {n.numeroVerificado} é par");
        }

        else
        {
            Console.WriteLine($"O numero {n.numeroVerificado} é impar");
        }*/

        Console.WriteLine("Soma de dois valores:\n");
        Console.WriteLine("Digite o primeiro numero:");
        n.num1 = Convert.ToInt16(Console.ReadLine());
            
        
        Console.WriteLine("Digite o segundo numero:");
        n.num2 = Convert.ToInt16(Console.ReadLine());

        n.soma = somanumeros(n.num1, n.num2);
        Console.WriteLine($"{n.num1} + {n.num2} = {n.soma} ");

        // chama o método sendo esse do tipo void, 
        // e executa o que tem dentro dele
        escreve_nome();

    }

    // a chamada do metodo tem que estar dentro da classe main
    // criacao do metodo para somar dois numeros
    static int somanumeros(int num1, int num2)
    {
       
        int resultado = num1 + num2;
        
        return resultado;
    }

     // o tipo de retorno do metodo deve ser 
     // igual ao seu tipo
    static string  verificaNumeros(int num1)
        {
        string resultado_par = $"O numero  é par";
        string resultado_impar = $"O numero é impar";

        if (num1 % 2 == 0)
            {
            return resultado_par;
            }
            else
            {
            return  resultado_impar;
            }
        }

    static void escreve_nome()
    {
        string nome;
        Console.WriteLine("Escreva o seu nome:\n");
        nome = Console.ReadLine();
        Console.WriteLine($"Obrigado por usar nosso teste, {nome}");

    }
}