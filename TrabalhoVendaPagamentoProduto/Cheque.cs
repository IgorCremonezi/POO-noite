using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaPagamentoProduto
{
    public class Cheque : Pagamento
    {
        public long Numero { get; set; }
        public DateTime DataDeposito { get; set; }
        public int Situacao { get; set; }

        public Cheque(long numero, DateTime dataDeposito, int situacao, Venda vend) : base(vend)
        {
            Numero = numero;
            DataDeposito = dataDeposito;
            Situacao = situacao;
        }

        public override void MostrarAtributos()
        {
            System.Console.WriteLine("\nPagamento em cheque");
            System.Console.WriteLine("Numero do cheque: " + Numero);
            System.Console.WriteLine("Data do depósito do cheque: " + DataDeposito);
            System.Console.WriteLine("Situação do cheque: " + Situacao);
            base.MostrarAtributos();
        }
    }
}