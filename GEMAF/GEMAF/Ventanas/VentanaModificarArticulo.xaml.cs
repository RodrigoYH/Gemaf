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
    /// Lógica de interacción para VentanaModificarArticulo.xaml
    /// </summary>
    public partial class VentanaModificarArticulo : Window
    {
        public VentanaModificarArticulo()
        {
            InitializeComponent();
        }

		private void BtnGuardar_Click_1(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Cambios realizados y guardados correctamente");
			this.Close();
		}
	}
}
