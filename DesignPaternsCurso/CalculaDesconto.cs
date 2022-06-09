using DesignPaternsCurso.Descontos;
using DesignPaternsCurso.Models.Descontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso
{
    public class CalculaDesconto
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorMaisdeCincoItens();
            IDesconto d2 = new DescontoPorMaisdeQuinhentos();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;
            return d1.Desconta(orcamento);
        }
    }
}
