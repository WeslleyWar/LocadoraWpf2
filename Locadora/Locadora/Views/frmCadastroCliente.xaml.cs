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
    /// Interaction logic for frmCadastroCliente.xaml
    /// </summary>
    public partial class frmCadastroCliente : Window
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            TxtNome.Clear();
            TxtIdade.Clear();
            TxtCpf.Clear();
            TxtEmail.Clear();
            TxtCnh.Clear();
            TxtTelefone.Clear();
            TxtCep.Clear();
            TxtSalario.Clear();
            CmbGenero.SelectedIndex = -1;
            TxtDtNasc.Clear();
            TxtCpf.Focus();
        }


        private void btnCancelarCadastroCliente(object sender, RoutedEventArgs e)
        {
            TxtNome.Clear();
            TxtIdade.Clear();
            TxtCpf.Clear();
            TxtEmail.Clear();
            TxtCnh.Clear();
            TxtTelefone.Clear();
            TxtCep.Clear();
            TxtSalario.Clear();
            CmbGenero.SelectedIndex = -1;
            TxtDtNasc.Clear();
            TxtCpf.Focus();
        }

    

        private void btnSalvarCliente(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente
            {

                Nome = TxtNome.Text,
                Idade = Convert.ToInt32(TxtIdade.Text),
                Cpf = TxtCpf.Text,
                Email = TxtEmail.Text,
                Cnh = TxtCnh.Text,
                Telefone = TxtTelefone.Text,
                Cep = TxtCep.Text,
                Salario = Convert.ToDouble(TxtSalario.Text),
                DataNascimento = Convert.ToDateTime(TxtDtNasc.Text)        
               
               

            };

            if (ClienteDAO.Cadastrar(c))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Pedido já existe!");
            }
        }

        private void btnBuscaCliente(object sender, RoutedEventArgs e)

        {

        }
    }
}
