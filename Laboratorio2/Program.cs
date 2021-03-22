using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente bobNelson = new ContaCorrente("Bob Nelson", "12345-6");

            ContaPoupanca tesltolfoRocha = new ContaPoupanca("Testolfo Rocha", "71717-1");

            ContaCorrente lisaLeite = new ContaCorrente("Lisa Leite", "65432-1");

            bobNelson.Depositar(5000f);
            lisaLeite.Depositar(2000f);
            tesltolfoRocha.Depositar(1500f);

            bobNelson.Transferencia(600f, tesltolfoRocha);
            lisaLeite.Saque(200f);
            lisaLeite.Transferencia(400f, tesltolfoRocha);

            tesltolfoRocha.Transferencia(1000f, bobNelson);
            bobNelson.Saque(900000f);
            bobNelson.Transferencia(1500f, lisaLeite);

            tesltolfoRocha.Transferencia(1200f, lisaLeite);
            bobNelson.Saque(2000f);
            lisaLeite.Depositar(100f);

            tesltolfoRocha.Transferencia(700f, bobNelson);
        }
    }
}
