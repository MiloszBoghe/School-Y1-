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

namespace Gezicht
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Ellipse face = new Ellipse();
            face.Height = 200;
            face.Width = 175;
            face.Margin = new Thickness(225,100,0,100);
            face.Fill = new SolidColorBrush(Colors.Red);
            face.Stroke = new SolidColorBrush(Colors.Black);
            positionCanvas.Children.Add(face);

            Ellipse eye1 = new Ellipse();
            eye1.Height = 20;
            eye1.Width = 30;
            eye1.Fill = new SolidColorBrush(Colors.Black);
            eye1.Margin = new Thickness(155,-50,0,0);
            positionCanvas.Children.Add(eye1);

            Ellipse eye2 = new Ellipse();
            eye2.Width = 30;
            eye2.Height = 20;
            eye2.Fill = new SolidColorBrush(Colors.Black);
            eye2.Margin = new Thickness(290, -50, 0, 0);
            positionCanvas.Children.Add(eye2);

            Ellipse pupil1 = new Ellipse();
            Ellipse pupil2 = new Ellipse();
            pupil1.Fill = new SolidColorBrush(Colors.MediumVioletRed);
            pupil1.Margin = new Thickness(165,-40,0,0);
            positionCanvas.Children.Add(pupil1);
            pupil1.Width = 15;
            pupil1.Height = 10;

            pupil2.Fill = new SolidColorBrush(Colors.MediumVioletRed);
            pupil2.Margin = new Thickness(295, -40, 0, 0);
            positionCanvas.Children.Add(pupil2);
            pupil2.Width = 15;
            pupil2.Height = 10;

            Line line1 = new Line();
            line1.X1 = 475;
            line1.Y1 = 105;
            line1.X2 = 440;
            line1.Y2 = 55;
            line1.Stroke = new SolidColorBrush(Colors.Black);
            positionCanvas.Children.Add(line1);

            Line line2 = new Line();
            line2.X1 = 452;
            line2.Y1 = 116;
            line2.X2 = 440;
            line2.Y2 = 55;
            line2.Stroke = new SolidColorBrush(Colors.Black);
            positionCanvas.Children.Add(line2);

            Line line3 = new Line();
            line3.X1 = 525;
            line3.Y1 = 103;
            line3.X2 = 560;
            line3.Y2 = 55;
            line3.Stroke = new SolidColorBrush(Colors.Black);
            positionCanvas.Children.Add(line3);

            Line line4 = new Line();
            line4.X1 = 548;
            line4.Y1 = 114;
            line4.X2 = 560;
            line4.Y2 = 55;
            line4.Stroke = new SolidColorBrush(Colors.Black);
            positionCanvas.Children.Add(line4);

            Line line5 = new Line();
            line5.X1 = 450;
            line5.Y1 = 240;
            line5.X2 = 565;
            line5.Y2 = 240;
            line5.Stroke = new SolidColorBrush(Colors.Black);
            positionCanvas.Children.Add(line5);

            Line line6 = new Line();
            line6.X1 = 450;
            line6.X2 = 480;
            line6.Y1 = 240;
            line6.Y2 = 270;
            line6.Stroke = new SolidColorBrush(Colors.Black);
            positionCanvas.Children.Add(line6);

            Line line7 = new Line();
            line7.X1 = 480;
            line7.X2 = 535;
            line7.Y1 = 270;
            line7.Y2 = 270;
            line7.Stroke = new SolidColorBrush(Colors.Black);
            positionCanvas.Children.Add(line7);


            Line line8 = new Line();
            line8.X1 = 535;
            line8.X2 = 565;
            line8.Y1 = 270;
            line8.Y2 = 240;
            line8.Stroke = new SolidColorBrush(Colors.Black);
            positionCanvas.Children.Add(line8);


            Ellipse ear1 = new Ellipse();
            Ellipse ear2 = new Ellipse();
            ear1.Fill = new SolidColorBrush(Colors.Red);
            ear2.Fill = new SolidColorBrush(Colors.Red);
            ear1.Margin = new Thickness(40,-20,0,0);
            ear2.Margin = new Thickness(408,-20,0,0);
            ear1.Width = 25;
            ear1.Height = 50;
            ear2.Width = 25;
            ear2.Height = 50;
            positionCanvas.Children.Add(ear1);
            positionCanvas.Children.Add(ear2);
            

        }



        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            positionTextBox.Text = "X:" + Convert.ToString(e.GetPosition(positionCanvas).X) + " Y:" + Convert.ToString(e.GetPosition(positionCanvas).Y);
        }
    }
}
