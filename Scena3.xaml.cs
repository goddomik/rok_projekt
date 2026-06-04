using System.Windows;
using System.Windows.Controls;

namespace rocnikový_projekt
{
    public partial class Scena3 : UserControl
    {
        public Scena3()
        {
            InitializeComponent();
        }

        private void KlikPostel(object sender, RoutedEventArgs e)
        {
            if (GameState.ProhledalPostel)
            {
                TextPopis.Text = "Už jsi postel prohledal.";
                return;
            }

            GameState.ProhledalPostel = true;
            TextPopis.Text = "Postel je rozhrabaná… někdo tu rozhodně nespal klidně.\nVypadá to na zápas… možná tu někoho přepadli.";
        }

        private void KlikSkrin(object sender, RoutedEventArgs e)
        {
            if (GameState.MaKlicZeSkrine)
            {
                TextPopis.Text = "Skříň je prázdná, už jsi tu našel klíč.";
            }
            else if (GameState.ProhledalPostel)
            {
                GameState.MaKlicZeSkrine = true;
                TextPopis.Text = "Ve skříni jsi našel klíč a starý papír…\nNa papíru je napsáno: \"Sklep\".";
            }
            else
            {
                TextPopis.Text = "Skříň nejde otevřít.\nNejdřív bych měl prohledat místnost.";
            }
        }

        private void KlikOkno(object sender, RoutedEventArgs e)
        {
            TextPopis.Text = "Okno je rozbité…\nNěkdo tudy utekl… nebo byl vyhozen ven.";
        }

        private void KlikPryc(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).MainContent.Content = new Scena4();
        }
    }
}