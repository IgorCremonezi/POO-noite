using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaPagamentoProduto
{
    public class ItemVenda
    {
        public int Quantidade { get; set; }
        public Produto Prod { get; set; }
        public double Preco { get; set; }
        public double Subtotal { get; set; }

        public ItemVenda(int quantidade, Produto prod)
        {
            Quantidade = quantidade;
            Prod = prod;
            Preco = Prod.Preco;
            Subtotal = Prod.Preco * Quantidade;
        }

        public void MostrarAtributosItemVenda()
        {
            System.Console.WriteLine("\nQuantidade do item de venda: " + Quantidade);
            System.Console.WriteLine("Produto do item de venda: " + Prod.Nome);
            System.Console.WriteLine("Preço do item de venda: " + Preco);
            System.Console.WriteLine("Subtotal do item de venda: " + Subtotal);
        }
    }
}