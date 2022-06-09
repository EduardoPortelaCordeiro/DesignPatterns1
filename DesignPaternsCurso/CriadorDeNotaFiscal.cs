using DesignPaternsCurso.Interfaces;
using DesignPaternsCurso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso
{
    public class CriadorDeNotaFiscal
    {
        private string RazaoSocial { get; set; }
        private string CNPJ { get; set; }
        private string Observacoes { get; set; }
        private DateTime Data { get; set; }

        private double valorTotal;
        private double impostos;
        private IList<Produto> todosItens = new List<Produto>();
        private IList<IAcoesNF> todasAcoesASeremExecutadas = new List<IAcoesNF>();

        public CriadorDeNotaFiscal()
        {
            this.Data = DateTime.Now;
        }

        public DateTime NaDataAtual(DateTime novaData)
        {
            return this.Data = novaData;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, CNPJ, Data, valorTotal, impostos, todosItens, Observacoes);

            foreach(IAcoesNF acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionaAcao(IAcoesNF novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public CriadorDeNotaFiscal ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public CriadorDeNotaFiscal comObservacoes(string observacoies)
        {
            Observacoes = observacoies;
            return this;
        }
        public CriadorDeNotaFiscal ComCNPJ(string cnpj)
        {
            CNPJ = cnpj;
            return this;
        }
        public CriadorDeNotaFiscal comItem(Produto produto)
        {
            todosItens.Add(produto);
            valorTotal += produto.Valor;
            impostos += produto.Valor * 0.5;

            return this;
        }

        public CriadorDeNotaFiscal NaData(DateTime data)
        {

            Data = data;
            return this;
        }
    }
}
