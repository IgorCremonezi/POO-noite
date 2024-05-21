using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Gerente : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                System.Console.WriteLine("\nGerente autenticado!");
                return true;
            }
            System.Console.WriteLine("\nGerente não autorizado!");
            return false;
        }
    }
}