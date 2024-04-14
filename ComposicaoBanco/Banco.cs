using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        private List<Poupanca> poups;
        private List<ContaCorrente> contas;
        public List<Poupanca> Poups
        {
            get { return poups; }
            set { poups = value; }
        }
        public List<ContaCorrente> Contas
        {
            get { return contas; }
            set { contas = value; }
        }

        public Banco()
        {
            this.poups = new List<Poupanca>();
            this.contas = new List<ContaCorrente>();
        }

        public void IniciarBanco()
        {
            this.poups.Clear();
            this.contas.Clear();
        }

        public void AbrirConta(ContaCorrente contaCorrente)
        {
            this.contas.Add(contaCorrente);
        }

        public void AbrirPoupanca(Poupanca contaPoupanca)
        {
            this.poups.Add(contaPoupanca);
        }

        public void MostrarAtributos()
        {
            foreach (ContaCorrente ccs in this.contas)
                ccs.GerarExtrato();
            foreach (Poupanca poup in this.poups)
                poup.MostrarAtributos();
        }
        
        public void DecretarFalencia()
        {
            this.poups = null;
            this.contas = null;
        }
    }
}