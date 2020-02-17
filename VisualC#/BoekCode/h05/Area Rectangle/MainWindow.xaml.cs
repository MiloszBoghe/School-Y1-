using System.Windows;

namespace Area_Rectangle
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int area;
            area = CalculateAreaOfRectangle(10, 20);
        }

        private int CalculateAreaOfRectangle(int length, int width)
        {
            int area;
            area = length * width;
            return area;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int area;
            area = CalculateAreaOfRectangle(10, 20);
            MessageBox.Show("Area is " + CalculateAreaOfRectangle(3, 4));
            area = CalculateAreaOfRectangle(10, 20) * CalculateAreaOfRectangle(7, 8);
        }

        private int CalculateAreaOfRectangle2(int length, int width)
        {
            return length * width;
        }
    }
}
