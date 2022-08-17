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

namespace WPF2App
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zamknij(object sender, RoutedEventArgs e)
        {
            this.Close();
            //Enviorment.Exit(0)
        }

        private void btn_AuthorPage(object sender, RoutedEventArgs e)
        {
            WindowAuthor window = new WindowAuthor();
            window.ShowDialog();
        }
    }
}
