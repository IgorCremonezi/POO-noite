using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaPagamentoProduto
{
    public class Pagamento
    {
        protected Venda vend;
        public Venda Vend
        {
            get { return vend; }
            set { vend = value; }
        }
        protected DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        protected double total;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        
        public Pagamento(Venda vend)
        {
            Vend = vend;
            Data = DateTime.Today;
            Total = Vend.Total;
        }

        public virtual void MostrarAtributos()
        {
            System.Console.WriteLine("\nData do Pagamento: " + Data);
            System.Console.WriteLine("Total do pagamento: " + Total);
            System.Console.WriteLine("Composição da Venda (Itens):\n");
            foreach (ItemVenda iv in Vend.ItensVenda)
            {
                iv.MostrarAtributosItemVenda();
            }
        }
    }
}