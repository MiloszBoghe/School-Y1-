using System;
using System.IO;
using System.Windows;

namespace FileSearch
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

        //private void searchButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //    string line = "";
        //    string[] words = new string[3];
        //    bool found = false;
        //    StreamReader reader = null;

        //    // clear any previous results
        //    result1Label.Content = "";
        //    result2Label.Content = "";

        //    if (fileTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing file name!");
        //    }
        //    else if (nameTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing student name!");
        //    }
        //    else
        //    {
        //        string fileToSearchPath = System.IO.Path.Combine(folderPath,
        //                                                     fileTextBox.Text);
        //        reader = File.OpenText(fileToSearchPath);
        //        char separator = ',';
        //        line = reader.ReadLine();
        //        while ((line != null) && (!found))
        //        {
        //            words = line.Split(separator);
        //            if (words[0].Trim() == nameTextBox.Text)
        //            {
        //                result1Label.Content = words[1].Trim();
        //                result2Label.Content = words[2].Trim();
        //                found = true;
        //            }
        //            else
        //            {
        //                line = reader.ReadLine();
        //            }
        //        }
        //        if (!found)
        //        {
        //            MessageBox.Show(nameTextBox.Text + " not found!");
        //        }
        //        reader.Close();
        //    }
        //}

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            // search the file with exception handling

            string folderPath = Environment.GetFolderPath(
                                    Environment.SpecialFolder.MyDocuments);

            string line = "";
            string[] words = new string[3];
            bool found = false;
            StreamReader reader = null;

            // clear any previous results
            result1Label.Content = "";
            result2Label.Content = "";

            if (fileTextBox.Text == "")
            {
                MessageBox.Show("Error: missing file name!");
            }
            else if (nameTextBox.Text == "")
            {
                MessageBox.Show("Error: missing student name!");
            }
            else
            {
                try
                {
                    string fileToSearchPath = System.IO.Path.Combine(folderPath,
                                                                 fileTextBox.Text);
                    reader = File.OpenText(fileToSearchPath);
                    char separator = ',';
                    line = reader.ReadLine();
                    while ((line != null) && (!found))
                    {
                        words = line.Split(separator);
                        if (words[0].Trim() == nameTextBox.Text)
                        {
                            result1Label.Content = words[1].Trim();
                            result2Label.Content = words[2].Trim();
                            found = true;
                        }
                        else
                        {
                            line = reader.ReadLine();
                        }
                    }
                    if (!found)
                    {
                        MessageBox.Show(nameTextBox.Text + " not found!");
                    }
                    reader.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"Error: File not found: {fileTextBox.Text}. Re-enter name.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error concerning file: {fileTextBox.Text}. {ex.Message}");
                }
            }
        }

        //private void searchButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // search the file with exception handling

        //    string folderPath = Environment.GetFolderPath(
        //                            Environment.SpecialFolder.MyDocuments);

        //    string line = "";
        //    string[] words = new string[3];
        //    bool found = false;
        //    StreamReader reader = null;

        //    // clear any previous results
        //    result1Label.Content = "";
        //    result2Label.Content = "";

        //    if (fileTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing file name!");
        //    }
        //    else if (nameTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing student name!");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            string fileToSearchPath = System.IO.Path.Combine(folderPath,
        //                                                         fileTextBox.Text);
        //            reader = File.OpenText(fileToSearchPath);
        //            char separator = ',';

        //            line = reader.ReadLine();
        //            while ((line != null) && (!found))
        //            {
        //                words = line.Split(separator);
        //                if (words[0].Trim() == nameTextBox.Text)
        //                {
        //                    result1Label.Content = words[1].Trim();
        //                    result2Label.Content = words[2].Trim();
        //                    found = true;
        //                }
        //                else
        //                {
        //                    line = reader.ReadLine();
        //                }
        //            }
        //            if (!found)
        //            {
        //                MessageBox.Show(nameTextBox.Text + " not found!");
        //            }
        //        }
        //        catch (FileNotFoundException ex)
        //        {
        //            MessageBox.Show($"Error: File not found: {fileTextBox.Text}. Re-enter name.");
        //        }
        //        catch (Exception ex)
        //        {
        //           MessageBox.Show($"Error concerning file: {fileTextBox.Text}. {ex.Message}");
        //        }
        //        finally
        //        {
        //            if (reader != null)
        //            {
        //                reader.Close();
        //            }
        //        }
        //    }
        //}
    }
}
