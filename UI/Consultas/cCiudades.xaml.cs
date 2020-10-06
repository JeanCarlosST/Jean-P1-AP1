using System;
using System.Linq;
using System.Windows;
using Jean_P1_AP1.Entities;
using Jean_P1_AP1.BLL;
using System.Collections.Generic;

namespace Jean_P1_AP1.UI.Consultas
{
    public partial class cCiudades : Window
    {
        public cCiudades()
        {
            InitializeComponent();
        }

        public void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Ciudad>(); 

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                listado = CiudadBLL.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
            }
            else
            {
                listado = CiudadBLL.GetList(c => true);
            }          

            DatosCiudades.ItemsSource = null;
            DatosCiudades.ItemsSource = listado;
        }
        

    }
    
}