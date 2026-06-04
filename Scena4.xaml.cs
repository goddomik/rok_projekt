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
    /// Interakční logika pro Scena4.xaml
    /// </summary>
    public partial class Scena4 : UserControl 
    {
        public Scena4()
        {
            InitializeComponent();
        }

        private void KlikZpet(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).MainContent.Content = new Scena3();
        }

        private void KlikDalze4(object sender, RoutedEventArgs e)
        {
            if (GameState.MaKlicZeSkrine)
            {
                ((MainWindow)Application.Current.MainWindow).MainContent.Content = new Scena5();
            }
            else
            {
                TextPopis.Text = "Dveře jsou zamčené.\nPotřebuješ klíč.";
            }
        }
    }
}
