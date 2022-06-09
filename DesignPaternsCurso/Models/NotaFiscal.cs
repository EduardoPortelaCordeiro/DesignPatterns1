using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso.Models
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataEmissao { get; set; }
        public double Valor { get; set; }
        public double Impostos { get; set; }
        public IList<Produto> Items { get; set; }
        public string Observacoes { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, double valor, double impostos, IList<Produto> items, string observacoes)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            DataEmissao = dataEmissao;
            Valor = valor;
            Impostos = impostos;
            Items = items;
            Observacoes = observacoes;
        }


    }
}
