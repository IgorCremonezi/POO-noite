using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> VetItens { get; set; }
        public NotaFiscal(int numNf, string data)
        {
            NumeroNf = numNf;
            Data = data;
            VetItens = new List<ItemNotaFiscal>();
        }
        public void AdicionaItens(ItemNotaFiscal itens)
        {
            VetItens.Add(itens);
        }
    }
}