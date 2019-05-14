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

namespace GEMAF
{
    /// <summary>
    /// Lógica de interacción para VentanaNuevoArticulo.xaml
    /// </summary>
    public partial class VentanaNuevoArticulo : Window
    {
        public VentanaNuevoArticulo()
        {
            InitializeComponent();
        }

		private void RdbLibro_Checked(object sender, RoutedEventArgs e)
		{
			lbMatricula.IsEnabled = true;
			lbTitulo.IsEnabled = true;
			lbAutorDirector.IsEnabled = true;
			lbCategoria.IsEnabled = true;
			lbSeccion.IsEnabled = true;
			lbLocacion.IsEnabled = true;
			txtMatricula.IsEnabled = true;
			txtTitulo.IsEnabled = true;
			txtAutorDirector.IsEnabled = true;
			cmbCategoria.IsEnabled = true;
			cmbSeccion.IsEnabled = true;
			cmbLocacion.IsEnabled = true;

			lbClasificacion.IsEnabled = false;
			cmbClasificacion.IsEnabled = false;
		}

		private void RdbPelicula_Checked(object sender, RoutedEventArgs e)
		{
			lbMatricula.IsEnabled = true;
			lbTitulo.IsEnabled = true;
			lbAutorDirector.IsEnabled = true;
			lbClasificacion.IsEnabled = true;
			lbCategoria.IsEnabled = true;
			lbSeccion.IsEnabled = true;
			lbLocacion.IsEnabled = true;
			txtMatricula.IsEnabled = true;
			txtTitulo.IsEnabled = true;
			txtAutorDirector.IsEnabled = true;
			cmbClasificacion.IsEnabled = true;
			cmbCategoria.IsEnabled = true;
			cmbSeccion.IsEnabled = true;
			cmbLocacion.IsEnabled = true;
		}

		private void BtnAgregar_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Artículo agregado exitosamente");
			this.Close();
		}
	}
}
