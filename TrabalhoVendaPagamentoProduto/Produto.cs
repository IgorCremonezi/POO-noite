using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaPagamentoProduto
{
    public class Produto
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(long codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void ReduzirEstoque(int quant)
        {
            Estoque -= quant;
        }

        public void MostrarAtributosProduto()
        {
            System.Console.WriteLine("\nCodigo do Produto: " + Codigo);
            System.Console.WriteLine("Nome do Produto: " + Nome);
            System.Console.WriteLine("Preço do Produto: " + Preco);
            System.Console.WriteLine("Estoque do Produto: " + Estoque);
        }
    }
}