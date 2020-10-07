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
    /// Interaction logic for viewLocacao.xaml
    /// </summary>
    public partial class viewLocacao : Window
    {
        private List<dynamic> veiculosGrid =
        new List<dynamic>();

        public viewLocacao()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtaLocacoes.ItemsSource = LocacaoDAO.ListarLocacao();
            dtaLocacoes.DisplayMemberPath = "Nome";
            dtaLocacoes.SelectedValuePath = "Id";
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
