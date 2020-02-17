using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentFilePath = "";
        private string initialFolderPath;

        public MainWindow()
        {
            InitializeComponent();

            initialFolderPath = Environment.GetFolderPath(
                            Environment.SpecialFolder.MyDocuments);
        }

        private void openMenuItem_Click(object sender, RoutedEventArgs e)
        {
            StreamReader reader;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = initialFolderPath;
            if (dialog.ShowDialog() == true)
            {
                currentFilePath = dialog.FileName;
                reader = File.OpenText(currentFilePath);
                mainTextBox.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (currentFilePath == "")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = initialFolderPath;
                if (dialog.ShowDialog() == true)
                {
                    currentFilePath = dialog.FileName;
                }
            }
            StreamWriter writer = File.CreateText(currentFilePath);
            writer.Write(mainTextBox.Text);
            writer.Close();
        }

        private void saveAsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialFolderPath;
            if (dialog.ShowDialog() == true)
            {
                currentFilePath = dialog.FileName;
                writer = File.CreateText(currentFilePath);
                writer.Write(mainTextBox.Text);
                writer.Close();
            }
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
