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
    /// Lógica de interacción para VentanaGestionTabletas.xaml
    /// </summary>
    public partial class VentanaGestionTabletas : Window
    {
        public VentanaGestionTabletas()
        {
            InitializeComponent();
        }

		private void BtnNuevaTableta_Click(object sender, RoutedEventArgs e)
		{
			VentanaNuevaTableta nuevaTableta = new VentanaNuevaTableta();
			nuevaTableta.ShowDialog();
		}

		private void BtnEliminarTableta_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult rs = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette tablette?", ""
				, MessageBoxButton.YesNo, MessageBoxImage.Question);
			if(rs == MessageBoxResult.Yes)
			{
				MessageBox.Show("Tablette supprimée correctement");
			}
			else
			{
				//NADA
			}
		}
	}
}
