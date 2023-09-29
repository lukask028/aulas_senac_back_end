using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class Pessoa
{
    public string nome, sobrenome, escolaridade;
    public int idade;
    public double altura, peso;

}

    class Principal
    {

        private static void Main(string[] args)
        {
        // variavel controle entrada de info
        int limite_informacao = 0;
        // contador
        int i = 0;
        Console.WriteLine("Algoritmo Classe Pessoa\n");
        try{ 
        Console.WriteLine("Insira a quantidade de pessoas qual você quer entrar com dados:\n");
        limite_informacao = Convert.ToInt16(Console.ReadLine());

            for (i = 0; i < limite_informacao; i++)
            {   // instanciando objeto da classe pessoa para poder receber dados
                Pessoa p = new Pessoa();

                // recebimento dos dados para os atributos da classe
                Console.WriteLine($"\nInsira o nome da pessoa{i}");
                p.nome = Console.ReadLine();

                Console.WriteLine($"\nInsira o sobrenome da pessoa{i}");
                p.sobrenome = Console.ReadLine();

                Console.WriteLine($"\nInsira a idade da pessoa{i}");
                p.idade = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine($"\nInsira a altura da pessoa{i}");
                p.altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"\nInsira o peso da pessoa{i}");
                p.peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"\nInsira a escolaridade da pessoa{i}");
                Console.WriteLine($"\n(2ºgrau incompleto ou superior incompleto)");
                p.escolaridade = Console.ReadLine();



                // calculo do imc de cada pessoa
                double imc;

                imc = p.peso / (p.altura * p.altura);

                // exibe as mensagens com os dados 
                Console.WriteLine($"\nO nome da pessoa é {p.nome}");
                Console.WriteLine($"O sobrenome da pessoa é {p.sobrenome}");
                Console.WriteLine($"A altura da pessoa é {p.altura.ToString("0.00")} cm");
                Console.WriteLine($"O peso da pessoa é {p.peso.ToString("0.00")} kg");
                Console.WriteLine($"O imc da pessoa é {imc.ToString("0.00")} kg/m2");
                Console.WriteLine($"A escolaridade da pessoa é {p.escolaridade}");


                // condicao da idade
                if (p.idade < 18)
                {
                    Console.WriteLine($"{p.nome} tem direito a estudar");
                }
                else
                {
                    Console.WriteLine($"{p.nome} tem direito a voto, e ser preso, trabalhar em tempo integral");
                }

                // classificacao do imc
                if (imc <= 16.9)
                {
                    Console.WriteLine($"O peso de {p.nome} está abaixo da média.");
                }

                else if (imc > 18.5 && imc < 24.9)
                {

                    Console.WriteLine($"O peso de {p.nome} está entre a média.");
                }

                else
                {
                    Console.WriteLine($"O peso de {p.nome} está acima da média.");
                }

                // cursos oferecidos de acordo com a escolaridade
                if (p.escolaridade == "2ºgrau incompleto")
                {
                    Console.WriteLine("Cursos Oferecidos: \n - Auxiliar Técnico Administrativo \n - Auxiliar de Logística \n - Desenvolvedor backend .net");
                }
                else if (p.escolaridade == "superior incompleto")
                {
                    Console.WriteLine("Cursos Oferecidos: \n - Desenvolvimento e Análise de Sistemas \n - Biologia \n - Direito");
                }
                else
                {
                    Console.WriteLine("Opção Inválida!!");
                }

            }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nCodigo executado com sucesso!");
            }

            }
        }
    
