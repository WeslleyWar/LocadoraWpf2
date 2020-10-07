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
    /// Interaction logic for frmRegistroLocacao.xaml
    /// </summary>
    public partial class frmRegistroLocacao : Window
    {
        public frmRegistroLocacao()
        {
            InitializeComponent();
        }
        private void LimparFormulario()
        {
            TxtNomeCliente.Clear();
            TxtCpfCliente.Clear();
            TxtCnhCliente.Clear();
        }
        private void LimparFormulario2()
        {
            TxtStatus.Clear();
            TxtModelo.Clear();
            TxtPlaca.Clear();
            TxtPlaca.Focus();
        }
        private void LimparFormulario3()
        {
            TxtNomeFuncionario.Clear();
            TxtCpfFuncionario.Clear();
            TxtCpfFuncionario.Focus();
        }


        private void btnLimparLocacao(object sender, RoutedEventArgs e)
        {
            TxtNomeCliente.Clear();
            TxtCpfCliente.Clear();
            TxtCnhCliente.Clear();
            TxtStatus.Clear();
            TxtModelo.Clear();
            TxtPlaca.Clear();
            TxtNomeFuncionario.Clear();
            TxtCpfFuncionario.Clear();
            TxtDiasLocacao.Clear();
            TxtValorPrevisto.Clear();
            TxtDataInicio.Clear();
            TxtDataPrevistaEntrega.Clear();
            TxtPlaca.Clear();
            TxtDataPrevistaEntrega.Clear();
            TxtPlaca.Focus();
        }

        private void btnValidarC_Click(object sender, RoutedEventArgs e)
        {
            if (!TxtCpfCliente.Text.Equals(""))
            {
                if (!TxtCpfCliente.Text.Equals(""))
                {
                    // Cliente c = new Cliente
                    // {
                    String cpf = TxtCpfCliente.Text;
                    // };
                    Cliente c = ClienteDAO.BuscarClientePorCpf(cpf);
                    if (c != null)

                    {
                        TxtNomeCliente.Text = c.Nome;
                        TxtCpfCliente.Text = c.Cpf;
                        TxtCnhCliente.Text = c.Cnh;
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

        private void btnLimpaCliente(object sender, RoutedEventArgs e)
        {
            TxtNomeCliente.Clear();
            TxtCpfCliente.Clear();
            TxtCnhCliente.Clear();

        }

        private void btnLimpVeiculo(object sender, RoutedEventArgs e)
        {

        }

        private void btnLimpaFuncionario(object sender, RoutedEventArgs e)
        {
            TxtNomeFuncionario.Clear();
            TxtCpfFuncionario.Clear();
            TxtCpfFuncionario.Focus();
        }

        private void TxtPlaca_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnValidarF_Click(object sender, RoutedEventArgs e)
        {
            if (!TxtCpfFuncionario.Text.Equals(""))
            {
                Funcionario f = new Funcionario
                {
                    Cpf = TxtCpfFuncionario.Text
                };
                f = FuncionarioDAO.BuscarFuncionario(f);
                if (f != null)
                {
                    TxtNomeFuncionario.Text = f.Nome;
                   
                    TxtCpfFuncionario.Text = f.Cpf;
                 }
                else
                {
                    MessageBox.Show("Funcionario inexistente!", "Locador", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario3();
                }
            }
        }

        private void btnConcluir_Click(object sender, RoutedEventArgs e)
        {
            Locacao l = new Locacao
            {
            NomeCliente = TxtNomeCliente.Text,
            CpfCliente = TxtCpfCliente.Text,
            CnhCliente = TxtCnhCliente.Text,
             Status =   TxtStatus.Text,
             Modelo =   TxtModelo.Text,
             Placa =   TxtPlaca.Text,
             NomeFuncionario =    TxtNomeFuncionario.Text,
             CpfFuncionario  = TxtCpfFuncionario.Text,
             QntdDiasLocacao = Convert.ToInt32(TxtDiasLocacao.Text),
             ValorSemMulta = Convert.ToDouble(TxtValorPrevisto.Text),
             DataInicio =  TxtDataInicio.Text,
             DevolucaoPrevista = Convert.ToDateTime(TxtDataPrevistaEntrega.Text),
            

        };

            if (LocacaoDAO.CadastrarLocacao(l))
            {
                MessageBox.Show("Locação cadastrado com sucesso!");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Favor Rever Dados!");
            }
        }

        private void btnValidarV_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}


