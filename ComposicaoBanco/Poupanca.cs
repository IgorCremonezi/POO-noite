using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value > 0)
                    saldo = value;
                else
                {
                    System.Console.WriteLine("\nInforme um valor válido!");
                }
            }
        }

        public void Depositar(double deposito)
        {
            this.saldo += deposito;
        }

        public void Sacar(double saque)
        {
            if (this.saldo >= saque)
                saldo -= saque;
            else
                System.Console.WriteLine("\nNão há saldo suficiente para o saque desejado!");
        }

        public void GerarRendimento()
        {
            this.saldo += this.saldo * (0.59 / 100);
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("\nSaldo da conta poupança: " + this.saldo);
        }
    }
}