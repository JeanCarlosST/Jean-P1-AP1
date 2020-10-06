using System;
using System.Linq;
using System.Windows;
using Jean_P1_AP1.Entities;
using Jean_P1_AP1.BLL;

namespace Jean_P1_AP1.UI.Registros
{
    public partial class rCiudades : Window
    {
        Ciudad ciudad;
        public rCiudades()
        {
            InitializeComponent();
            ciudad = new Ciudad();
            this.DataContext = ciudad;
        }

        public void Limpiar()
        {
            ciudad = new Ciudad();
            this.DataContext = ciudad;
        }
    
        public void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
            Ciudad ciudad = CiudadBLL.Buscar(Utilities.ToInt(CiudadIDTextBox.Text));

            if(ciudad != null)
            {
                this.ciudad = ciudad;
            }
            else
            {
                this.ciudad = new Ciudad();
                MessageBox.Show("No se encontró ninguna ciudad", "Registro ciudades",
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }

            this.DataContext = ciudad;
        }

        public void NuevoBoton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void GuardarBoton_Click(object sender, RoutedEventArgs e)
        {
            if(!Validar())
                return;

            if(CiudadBLL.Guardar(ciudad))
            {
                MessageBox.Show("Guardado con éxito", "Registro de ciudades", 
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                 MessageBox.Show("Hubo un error en el guardado", "Registro de ciudades", 
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Limpiar();
        }

        public void EliminarBoton_Click(object sender, RoutedEventArgs e)
        {
            if(CiudadBLL.Eliminar(Utilities.ToInt(CiudadIDTextBox.Text)))
            {
                MessageBox.Show("Se ha eliminado la ciudad", "Registro de ciudades", 
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error en eliminar", "Registro de ciudades", 
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Limpiar();
        }

        private bool Validar()
        {
            if(NombreTextBox.Text.Length == 0)
            {
                MessageBox.Show("Introduzca un nombre", "Registro de ciudades", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else if(CiudadBLL.Existe(NombreTextBox.Text))
            {
                MessageBox.Show("Esta ciudad ya existe", "Registro de ciudades", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else if(NombreTextBox.Text.Any(char.IsSymbol) || NombreTextBox.Text.Any(char.IsPunctuation)){
                MessageBox.Show("Introduzca un nombre válido", "Registro de ciudades", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }
    }
}