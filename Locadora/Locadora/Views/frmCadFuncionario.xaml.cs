using Locadora.DAL;
using Locadora.Models;
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
    /// Interaction logic for CadFuncionario.xaml
    /// </summary>
    public partial class frmCadFuncionario : Window
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
            txtCriadoEm.Text = DateTime.Now.ToString();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtGenero.Clear();
            txtIdade.Clear();
            txtRg.Clear();
            txtSalario.Clear();
            txtEmail.Clear();
            //txtDataNascimento.Clear();
            txtCriadoEm.Clear();
            txtCpf.Clear();
            //txtContratacao.Clear();
            txtCargo.Clear();
            txtCep.Clear();
            txtCep.Clear();
            txtCnh.Clear();            
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Funcionario f = new Funcionario
            {
                Nome = txtNome.Text,
                Genero = Convert.ToString(txtGenero.Text),
                Idade = Convert.ToInt32(Convert.ToString(txtIdade.Text)),
                Cpf = Convert.ToString(txtCpf.Text),
                DataContratacao = Convert.ToDateTime(Convert.ToString(dtpContratacao.Text)),
                Rg = Convert.ToString(txtRg.Text),
                Cnh = Convert.ToString(txtCnh.Text),
                DataNascimento = Convert.ToDateTime(Convert.ToString(dtpNascimento.Text)),
                Email = Convert.ToString(txtEmail.Text),
                Cep = Convert.ToString(txtCep.Text),
                Cargo = Convert.ToString(txtCargo.Text),
                Salario = float.Parse(Convert.ToString(txtSalario.Text)),
                CriadoEm = DateTime.Now

            };
            if (FuncionarioDAO.CadastrarFuncionario(f))
            {
                MessageBox.Show("Funcionario cadastrado!", "Locador", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Funcionario já cadastrado!", "Locador", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
