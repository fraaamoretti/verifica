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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace verifica
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Biblioteca malatestiana;
        bool flag = true;
        private void btnAddLibro_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("COMPILA I CAMPI DI TESTO PER LIBO");
                flag = false;
            }
            else
            {
                try
                {
                    Libro l = new Libro(txtAutore.Text, txtTitolo.Text, txtEditore.Text, int.Parse(txtAnnoDIPubblicazione.Text), int.Parse(txtNumeroDiPagine.Text)); 
                    malatestiana.addLibro(l);
                    lblRis.Content = "true";
                }
                catch
                {
                     lblRis.Content = "false";
                }
            }  
        }
        private void btnCercaLibro_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("COMPILA IL CAMPO DI TESTO AUTORE PER LIBO");
                flag = false;
            }
            else
            {
                try
                {
                    lblRis.Content = malatestiana.cercaLibroDIAutore(txtAutore.Text);
                }
                catch
                {
                    lblRis.Content = "false";
                }
            }
        }

        private void btnElencoLibriAutore_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("COMPILA IL CAMPO DI TESTO AUTORE PER LIBO");
                flag = false;
            }
            else
            {
                try
                {
                    lblRis.Content = malatestiana.elencoLibriPerAutore(txtAutore.Text);
                }
                catch
                {
                    lblRis.Content = "false";
                }
            }
        }

        private void btnGetNumLibri_Click(object sender, RoutedEventArgs e)
        {
            lblRis.Content = malatestiana.getNumLibri();
        }
    }
}
