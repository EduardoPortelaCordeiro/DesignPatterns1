using DesignPaternsCurso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models
{
    internal class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Estado Reprovadi");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Este orçamento já está Reprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Este orçamento já está Reprovado!");
        }
    }
}
