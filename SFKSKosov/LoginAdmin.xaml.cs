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

namespace SFKSKosov
{
    /// <summary>
    /// Логика взаимодействия для LoginAdmin.xaml
    /// </summary>
    public partial class LoginAdmin : Window
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtPas.Focus();
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            if (txtPas.Password == "123123")
            {
                Close();
                Vault.LogAdmin = 1;
            }
            else
            {
                MessageBox.Show("Пароль неверен, попробуй еще раз");
                txtPas.Focus();
            }
        }

        private void Esc(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
