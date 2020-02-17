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

namespace Stringhe_ordinate
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
        List<string> lista = new List<string>(5);
        int c = 0;
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            c++;
            string nome = txt_nome.Text;
            lista.Add(nome);           
            if(c==5)
            {
                btn_public_.IsEnabled = true;
                btn_stampa.IsEnabled = true;
                c = 0;
                btn_add.IsEnabled = false;
            }
            txt_nome.Clear();
        }

        private void btn_ordina_Click(object sender, RoutedEventArgs e)
        {
            lista.Sort();
            for (int i = 0; i < lista.Count; i++)
            {
                lbl_lista.Content = lista[i];
            }
        }

        private void btn_stampa_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                lbl_lista.Content = $"{lista[i]}";
            }
        }
    }
}
