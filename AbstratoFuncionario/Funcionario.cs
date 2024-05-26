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
        public List<Dependente> Depend { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Depend = new List<Dependente>();
        }

        public virtual void Mostrar()
        {
            System.Console.WriteLine("\nCódigo do funcionário: " + Codigo);
            System.Console.WriteLine("Nome do funcionário: " + Nome);
            System.Console.WriteLine("Salário do funcionário: " + Salario);
        }

        public abstract double CalcularSalario(int diasUteis);

        public void AdicionarDependente(Dependente dependente)
        {
            Depend.Add(dependente);
        }

        public void RemoverDependente(int codigo)
        {
            var dependARemover = Depend.Find(d => d.Codigo == codigo);

            if (dependARemover != null)
            {
                Depend.Remove(dependARemover);
                System.Console.WriteLine("\nDependente removido com sucesso!");
            }
            else
            {
                System.Console.WriteLine("\nDependente não encontrado na lista!");
            }
        }

        public int TotalDependentes()
        {
            return Depend.Count;
        }

        public void MostrarDependentes()
        {
            foreach (Dependente d in Depend)
                d.Mostrar();
        }
    }
}