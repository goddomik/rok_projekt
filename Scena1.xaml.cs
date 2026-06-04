using System.Windows;
using System.Windows.Controls;

namespace rocnikový_projekt
{
    public partial class Scena1 : UserControl
    {
        public Scena1()
        {
            InitializeComponent();
        }

        private void KlikDvere(object sender, RoutedEventArgs e)
        {
            if (GameState.MaKlic)
            {
                ((MainWindow)Application.Current.MainWindow).MainContent.Content = new Scena2();
            }
            else
            {
                TextPopis.Text = "Dveře jsou zamčené... potřebujete klíč.";
            }
        }
        private void KlikOkno(object sender, RoutedEventArgs e)
        {
            TextPopis.Text = "Okno je rozbité... někdo se sem vloupal.";
        }

        private void KlikKer(object sender, RoutedEventArgs e)
        {

            if (GameState.MaKlic)
            {
                TextPopis.Text = "Už máš klíč, není tu nic dalšího.";
                return;
            }

            GameState.MaKlic = true;
            TextPopis.Text = "Našel si klíč";

            ((Button)sender).Visibility = Visibility.Hidden;
        }
    }
}