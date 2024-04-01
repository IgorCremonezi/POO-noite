using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        //declaração dos atributos
        public int codigo;
        public string? nome;
        public double preco;
        public int quantidade;

        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo} \tNome: {nome} \tPreço: {preco:c}\tQuantidade: {quantidade}");
        }
        public void CalcularAumento(double porcentagem)
        {
            preco = preco + (preco * porcentagem/100);
            //preco += preco * porcentagem/100;
        }
        public double ValorTotalEmEstoque()
        {
            double totalEstoque = quantidade * preco;
            return totalEstoque;
        }
        public void RemoverEstoque(int qtdeVendida)
        {
            quantidade = quantidade - qtdeVendida;
        }
    }
}