using System.Windows;

namespace rocnikový_projekt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainContent.Content = new Scena1();
        }
    }
}