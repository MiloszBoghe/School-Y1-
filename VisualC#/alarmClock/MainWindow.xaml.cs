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
using System.Windows.Threading;

namespace alarmClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AlarmClock _alarmClock;
        private DispatcherTimer _clockTimer;
        private DispatcherTimer _alarmTimer;
        private Color _color1;
        private Color _color2;
        private SolidColorBrush _brush;

        public MainWindow()
        {
            InitializeComponent();

            _alarmClock = new FlickerAlarmClock(_brush);

            _color1 = Colors.White;
            _color2 = Colors.Tomato;

            _brush = new SolidColorBrush(_color1);

            clockLabel.Background = _brush;


            _clockTimer = new DispatcherTimer();
            _alarmTimer = new DispatcherTimer();

            _clockTimer.Interval = TimeSpan.FromSeconds(1);
            _alarmTimer.Interval = TimeSpan.FromMilliseconds(300);

            _clockTimer.Tick += _clockTimer_Tick;
            _alarmTimer.Tick += _alarmTimer_Tick;

            _clockTimer.Start();

        }


        private void SetButton_Click(object sender, RoutedEventArgs e)
        {
            _alarmClock.AlarmTime = alarmTimeTextBox.Text;
        }

        
        private void _clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Content = _alarmClock.CurrentTime;
            if (_alarmClock.isAlarmPassed())
            {
                Console.WriteLine("Alarm passed");
                _alarmTimer.Start();
            }
            else
            {
                Console.WriteLine("Alarm NOT passed");
            }
            if (_alarmClock.ShouldStopBeeping())
            {
                Console.WriteLine("ShouldStop");
                _alarmTimer.Stop();
                _brush.Color = _color1;
                _alarmClock.Reset();
                alarmTimeTextBox.Clear();
            }
        }
        private void _alarmTimer_Tick(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            _brush.Color = _brush.Color == _color1 ? _color2 : _color1;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _alarmClock.Reset();
            _alarmTimer.Stop();
            if (flickerRadioButton.IsChecked == true)
            {
                _alarmClock = new FlickerAlarmClock(_brush);
            }
            else
            {
                _alarmClock = new BeeperAlarmClock();
            }
        }
        
    }

}

