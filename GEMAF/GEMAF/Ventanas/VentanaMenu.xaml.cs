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
			MessageBoxResult rs = MessageBox.Show("L'élément avec ID: ####### sera supprimé. Êtes-vous sûr de vouloir le supprimer?", "",
				 MessageBoxButton.YesNo, MessageBoxImage.Warning);
			if(rs==MessageBoxResult.Yes)
			{
				MessageBox.Show("Article supprimé correctement");
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

		private void BtnAsignarTableta_Click(object sender, RoutedEventArgs e)
		{
			lbMatricula.IsEnabled = true;
			txtMatricula.IsEnabled = true;
			btnBuscarUsuarioTableta.IsEnabled = true;
	
			btnAsignarTableta.IsEnabled = false;
			btnFinalizarPrestamoTableta.IsEnabled = false;
			btnGestionarTableta.IsEnabled = false;
			btnCancelarOperacionTableta.IsEnabled = true;
		}

		private void BtnFinalizarPrestamo_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Tablette libéré");
			btnBuscarUsuarioTableta.IsEnabled = false;
			lbMatricula.IsEnabled = false;
			txtMatricula.IsEnabled = false;
			txtMatricula.Text = "";
		}

		private void BtnBuscarUsuarioTableta_Click(object sender, RoutedEventArgs e)
		{
			btnAutorizarTableta.IsEnabled = true;
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
			MessageBoxResult rs = MessageBox.Show("Êtes-vous sûr de vouloir éliminer cet utilisateur?", 
				"", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (rs == MessageBoxResult.Yes)
			{
				MessageBox.Show("L'utilisateur a été supprimé avec succès");
			}
			else
			{

			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			btnCatalogo.IsEnabled = false;
			btnCatalogo.Foreground = Brushes.Black;
		}

		private void BtnCatalogo_Click(object sender, RoutedEventArgs e)
		{
			tbcOpciones.SelectedIndex = 0;
			btnCatalogo.IsEnabled = false;
			btnPrestamos.IsEnabled = true;
			btnTabletas.IsEnabled = true;
			btnUsuarios.IsEnabled = true;

			btnCatalogo.Foreground = Brushes.Black;
			btnPrestamos.Foreground = Brushes.White;
			btnTabletas.Foreground = Brushes.White;
			btnUsuarios.Foreground = Brushes.White;
		}

		private void BtnPrestamos_Click(object sender, RoutedEventArgs e)
		{
			tbcOpciones.SelectedIndex = 1;
			btnPrestamos.IsEnabled = false;
			btnCatalogo.IsEnabled = true;
			btnTabletas.IsEnabled = true;
			btnUsuarios.IsEnabled = true;

			btnCatalogo.Foreground = Brushes.White;
			btnPrestamos.Foreground = Brushes.Black;
			btnTabletas.Foreground = Brushes.White;
			btnUsuarios.Foreground = Brushes.White;
		}

		private void BtnTabletas_Click(object sender, RoutedEventArgs e)
		{
			tbcOpciones.SelectedIndex = 2;
			btnTabletas.IsEnabled = false;
			btnCatalogo.IsEnabled = true;
			btnPrestamos.IsEnabled = true;
			btnUsuarios.IsEnabled = true;

			btnCatalogo.Foreground = Brushes.White;
			btnPrestamos.Foreground = Brushes.White;
			btnTabletas.Foreground = Brushes.Black;
			btnUsuarios.Foreground = Brushes.White;
		}

		private void BtnUsuarios_Click(object sender, RoutedEventArgs e)
		{
			tbcOpciones.SelectedIndex = 3;
			btnUsuarios.IsEnabled = false;
			btnCatalogo.IsEnabled = true;
			btnPrestamos.IsEnabled = true;
			btnTabletas.IsEnabled = true;

			btnCatalogo.Foreground = Brushes.White;
			btnPrestamos.Foreground = Brushes.White;
			btnTabletas.Foreground = Brushes.White;
			btnUsuarios.Foreground = Brushes.Black;
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			App.Current.Shutdown();
		}

		private void CmbLibrosPeliculas_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			switch (cmbLibrosPeliculas.SelectedIndex)
			{
				case 0: //Libros
					cmbOpcionesBusqueda.Items.Clear();
					cmbOpcionesBusqueda.Text = "";

					cmbOpcionesBusqueda.Items.Add("ID");
					cmbOpcionesBusqueda.Items.Add("Titre");
					cmbOpcionesBusqueda.Items.Add("Auteur");
					cmbOpcionesBusqueda.Items.Add("Catégorie");
					cmbOpcionesBusqueda.Items.Add("Section");
					cmbOpcionesBusqueda.Items.Add("Location");
					break;

				case 1: //Películas
					cmbOpcionesBusqueda.Items.Clear();
					cmbOpcionesBusqueda.Text = "";

					cmbOpcionesBusqueda.Items.Add("ID");
					cmbOpcionesBusqueda.Items.Add("Titre");
					cmbOpcionesBusqueda.Items.Add("Directeur");
					cmbOpcionesBusqueda.Items.Add("Classification");
					cmbOpcionesBusqueda.Items.Add("Catégorie");
					cmbOpcionesBusqueda.Items.Add("Section");
					cmbOpcionesBusqueda.Items.Add("Location");
					break;
			}
		}

		private void BtnAutorizarTableta_Click(object sender, RoutedEventArgs e)
		{
			if(txtInhabilitado.Text=="Non")
			{
				txtMatricula.IsEnabled = true;
				lbMatricula.IsEnabled = true;

				btnBuscarUsuarioTableta.IsEnabled = false;
				btnAutorizarTableta.IsEnabled = false;

				btnAsignarTableta.IsEnabled = true;
				btnFinalizarPrestamoTableta.IsEnabled = true;
				btnGestionarTableta.IsEnabled = true;
				MessageBox.Show("Tablette assignée");
			}
			else
			{
				MessageBox.Show("L'opération ne peut pas être effectuée: l'utilisateur est désactivé", "",
					 MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void BtnCancelarOperacionTableta_Click(object sender, RoutedEventArgs e)
		{
			lbMatricula.IsEnabled = false;
			txtMatricula.IsEnabled = false;
			txtMatricula.Text = "";
			txtNombre.Text = "";
			txtApellidos.Text = "";
			txtNivelCurso.Text = "";
			txtNoSancion.Text = "";
			txtInhabilitado.Text = "";
			btnBuscarUsuarioTableta.IsEnabled = false;
			btnAutorizarTableta.IsEnabled = false;

			btnAsignarTableta.IsEnabled = true;
			btnFinalizarPrestamoTableta.IsEnabled = true;
			btnGestionarTableta.IsEnabled = true;
			btnCancelarOperacionTableta.IsEnabled = false;
			MessageBox.Show("Opération annulée");
		}

		private void BtnLimpiarSancion_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Sanction annulée: l'utilisateur est activé");
		}

		private void BtnBusquedaRapidaCatalogo_Click(object sender, RoutedEventArgs e)
		{
			
		}

		private void CmbTiposUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			switch(cmbTiposUsuarios.SelectedIndex)
			{
				case 0: //Alumno
					cmbOpcionesBusquedaUsuarios.Items.Clear();
					cmbOpcionesBusquedaUsuarios.Text = "";
					cmbOpcionesBusquedaUsuarios.Items.Add("Inscription");
					cmbOpcionesBusquedaUsuarios.Items.Add("Prénom");
					cmbOpcionesBusquedaUsuarios.Items.Add("Nom du père");
					cmbOpcionesBusquedaUsuarios.Items.Add("Nom du mère");
					cmbOpcionesBusquedaUsuarios.Items.Add("Email");
					cmbOpcionesBusquedaUsuarios.Items.Add("Niveau et cours");
					break;

				case 1: //Maestro
					cmbOpcionesBusquedaUsuarios.Items.Clear();
					cmbOpcionesBusquedaUsuarios.Text = "";
					cmbOpcionesBusquedaUsuarios.Items.Add("Inscription");
					cmbOpcionesBusquedaUsuarios.Items.Add("Prénom");
					cmbOpcionesBusquedaUsuarios.Items.Add("Nom");
					cmbOpcionesBusquedaUsuarios.Items.Add("Email");
					break;
					
			}
		}

		private void BtnGestionarTableta_Click(object sender, RoutedEventArgs e)
		{
			VentanaGestionTabletas gestionTabletas = new VentanaGestionTabletas();
			gestionTabletas.ShowDialog();
		}
	}
}
