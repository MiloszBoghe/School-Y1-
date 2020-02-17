using System.Windows;

namespace DotNetExamenJuni
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void ProgramButton_Click(object sender, RoutedEventArgs e)
        {
            StageLineUpWindow window = new StageLineUpWindow();
            window.ShowDialog();
        }
    }
}
