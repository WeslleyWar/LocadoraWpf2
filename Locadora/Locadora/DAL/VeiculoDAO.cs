using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.DAL
{
    class VeiculoDAO
    {
        private static Context ctx = new Context();

        private static List<Veiculo> veiculos = new List<Veiculo>();

        public static bool Cadastrar(Veiculo veiculo)
        {
            if (BuscarVeiculo(veiculo.NomeModelo) != null)
            {
                return false;
            }
            veiculos.Add(veiculo);
            return true;
        }

        public static Veiculo BuscarVeiculoPorNumeroRenavam(Veiculo v)
        {
            return ctx.Veiculos.FirstOrDefault(x => x.Renavan.Equals(v.Renavan));
        }

        public static Veiculo BuscarVeiculoPorId(int id)
        {
            return ctx.Veiculos.Find(id);
        }

        public static Veiculo BuscarVeiculo(string NomeModelo)
        {
            foreach (Veiculo veiculoCadastrado in veiculos)
            {
                if (NomeModelo.Equals(veiculoCadastrado.NomeModelo))
                {
                    return veiculoCadastrado;
                }
            }
            return null;
        }

        public static Veiculo RemoverVeiculoPorRenavan(Veiculo v)
        {
            return ctx.Veiculos.FirstOrDefault(x => x.Renavan.Equals(v.Renavan));
        }

        public static Veiculo RemoverVeiculoPorPlaca(Veiculo v)
        {
            return ctx.Veiculos.FirstOrDefault(x => x.Placa.Equals(v.Placa));
        }

        public static void ExcluirVeiculo(Veiculo v)
        {
            ctx.Veiculos.Remove(v);
            ctx.SaveChanges();
        }

        public static List<Veiculo> ListarVeiculos()
        {
            return ctx.Veiculos.ToList();
        }

        public static bool AlterarVeiculo(Veiculo v)
        {
            ctx.Veiculos.Add(v);
            ctx.SaveChanges();
            return true;
        }

        public static List<Veiculo> Listar() => veiculos;
    }
}
