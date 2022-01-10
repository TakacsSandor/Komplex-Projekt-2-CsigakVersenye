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
using System.Windows.Threading;

namespace Csigaverseny_TakacsSandor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer idozito;
        int szamlalo = 10;
        double celVonalX;
        List<Image> versenyzok = new List<Image>();
        public MainWindow()
        {
            InitializeComponent();
            idozito = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(0.04);
            idozito.Tick += new EventHandler(MitCsinaljon);

        }
        void MitCsinaljon(object sender, EventArgs e)
        {

            Random rnd = new Random();
            celVonalX = celVonal.TransformToAncestor(racsos).Transform(new Point(0, 0)).X;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (csiga1.TransformToAncestor(racsos).Transform(new Point(0, 0)).X + 150 < celVonalX)
            {
                var X1 = csiga1.TransformToAncestor(racsos).Transform(new Point(0, 0)).X + rnd.Next(1, 5);
                if (X1 + 150 > celVonalX)
                {
                    X1 = celVonalX = 850;
                }
                csiga1.Margin = new Thickness(X1, 60, 0, 0);

            }

            if (csiga2.TransformToAncestor(racsos).Transform(new Point(0, 0)).X + 150 < celVonalX)
            {
                var X2 = csiga2.TransformToAncestor(racsos).Transform(new Point(0, 0)).X + rnd.Next(1, 5);
                if (X2 + 150 > celVonalX)
                {
                    X2 = celVonalX = 850;
                }
                csiga2.Margin = new Thickness(X2, 240, 0, 0);

            }
            if (csiga3.TransformToAncestor(racsos).Transform(new Point(0, 0)).X + 150 < celVonalX)
            {
                var X3 = csiga3.TransformToAncestor(racsos).Transform(new Point(0, 0)).X + rnd.Next(1, 5);
                if (X3 + 150 > celVonalX)
                {
                    X3 = celVonalX = 850;
                }
                csiga3.Margin = new Thickness(X3, 420, 0, 0);

            }

        }

        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            idozito.Start();
        }

        private void ujFutamGomb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ujBajnoksagGomb_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    }

