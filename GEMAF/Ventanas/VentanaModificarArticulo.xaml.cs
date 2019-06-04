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
			if(txtTipo.Text=="Livre")
			{
				if (txtTitulo.Text == "" || txtAutorDirector.Text == "" || cmbCategoria.Text == ""
				|| cmbSeccion.Text == "" || cmbLocacion.Text == "")
				{
					MessageBox.Show("Complétez toutes les données pour pouvoir effectuer l'opération", "",
						 MessageBoxButton.OK, MessageBoxImage.Warning);
				}
				else
				{
					MessageBox.Show("Modifications effectuées et enregistrées correctement");
					this.Close();
				}
			}
			else if(txtTipo.Text=="Film")
			{
				if (txtTitulo.Text == "" || txtAutorDirector.Text == "" || cmbClasificacion.Text=="" 
					|| cmbCategoria.Text == "" || cmbSeccion.Text == "" || cmbLocacion.Text == "")
				{
					MessageBox.Show("Complétez toutes les données pour pouvoir effectuer l'opération", "",
						 MessageBoxButton.OK, MessageBoxImage.Warning);
				}
				else
				{
					MessageBox.Show("Modifications effectuées et enregistrées correctement");
					this.Close();
				}
			}
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

		private void TxtTipo_TextChanged(object sender, TextChangedEventArgs e)
		{
			if(txtTipo.Text=="Libro")
			{
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
			else if(txtTipo.Text=="Pelicula")
			{
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
		}
	}
}
