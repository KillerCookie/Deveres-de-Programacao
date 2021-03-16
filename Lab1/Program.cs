using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Perfil pessoa1 = new Perfil("Bob Nelson", 37, 1.70f, 78);

            Perfil pessoa2 = new Perfil("Testolfo Rocha", 47, 1.65f, 60);

            Perfil pessoa3 = new Perfil("Lisa Leite", 22, 1.72f, 92);

            pessoa1.DadosPessoais();
            pessoa2.DadosPessoais();
            pessoa3.DadosPessoais();


        }
    }
}
