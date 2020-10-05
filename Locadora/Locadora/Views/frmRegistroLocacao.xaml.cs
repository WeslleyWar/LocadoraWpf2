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
    /// Interaction logic for frmRegistroLocacao.xaml
    /// </summary>
    public partial class frmRegistroLocacao : Window
    {
        public frmRegistroLocacao()
        {
            InitializeComponent();
        }

        private void btnLimparLocacao(object sender, RoutedEventArgs e)
        {
            TxtNomeCliente.Clear();
            TxtIdadeCliente.Clear();
            TxtCpfCliente.Clear();
            TxtCnhCliente.Clear();
            TxtMarca.Clear();
            TxtModelo.Clear();
            TxtPlaca.Clear();
            TxtNomeFuncionario.Clear();
            TxtCargoFuncionario.Clear();
            TxtCpfFuncionario.Clear();
            TxtDiasLocacao.Clear();
            TxtValorPrevisto.Clear();
            TxtDataInicio.Clear();
            TxtDataPrevistaEntrega.Clear();
            TxtPlaca.Clear();
            TxtDataPrevistaEntrega.Clear();
            TxtPlaca.Focus();
        }
    }
}
