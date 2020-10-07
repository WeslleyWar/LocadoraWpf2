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
    /// Interaction logic for frmRegistroDevolucao.xaml
    /// </summary>
    public partial class frmRegistroDevolucao : Window
    {
        public frmRegistroDevolucao()
        {
            InitializeComponent();
        }

               private void BtnLimparDevolucao(object sender, RoutedEventArgs e)
        {
            TxtMarca.Clear();
            TxtModelo.Clear();
            TxtPlaca.Clear();
            TxtDataEntrega.Clear();
            TxtPlaca.Focus();

        }

        private void BtnBuscarPlaca_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
