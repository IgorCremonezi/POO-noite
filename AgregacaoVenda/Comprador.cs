using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;
        public double Verba
        {
            get { return verba; }
            set
            {
                if (value >= 0)
                    verba = value;
                else
                    System.Console.WriteLine("\nInforme um valor de verba!");
            }
        }
        public Comprador (double verbaInicial)
        {
            this.verba = verbaInicial;
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("\nValor de verba: " + this.verba);
        }
    }
}