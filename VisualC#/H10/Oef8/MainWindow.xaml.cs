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
using System.Media;

namespace Oef8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AlarmClock alarmClock;
        DispatcherTimer timer;
        int counter = 0;
        int seconds;
        DateTime alarmTime;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            alarmClock = new AlarmClock();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Content = alarmClock.getCurrentTime().Hour + " : " + alarmClock.getCurrentTime().Minute + " : " + alarmClock.getCurrentTime().Second;

            if (alarmClock.getCurrentTime() > alarmTime && counter <= seconds)
            {
                SystemSounds.Beep.Play();
                Console.WriteLine("BEEP"+counter);
                counter++;
            }

        }

        private void StartTimer_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            alarmTime = Convert.ToDateTime(alarmTimeTextbox.Text);
            alarmClock.setAlarmTime(alarmTime);
            seconds = Convert.ToInt32(secondsTextBox.Text);
            alarmClock.setSeconds(seconds);
            counter = 0;

        }

    }
}