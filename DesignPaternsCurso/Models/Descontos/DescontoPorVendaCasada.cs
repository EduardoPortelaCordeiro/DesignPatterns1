
namespace DesignPaternsCurso.Models.Descontos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Any(s => s.Name.ToUpper() == "CANETA") && orcamento.Itens.Any(s => s.Name.ToUpper() == "LAPIS"))
            {
                return orcamento.Valor * 0.05;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}
