using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models
{
    public class SaldoPositivo : IEstadoDeUmSaldo
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }
        public void Saque(Conta conta, double valor)
        {
            conta.Saldo -= valor;
        }

        public void MudancaEstado(Conta conta)
        {
            if(conta.Saldo > 0)
            {
                conta.EstadoSaldo = new SaldoPositivo();
            }
            else
            {
                conta.EstadoSaldo = new SaldoNegativo();
            }
        }
    }
}
