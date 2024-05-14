using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class ClienteJuridico : Cliente
    {
        private int cnpj;
        public ClienteJuridico(): base()
        {            
        }
        public ClienteJuridico(int codigo, string nome, string endereco, int idade, int cnpj) : base(codigo, nome, endereco, idade)
        {
            Cnpj = cnpj;
        }
        public override void Mostrar()
        {
            System.Console.WriteLine("\nCódigo do cliente: " + codigo);
            System.Console.WriteLine("Nome do cliente: " + nome);
            System.Console.WriteLine("Endereço do cliente: " + endereco);
            System.Console.WriteLine("Cnpj: " + Cnpj);
            System.Console.WriteLine("Idade: " + idade);
        }
        public int Cnpj{
            get { return cnpj;}
            set { cnpj = value;}
        }

        public override void AvaliaIdade()
        {
            if (Idade >= 40)
                System.Console.WriteLine("\nCliente Jurídico!");
        }
    }
}