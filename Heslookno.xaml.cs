using System.Windows;

namespace rocnikový_projekt
{
    public partial class Heslookno : Window
    {
        public string ZadanaVeta = "";

        public Heslookno()
        {
            InitializeComponent();
        }

        private void PotvrditKlik(object sender, RoutedEventArgs e)
        {
            ZadanaVeta = TextHeslo.Text;

            DialogResult = true;
            Close();
        }
    }
}