using Microsoft.Win32;
using System;
using System.Windows;

namespace FileDialogs
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

        private void openButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string startFolder = Environment.GetFolderPath(
                                 Environment.SpecialFolder.MyPictures);
            openFileDialog.InitialDirectory = startFolder;
            openFileDialog.Filter = "Image Files|*.BMP;" +
                                    "*.JPG;*.GIF|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true) // User clicks Open
            {
                MessageBox.Show(openFileDialog.FileName);
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(
                                         Environment.SpecialFolder.MyDocuments);
            if (dialog.ShowDialog() == true) // User clicks Save
            {
                MessageBox.Show(dialog.FileName);
            }
        }
    }
}
