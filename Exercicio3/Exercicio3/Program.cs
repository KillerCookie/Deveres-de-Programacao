using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto Yakusa = new JogoDigital("Yakusa0", 36, "PS4");
            Produto Hades = new JogoDigital("Hades", 37, "PS4");
            Produto Livro1 = new Livro("Metamorfose", 40, "Franz Kafka");
            Produto Livro2 = new Livro("O Iluminado", 40, "Stephen King");

            Produto[] produtos = { Yakusa, Hades, Livro1, Livro2 };

            foreach (Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.WriteLine("...........");
                Console.ReadLine();
            }


        }
    }
}
