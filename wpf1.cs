using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }

            private void Zapisz_Click(object sender, RoutedEventArgs e)
            {
                string tekstDoZapisu = txtbox.Text;
                string sciezkaDoPliku = "C:/tmp/plik.txt";

                try
                {
                    using (StreamWriter sw = new StreamWriter(sciezkaDoPliku))
                    {
                        sw.Write(tekstDoZapisu);
                    }

                    MessageBox.Show("Dane zostały zapisane do pliku.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania danych do pliku: " + ex.Message);
                }
            }

            private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
            {

            }

        private void Wczytaj_Click(object sender, RoutedEventArgs e)
        {
            string text = "";
            using(StreamReader sr = new ("C:/tmp/plik.txt")) 
            {
                try
                {
                    string a = sr.ReadLine();
                    do
                    {
                        text += a;
                        a = sr.ReadLine();
                    }
                    while (!sr.EndOfStream);

                    MessageBox.Show("Dane zostały wczytane z pliku.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania danych do pliku: " + ex.Message);
                }
            }
            txtbox.Text = text;
        }

        private void Bold_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox.FontWeight == FontWeights.Bold)
            {
                txtbox.FontWeight= FontWeights.Normal;
            }
            else
            {
                txtbox.FontWeight = FontWeights.Bold;
            }
        }
        }
}
