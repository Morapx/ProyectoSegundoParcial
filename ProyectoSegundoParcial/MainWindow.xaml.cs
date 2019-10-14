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

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botonagregar_Click(object sender, RoutedEventArgs e)
        {
            switch (combotipoproducto.SelectedIndex)
            {
                case 0:
                    grindprincipal.Children.Add(new Bocina());
                    break;
                case 1:
                    grindprincipal.Children.Add(new Audiculares());
                    break;
                case 2:
                    grindprincipal.Children.Add(new Audifonos());
                    break;
                case 3:
                    grindprincipal.Children.Add(new Bajos());
                    break;
                case 4:
                    grindprincipal.Children.Add(new Amplificadores());
                    break;
                case 5:
                    grindprincipal.Children.Add(new Microfonos());
                    break;
            }
        }

        private void combotipoproducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grindprincipal.Children.Clear();
        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
