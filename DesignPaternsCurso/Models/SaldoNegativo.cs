using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models
{
    public class SaldoNegativo : IEstadoDeUmSaldo
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
        }

        public void MudancaEstado(Conta conta)
        {
            if (conta.Saldo > 0)
            {
                conta.EstadoSaldo = new SaldoPositivo();
            }
            else
            {
                conta.EstadoSaldo = new SaldoNegativo();
            }
        }

        public void Saque(Conta conta, double valor)
        {
            throw new Exception("Contas com saldo negativo não podem ser sacadas!");
        }
    }
}
