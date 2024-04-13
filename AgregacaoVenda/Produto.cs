using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private static int proxCodigo = 500;
        private int codigo;
        private string nome;
        private double preco;
        public Produto()
        {
            this.codigo = proxCodigo++;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    nome = value;
                else
                    System.Console.WriteLine("\nO produto deve ter um nome!");
            }
        }
        public double Preco
        {
            get { return preco; }
            set
            {
                if (value >= 0)
                    preco = value;
                else
                    System.Console.WriteLine("\nO produto deve ter um preço!");
            }
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("\nCódigo do produto: " + this.Codigo);
            System.Console.WriteLine("Nome do produto: " + this.Nome);
            System.Console.WriteLine("Preço do produto: " + this.Preco);
        }
    }
}