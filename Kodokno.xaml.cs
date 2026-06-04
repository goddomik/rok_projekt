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
    /// Interakční logika pro Kodokno.xaml
    /// </summary>
    public partial class Kodokno : Window
    {

        public string ZadanyKod { get; private set; }

        public Kodokno()
        {
            InitializeComponent();
        }

        private void Potvrdit(object sender, RoutedEventArgs e)
        {
            ZadanyKod = Inputkod.Text;
            this.DialogResult = true; 
            this.Close();
        }
    }
}
