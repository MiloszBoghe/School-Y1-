using System.IO;
using System.Windows;

namespace TestVraag18_1_Stars
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

        private void starsButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "pattern.txt";
            StreamWriter writer = File.CreateText(fileName);
            for (int line = 1; line <= 10; line++)
            {
                for (int star = 1; star <= line; star++)
                {
                    writer.Write("*");
                }
                writer.WriteLine();
            }
            writer.Close();
        }
    }
}
