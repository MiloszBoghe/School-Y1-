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

namespace StringConcat
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

        private void concatButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = "Anders";
            string lastName, wholeName;
            string greeting;
            lastName = "Hejlsberg";
            wholeName = firstName + " " + lastName;
            greeting = wholeName + " invented C#"; // wordt "Anders Hejlsberg invented C#"

            MessageBox.Show(greeting);
        }
    }
}
