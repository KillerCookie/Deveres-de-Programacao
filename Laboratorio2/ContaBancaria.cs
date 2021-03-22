using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
     public abstract class ContaBancaria
     {
        protected string numIdentificacao { get; set; }
        protected string nomeCorrentista { get; set; }
        protected float saldoAtual { get; set; }

        public ContaBancaria(string nomeCorrentista, string numIdentificacao)
        {
            this.nomeCorrentista = nomeCorrentista;
            this.numIdentificacao = numIdentificacao;
        }

        public virtual float Saque(float sacarDinheiro)
        {
            float ValorSaqueFinal = saldoAtual - sacarDinheiro;
            
            if(ValorSaqueFinal <= 0)
            {
                Console.WriteLine("Saque nao autorizado, saldo negativo");
                return -1;
            }

            Console.WriteLine($"Saque feito com sucesso {sacarDinheiro} nome: {nomeCorrentista}");
            return saldoAtual = ValorSaqueFinal;
        } 

        public virtual float Depositar(float depositarDinheiro)
        {
            Console.WriteLine($"Deposito feito com sucesso {depositarDinheiro} nome: {nomeCorrentista}");
            return saldoAtual += depositarDinheiro;
        }

        public virtual float Transferencia(float transferirDinheiro, ContaBancaria contaReceber)
        {
            float saldoFinal =  saldoAtual - transferirDinheiro;

            if (saldoFinal <= 0 ) 
            {
                Console.WriteLine("Transferencia nao autorizado");
                return -1;
            }

            Console.WriteLine($"Transferencia feito com sucesso {transferirDinheiro} de: {nomeCorrentista} para: {contaReceber.nomeCorrentista}");
            saldoAtual -= transferirDinheiro;
            return contaReceber.Depositar(transferirDinheiro);

        }
     }
}
