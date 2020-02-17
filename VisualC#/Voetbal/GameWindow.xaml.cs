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
using System.Windows.Shapes;

namespace Soccer
{
    /// <summary>
    /// Interaction logic for WedstrijdWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        MainWindow window;
        Team team1;
        Team team2;
        MatchDay matchDay;
        int index;
        int score1;
        int score2;

        public GameWindow(MainWindow window, Team team1, Team team2, MatchDay matchDay, int index)
        {
            InitializeComponent();
            this.window = window;
            this.team1 = team1;
            this.team2 = team2;
            this.matchDay = matchDay;
            this.index = index;

            score1 = matchDay.ScoresList1[index];
            score2 = matchDay.ScoresList2[index];

            scoreT1Label.Content = score1;
            scoreT2Label.Content = score2;

            team1Label.Content = team1.Name;
            team2Label.Content = team2.Name;

            playersTeam1ListBox.ItemsSource = team1.Players;
            playersTeam2ListBox.ItemsSource = team2.Players;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (score1 > score2)
            {
                team1.Points += 3;
            }
            else if (score1 == score2)
            {
                team1.Points += 1;
                team2.Points += 1;
            }
            else
            {
                team2.Points += 3;
            }

            Close();
            window.Show();
        }

        private void PlayersTeam1ListBox_dblClick(object sender, MouseButtonEventArgs e)
        {
            score1++;
            scoreT1Label.Content = score1;
            matchDay.ScoresList1[index] = score1;
        }

        private void PlayersTeam2ListBox_dblClick(object sender, MouseButtonEventArgs e)
        {
            score2++;
            scoreT2Label.Content = score2;
            matchDay.ScoresList2[index] = score2;

        }
    }
}
