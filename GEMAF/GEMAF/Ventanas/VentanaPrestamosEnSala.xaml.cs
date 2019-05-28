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
	/// Lógica de interacción para VentanaPrestamosEnSala.xaml
	/// </summary>
	public partial class VentanaPrestamosEnSala : Window
	{
		public VentanaPrestamosEnSala()
		{
			InitializeComponent();
		}

		private void BtnAutorizarPrestamo_Click(object sender, RoutedEventArgs e)
		{
			if(txtIdLibro.Text=="" || txtTitulo.Text=="" || txtAutor.Text=="" || txtCategoria.Text==""
				 || txtSeccion.Text=="" || txtLocacion.Text=="" || txtNombre.Text==""
				 || txtTelefono.Text=="" || txtCorreo.Text=="")
			{
				MessageBox.Show("Complétez toutes les données pour effectuer l'opération", ""
					, MessageBoxButton.OK, MessageBoxImage.Warning);
			}
			else
			{
				MessageBox.Show("Prêt dans chambre autorisée");
			}
		}

		private void BtnFinalizarPrestamo_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Prêt dans chambre terminée avec succès");
		}
	}
}
