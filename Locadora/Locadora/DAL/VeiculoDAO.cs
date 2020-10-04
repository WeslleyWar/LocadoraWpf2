using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.DAL
{
    class VeiculoDAO
    {
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

        public static List<Veiculo> Listar() => veiculos;
    }
}
