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

        private void OnClick1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCancelaCadastroVeiculo(object sender, RoutedEventArgs e)
        {

        }
    }
}
