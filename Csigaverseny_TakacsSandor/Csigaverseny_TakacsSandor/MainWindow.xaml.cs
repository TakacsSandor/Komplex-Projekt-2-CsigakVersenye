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
        double celVonalX;
        List<Image> versenyzok = new List<Image>();
        public MainWindow()
        {
            InitializeComponent();
            idozito = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(0.04);
            idozito.Tick += new EventHandler(MitCsinaljon);
            SolidColorBrush[] ermek = { Brushes.Gold, Brushes.Silver, Brushes.SandyBrown };

        }
        void MitCsinaljon(object sender, EventArgs e)
        {

            Random rnd = new Random();
            celVonalX = celVonal.TransformToAncestor(racsos).Transform(new Point(0, 0)).X;
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
        
        private void Visszallitas()
        {
            csiga1.Margin = new Thickness(10, 60, 0, 0);
            csiga2.Margin = new Thickness(10, 240, 0, 0);
            csiga3.Margin = new Thickness(10, 420, 0, 0);
        }
        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            idozito.Start();
            startGomb.IsEnabled = false;
            
           
        }

        private void ujFutamGomb_Click(object sender, RoutedEventArgs e)
        {
            Visszallitas();
            idozito.Stop();
            startGomb.IsEnabled = true;
        }

        private void ujBajnoksagGomb_Click(object sender, RoutedEventArgs e)
        { 
            MessageBox.Show("eredmenyek");
        }
        /*private string VersenyzokAllasa()
           {
           string versenyzokAllasa = "Hely \tNév\t\t1.\t2.\t3.\tPont\n";
           var sorrend = versenyzok.OrderByDescending(x => x.Pont).ThenByDescending(x => x.Helyezes[1]).ThenByDescending(x => x.Helyezes[2]);
            }*/

        public void Versenyzok()
        {
            versenyzok.Add(csiga1);
            versenyzok.Add(csiga2);
            versenyzok.Add(csiga3);
        }
        public class VersenyzoCsiga
        {
            public string nev;
            public int pontjai = 0;
            public int elsoHely = 0;
            public int masodikHely = 0;
            public int harmadikHely = 0;


        }
      /*  private void Szinezes(object sender, EventArgs e)
        {
            if(csiga1.Margin.Left >= 850)
            {
                csigaPalya1.Fill = new SolidColorBrush(System.Windows.Media.Colors.AliceBlue);
           
            }*/
        }
    }
    

