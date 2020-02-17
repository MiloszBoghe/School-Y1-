using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Soccer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int MaximumNumberOfPlayers = 11;
        private List<Team> teams;
        private IList<MatchDay> matchDays;
        MatchDay matchDay;
        public MainWindow()
        {
            InitializeComponent();
            teams = new List<Team>();
            matchDays = new List<MatchDay>();
        }

        private void SwitchTeams()
        {

        }

        private void MenuItem_Read_Click(object sender, RoutedEventArgs e)
        {
            //InvoerDemo
            string sourcepath = @"..\..\";
            string teamFile = System.IO.Path.Combine(sourcepath, "Teams.txt");
            StreamReader inputStreamTeam = new StreamReader(teamFile, Encoding.Default);
            string playersFile = System.IO.Path.Combine(sourcepath, "Players.txt");
            StreamReader inputStreamPlayers = new StreamReader(playersFile, Encoding.Default);
            try
            {
                string lineTeam = inputStreamTeam.ReadLine();
                string linePlayer = inputStreamPlayers.ReadLine();

                while (lineTeam != null)
                {
                    //lees team in
                    string[] dataTeamArray = lineTeam.Split(',');
                    int id = Convert.ToInt32(dataTeamArray[0]);
                    string name = dataTeamArray[1];
                    string location = dataTeamArray[2];
                    Team team = new Team(id, name, location);
                    teams.Add(team);

                    //lees spelers voor dat team in
                    for (int i = 0; i < MaximumNumberOfPlayers; i++)
                    {
                        string[] dataPlayerArray = linePlayer.Split(',');
                        int number = Convert.ToInt32(dataPlayerArray[1]);
                        string surname = dataPlayerArray[2];
                        name = dataPlayerArray[3];
                        char function = Convert.ToChar(dataPlayerArray[4]);
                        Player player = new Player(id, number, surname, name, function);
                        team.Players.Add(player);
                        linePlayer = inputStreamPlayers.ReadLine();
                    }

                    //Ga naar volgende team:
                    lineTeam = inputStreamTeam.ReadLine();
                }
                menuCompetition.IsEnabled = true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Bestand niet gevonden!");
            }
            finally
            {
                inputStreamTeam.Close();
                inputStreamPlayers.Close();
            }
        }

        private void MenuItem_Compose_Click(object sender, RoutedEventArgs e)
        {
            List<Team> teamList1 = new List<Team>();
            List<Team> teamList2 = new List<Team>();
            List<Team> newTeamList1 = new List<Team>();
            List<Team> newTeamList2 = new List<Team>();

            for (int i = 0; i < teams.Count / 2; i++)
            {
                teamList1.Add(teams[i]);
                teamList2.Add(teams[i + 8]);
            }

            for (int i = 0; i < 15; i++)
            {
                newTeamList1.Add(teamList1[0]);
                for (int j = 2; j < teamList1.Count; j++)
                {
                    newTeamList1.Add(teamList1[j]);
                }
                newTeamList1.Add(teamList2[7]);

                newTeamList2.Add(teamList1[1]);
                for (int j = 0; j < 7; j++)
                {
                    newTeamList2.Add(teamList2[j]);
                }

                MatchDay match = new MatchDay(teamList1, teamList2, i);
                matchDays.Add(match);

                teamList1 = new List<Team>(newTeamList1);
                teamList2 = new List<Team>(newTeamList2);

                newTeamList1.Clear();
                newTeamList2.Clear();

            }

            menuCompose.IsEnabled = false;
            menuScores.IsEnabled = true;
            menuRanking.IsEnabled = true;

        }

        private void MenuScores_Click(object sender, RoutedEventArgs e)
        {
            matchDaysListBox.ItemsSource = matchDays;
            matchDaysListBox.Items.Refresh();
        }

        private void MenuRanking_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            RankingWindow window = new RankingWindow(this,teams);
            window.ShowDialog();
        }

        private void MatchDaysListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            matchDay = (MatchDay)((ListBox)sender).SelectedItem;
            wedstrijdenListBox.Items.Clear();

            for (int i = 0; i < matchDay.TeamsList1.Count; i++)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Content = matchDay.TeamsList1[i] + " - " + matchDay.TeamsList2[i];
                listBoxItem.MouseDoubleClick += new MouseButtonEventHandler(ListBoxItem_dblClick);
                wedstrijdenListBox.Items.Add(listBoxItem);
            }
        }

        private void ListBoxItem_dblClick(object sender, RoutedEventArgs e)
        {
            Hide();
            matchDay = matchDays[matchDaysListBox.SelectedIndex];
            int index = wedstrijdenListBox.SelectedIndex;
            Team team1 = matchDay.TeamsList1[index];
            Team team2 = matchDays[matchDaysListBox.SelectedIndex].TeamsList2[wedstrijdenListBox.SelectedIndex];
            GameWindow game = new GameWindow(this, team1, team2, matchDay, index);
            game.ShowDialog();
        }
    }
}
