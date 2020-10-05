﻿using System;
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

        private void btnCancelarCadastroFuncionario(object sender, RoutedEventArgs e)
        {
            TxtNome.Clear();
            TxtIdade.Clear();
            CmbPermissao.SelectedIndex = -1;
            TxtCpf.Clear();
            TxtDtNasc.Clear();
            TxtCnh.Clear();
            TxtEmail.Clear();
            CmbPermissao.SelectedIndex = -1;
            TxtContatoPessoal.Clear();
            TxtCpf.Focus();
        }
    }
}
