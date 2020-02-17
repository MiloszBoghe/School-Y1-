using System;
using System.IO;
using System.Windows;

namespace FileOutput
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

        private void writeButton_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = File.CreateText(@"C:\myfile.txt");
            writer.WriteLine("This file will");
            writer.WriteLine("contain 3");
            writer.WriteLine("lines of text.");
            writer.Close();
        }

        private void myDocButton_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = Environment.GetFolderPath(
                                    Environment.SpecialFolder.MyDocuments);
            statusLabel.Content = "Writing to: " + folderPath;

            string filePath = System.IO.Path.Combine(folderPath, "myfile.txt");
            StreamWriter writer = File.CreateText(filePath);
            writer.WriteLine("This file will");
            writer.WriteLine("contain 3");
            writer.WriteLine("lines of text.");
            writer.Close();
        }

        private void writeAppButton_Click(object sender, RoutedEventArgs e)
        {
            string destination = Environment.GetFolderPath(
                                    Environment.SpecialFolder.ApplicationData);
            statusLabel.Content = "Writing to: " + destination;

            string newFile = System.IO.Path.Combine(destination, "myfile.txt");
            StreamWriter outputStream = File.CreateText(newFile);
            outputStream.WriteLine("This file will");
            outputStream.WriteLine("contain 3");
            outputStream.WriteLine("lines of text.");
            outputStream.Close();
        }
    }
}
