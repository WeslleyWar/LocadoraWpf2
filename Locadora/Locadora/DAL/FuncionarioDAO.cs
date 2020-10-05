using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.DAL
{
    class FuncionarioDAO :  ClienteDAO
    {
        private static List<Funcionario> funcionarios = new List<Funcionario>();
        public static List<Funcionario> ListarFuncionario() => funcionarios;

        private static Context ctx =
            SingletonContext.GetInstance();

        public static bool CadastrarFuncionario(Funcionario f)
        {
            if (BuscarFuncionarioPorCpf(f) == null)
            {
                ctx.Funcionarios.Add(f);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
        public static Funcionario BuscarFuncionario(string cpf)
        {
            return funcionarios.FirstOrDefault(x => x.Cpf == cpf);
        }

        public static Funcionario BuscarFuncionarioPorId(Funcionario id)
        {
            return ctx.Funcionarios.Find(id);
        }

        public static Funcionario BuscarFuncionarioPorCpf(Funcionario f)
        {
            return ctx.Funcionarios.FirstOrDefault(x => x.Cpf.Equals(f.Cpf));
        }

        public static List<Funcionario> ListarFuncionarios()
        {
            return ctx.Funcionarios.ToList();
        }

    }
}
