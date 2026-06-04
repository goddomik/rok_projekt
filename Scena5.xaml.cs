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
using System.Windows.Shapes;

namespace rocnikový_projekt
{
    /// <summary>
    /// Interakční logika pro Scena5.xaml
    /// </summary>
    public partial class Scena5 : UserControl
    {
        public Scena5()
        {
            InitializeComponent();
        }

        private void KlikOdchod(object sender, RoutedEventArgs e)
        {
            if(GameState.Postel && GameState.Nastenka && GameState.Noviny)
            {
                Heslookno okno = new Heslookno();

                if (okno.ShowDialog() == true)
                {
                    if (okno.ZadanaVeta.ToUpper() == "HLEDEJ VE SKLEPE")        
                    {
                        TextPopis.Text = "Správně!!";
                        ((MainWindow)Application.Current.MainWindow).MainContent.Content = new Scena6();
                    }
                    else
                    {
                        TextPopis.Text = "Špatné heslo. Zkus to znovu.";
                    }
                }
            }
            else
            {
                TextPopis.Text = "Být tebou bych ještě hledal";
            }
        }

        private void Postel(object sender, RoutedEventArgs e)
        {
            GameState.Postel = true;
            TextPopis.Text = "Na kovu je vyškrábané:\r\n\"HLEDEJ\"";
        }

        private void Nastenka(object sender, RoutedEventArgs e)
        {
            GameState.Nastenka = true;
            TextPopis.Text = "Na papíru je napsáno:\r\n\"SKLEPE\"";
        }

        private void Miska(object sender, RoutedEventArgs e)
        {
            TextPopis.Text = "Prázdná miska.";
        }

        private void Mrize(object sender, RoutedEventArgs e)
        {
            TextPopis.Text = "Mříže jsou pevné.";
        }

        private void Noviny(object sender, RoutedEventArgs e)
        {
            GameState.Noviny = true;
            TextPopis.Text = "Titulek je podtržený:\r\n\"VE\"";
        }

        private void Spisy(object sender, RoutedEventArgs e)
        {
            TextPopis.Text = "Ve spisech je založené číslo 52";
        }
    }
}
