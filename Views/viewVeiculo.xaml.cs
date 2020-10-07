using Locadora.DAL;
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
    /// Interaction logic for viewVeiculo.xaml
    /// </summary>
    public partial class viewVeiculo : Window
    {
        private List<dynamic> veiculosGrid =
        new List<dynamic>();

        public viewVeiculo()
        {
            InitializeComponent();
        }

        private void dtaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtaVeiculos.ItemsSource = VeiculoDAO.ListarVeiculos();
            dtaVeiculos.DisplayMemberPath = "Nome";
            dtaVeiculos.SelectedValuePath = "Id";
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
