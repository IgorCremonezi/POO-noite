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

        public void Depositar(double deposito)
        {
            this.saldo += deposito;
        }

        public void Sacar(double saque)
        {
            double diferenca = 0;
            if (saque > this.saldo)
            {
                diferenca = saque - this.saldo;
                if (diferenca <= this.chequeEspecial)
                    this.saldo -= saque;
                else
                    System.Console.WriteLine("\nO valor do saque ultrapassa o limite do cheque especial da conta");
            }
            else
                this.saldo -= saque;
        }

        public void GerarExtrato()
        {
            System.Console.WriteLine("\nSaldo da conta: " + this.saldo);
            System.Console.WriteLine("\nCheque Especial da conta: " + this.chequeEspecial);
        }
    }
}