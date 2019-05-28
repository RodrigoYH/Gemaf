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
    /// Lógica de interacción para VentanaDevolucion.xaml
    /// </summary>
    public partial class VentanaDevolucion : Window
    {
        public VentanaDevolucion()
        {
            InitializeComponent();
        }

		private void BtnRegistrarDevolucion_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Retour de l'article correctement enregistré");
			this.Close();
		}
	}
}
