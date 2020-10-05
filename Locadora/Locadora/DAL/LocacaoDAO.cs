using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.DAL
{
    class LocacaoDAO : Veiculo
    {
        //Context
        private static Context ctx =
            SingletonContext.GetInstance();
        //Previamente organizando as listas
        private static List<Locacao> locacoes = new List<Locacao>();
        private static List<Locacao> aux = new List<Locacao>();
        //cadastro
        public static bool CadastrarLocacao(Locacao l)
        {
            if (BuscarLocacaoPorId(l) == null)
            {
                ctx.Locacoes.Add(l);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
        //Listagem
        public static List<Locacao> Listar() => locacoes;

        public static List<Locacao> ListarLocacao()
        {
            return ctx.Locacoes.ToList();
        }

        private static List<Locacao> Locacoes = new List<Locacao>();
        //Filtra listagem por cliente
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

        public static List<Locacao>
            ListarLocacoesPorCliente(string cpf)
        {
            List<Locacao> aux = new List<Locacao>();
            foreach (Locacao locacaoCadastrada in Locacoes)
            {
                if (locacaoCadastrada.Cliente.Cpf.Equals(cpf))
                {
                    aux.Add(locacaoCadastrada);
                }
            }
            return aux;
        }
        //Buscar locação por IdLocação
        public static Locacao BuscarLocacaoPorId(Locacao l)
        {
            return ctx.Locacoes.FirstOrDefault(x => x.IdLocacao.Equals(l.IdLocacao));
        }
        //Tentando o sistema de multas
        public static void GerarMulta(Locacao l)
        {
            DateTime AuxDevolucao = Convert.ToDateTime(l.QntdDiasLocacao);
            DateTime DevolucaoPrevista = l.LocadoEm.AddDays(l.QntdDiasLocacao);
            if (l.LocadoEm <= AuxDevolucao)
            {
                //sem multas
            }
            else
            {
                AdicionarMulta(l);
            }
        }

        public static Double AdicionarMulta(Locacao l)
        {
            double aux = 0;//auxiliar final que receberá o valor Total da locacao
            double aux2 = 0.5f; //auxiliar que receberá os 50%
            aux = l.ValorTotal * aux2;
            double TotalLocacao = l.ValorTotal + aux;
            //TotalLocacao soma o valor da Locacao(contrato) com a multa
            return TotalLocacao;
        }

    }
}
