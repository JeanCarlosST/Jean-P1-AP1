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
using Jean_P1_AP1.UI.Registros;
using Jean_P1_AP1.UI.Consultas;

namespace Jean_P1_AP1
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

        public void rCiudadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            new rCiudades().Show();
        }

        public void cCiudadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            new cCiudades().Show();
        }
    }
}
