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

		}

		private void BtnFinalizarPrestamo_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Prestamo finalizado correctamente");
		}
	}
}
