using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcmaento)
        {
            return 0;
        }
    }
}
