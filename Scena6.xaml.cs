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
    /// Interakční logika pro Scena6.xaml
    /// </summary>
    public partial class Scena6 : UserControl
    {
        public Scena6()
        {
            InitializeComponent();
        }

        private void Konec(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gratulace! Dokázal jsi uniknout z tajemného domu a odhalit jeho temné tajemství. Tvé dobrodružství skončilo, ale vzpomínky na něj zůstanou navždy. Děkujeme, že jsi se vydal na tuto cestu s námi!");
            Application.Current.Shutdown();
        }
    }
}

