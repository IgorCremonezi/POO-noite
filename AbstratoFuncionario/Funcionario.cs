using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public virtual void Mostrar()
        {
            System.Console.WriteLine("\nCódigo do funcionário: " + Codigo);
            System.Console.WriteLine("Nome do funcionário: " + Nome);
            System.Console.WriteLine("Salário do funcionário: " + Salario);
        }

        public abstract double CalcularSalario(int diasUteis);
    }
}