using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso
{
    public abstract class IImposto
    {
        public IImposto OutroImposto { get; set; }
        public IImposto()
        {
            this.OutroImposto = null;
        }
        public IImposto(IImposto OutroImposto)
        {
            this.OutroImposto = OutroImposto;
        }
        public abstract double Calcula(Orcamento orcamento);
        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}
