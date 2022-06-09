// See https://aka.ms/new-console-template for more information
using DesignPaternsCurso;
using DesignPaternsCurso.Models;

CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();

criador
    .ParaEmpresa("SiMCo - HealtCare")
    .ComCNPJ("23.225.789/0001")
    .comItem(new Produto("item1", 23.00))
    .comItem(new Produto("item2", 2.00))
    .comItem(new Produto("item3", 33.33))
    .comObservacoes("Compra realizada através de aplicação online");

NotaFiscal nf = criador.Constroi();

Console.WriteLine(nf.Valor);
Console.WriteLine(nf.Impostos);
Console.WriteLine(nf.Observacoes);