using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso
{
    public interface IDesconto
    {
        public double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
