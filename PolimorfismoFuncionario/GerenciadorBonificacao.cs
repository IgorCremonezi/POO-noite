using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;
        public double TotalBonificacao
        {
            get { return totalBonificacao; }
            set { totalBonificacao = value; }
        }
        
        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Diretor diretor)
        {
            this.TotalBonificacao += diretor.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Gerente gerente)
        {
            this.TotalBonificacao += gerente.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Secretario secretario)
        {
            this.TotalBonificacao += secretario.CalcularBonificacao();
        }
    }
}