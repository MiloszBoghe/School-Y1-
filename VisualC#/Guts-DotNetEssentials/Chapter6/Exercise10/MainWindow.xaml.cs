using System;
using System.Windows;
using System.Windows.Threading;

namespace Exercise10
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += Timer_tick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            loginProgressBar.Value += loginProgressBar.Maximum * 0.2;
            if (loginProgressBar.Value == loginProgressBar.Maximum)
            {
                MessageBox.Show("U hebt slechts vijf seconden om in te loggen.", "ERROR");
                okButton.IsEnabled = false;
                timer.Stop();
            }
        }
        
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            okButton.IsEnabled = true;
            timer.Start();
            loginProgressBar.Value = 0;
        }

        
    }
}
