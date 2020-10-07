using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.DAL
{
    class ClienteDAO
    {
        private static readonly Context ctx =
            SingletonContext.GetInstance();

        // private static List<Cliente> clientes = new List<Cliente>();
        // public static List<Cliente> Listar() => clientes;


        // public static Cliente BuscarClienteCpf(Cliente c)
        public static Cliente BuscarClientePorCpf(String cpf)
        {
            // return clientes.FirstOrDefault(x => x.Cpf.Equals(c.Cpf));
            return ctx.Clientes.FirstOrDefault(c => c.Cpf.Equals(cpf));
        }

        public static bool Cadastrar(Cliente c)
        {
            if (BuscarClientePorCpf(c.Cpf) == null)
            {
                // clientes.Add(c);
                ctx.Add(c);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Cliente BuscarClientePorId(Cliente id)
        {
            return ctx.Clientes.Find(id);
        }
        public static bool CadastrarCliente(Cliente c)
        {
            if (BuscarClientePorCpf(c.Cpf) == null)
            {
                ctx.Clientes.Add(c);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Cliente BuscarClientePorCNH(Cliente c)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Cnh.Equals(c.Cnh));
        }

        public static List<Cliente> ListarClientes()
        {
            return ctx.Clientes.ToList();
        }

        public static bool AlterarCliente(Cliente c)
        {
            ctx.Clientes.Add(c);
            ctx.SaveChanges();
            return true;
        }
        



        //public static bool Remover(Cliente c)
        //{
        //    ctx.Clientes.Remove(c);
        //    ctx.SaveChanges();
        //    return true;
        //}

    }
}

