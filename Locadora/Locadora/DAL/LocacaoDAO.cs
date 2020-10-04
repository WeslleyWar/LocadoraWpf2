using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.DAL
{
    class LocacaoDAO
    {
        private static List<Locacao> locacoes = new List<Locacao>();
        private static List<Locacao> aux = new List<Locacao>();
        public static void Cadastrar(Locacao locacao) => locacoes.Add(locacao);
        public static List<Locacao> Listar() => locacoes;
        public static List<Locacao> ListarPorCliente(string cpf)
        {
            aux.Clear();
            foreach (Locacao locacaoCadastrada in Listar())
            {
                if (locacaoCadastrada.Cliente.Cpf == cpf)
                {
                    aux.Add(locacaoCadastrada);
                }
            }
            return aux;
        }
    }
}
