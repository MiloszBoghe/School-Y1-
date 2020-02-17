using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Oef14._21_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stopwatch stopwatch;
        private Dictionary<string, Course> coursesDictionary;
        private Course[] coursesArray;
        private List<Course> coursesList;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void StartTiming()
        {
            stopwatch.Start();
        }

        private void StopTiming()
        {
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            
        }

        
    }
}
