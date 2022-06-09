using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso
{
    public class ICMS : IImposto
    {
        public ICMS(IImposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculaOutroImposto(orcamento);
        }
    }
}
