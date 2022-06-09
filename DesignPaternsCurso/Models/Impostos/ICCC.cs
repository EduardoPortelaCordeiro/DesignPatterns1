using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso
{
    public class ICCC : IImposto
    {
        public ICCC(IImposto outroImposto) : base(outroImposto) { }
        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000.00)
            {
                return orcamento.Valor * 0.05 + CalculaOutroImposto(orcamento);
            }
            else if (orcamento.Valor >= 1000.00 && orcamento.Valor <= 3000.00)
            {
                return orcamento.Valor * 0.07 + CalculaOutroImposto(orcamento);
            }
            else
            {
                return orcamento.Valor * 0.08 + 30 + CalculaOutroImposto(orcamento);
            }
        }
    }
}
