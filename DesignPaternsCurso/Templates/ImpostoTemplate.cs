using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Templates
{
    public abstract class ImpostoTemplate : IImposto
    {
        public ImpostoTemplate(IImposto outroImposto) : base(outroImposto) { }
        public ImpostoTemplate() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalculaOutroImposto(orcamento);
            }
            return MinimaTaxacao(orcamento) + CalculaOutroImposto(orcamento);
        }

        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}
