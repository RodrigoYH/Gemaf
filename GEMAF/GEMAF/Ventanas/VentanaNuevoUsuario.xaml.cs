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
    /// Lógica de interacción para VentanaNuevoUsuario.xaml
    /// </summary>
    public partial class VentanaNuevoUsuario : Window
    {
        public VentanaNuevoUsuario()
        {
            InitializeComponent();
        }

		private void RdbAlumno_Checked(object sender, RoutedEventArgs e)
		{
			lbNombre.IsEnabled = true;
			lbApPaterno.IsEnabled = true;
			lbApMaterno.IsEnabled = true;
			lbFechaNacim.IsEnabled = true;
			lbCorreo.IsEnabled = true;
			lbNivelCurso.IsEnabled = true;
			txtNombre.IsEnabled = true;
			txtApPaterno.IsEnabled = true;
			txtApMaterno.IsEnabled = true;
			dtpFechaNacim.IsEnabled = true;
			txtCorreo.IsEnabled = true;
			cmbNivelCurso.IsEnabled = true;
			btnAgregarUsuario.IsEnabled = true;

			lbUserActual.IsEnabled = false;
			lbPasswordActual.IsEnabled = false;
			lbNuevoUser.IsEnabled = false;
			lbNuevoPassword.IsEnabled = false;
			lbConfirmarNuevoPassword.IsEnabled = false;
			txtUserActual.IsEnabled = false;
			pwdPasswordActual.IsEnabled = false;
			txtNuevoUser.IsEnabled = false;
			pwdNuevoPassword.IsEnabled = false;
			pwdConfirmarNuevoPassword.IsEnabled = false;
		}

		private void RdbMaestro_Checked(object sender, RoutedEventArgs e)
		{
			lbNombre.IsEnabled = true;
			lbApPaterno.IsEnabled = true;
			lbApMaterno.IsEnabled = true;
			lbFechaNacim.IsEnabled = true;
			lbCorreo.IsEnabled = true;
			lbNivelCurso.IsEnabled = false;
			txtNombre.IsEnabled = true;
			txtApPaterno.IsEnabled = true;
			txtApMaterno.IsEnabled = true;
			dtpFechaNacim.IsEnabled = true;
			txtCorreo.IsEnabled = true;
			cmbNivelCurso.IsEnabled = false;
			btnAgregarUsuario.IsEnabled = true;

			lbUserActual.IsEnabled = false;
			lbPasswordActual.IsEnabled = false;
			lbNuevoUser.IsEnabled = false;
			lbNuevoPassword.IsEnabled = false;
			lbConfirmarNuevoPassword.IsEnabled = false;
			txtUserActual.IsEnabled = false;
			pwdPasswordActual.IsEnabled = false;
			txtNuevoUser.IsEnabled = false;
			pwdNuevoPassword.IsEnabled = false;
			pwdConfirmarNuevoPassword.IsEnabled = false;
		}

		private void RdbAdministrador_Checked(object sender, RoutedEventArgs e)
		{
			lbNombre.IsEnabled = true;
			lbApPaterno.IsEnabled = true;
			lbApMaterno.IsEnabled = true;
			lbFechaNacim.IsEnabled = true;
			lbCorreo.IsEnabled = true;
			lbNivelCurso.IsEnabled = false;
			txtNombre.IsEnabled = true;
			txtApPaterno.IsEnabled = true;
			txtApMaterno.IsEnabled = true;
			dtpFechaNacim.IsEnabled = true;
			txtCorreo.IsEnabled = true;
			cmbNivelCurso.IsEnabled = false;
			btnAgregarUsuario.IsEnabled = true;

			lbUserActual.IsEnabled = true;
			lbPasswordActual.IsEnabled = true;
			lbNuevoUser.IsEnabled = true;
			lbNuevoPassword.IsEnabled = true;
			lbConfirmarNuevoPassword.IsEnabled = true;
			txtUserActual.IsEnabled = true;
			pwdPasswordActual.IsEnabled = true;
			txtNuevoUser.IsEnabled = true;
			pwdNuevoPassword.IsEnabled = true;
			pwdConfirmarNuevoPassword.IsEnabled = true;

			MessageBox.Show("Se agregará un nuevo usuario administrador, " +
				"esto implica que el usuario administrador actual se elimine, ya que solo " +
	"puede haber un usario administrador a la vez. Para porceder con esta operación, es necesario " +
 "que el usuario administrador actual esté presente para escribir sus datos de acceso a GEMAF y autorizar " +
 "el registro del nuevo usuario administrador", "", MessageBoxButton.OK, MessageBoxImage.Warning);
		}

		private void BtnAgregarUsuario_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Usuario registrado correctamente");
			this.Close();
		}
	}
}
