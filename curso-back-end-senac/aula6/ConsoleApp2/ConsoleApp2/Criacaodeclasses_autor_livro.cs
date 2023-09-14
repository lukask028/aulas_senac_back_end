// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace livros;
class Program
{
    static void Main(string[] args)
    {
        //Cria um autor
        Autor tolkien = new Autor
        {
            AutorId = 1,
            Nome = "J.R.R Tolkien",
            DataNascimento = new DateTime(1892, 1, 3)
        };

        //Criar um livro
        Livro senhorDosAneis = new Livro
        {
            LivroId = 1,
            Título = "O Senhor do Anéis",
            AnoPublicacao = 1954,
            Autor = tolkien
        };

        //Associar o livro ao autor 
        tolkien.Livros.Add(senhorDosAneis);

        //Exibir as informações
        Console.WriteLine($"Autor: {tolkien.Nome}");
        foreach (var livro in tolkien.Livros)
        {
            Console.WriteLine($"Livro: {livro.Título}, Publicado em: {livro.AnoPublicacao}");
        }

    }
}
