﻿using Locadora.DAL;
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
    /// Interaction logic for viewFuncionario.xaml
    /// </summary>
    public partial class viewFuncionario : Window
    {
        private List<dynamic> funcionariosGrid =
        new List<dynamic>();

        public viewFuncionario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtaFuncionarios.ItemsSource = FuncionarioDAO.ListarFuncionarios();
            dtaFuncionarios.DisplayMemberPath = "Nome";
            dtaFuncionarios.SelectedValuePath = "Id";
        }
    }
}
