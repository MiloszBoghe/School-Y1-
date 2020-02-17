using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Beetle
{
    public class BeetleClass
    {
        private int grootte;
        private double snelheid;

        private double x;
        private double y;

        public string movement;

        private SolidColorBrush brusToUse = new SolidColorBrush(Colors.Red);
        private DispatcherTimer timer = new DispatcherTimer();
        Ellipse beetle = new Ellipse();

        Random random = new Random();

        public BeetleClass(int grootte, double snelheid)
        {
            this.grootte = grootte;
            this.snelheid = snelheid;
            movement = "up";
            timer.Interval = TimeSpan.FromMilliseconds(5);
            timer.Tick += Timer_Tick;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (movement == "up")
            {
                MoveBeetlUp();
            }
            else if (movement == "down")
            {
                MoveBeetlyDown();
            }
            else if (movement == "left")
            {
                MoveBeetleLeft();
            }
            else if (movement == "right")
            {
                MoveBeetleRight();
            }
        }

        public void drawBeetle(Canvas drawingPaper)
        {
            beetle.Width = grootte;
            beetle.Height = grootte;
            beetle.Fill = brusToUse;
            generateXY();
            beetle.Margin = new Thickness(x, y, 0, 0);
            drawingPaper.Children.Add(beetle);
        }
        private void Moved()
        {
            if (x < 0)
            {
                movement = "right";
            }
            else if (x > 378 - beetle.Width)
            {
                movement = "left";
            }
            else if (y < 0)
            {
                movement = "down";
            }
            else if (y > 226 - beetle.Width)
            {
                movement = "up";
            }

        }

        public void MoveBeetlUp()
        {
            beetle.Margin = new Thickness(x, y - snelheid, 0, 0);
            y -= snelheid;
            Moved();
        }
        public void MoveBeetlyDown()
        {
            beetle.Margin = new Thickness(x, y + snelheid, 0, 0);
            y += snelheid;
            Moved();
        }

        public void MoveBeetleLeft()
        {
            beetle.Margin = new Thickness(x - snelheid, y, 0, 0);
            x -= snelheid;
            Moved();
        }
        public void MoveBeetleRight()
        {
            beetle.Margin = new Thickness(x + snelheid, y, 0, 0);
            x += snelheid;
            Moved();
        }

        public void StartTimer()
        {
            timer.Start();
        }
        public void StopTimer()
        {
            timer.Stop();
        }

        private void generateXY()
        {
            x = random.Next(100);
            y = random.Next(100);
        }

    }
}