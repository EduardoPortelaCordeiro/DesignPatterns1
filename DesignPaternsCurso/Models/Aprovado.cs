using DesignPaternsCurso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models
{
    internal class Aprovado : IEstadoDeUmOrcamento
    {
        public bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto jà aplicado!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Este orçamento já está aprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Este orçamento já está aprovado!");
        }
    }
}
