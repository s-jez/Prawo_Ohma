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
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : UserControl
    {
        double E, VF_LED, IF_LED;

        private void btn_Clear(object sender, RoutedEventArgs e)
        {
            E = 0;
            VF_LED = 0;
            IF_LED = 0;
            tb_1.Text = "";
            tb_2.Text = "";
            tb_3.Text = "";
            res.Text = "";
        }

        private void tb_3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                IF_LED = Convert.ToDouble(tb_3.Text);
            }
            catch
            {
                tb_3.Text = "";
            }
            if(tb_1 != null && tb_2 != null & tb_3 != null)
                res.Text = "R wynosi: " + Obliczenia().ToString() + "Ω";
        }

        private void tb_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                VF_LED = Convert.ToDouble(tb_2.Text);
            }
            catch
            {
                tb_2.Text = "";
            }
            if (tb_1 != null && tb_2 != null & tb_3 != null)
                res.Text = "R wynosi: " + Obliczenia().ToString() + "Ω";
        }

        private void tb_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                E = Convert.ToDouble(tb_1.Text);
            }
            catch
            {
                tb_1.Text = "";
            };
            if (tb_1 != null && tb_2 != null & tb_3 != null)
                res.Text = "R wynosi: " + Obliczenia().ToString() + "Ω";
        }

        public Window3()
        {
            InitializeComponent();
        }
        public double Obliczenia()
        {
            if (VF_LED >= E)
                VF_LED = 0;

            double R = (E - VF_LED) / IF_LED;
            return Math.Round(R, 2);
        }
    }
}
