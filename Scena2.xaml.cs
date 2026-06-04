using System.Windows;
using System.Windows.Controls;

namespace rocnikový_projekt
{
    public partial class Scena2 : UserControl
    {
        public Scena2()
        {
            InitializeComponent();
        }

        private void KlikDvere(object sender, RoutedEventArgs e)
        {
            
            if (GameState.NaselPapir && GameState.NaselObraz && GameState.NaselKulnu)
            {
                Kodokno okno = new Kodokno();
                if (okno.ShowDialog() == true)
                {
                    if (okno.ZadanyKod == "843")
                    {
                        TextPopis.Text = "Dveře se odemkly a můžeš projít dál.";
                        ((MainWindow)Application.Current.MainWindow).MainContent.Content = new Scena3();
                    }
                    else
                    {
                        TextPopis.Text = "Špatný kód. Zkus to znovu.";
                    }
                }
            }
            else
            {
                TextPopis.Text = "Mám zatím jen část kódu musím najít zbytek";
            }
        }

        private void KlikPostel(object sender, RoutedEventArgs e)
        {
            GameState.NaselPapir = true;
            TextPopis.Text = "Na papíru je napsáno: První číslo je 8";
        }

        private void KlikObraz(object sender, RoutedEventArgs e)
        {
            GameState.NaselObraz = true;
            TextPopis.Text = "Za obrazem je nápis: druhé číslo je 4.";
        }

        private void KlikStena(object sender, RoutedEventArgs e)
        {
            TextPopis.Text = "Nahoru se nedostaneš schody se rozpadají, není to bezpečné.";
        }

        private void KlikKulna(object sender, RoutedEventArgs e)
        {
            GameState.NaselKulnu = true;
            TextPopis.Text = "V kůlně si našel poslední třetí číslo 3.";
        }
    }
}