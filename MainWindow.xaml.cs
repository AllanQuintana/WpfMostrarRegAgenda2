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

namespace WpfMostrarRegAgenda2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.lsvRegistros.Items.Clear();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\allan\Documents\Programas\WpfAgenda2\bin\Debug\MiAgenda2.txt";

            this.lsvRegistros.Items.Clear();

            using (var streamReader = new StreamReader(filePath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var fields = line.Split(',');
                    var record = fields[0] + "-" + fields[1];
                    this.lsvRegistros.Items.Add(record);
                }
            }
        }
    }
}
