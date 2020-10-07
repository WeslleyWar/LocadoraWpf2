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
                DataNascimento = Convert.ToDateTime(TxtDtNasc.Text),
                Categoria = CmbCategoria.Text,
                Genero = CmbGenero.Text

            };

            if (ClienteDAO.Cadastrar(c))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Cliente já existe!");
            }
        }

        private void eventBtnBuscaCliente(object sender, RoutedEventArgs e)
        {
            if (!TxtCpf.Text.Equals(""))
            {
                // Cliente c = new Cliente
                // {
                String cpf = TxtCpf.Text;
                // };
                Cliente c = ClienteDAO.BuscarClientePorCpf(cpf);
                if (c != null)
                {
                    TxtNome.Text = c.Nome;
                    CmbGenero.Text = c.Genero;
                    TxtCpf.Text = c.Cpf;
                    TxtSalario.Text = Convert.ToString(c.Salario);
                    TxtIdade.Text = Convert.ToString(Convert.ToInt32(c.Idade));
                    TxtEmail.Text = c.Email;
                    TxtDtNasc.Text = Convert.ToString(Convert.ToDateTime(c.DataNascimento));
                    TxtCnh.Text = c.Cnh;
                    TxtTelefone.Text = c.Telefone;
                    TxtCep.Text = c.Cep;
                    CmbCategoria.Text = c.Categoria;
                    //TxtCriadoEm.Text = Convert.ToString(Convert.ToDateTime(f.CriadoEm));
                    //btnEditar.IsEnabled = true;
                              
                                
                }
                else
                {
                    MessageBox.Show("Cliente inexistente!", "Locador", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
            }
        }
    }
}



   