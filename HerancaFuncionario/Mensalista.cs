using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Mensalista : Funcionario
    {
        private double qtdeHorasTrabalhadas;
        public double QtdeHorasTrabalhadas
        {
            get { return qtdeHorasTrabalhadas; }
            set { qtdeHorasTrabalhadas = value; }
        }
        
        public Mensalista(int codigo, string nome, double salario, double qtdeHorasTrabalhadas) : base(codigo, nome, salario)
        {
            QtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
        }

        public void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine("Quantidade de horas trabalhadas: " + this.qtdeHorasTrabalhadas);
        }
    }
}