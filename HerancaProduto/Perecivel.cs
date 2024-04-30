using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        private string dataFabricacao;
        public string DataFabricacao
        {
            get { return dataFabricacao; }
            set { dataFabricacao = value; }
        }
        private string dataValidade;
        public string DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }
        private int lote;
        public int Lote
        {
            get { return lote; }
            set { lote = value; }
        }
        public Perecivel(int codigo, string nome, double preco, string dataFabricacao, string dataValidade, int lote) : base (codigo, nome, preco)
        {
            DataFabricacao = dataFabricacao;
            DataValidade = dataValidade;
            Lote = lote;
        }

        public Perecivel() : base()
        {
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            System.Console.WriteLine("Data de fabricação do produto: " + DataFabricacao);
            System.Console.WriteLine("Data de validade do produto: " + DataValidade);
            System.Console.WriteLine("Número do lote do produto: " + Lote);
        }
    }
}