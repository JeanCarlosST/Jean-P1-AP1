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
using Jean_P1_AP1.Entities;

namespace Jean_P1_AP1.UI.Registros
{
    public partial class rCiudades : Window
    {
        Ciudad ciudad;
        public rCiudades()
        {
            InitializeComponent();
            ciudad = new Ciudad();
        }
    
        public void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
        }

        public void NuevoBoton_Click(object sender, RoutedEventArgs e)
        {
        }

        public void GuardarBoton_Click(object sender, RoutedEventArgs e)
        {
        }

        public void EliminarBoton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}