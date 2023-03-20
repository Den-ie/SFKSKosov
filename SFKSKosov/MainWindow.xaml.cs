using Practice13_15;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SFKSKosov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Guesting(object sender, RoutedEventArgs e)
        {
            int X = 1,
                Y = 2,
                Z = 3,
                V = 4,
                W;

            if (X - Y <= Z - V)
            {
                if (Z <= V)
                {
                    W = V;
                }
                else W = (Y + Z) / 2;
            }
            else
            {
                if (X <= Y)
                {
                    W = (Y + Z) / 2;
                }
                else W = X;
            }
            Textik.Text = "X = " + X + "\nY = " + Y + "\nZ = " + Z + "\nV = " + V;
            MessageBox.Show(Convert.ToString(W));
        }

        private void UserLog(object sender, RoutedEventArgs e)
        {
            Login password = new();
            password.Owner = this;
            password.ShowDialog();
            if (Vault.LogUser > 0)
            {
                Programm.IsEnabled = true;
                UserGroup.IsEnabled = true;
            }
        }

        private void Solving(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Xt.Text, out int X) & int.TryParse(Yt.Text, out int Y) & int.TryParse(Zt.Text, out int Z) & int.TryParse(Vt.Text, out int V))
            {
                int W;
                if (X - Y <= Z - V)
                {
                    if (Z <= V)
                    {
                        W = V;
                    }
                    else W = (Y + Z) / 2;
                }
                else
                {
                    if (X <= Y)
                    {
                        W = (Y + Z) / 2;
                    }
                    else W = X;
                }
                Textik.Text = "X = " + X + "\nY = " + Y + "\nZ = " + Z + "\nV = " + V;
                MessageBox.Show(Convert.ToString(W));
            }
            else MessageBox.Show("Введите корректные значения");
        }

        public void Admining(object sender, RoutedEventArgs e)
        {
            LoginAdmin password = new();
            password.Owner = this;
            password.ShowDialog();
            if (Vault.LogAdmin > 0)
            {
                AdminGroup.IsEnabled = true;
            }

        }

        private void AdminStuff(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("*Логи*");
        }
    }
}
