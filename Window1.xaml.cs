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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : UserControl
    {
        double I, U, R, P;
        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tb2.Text = slider2.Value.ToString() + "Ω";
            if (tb2 != null)
            {
                ObliczMoc();
                ObliczNapiecie();
                ObliczNatezenie();
            }
        }

        private void slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tb3.Text = slider3.Value.ToString() + "V";
            if (tb3 != null)
            {
                ObliczMoc();
                ObliczRezystancje();
                ObliczNatezenie();
            }
        }

        public Window1()
        {
            InitializeComponent();
            tb1.Text = slider1.Value.ToString() + "A";
            tb2.Text = slider2.Value.ToString() + "Ω";
            tb3.Text = slider3.Value.ToString() + "V";
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tb1.Text = slider1.Value.ToString() + "A";
            if (tb1 != null)
            {
                ObliczMoc();
                ObliczNapiecie();
                ObliczRezystancje();
            }
        }
        public void ObliczNatezenie()
        {
            if (slider3 != null && slider2 != null)
            {
                if (slider3.Value > 0 && slider2.Value > 0)
                {
                    R = slider2.Value;
                    U = slider3.Value;
                    I = U / R;
                    if (tb1 != null)
                    {
                        tb1.Text = Math.Round(I, 2) + "A";
                        slider1.Value = I;
                    }
                    else
                        tb1.Text = "";
                }
            }
        }

        private void btn_Czysc(object sender, RoutedEventArgs e)
        {
            R = 0;
            U = 0;
            I = 0;
            slider1.Value = 0;
            slider2.Value = 0;
            slider3.Value = 0;
            resultMoc.Content = "";
        }

        public void ObliczRezystancje()
        {
            if (slider1 != null && slider3 != null)
            {
                if (slider1.Value > 0 && slider3.Value > 0)
                {
                    I = slider1.Value;
                    U = slider3.Value;
                    R = U / I;
                    if (tb2 != null)
                    {
                        slider2.Value = R;
                        tb2.Text = Math.Round(R, 2) + "Ω";
                    }
                    else
                        tb2.Text = "";
                }
            }
        }
        public void ObliczNapiecie()
        {
            if (slider1 != null && slider2 != null)
            {
                if (slider1.Value > 0 && slider2.Value > 0)
                {
                    I = slider1.Value;
                    R = slider2.Value;
                    U = I * R;
                    if (tb3 != null)
                    {
                        slider3.Value = U;
                        tb3.Text = Math.Round(U, 2) + "V";
                    }
                    else
                        tb3.Text = "";
                }
            }
        }
        public void ObliczMoc()
        {
            if (slider1 != null && slider3 != null)
            {
                if (slider1.Value > 0 && slider3.Value > 0)
                {
                    I = slider1.Value;
                    U = slider3.Value;
                    P = U * I;
                    if (resultMoc != null)
                        resultMoc.Content = "Moc wynosi: " + Math.Round(P, 2).ToString() + "W";
                    else
                        resultMoc.Content = "";
                }
            }
        }
    }
}
