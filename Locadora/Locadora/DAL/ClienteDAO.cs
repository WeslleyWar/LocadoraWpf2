using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.DAL
{
    class ClienteDAO
    {
        private static Context ctx =
            SingletonContext.GetInstance();

        private static List<Cliente> clientes = new List<Cliente>();
        public static List<Cliente> Listar() => clientes;
        public static bool Cadastrar(Cliente c)
        {
            if (BuscarCliente(c.Cpf) == null)
            {
                clientes.Add(c);
                return true;
            }
            return false;
        }
        public static Cliente BuscarCliente(string cpf)
        {
            return clientes.FirstOrDefault(x => x.Cpf == cpf);
            //foreach (Cliente clienteCadastrado in clientes)
            //{
            //    if (clienteCadastrado.Cpf == cpf)
            //    {
            //        return clienteCadastrado;
            //    }
            //}
            //return null;
        }
    }
}

