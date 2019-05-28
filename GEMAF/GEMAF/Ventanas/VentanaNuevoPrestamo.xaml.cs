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
    /// Lógica de interacción para VentanaNuevoPrestamo.xaml
    /// </summary>
    public partial class VentanaNuevoPrestamo : Window
    {
        public VentanaNuevoPrestamo()
        {
            InitializeComponent();
        }

		private void BtnAceptarFinalizar_Click(object sender, RoutedEventArgs e)
		{
			if(txtID.Text=="" || txtMatricula.Text=="" || txtTitulo.Text=="" || txtTipo.Text==""
				 || txtCategoria.Text=="" || txtSeccion.Text=="" || txtLocacion.Text==""
				  || txtNombre.Text=="" || txtApellidos.Text=="" || txtNivelCurso.Text==""
				   || txtNoSanciones.Text=="" || txtInhabilitado.Text=="" || txtFechaPrestamo.Text==""
				    || txtFechaDevolucion.Text=="")
			{
				MessageBox.Show("Complétez toutes les données pour effectuer l'opération", ""
					, MessageBoxButton.OK, MessageBoxImage.Warning);
			}
			else
			{
				MessageBox.Show("Prêt fait correctement");
				this.Close();
			}
		}
	}
}
