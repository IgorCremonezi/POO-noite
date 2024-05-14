using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class ClienteFisico : Cliente
    {
        private int rg;
        public ClienteFisico(): base()
        {            
        }
        public override void Mostrar()
        {
            System.Console.WriteLine("\nCódigo do cliente: " + codigo);
            System.Console.WriteLine("Nome do cliente: " + nome);
            System.Console.WriteLine("Endereço do cliente: " + endereco);
            System.Console.WriteLine("Rg: " + Rg);
            System.Console.WriteLine("Idade: " + idade);
        }

        public ClienteFisico(int codigo, string nome, string endereco, int idade, int rg) : base(codigo, nome, endereco, idade)
        {
            Rg = rg;
        }
        public int Rg{
            get { return rg;}
            set { rg = value;}
        }

        public override void AvaliaIdade()
        {
            if (Idade >= 18 && Idade < 40)
                System.Console.WriteLine("\nCliente Físico!");
        }
    }
}