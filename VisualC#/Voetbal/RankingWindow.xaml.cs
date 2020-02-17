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
    /// Interaction logic for RangschikkingWindow.xaml
    /// </summary>
    public partial class RankingWindow : Window
    {
        MainWindow window;
        public RankingWindow(MainWindow window, List<Team> teams)
        {
            InitializeComponent();
            rankingTextBox.Text = "";
            this.window = window;
            teams = teams.OrderByDescending(team => team.Points).ToList();
            foreach (Team team in teams)
            {
                rankingTextBox.Text += $"{team.Points}\t{team.Name}";
                rankingTextBox.Text += "\n";
            }

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
            window.Show();
        }
    }
}
