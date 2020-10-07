using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.DAL
{
    class FuncionarioDAO :  ClienteDAO
    {
        // private readonly static List<Funcionario> funcionarios = new List<Funcionario>();
        // public static List<Funcionario> ListarFuncionario() => funcionarios;

        private readonly static Context ctx =
            SingletonContext.GetInstance();

        public static bool CadastrarFuncionario(Funcionario f)
        {
            if (BuscarFuncionarioPorCpf(f.Cpf) == null)
            {
                ctx.Funcionarios.Add(f);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Funcionario BuscarFuncionario(Funcionario f)
        {
            // return funcionarios.FirstOrDefault(x => x.Cpf == (f.Cpf));
            return ctx.Funcionarios.FirstOrDefault(x => x.Cpf == (f.Cpf));
        }

        public static Funcionario BuscarFuncionarioPorId(Funcionario id)
        {
            return ctx.Funcionarios.Find(id);
        }

        public static Funcionario BuscarFuncionarioPorCpf(String cpf)
        {
            // return funcionarios.FirstOrDefault(x => x.Cpf.Equals(f.Cpf));
            return ctx.Funcionarios.FirstOrDefault(x => x.Cpf.Equals(cpf));
        }

        public static List<Funcionario> ListarFuncionarios()
        {
            return ctx.Funcionarios.ToList();
        }

    }
}
