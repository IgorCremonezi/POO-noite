using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void Admitir(Funcionario funcionario)
        {
            VetF.Add(funcionario);
        }

        public void ListarFuncionario()
        {
            System.Console.WriteLine("\nListagem do departamento: " + Nome);
            foreach (Funcionario funcionario in VetF)
            {
                funcionario.Mostrar();
            }
        }

        public void Demitir(int codigo)
        {
            for(int i = 0; i < VetF.Count; i++)
            {
                Funcionario funcionario = VetF.ElementAt<Funcionario>(i);
                if (funcionario.Codigo == codigo)
                    VetF.Remove(funcionario);
            }
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for(int i = 0; i < VetF.Count; i++)
            {
                Funcionario funcionario = VetF.ElementAt<Funcionario>(i);
                folha += funcionario.CalcularSalario(diasUteis);
            }
            return folha;
        }
    }
}