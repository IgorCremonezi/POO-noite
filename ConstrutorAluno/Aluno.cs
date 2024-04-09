using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private long matricula;
        public long Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private static int contador;
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value != "")
                    nome = value;
                else
                    System.Console.WriteLine("\nDigite um nome válido!");
            }
        }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Media { get; private set; }

        static Aluno()
        {
            contador = 1;
        }
        public Aluno()
        {
            Matricula = 1570482211000 + contador;
            contador++;
        }

        public Aluno(string nome, double p1, double p2)
        {
            Nome = nome;
            P1 = p1;
            P2 = p2;
            this.CalcularMediaInterna();
            Matricula = 1570482211000 + contador;
            contador++;
        }
        public void CalcularMediaInterna()
        {
            Media = (P1 + P2) / 2;
        }

        public void CalcularMediaMain(double p1, double p2)
        {
            Media = (p1 + p2) / 2;
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("\nMatricula do aluno: " + Matricula);
            System.Console.WriteLine("Nome do aluno: " + Nome);
            System.Console.WriteLine("Nota da P1: " + P1);
            System.Console.WriteLine("Nota da P2: " + P2);
            System.Console.WriteLine("Média das notas: " + Media);
        }
    }
}