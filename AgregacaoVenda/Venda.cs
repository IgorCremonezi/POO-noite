using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        private Comprador comp;
        private Vendedor vend;
        private List<Produto> vetProd;
        public Comprador Comp
        {
            get { return comp; }
            set { comp = value; }
        }
        public Vendedor Vend
        {
            get { return vend; }
            set { vend = value; }
        }
        public List<Produto> VetProd
        {
            get { return vetProd; }
            set { vetProd = value; }
        }

        public void MostrarAtributos()
        {
            Comp.MostrarAtributos();
            Vend.MostrarAtributos();
            foreach (Produto prod in vetProd)
                prod.MostrarAtributos();
        }

        public void ValorComissaoVendedor()
        {
            double valorComissao = 0;
            foreach (Produto prod in vetProd)
                valorComissao += prod.Preco * (2.0 / 100);
            Vend.Comissao = valorComissao;
        }

        public void RealizarVenda(Comprador comprador)
        {
            double valorVenda = 0;
            foreach (Produto prod in vetProd)
                valorVenda += prod.Preco;
                
            if (comprador.Verba >= valorVenda)
                comprador.Verba -= valorVenda;
            else
                System.Console.WriteLine("\nVerba insuficiente!");
        }
    }
}