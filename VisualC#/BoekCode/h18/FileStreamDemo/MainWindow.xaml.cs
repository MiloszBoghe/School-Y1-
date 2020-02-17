using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileStreamDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentFile;
        private string currentFolder;
        
        public MainWindow()
        {
            InitializeComponent();

            currentFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = currentFolder;

            if (dialog.ShowDialog() == true)
            {
                currentFile = dialog.FileName;
                currentFolder = Directory.GetParent(currentFile).ToString();
                fileTextBox.Text = currentFile;
            }
        }

        private void openButton_Click(object sender, RoutedEventArgs e)
        {
            StreamReader reader = null;
            try
            {
                FileStream fstream = new FileStream(currentFile,
                                                    FileMode.Open,
                                                    FileAccess.Read);
                reader = new StreamReader(fstream);
                mainTextBox.Text = reader.ReadToEnd();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(fileTextBox.Text + " niet gevonden!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void appendButton_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = null;
            try
            {
                FileStream fstream = new FileStream(currentFile,
                                                    FileMode.Append,
                                                    FileAccess.Write);
                writer = new StreamWriter(fstream);
                // Append content
                writer.Write(mainTextBox.Text);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        private void replaceButton_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = null;
            try
            {
                FileStream fstream = new FileStream(currentFile,
                                                    FileMode.Create,
                                                    FileAccess.Write);
                writer = new StreamWriter(fstream);
                // Replace content
                writer.Write(mainTextBox.Text);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }
    }
}
