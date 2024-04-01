using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;

        public int Numero//propriedade
        {
            set {
                this.numero = value;
            }
            get{
                return this.numero;
            }
        }
        
        private string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        
        /*public void SetNumero(int numero)//AlterarNumero
        {
            this.numero = numero;
        }
        public int GetNumero()//BuscaNumero
        {
            return numero;
        }
        public void AlterarNumero(int numeroConta)
        {
            numero = numeroConta;
        }
        public int BuscarNumero()
        {
            return numero;
        }*/

    }
}