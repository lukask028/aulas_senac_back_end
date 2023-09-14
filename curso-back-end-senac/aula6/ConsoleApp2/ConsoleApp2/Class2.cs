using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Livro
    {
        public int LivroId { get; set; }

        public string Titulo { get; set; }

        public int AnoPublicacao { get; set; }

        //Referência ao autor deste livro

        public Autor Autor { get; set; }
    }
}
