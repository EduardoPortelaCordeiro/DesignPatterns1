using DesignPaternsCurso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }

        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser finalizado diretamente!");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
