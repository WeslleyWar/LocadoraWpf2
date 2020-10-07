using Locadora.DAL;
using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Locadora.Views
{
    /// <summary>
    /// Interaction logic for frmCadastroVeiculo.xaml
    /// </summary>
    public partial class frmCadastroVeiculo : Window
    {
        public frmCadastroVeiculo()
        {
            InitializeComponent();
        }

        private void btnCancelarCadastroVeiculo(object sender, RoutedEventArgs e)
        {
            TxtMarca.Clear();
            txtModelo.Clear();
            CmbTipoVeiculo.SelectedIndex = -1;
            TxtPlaca.Clear();
            TxtAno.Clear();
            TxtRenavan.Clear();
            TxtPortas.Clear();
            CmbTipoCombustivel.SelectedIndex = -1;
            TxtPotencia.Clear();
            TxtCor.Clear();
            TxtStatus.Clear();
            TxtPlaca.Focus();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Veiculo v = new Veiculo
            {
                NomeMarca = TxtMarca.Text,
                NomeModelo = txtModelo.Text,
                TipoVeiculo = CmbTipoVeiculo.Text,
                Placa = TxtPlaca.Text,
                Ano = Convert.ToInt32(TxtAno.Text),
                Renavan = Convert.ToInt32(TxtRenavan.Text),
                QntdPortas = Convert.ToInt32(TxtPortas.Text),
                TipoCombustivel = CmbTipoCombustivel.Text,
                Potencia = TxtPotencia.Text,
                Cor = TxtCor.Text,
                StatusVeiculo = TxtStatus.Text
            };

            if (VeiculoDAO.CadastrarVeiculo(v))
            {
                MessageBox.Show("Veiculo cadastrado com sucesso!");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Veículo já existe!");
            }
        }

        private void LimparFormulario()
        {
            TxtMarca.Clear();
            txtModelo.Clear();
            CmbTipoVeiculo.SelectedIndex = -1;
            TxtPlaca.Clear();
            TxtAno.Clear();
            TxtRenavan.Clear();
            TxtPortas.Clear();
            CmbTipoCombustivel.SelectedIndex = -1;
            TxtPotencia.Clear();
            TxtCor.Clear();
            TxtStatus.Clear();
            TxtPlaca.Focus();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!TxtPlaca.Text.Equals(""))
            {

               Veiculo v = new Veiculo
                {
                    Placa = TxtPlaca.Text
                };
                v = VeiculoDAO.BuscarVeiculoPorPlaca(v);
                if (v != null)
               
                {
                    TxtMarca.Text = v.NomeMarca;
                    txtModelo.Text = v.NomeModelo;
                    CmbTipoVeiculo.Text = v.TipoVeiculo;
                    TxtPlaca.Text = v.Placa;
                    TxtAno.Text = Convert.ToString(v.Ano);
                    TxtRenavan.Text = Convert.ToString(v.Renavan);
                    TxtPortas.Text = Convert.ToString(v.QntdPortas);
                    CmbTipoCombustivel.Text = v.TipoCombustivel;
                    TxtPotencia.Text = v.Potencia;
                    TxtCor.Text = v.Cor;
                    TxtStatus.Text = v.StatusVeiculo;
                    TxtPlaca.Focus();
                    //TxtCriadoEm.Text = Convert.ToString(Convert.ToDateTime(f.CriadoEm));
                    //btnEditar.IsEnabled = true;
                }

                
                else
                {
                    MessageBox.Show("Veículo inexistente!", "Locador", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            //    VeiculoDAO.ExcluirVeiculo(v);
            //    MessageBox.Show("Veiculo removido!", "Locador", MessageBoxButton.OK, MessageBoxImage.Information);
            //    LimparFormulario();
        }
    }
}
