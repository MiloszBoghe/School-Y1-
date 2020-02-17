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

namespace Rectangle_Method
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush blackBrush = new SolidColorBrush(Colors.Black);
            
            // draw first logo at (10, 20)
            DrawRectangle(paperCanvas, blackBrush, 10, 20, 20);
            DrawRectangle(paperCanvas, blackBrush, 10, 20, 40);
            DrawRectangle(paperCanvas, blackBrush, 10, 20, 60);

            //// draw second logo at (100, 100)
            //DrawRectangle(paperCanvas, blackBrush, 100, 100, 20);
            //DrawRectangle(paperCanvas, blackBrush, 100, 100, 40);
            //DrawRectangle(paperCanvas, blackBrush, 100, 100, 60);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPosition,
                                   double yPosition,
                                   double size)
        {
            Rectangle theRectangle = new Rectangle();
            theRectangle.Width = size;
            theRectangle.Height = size;
            theRectangle.Margin = new Thickness(xPosition, yPosition, 0, 0);
            theRectangle.Stroke = brushToUse;
            drawingArea.Children.Add(theRectangle);
        }
    }
}
