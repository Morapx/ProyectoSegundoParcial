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
    /// Lógica de interacción para Microfonos.xaml
    /// </summary>
    public partial class Microfonos : UserControl
    {
        public Microfonos()
        {
            InitializeComponent();
            textoadvertencia.Visibility = Visibility.Hidden;
        }

        private void boxtipo_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoadvertencia.Visibility = Visibility.Hidden;
        }

        private void boxprovedor_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoadvertencia.Visibility = Visibility.Hidden;
        }

        private void boxprecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoadvertencia.Visibility = Visibility.Hidden;
        }

        private void boxdescripcion_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoadvertencia.Visibility = Visibility.Hidden;
        }

        private void boxcodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoadvertencia.Visibility = Visibility.Hidden;
        }

        private void boroncancelar_Click(object sender, RoutedEventArgs e)
        {
            grindsecundarios.Children.Clear();
        }


    }
}
