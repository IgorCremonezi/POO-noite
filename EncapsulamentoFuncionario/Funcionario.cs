using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private int matricula;
        private string? nome;
        private decimal salario;
        public int Matricula//propriedade
        {
            get { return matricula; }
            set { 
                if (value > 0)
                {
                    matricula = value; 
                }
                else
                {
                    Console.WriteLine("Matrícula inválida!");
                }
            }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        } 
        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        
    }
}