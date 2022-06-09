using DesignPaternsCurso.Interfaces;
using DesignPaternsCurso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso
{
    public class Multiplicador : IAcoesNF
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator) { this.Fator = fator; }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.Valor * this.Fator);
        }
    }
}