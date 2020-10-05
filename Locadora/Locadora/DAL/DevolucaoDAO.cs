using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.DAL
{
    class DevolucaoDAO
    {
        private static Context ctx =
            SingletonContext.GetInstance();

        private static List<Devolucao> Devolucoes = new List<Devolucao>();
        //private static List<Devolucao> aux = new List<Devolucao>();

        public static Devolucao BuscarDevolucaoPorId(Devolucao d)
        {
            return ctx.Devolucoes.FirstOrDefault(x => x.IdDevolucao.Equals(d.IdDevolucao));
        }

        public static bool CadastrarDevolucao(Devolucao d)
        {
            if (BuscarDevolucaoPorId(d) == null)
            {
                ctx.Locacoes.Add(d);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Devolucao> ListarDevolucao()
        {
            return ctx.Devolucoes.ToList();
        }

        //public static void Cadastrar(Devolucao devolucao) => devolucoes.Add(devolucao);
        //public static List<Devolucao> Listar() => devolucoes;
        //public static List<Devolucao> ListarPorCliente(string cpf)
        //{
        //    aux.Clear();
        //    foreach (Devolucao devolucaoCadastrada in Listar())
        //    {
        //        if (devolucaoCadastrada.Cliente.Cpf == cpf)
        //        {
        //            aux.Add(devolucaoCadastrada);
        //        }
        //    }
        //    return aux;
        //}
    }
}
