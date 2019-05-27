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
    /// Lógica de interacción para VentanaNuevoArticulo.xaml
    /// </summary>
    public partial class VentanaNuevoArticulo : Window
    {
        public VentanaNuevoArticulo()
        {
            InitializeComponent();
        }

		private void RdbLibro_Checked(object sender, RoutedEventArgs e)
		{
			lbMatricula.IsEnabled = true;
			lbTitulo.IsEnabled = true;
			lbAutorDirector.IsEnabled = true;
			lbCategoria.IsEnabled = true;
			lbSeccion.IsEnabled = true;
			lbLocacion.IsEnabled = true;
			txtMatricula.IsEnabled = true;
			txtTitulo.IsEnabled = true;
			txtAutorDirector.IsEnabled = true;
			cmbCategoria.IsEnabled = true;
			cmbSeccion.IsEnabled = true;
			cmbLocacion.IsEnabled = true;

			lbClasificacion.IsEnabled = false;
			cmbClasificacion.IsEnabled = false;

			cmbCategoria.Items.Clear();
			cmbCategoria.Text = "";
			cmbCategoria.Items.Add("Apprentissage");
			cmbCategoria.Items.Add("Art");
			cmbCategoria.Items.Add("Arts");
			cmbCategoria.Items.Add("Arts du Mexique");
			cmbCategoria.Items.Add("Animaux");
			cmbCategoria.Items.Add("Biographie/Monographie");
			cmbCategoria.Items.Add("BD adultes");
			cmbCategoria.Items.Add("Contes");
			cmbCategoria.Items.Add("Comic");
			cmbCategoria.Items.Add("Cuisine");
			cmbCategoria.Items.Add("Conjugaison");
			cmbCategoria.Items.Add("Communication");
			cmbCategoria.Items.Add("Culture et Civilisation");
			cmbCategoria.Items.Add("Divers");
			cmbCategoria.Items.Add("Diplômes FLE");
			cmbCategoria.Items.Add("Dictionnaires");
			cmbCategoria.Items.Add("Enfants");
			cmbCategoria.Items.Add("Économie domestique");
			cmbCategoria.Items.Add("Encyclopédie");
			cmbCategoria.Items.Add("Général");
			cmbCategoria.Items.Add("Géographie");
			cmbCategoria.Items.Add("Grammaire");
			cmbCategoria.Items.Add("Histoire");
			cmbCategoria.Items.Add("Histoire de France");
			cmbCategoria.Items.Add("Histoire d'Amérique");
			cmbCategoria.Items.Add("Histoire du Yucatán");
			cmbCategoria.Items.Add("Histoire Universelle");
			cmbCategoria.Items.Add("Jeunes");
			cmbCategoria.Items.Add("Langues");
			cmbCategoria.Items.Add("Langues Etrangères");
			cmbCategoria.Items.Add("Lecture");
			cmbCategoria.Items.Add("Littérature");
			cmbCategoria.Items.Add("Manual");
			cmbCategoria.Items.Add("Méthode");
			cmbCategoria.Items.Add("Orthographe");
			cmbCategoria.Items.Add("Philosophie");
			cmbCategoria.Items.Add("Phonétique");
			cmbCategoria.Items.Add("Poésie");
			cmbCategoria.Items.Add("Politique/Social");
			cmbCategoria.Items.Add("Production écrite");
			cmbCategoria.Items.Add("Religion/Philosophie");
			cmbCategoria.Items.Add("Récit");
			cmbCategoria.Items.Add("Roman");
			cmbCategoria.Items.Add("Sciences sociales");
			cmbCategoria.Items.Add("Sciences appliquées");
			cmbCategoria.Items.Add("Spécialités");
			cmbCategoria.Items.Add("Sport");
			cmbCategoria.Items.Add("Théâtre");
			cmbCategoria.Items.Add("Tourisme");
			cmbCategoria.Items.Add("Vocabulaire");
		}

		private void RdbPelicula_Checked(object sender, RoutedEventArgs e)
		{
			lbMatricula.IsEnabled = true;
			lbTitulo.IsEnabled = true;
			lbAutorDirector.IsEnabled = true;
			lbClasificacion.IsEnabled = true;
			lbCategoria.IsEnabled = true;
			lbSeccion.IsEnabled = true;
			lbLocacion.IsEnabled = true;
			txtMatricula.IsEnabled = true;
			txtTitulo.IsEnabled = true;
			txtAutorDirector.IsEnabled = true;
			cmbClasificacion.IsEnabled = true;
			cmbCategoria.IsEnabled = true;
			cmbSeccion.IsEnabled = true;
			cmbLocacion.IsEnabled = true;

			cmbCategoria.Items.Clear();
			cmbCategoria.Text = "";
			cmbCategoria.Items.Add("Action");
			cmbCategoria.Items.Add("Action/Policier");
			cmbCategoria.Items.Add("Apprentissage");
			cmbCategoria.Items.Add("Aventure");
			cmbCategoria.Items.Add("Biographie");
			cmbCategoria.Items.Add("Conte");
			cmbCategoria.Items.Add("Comédie");
			cmbCategoria.Items.Add("Comédie/Romance");
			cmbCategoria.Items.Add("Comédie Dramatique");
			cmbCategoria.Items.Add("Documentaire");
			cmbCategoria.Items.Add("Drame");
			cmbCategoria.Items.Add("Enfants");
			cmbCategoria.Items.Add("Intrigue");
			cmbCategoria.Items.Add("Musique");
			cmbCategoria.Items.Add("Reportage");
			cmbCategoria.Items.Add("Romance");
			cmbCategoria.Items.Add("Suspens");
		}

		private void BtnAgregar_Click(object sender, RoutedEventArgs e)
		{
			if (rdbLibro.IsChecked == false || rdbPelicula.IsChecked == false || txtTitulo.Text == ""
				 || txtAutorDirector.Text == "" || cmbClasificacion.Text == "" || cmbCategoria.Text == ""
				  || cmbSeccion.Text == "" || cmbLocacion.Text == "")
			{

			}
			else
			{
				MessageBox.Show("Article ajouté avec succès");
				this.Close();
			}
		}

		private void ChkSi_Checked(object sender, RoutedEventArgs e)
		{
			lbCopia.IsEnabled = true;
			txtCopia.IsEnabled = true;
			chkNo.IsChecked = false;
		}

		private void ChkNo_Checked(object sender, RoutedEventArgs e)
		{
			lbCopia.IsEnabled = false;
			txtCopia.IsEnabled = false;
			txtCopia.Text = "";
			chkSi.IsChecked = false;
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			//SECCIÓN:
			cmbSeccion.Items.Add("BD");
			cmbSeccion.Items.Add("Culture et Civilisation");
			cmbSeccion.Items.Add("Langues et Références");
			cmbSeccion.Items.Add("Films");
			cmbSeccion.Items.Add("Littérature");
			cmbSeccion.Items.Add("Pédagogique");
			cmbSeccion.Items.Add("Premiers livres");

			//LOCACIÓN:
			cmbLocacion.Items.Add("Arts - Architecture");
			cmbLocacion.Items.Add("Bandes Desinées");
			cmbLocacion.Items.Add("Bibliothèque cinéma");
			cmbLocacion.Items.Add("Bibliothèque pédagogique");
			cmbLocacion.Items.Add("Biographies");
			cmbLocacion.Items.Add("Cuisine et travaux manuels");
			cmbLocacion.Items.Add("Études littéraires");
			cmbLocacion.Items.Add("Géographie et histoire");
			cmbLocacion.Items.Add("Littérature du monde");
			cmbLocacion.Items.Add("Littérature française");
			cmbLocacion.Items.Add("Livres ados");
			cmbLocacion.Items.Add("Livres d'art");
			cmbLocacion.Items.Add("Livres enfants");
			cmbLocacion.Items.Add("Poésie");
			cmbLocacion.Items.Add("Religion");
			cmbLocacion.Items.Add("Salle des professeurs");
			cmbLocacion.Items.Add("Sciences sociales");
			cmbLocacion.Items.Add("Théâtre");
			cmbLocacion.Items.Add("Tourisme");
		}
	}
}
