using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso
{
    public class ProdutoBuilder
    {
        private string Name { get; set; }
        public double Valor { get; set; }

        public ProdutoBuilder comNome(string name)
        {
            Name = name;
            return this;
        }

        public ProdutoBuilder comValor(double valor)
        {
            Valor = valor;
            return this;
        }
    }
}
