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
    /// Lógica de interacción para VentanaModificarUsuario.xaml
    /// </summary>
    public partial class VentanaModificarUsuario : Window
    {
        public VentanaModificarUsuario()
        {
            InitializeComponent();
        }

		private void TxtTipoUsuario_TextChanged(object sender, TextChangedEventArgs e)
		{
			if(txtTipoUsuario.Text=="Maestro")
			{
				lbNivelCurso.IsEnabled = false;
				cmbNivelCurso.IsEnabled = false;
			}
		}

		private void BtnGuardarCambios_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Datos guardados correctamente");
			this.Close();
		}
	}
}
