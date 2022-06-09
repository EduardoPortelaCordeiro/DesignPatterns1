using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Interfaces
{
    public interface IEstadoDeUmOrcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);

    }
}
