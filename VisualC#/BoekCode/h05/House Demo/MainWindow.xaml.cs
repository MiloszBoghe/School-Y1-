using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace House_Demo
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

            DrawHouse(paperCanvas, blackBrush, 10, 20, 70, 20);
            DrawHouse(paperCanvas, blackBrush, 10, 90, 50, 50);
        }

        private void DrawHouse(Canvas drawingArea,
                               SolidColorBrush brushToUse,
                               double topRoofX,
                               double topRoofY,
                               double width,
                               double height)
        {
            DrawTriangle(drawingArea, brushToUse, topRoofX,
                         topRoofY, width, height);
            DrawRectangle(drawingArea, brushToUse, topRoofX,
                          topRoofY + height, width, height);
        }

        private void DrawTriangle(Canvas drawingArea,
                                  SolidColorBrush brushToUse,
                                  double topX,
                                  double topY,
                                  double width,
                                  double height)
        {
            DrawLine(drawingArea, brushToUse, topX, topY,
                     topX, topY + height);
            DrawLine(drawingArea, brushToUse, topX,
                     topY + height,
                     topX + width, topY + height);
            DrawLine(drawingArea, brushToUse, topX, topY,
                     topX + width, topY + height);
        }

        private void DrawLine(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double startX, double startY,
                              double endX, double endY)
        {
            Line theLine = new Line();
            theLine.X1 = startX; theLine.X2 = endX;
            theLine.Y1 = startY; theLine.Y2 = endY;
            theLine.Stroke = brushToUse;
            theLine.StrokeThickness = 1;
            drawingArea.Children.Add(theLine);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double topLeftX,
                                   double topLeftY,
                                   double width,
                                   double height)
        {
            Rectangle theRectangle = new Rectangle();
            theRectangle.Width = width;
            theRectangle.Height = height;
            theRectangle.Margin = new Thickness(topLeftX, topLeftY, 0, 0);
            theRectangle.Stroke = brushToUse;
            drawingArea.Children.Add(theRectangle);
        }
    }
}
