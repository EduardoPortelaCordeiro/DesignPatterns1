using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models
{
    public interface IEstadoDeUmSaldo
    {
        void Deposito(Conta conta, double valor);
        void Saque(Conta conta, double valor);
        void MudancaEstado(Conta conta);
    }
}
