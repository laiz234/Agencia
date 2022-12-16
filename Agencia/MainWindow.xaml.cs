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

namespace Agencia
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
        private Cliente[] cs = new Cliente[100];
        private int k;

        private void NovoCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.SetNome(txt1.Text);
            c.SetCpf(txt2.Text);
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
