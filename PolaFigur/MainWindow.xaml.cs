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

namespace Kalkulator_Figur
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void PoleKwadrat(object sender, RoutedEventArgs e)
    {
        int bok;
        if (int.TryParse(BokKwadrat.Text, out bok) == false || BokKwadrat.Text == null)
        {
            MessageBox.Show("podaj odpowiednią wartość");
        }
        else{
            var pole = bok * bok;
            PoleKwadratT.Text = pole.ToString();
        }
    }
    private void ObwodKwadrat(object sender, RoutedEventArgs e)
    {
        int bok;
        if (int.TryParse(BokKwadrat.Text, out bok) == false || BokKwadrat.Text == null)
        {
            MessageBox.Show("podaj odpowiednią wartość");
        }
        else
        {
            var obwod = bok * 4;
            ObwodKwadratT.Text = obwod.ToString();
        }
    }
    private void PoleTrojkat(object sender, RoutedEventArgs e)
    {
        int bok;
        if (int.TryParse(BokTrojkat.Text, out bok) == false || BokTrojkat.Text == null)
        {
            MessageBox.Show("podaj odpowiednią wartość");
        }
        else{
            var pole = ((bok * bok) * Math.Sqrt(3)) / 4;
            PoleTrojkatT.Text = Math.Round(pole, 2).ToString();
        }
    }
    private void ObwodTrojkat(object sender, RoutedEventArgs e)
    {
        int bok;
        if (int.TryParse(BokTrojkat.Text, out bok) == false || BokTrojkat.Text == null)
        {
            MessageBox.Show("podaj odpowiednią wartość");
        }
        else
        {
            var obwod = bok * 3;
            ObwodTrojkatT.Text = obwod.ToString();
        }
    }
    private void PoleKolo(object sender, RoutedEventArgs e)
    {
        int bok;
        if (int.TryParse(BokKolo.Text, out bok) == false || BokKolo.Text == null)
        {
            MessageBox.Show("podaj odpowiednią wartość");
        }
        else
        {
            var pole = Math.PI * (bok * bok) ;
            PoleKoloT.Text = Math.Round(pole, 2).ToString();
        }
    }
    private void ObwodKolo(object sender, RoutedEventArgs e)
    {
        int bok;
        if (int.TryParse(BokKolo.Text, out bok) == false || BokKolo.Text == null)
        {
            MessageBox.Show("podaj odpowiednią wartość");
        }
        else
        {
            var obwod = (Math.PI * 2) * bok;
            ObwodKoloT.Text = Math.Round(obwod, 2).ToString();
        }
    }
}
}
