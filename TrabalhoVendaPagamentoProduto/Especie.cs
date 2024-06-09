using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaPagamentoProduto
{
    public class Especie : Pagamento
    {
        public double Quantia { get; set; }
        public double Troco { get; set; }

        public Especie(double quantia, Venda vend) : base (vend)
        {
            Quantia = quantia;
            if (vend != null)
                Troco = quantia - vend.Total;
            else
                Troco = quantia;
        }

        public override void MostrarAtributos()
        {
            System.Console.WriteLine("\nPagamento em Espécie");
            System.Console.WriteLine("Quantia: " + Quantia);
            System.Console.WriteLine("Troco: " + Troco);
            base.MostrarAtributos();
        }
    }
}