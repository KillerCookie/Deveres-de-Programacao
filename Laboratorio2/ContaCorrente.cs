using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(string nome, string id) : base(nome, id) { }

        public override float Transferencia(float transferirDinheiro, ContaBancaria contaReceber)
        {
            saldoAtual -= (transferirDinheiro - 0.10f);
            return base.Transferencia(transferirDinheiro, contaReceber);
        }

        public override float Saque(float sacarDinheiro)
        {
            saldoAtual -= (sacarDinheiro - 0.37f);
            return base.Saque(sacarDinheiro);
        }
    }
}
