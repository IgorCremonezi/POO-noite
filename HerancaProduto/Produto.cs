using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Produto
    {
        protected int codigo;
        public int Codigo
        {
            get {return codigo; }
            set {codigo = value; }
        }
        protected string nome;
        public string Nome
        {
            get {return nome; }
            set {nome = value; }
        }
        protected double preco;
        public double Preco
        {
            get {return preco; }
            set {preco = value; }
        }
        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public Produto()
        {
        }

        public virtual void MostrarAtributos()
        {
            System.Console.WriteLine("\nCódigo do produto: " + Codigo);
            System.Console.WriteLine("Nome do produto: " + Nome);
            System.Console.WriteLine("Preço do produto: " + Preco);
        }
    }
}