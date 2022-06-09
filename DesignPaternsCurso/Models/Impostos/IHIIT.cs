using DesignPaternsCurso.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models.Impostos
{
    public class IHIIT : ImpostoTemplate
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                foreach(Item sitem in orcamento.Itens)
                {
                    if (sitem.Name.Equals(item.Name)) return true;
;               }
            }
            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.01 + orcamento.Itens.Count());
        }
    }
}
