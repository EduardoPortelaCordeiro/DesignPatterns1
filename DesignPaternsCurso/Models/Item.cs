using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaternsCurso
{
    public class Item
    {
        public string Name { get; set; }
        public double Valor { get; set; }
        
        public Item (string name, double valor)
        {
            this.Name = name;
            this.Valor = valor;
        }
    }
}
