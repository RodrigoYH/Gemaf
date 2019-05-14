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
    /// Lógica de interacción para VentanaMenu.xaml
    /// </summary>
    public partial class VentanaMenu : Window
    {
        public VentanaMenu()
        {
            InitializeComponent();
        }

		private void BtnNuevoArt_Click(object sender, RoutedEventArgs e)
		{
			VentanaNuevoArticulo nuevoArt = new VentanaNuevoArticulo();
			nuevoArt.ShowDialog();
		}

		private void BtnModificarArtículo_Click(object sender, RoutedEventArgs e)
		{
			VentanaModificarArticulo modifArt = new VentanaModificarArticulo();
			modifArt.ShowDialog();
		}

		private void BtnElliminarArt_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult rs = MessageBox.Show("Se eliminará el artículo con ID: #######\n¿Esta seguro que desea eliminarlo?", "",
				 MessageBoxButton.YesNo, MessageBoxImage.Warning);
			if(rs==MessageBoxResult.Yes)
			{
				MessageBox.Show("Artículo eliminado correctamente");
			}
			else
			{
				//NADA
			}
		}

		private void BtnNuevoPrestamo_Click(object sender, RoutedEventArgs e)
		{
			VentanaNuevoPrestamo nuevoPres = new VentanaNuevoPrestamo();
			nuevoPres.ShowDialog();
		}

		private void BtnDevolucionArticulo_Click(object sender, RoutedEventArgs e)
		{
			VentanaDevolucion devolverArt = new VentanaDevolucion();
			devolverArt.ShowDialog();
		}

		private void BtnPrestamoSala_Click(object sender, RoutedEventArgs e)
		{
			VentanaPrestamosEnSala prestamoSala = new VentanaPrestamosEnSala();
			prestamoSala.ShowDialog();
		}

		private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
		{
			MainWindow main = new MainWindow();
			main.Show();
			this.Hide();
		}

		private void BtnAsignarTbaleta_Click(object sender, RoutedEventArgs e)
		{
			lbMatricula.IsEnabled = true;
			txtMatricula.IsEnabled = true;
			btnBuscar.IsEnabled = true;
		}

		private void BtnFinalizarPrestamo_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Tableta liberada");
		}

		private void BtnAutorizar_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Tableta asignada");
		}

		private void BtnAgregarUsuario_Click(object sender, RoutedEventArgs e)
		{
			VentanaNuevoUsuario nuevoUser = new VentanaNuevoUsuario();
			nuevoUser.ShowDialog();
		}

		private void BtnModificarUsuario_Click(object sender, RoutedEventArgs e)
		{
			VentanaModificarUsuario modifUser = new VentanaModificarUsuario();
			modifUser.ShowDialog();
		}

		private void BtnEliminarUsuario_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult rs = MessageBox.Show("¿Esta seguro de que quiere eliminar a este usuario?", 
				"", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (rs == MessageBoxResult.Yes)
			{
				MessageBox.Show("El usuario se eliminó correctamente");
			}
			else
			{

			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			
		}

		private void BtnCatalogo_Click(object sender, RoutedEventArgs e)
		{
			tbcOpciones.SelectedIndex = 0;
			btnCatalogo.IsEnabled = false;
			btnPrestamos.IsEnabled = true;
			btnTabletas.IsEnabled = true;
			btnUsuarios.IsEnabled = true;
		}

		private void BtnPrestamos_Click(object sender, RoutedEventArgs e)
		{
			tbcOpciones.SelectedIndex = 1;
			btnPrestamos.IsEnabled = false;
			btnCatalogo.IsEnabled = true;
			btnTabletas.IsEnabled = true;
			btnUsuarios.IsEnabled = true;
		}

		private void BtnTabletas_Click(object sender, RoutedEventArgs e)
		{
			tbcOpciones.SelectedIndex = 2;
			btnTabletas.IsEnabled = false;
			btnCatalogo.IsEnabled = true;
			btnPrestamos.IsEnabled = true;
			btnUsuarios.IsEnabled = true;
		}

		private void BtnUsuarios_Click(object sender, RoutedEventArgs e)
		{
			tbcOpciones.SelectedIndex = 3;
			btnUsuarios.IsEnabled = false;
			btnCatalogo.IsEnabled = true;
			btnPrestamos.IsEnabled = true;
			btnTabletas.IsEnabled = true;
		}
	}
}
