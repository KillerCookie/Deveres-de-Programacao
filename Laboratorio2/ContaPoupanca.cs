using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    class ContaPoupanca : ContaBancaria
    {
        
        public ContaPoupanca(string nome, string id) : base(nome, id) { }
        
        public override float Transferencia(float transferirDinheiro, ContaBancaria contaReceber)
        {
            saldoAtual -= (transferirDinheiro - 0.15f);
            return base.Transferencia(transferirDinheiro, contaReceber);
        }

        public override float Saque(float sacarDinheiro)
        {
            saldoAtual -= (sacarDinheiro - 0.20f);
            return base.Saque(sacarDinheiro);
        }
    }
}
