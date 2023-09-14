using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Autor
{
    public int AutorId { get; set; }
    
    public string Nome { get; set;}

    public DateTime DataNascimento { get; set; }

    // Lista de livros escritos por este autor 

    public List<Livros> Livros { get; set; }

    public Autor() 
    {
        Livros = new List<Livros>();
    }
}