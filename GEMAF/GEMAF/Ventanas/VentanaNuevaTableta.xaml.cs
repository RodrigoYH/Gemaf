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
    /// Lógica de interacción para VentanaNuevaTableta.xaml
    /// </summary>
    public partial class VentanaNuevaTableta : Window
    {
        public VentanaNuevaTableta()
        {
            InitializeComponent();
        }

		private void BtnAgregarTableta_Click(object sender, RoutedEventArgs e)
		{
			if(txtIdTableta.Text=="" || txtModeloTableta.Text=="")
			{
				MessageBox.Show("Complétez toutes les données pour effectuer l'opération", ""
						, MessageBoxButton.OK, MessageBoxImage.Warning);
			}
			else
			{
				MessageBox.Show("Tablette ajouté avec succès");
				this.Close();
			}
		}
	}
}
