using Locadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.DAL
{
    class FuncionarioDAO : ClienteDAO
    {
        //Funcionario deixa de Editar ou remover informações cadastradas.
        private static Context ctx =
            SingletonContext.GetInstance();
        //private static Context ctx = new Context();
        //Funcionarios
        public static Funcionario BuscarFuncionarioPorId(Funcionario id)
        {
            return ctx.Funcionarios.Find(id);
        }
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
