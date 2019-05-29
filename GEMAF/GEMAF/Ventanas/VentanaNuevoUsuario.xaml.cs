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
			
			lbNuevoUser.IsEnabled = false;
			lbNuevoPassword.IsEnabled = false;
			lbConfirmarNuevoPassword.IsEnabled = false;
			txtNuevoUser.IsEnabled = false;
			pwdNuevoPassword.IsEnabled = false;
			pwdConfirmarNuevoPassword.IsEnabled = false;
		}

		private void RdbMaestro_Checked(object sender, RoutedEventArgs e)
		{
			lbNombre.IsEnabled = true;
			lbApPaterno.IsEnabled = true;
			lbApMaterno.IsEnabled = false;
			lbFechaNacim.IsEnabled = true;
			lbCorreo.IsEnabled = true;
			lbNivelCurso.IsEnabled = false;
			txtNombre.IsEnabled = true;
			txtApPaterno.IsEnabled = true;
			txtApMaterno.IsEnabled = false;
			dtpFechaNacim.IsEnabled = true;
			txtCorreo.IsEnabled = true;
			cmbNivelCurso.IsEnabled = false;
			btnAgregarUsuario.IsEnabled = true;

			lbNuevoUser.IsEnabled = false;
			lbNuevoPassword.IsEnabled = false;
			lbConfirmarNuevoPassword.IsEnabled = false;
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

			lbNuevoUser.IsEnabled = true;
			lbNuevoPassword.IsEnabled = true;
			lbConfirmarNuevoPassword.IsEnabled = true;
			txtNuevoUser.IsEnabled = true;
			pwdNuevoPassword.IsEnabled = true;
			pwdConfirmarNuevoPassword.IsEnabled = true;
		}

		private void BtnAgregarUsuario_Click(object sender, RoutedEventArgs e)
		{
			if(rdbAlumno.IsChecked==false || rdbMaestro.IsChecked==false || rdbAdministrador.IsChecked==false
				 || txtNombre.Text=="" || txtApPaterno.Text=="" || txtApMaterno.Text=="" 
				 || dtpFechaNacim.Text=="" || txtCorreo.Text=="" || txtNuevoUser.Text==""
				  || pwdNuevoPassword.Password=="" || pwdConfirmarNuevoPassword.Password=="")
			{
				MessageBox.Show("Complétez toutes les données pour effectuer l'opération", ""
					, MessageBoxButton.OK, MessageBoxImage.Warning);
			}
			else
			{
				MessageBox.Show("Utilisateur ajouté avec succès");
				this.Close();
			}
		}
	}
}
