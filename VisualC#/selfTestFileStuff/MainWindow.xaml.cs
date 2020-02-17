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

namespace selfTestFileStuff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string folderPath;
        string filePath;
        StreamWriter writer;
        StreamReader reader;
        public MainWindow()
        {
            InitializeComponent();
            folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            filePath = System.IO.Path.Combine(folderPath, "testjee.txt");
            writer = File.CreateText(filePath);
            writer.WriteLine("Did I do it right?");
            writer.WriteLine("YES!");
            writer.WriteLine("Hello world xD");
            writer.Close();

            reader = File.OpenText(filePath);
            MessageBox.Show(reader.ReadLine());

        }
       

    }
}
