using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Livro : Produto
    {
        public string Autor { get; set; }

        public Livro(string titulo, double preco, string autor) : base(titulo, preco)
        {
            Autor = autor;
        }

        public override void InformarDescricao()
        {
            Console.WriteLine($"{Titulo} escrito por {Autor}");
        }



    }
}
