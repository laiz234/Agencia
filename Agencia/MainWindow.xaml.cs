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
        private Conta[] ct = new Conta[100];
        private int k;

        private void NovoCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.SetNome(txt1.Text);
            c.SetCpf(txt2.Text);
            cs[k] = c;
            k++;
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Conta x = new Conta();
            x.SetNumero(txt3.Text);
            x.SetAgencia(txt4.Text);
            x.SetSaldo(Double.Parse(txt3.Text));
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            //Cliente x = new Cliente();
            Conta x = new Conta();
            exibirlista.ItemsSource = null;
            exibirlista.ItemsSource = x.Listar();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
         //   Cliente s = new Cliente();
         //   exibirtotal.ItemsSource = null;
         //   exibirtotal.ItemsSource = s.SaldoTotal();
       // }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Conta s = new Conta();
            exibirtotal.ItemsSource = null;
            exibirtotal.ItemsSource = s.GetSaldo();
        }
    }
}
