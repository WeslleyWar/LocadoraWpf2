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
    /// Interaction logic for frmCadastroFuncionario.xaml
    /// </summary>
    public partial class frmCadastroFuncionario : Window
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }
           private void LimparFormulario()
            {
                TxtNome.Clear();
                TxtIdade.Clear();
                CmbCategoria.SelectedIndex = -1;
                TxtCpf.Clear();
                TxtDtNasc.Clear();
                TxtCnh.Clear();
                TxtEmail.Clear();
                CmbGenero.SelectedIndex = -1;
                TxtTelefone.Clear();

            TxtCpf.Focus(); 
            }
            private void btnCancelarCadastroFuncionario(object sender, RoutedEventArgs e)
        {
            TxtNome.Clear();
            TxtIdade.Clear();
            CmbCategoria.SelectedIndex = -1;
            TxtCpf.Clear();
            TxtDtNasc.Clear();
            TxtCnh.Clear();
            TxtEmail.Clear();
            CmbGenero.SelectedIndex = -1;
            TxtTelefone.Clear();
            
            TxtCpf.Focus();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {

            if (!TxtCpf.Text.Equals(""))
            {
                Funcionario f = new Funcionario
                {
                    Cpf = TxtCpf.Text
                };
                f = FuncionarioDAO.BuscarFuncionario(f);
                if (f != null)
                {
                    TxtNome.Text = f.Nome;
                    CmbGenero.Text = f.Genero;
                    TxtCpf.Text = f.Cpf;
                    TxtIdade.Text = Convert.ToString(Convert.ToInt32(f.Idade));
                    TxtEmail.Text = f.Email;
                    TxtDtNasc.Text = Convert.ToString(Convert.ToDateTime(f.DataNascimento));
                    TxtCnh.Text = f.Cnh;
                    TxtTelefone.Text = f.Telefone;
                    CmbCategoria.Text = f.Categoria;
                    //TxtCriadoEm.Text = Convert.ToString(Convert.ToDateTime(f.CriadoEm));
                    //btnEditar.IsEnabled = true;


                }
                else
                {
                    MessageBox.Show("Funcionario inexistente!", "Locador", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
            }

        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Funcionario f = new Funcionario
            {

                Nome = TxtNome.Text,
                Idade = Convert.ToInt32(TxtIdade.Text),
                Cpf = TxtCpf.Text,
                Email = TxtEmail.Text,
                Cnh = TxtCnh.Text,
                Telefone = TxtTelefone.Text,
                DataNascimento = Convert.ToDateTime(TxtDtNasc.Text),
                Categoria = CmbCategoria.Text,
                Genero = CmbGenero.Text,
                
            };

            if (FuncionarioDAO.CadastrarFuncionario(f))
            {
                MessageBox.Show("Funcionario cadastrado com sucesso!");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Funcionario já existe!");
            }
        }

        
    }
}
