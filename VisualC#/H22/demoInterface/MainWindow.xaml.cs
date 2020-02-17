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

namespace demoInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String lol = new String('l',4);
        string lol2 = "llll";
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show(lol);
            MessageBox.Show(lol2);
            bool yes = lol == lol2;
            MessageBox.Show(Convert.ToString(yes));

        }
    }
}
