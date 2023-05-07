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
            FileStream f;
            StreamReader fr;

            string linea;
            string[] campo;
            string registro;

            this.lsvRegistros.Items.Clear() ;

            f = new FileStream("MiAgenda2.txt", FileMode.Open, FileAccess.Read);
            fr = new StreamReader(f);
            while (!fr.EndOfStream)
            {
                linea = fr.ReadLine();
                campo = linea.Split(',');
                registro = campo[0] + "-" + campo[1];
                this.lsvRegistros.Items.Add(registro);
            }
        }
    }
}
