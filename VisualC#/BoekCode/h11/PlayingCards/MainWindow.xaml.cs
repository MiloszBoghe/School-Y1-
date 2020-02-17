using System.Windows;

namespace PlayingCards
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Card twoOfHearts = new Card
            {
                Value = 2,
                Suit = SuitType.Hearts
            };
        }
    }
}
