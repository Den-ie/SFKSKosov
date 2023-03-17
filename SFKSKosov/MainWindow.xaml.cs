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

        private void Solving(object sender, RoutedEventArgs e)
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

        private void Guesting(object sender, RoutedEventArgs e)
        {
            Programm.IsEnabled = true;
        }

        private void WindowStart(object sender, RoutedEventArgs e)
        {
            Login password = new();
            password.Owner = this;
            password.ShowDialog();
        }
    }
}
