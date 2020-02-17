using System;
using System.IO;
using System.Windows;

namespace FileInput
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

        private void readButton_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = Environment.GetFolderPath(
                                   Environment.SpecialFolder.MyDocuments);
            // Use System.IO.Path io Path because of misinterpretation with
            // System.Shapes.Path
            string filePath = System.IO.Path.Combine(folderPath, "myfile.txt");
            StreamReader reader = File.OpenText(filePath);
            string line = reader.ReadLine();
            while (line != null)
            {
                fileTextBox.AppendText(line);
                fileTextBox.AppendText(Environment.NewLine);
                line = reader.ReadLine();
            }
            reader.Close();
        }
    }
}
