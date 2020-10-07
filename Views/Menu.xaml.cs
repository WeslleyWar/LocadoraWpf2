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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MenuItemCadastroCliente(object sender, RoutedEventArgs e)
        {
            frmCadastroCliente c = new frmCadastroCliente();
            c.ShowDialog();
        }

        private void MenuItemCadastroFuncionario(object sender, RoutedEventArgs e)
        {
            new frmCadastroFuncionario().ShowDialog();
        }

        private void MenuItemCadastroVeiculo(object sender, RoutedEventArgs e)
        {
            //new frmCadastroVeiculo().ShowDialog();
            frmCadastroVeiculo v = new frmCadastroVeiculo();
            v.ShowDialog();
        }

        private void MenuItemListarCliente(object sender, RoutedEventArgs e)
        {
            new viewCliente().ShowDialog();
        }

        private void MenuItemListarFuncionario(object sender, RoutedEventArgs e)
        {
            new viewFuncionario().ShowDialog();
        }

        private void MenuItemListarVeiculo(object sender, RoutedEventArgs e)
        {
            new viewVeiculo().ShowDialog();
        }

        private void MenuItemGerarLocacao(object sender, RoutedEventArgs e)
        {
            //new frmRegistroLocacao().ShowDialog();
            frmRegistroLocacao l = new frmRegistroLocacao();
            l.ShowDialog();
        }

        private void MenuItemListarLocacao(object sender, RoutedEventArgs e)
        {
            new viewLocacao().ShowDialog();
        }

        private void MenuItemDevolverVeiculo(object sender, RoutedEventArgs e)
        {
            new frmRegistroDevolucao().ShowDialog();
        }

        private void MenuItemListarDevolucao(object sender, RoutedEventArgs e)
        {
            new viewDevolucao().ShowDialog();
        }
    }
}
