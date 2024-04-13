using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        private double comissao;
        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("\nValor da comissão: " + this.Comissao);
        }
    }
}