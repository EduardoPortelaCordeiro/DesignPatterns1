using DesignPaternsCurso.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models.Impostos
{
    internal class IPCK : ImpostoTemplate
    {
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6;
        }
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 500)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
