using DesignPaternsCurso.Interfaces;
using DesignPaternsCurso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso
{
    public class EnviadorDeEmail : IAcoesNF
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviado email");
        }
    }
}
