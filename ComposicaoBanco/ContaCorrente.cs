using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private double saldo;
        private double chequeEspecial;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public double ChequeEspecial
        {
            get { return chequeEspecial; }
            set { chequeEspecial = value; }
        }

        public void Depositar(deposito)
        {
            this.saldo += deposito;
        }

        public void Sacar(saque)
        {
            if (saque > this.saldo)
                
        }
    }
}