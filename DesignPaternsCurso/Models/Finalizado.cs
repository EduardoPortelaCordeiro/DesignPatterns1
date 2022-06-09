using DesignPaternsCurso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models
{
    internal class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Estado Finalizado não possui desconto!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento Finalizado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento Finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento Finalizado!");
        }
    }
}
