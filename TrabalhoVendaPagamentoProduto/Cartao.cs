using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaPagamentoProduto
{
    public class Cartao : Pagamento
    {
        public string DadosTransacao { get; set; }
        public int ResultadoTransacao { get; set; }

        public Cartao(string dadosTransacao, int resultadoTransacao, Venda vend) : base (vend)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }

        public override void MostrarAtributos()
        {
            System.Console.WriteLine("\nPagamento em cartão");
            System.Console.WriteLine("Dados da transação do cartão: " + DadosTransacao);
            System.Console.WriteLine("Resultado da transação do cartão: " + ResultadoTransacao);
            base.MostrarAtributos();
        }
    }
}