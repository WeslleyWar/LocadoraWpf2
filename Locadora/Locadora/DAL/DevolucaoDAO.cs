using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.DAL
{
    class DevolucaoDAO
    {
        private static List<Devolucao> devolucoes = new List<Devolucao>();
        private static List<Devolucao> aux = new List<Devolucao>();
        public static void Cadastrar(Devolucao devolucao) => devolucoes.Add(devolucao);
        public static List<Devolucao> Listar() => devolucoes;
        public static List<Devolucao> ListarPorCliente(string cpf)
        {
            aux.Clear();
            foreach (Devolucao devolucaoCadastrada in Listar())
            {
                if (devolucaoCadastrada.Cliente.Cpf == cpf)
                {
                    aux.Add(devolucaoCadastrada);
                }
            }
            return aux;
        }
    }
}
