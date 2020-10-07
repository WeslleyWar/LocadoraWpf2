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
    /// Interaction logic for viewCliente.xaml
    /// </summary>
    public partial class viewCliente : Window
    {
        private List<dynamic> clientesGrid =
        new List<dynamic>();

        public viewCliente()
        {
            InitializeComponent();
        }

        private void btnFecharClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAdicionarClick(object sender, RoutedEventArgs e)
        {

        }

        private void dtaClientes_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtaClientes.ItemsSource = ClienteDAO.ListarClientes();
            dtaClientes.DisplayMemberPath = "Nome";
            dtaClientes.SelectedValuePath = "ClienteId";
        }
    }
}
