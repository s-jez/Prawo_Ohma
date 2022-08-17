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
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : UserControl
    {
        public double R1, R2;

        private void tb_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                R1 = Convert.ToDouble(tb_1.Text);
            }
            catch
            {
                tb_1.Text = "";
            }
            res2.Text = "Wynik to: " + ObliczRownolegle().ToString() + "Ω";
        }

        private void tb_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                R2 = Convert.ToDouble(tb_2.Text);
            }
            catch
            {
                tb_2.Text = "";
            }
            res2.Text = "Wynik to: " + ObliczRownolegle().ToString() + "Ω";
        }

        public Window2()
        {
            InitializeComponent();
        }
        public double ObliczSzeregowo()
        {
            try
            {
                R2 = R1 + R2;
            }
            catch
            {

            }
            return Math.Round(R2, 2);
        }

        private void tb_3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                R1 = Convert.ToDouble(tb_3.Text);
            }
            catch
            {
                tb_3.Text = "";
            }
            res1.Text = "Wynik to: " + ObliczSzeregowo().ToString() + "Ω";
        }

        private void tb_4_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                R2 = Convert.ToDouble(tb_4.Text);
            }
            catch
            {
                tb_4.Text = "";
            }
            res1.Text = "Wynik to: " + ObliczSzeregowo().ToString() + "Ω";
        }

        private void btn_Clear(object sender, RoutedEventArgs e)
        {
            R1 = 0;
            R2 = 0;
            tb_1.Text = "";
            tb_2.Text = "";
            tb_3.Text = "";
            tb_4.Text = "";
            res1.Text = "";
            res2.Text = "";
        }

        public double ObliczRownolegle()
        {
            try
            {
                R2 = R1 * R2 / (R1 + R2);
            }
            catch
            {

            }
            return Math.Round(R2, 2);
        }
    }
}
