using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class ContaCorrente : ITributavel
    {
        public double Saldo { get; set; }

        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }

        public double CalculaTributos()
        {
            double imposto = 0;
            imposto = this.Saldo * 5 / 100;
            return imposto;
        }

    }
}