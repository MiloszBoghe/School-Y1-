using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Forms;
using System.IO;

namespace DirectoryForEx18_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        FolderBrowserDialog browse;
        StreamReader reader;
        string[] files;
        string line;
        int count;

        public MainWindow()
        {
            InitializeComponent();
            browse = new FolderBrowserDialog();
        }
        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            browse.ShowDialog();
            pathTextBox.Text = browse.SelectedPath;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

            files = Directory.GetFiles(pathTextBox.Text, "*.txt", SearchOption.TopDirectoryOnly);
            count = 0;

            foreach (string f in files)
            {
                reader = new StreamReader(f);
                line = reader.ReadLine();
                count++;
                while (line != null)
                {
                    if (line.Contains(targetTextBox.Text))
                    {
                        string filename = System.IO.Path.GetFileName(f);
                        resultTextBox.AppendText("file: " + filename + " line: " + count + " " + "text: " + line);
                        resultTextBox.AppendText(Environment.NewLine);
                    }
                    line = reader.ReadLine();
                    count++;
                }
                count = 0;
            }
        }

    }
}
