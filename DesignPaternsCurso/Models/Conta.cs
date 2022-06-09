using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models
{
    public class Conta
    {
        public IEstadoDeUmSaldo EstadoSaldo { get; set; }
        public double Saldo { get; set; } 

        public Conta(double saldo)
        {
            Saldo = saldo;
            if (this.Saldo > 0)
            {
                this.EstadoSaldo = new SaldoPositivo();
            }
            else
            {
                this.EstadoSaldo = new SaldoNegativo();
            }
        }
       
        public void AplicaDeposito(double valor)
        {
            EstadoSaldo.Deposito(this, valor);
        }

        public void AplicaSaque(double valor)
        {
            EstadoSaldo.Saque(this, valor);
        }
    }
}
