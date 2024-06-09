using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaPagamentoProduto
{
    public class Venda
    {
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public List<ItemVenda> ItensVenda { get; set; }

        public Venda(DateTime data)
        {
            Data = data;
            Total = 0;
            ItensVenda = new List<ItemVenda>();
        }

        public void AdicionarItem(ItemVenda item)
        {
            ItensVenda.Add(item);
            Totalizador();
        }

        public void RemoverItem(ItemVenda item)
        {
            ItensVenda.Remove(item);
            Totalizador();
        }

        public void Totalizador()
        {
            double Total = 0;
            foreach (ItemVenda item in ItensVenda)
            {
                Total += item.Subtotal;
            }
        }

        public void MostrarAtributosVenda()
        {
            System.Console.WriteLine("\nData da Venda: " + Data);
            System.Console.WriteLine("Total da Venda: " + Total);
            System.Console.WriteLine("Itens da venda:\n");
            foreach (ItemVenda item in ItensVenda)
            {
                item.MostrarAtributosItemVenda();
            }
        }
    }
}