using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Funcionario
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        protected string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        protected double salario;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public void Mostrar()
        {
            System.Console.WriteLine("\nCódigo do Funcionário: " + this.codigo);
            System.Console.WriteLine("Nome do Funcionário: " + this.nome);
            System.Console.WriteLine("Salário do Funcionário: " + this.salario);
        }
    }
}