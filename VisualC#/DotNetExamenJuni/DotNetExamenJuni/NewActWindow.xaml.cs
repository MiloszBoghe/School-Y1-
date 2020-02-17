using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DotNetExamenJuni
{
    /// <summary>
    /// Interaction logic for NewActWindow.xaml
    /// </summary>
    public partial class NewActWindow : Window
    {
        List<string> performancesStrings;
        List<Performer> performanceList;
        ListBox performListBox;
        public NewActWindow(List<Performer> performances, List<string> lines, ListBox listBox)
        {
            InitializeComponent();
            performancesStrings = lines;
            performanceList = performances;
            performListBox = listBox;
        }

        private void BandRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            if (typeCountLabel != null)
            {
                typeCountLabel.Content = "Members";
            }

        }

        private void SoloRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (typeCountLabel != null)
            {
                typeCountLabel.Content = "Type of artist";
            }

        }

        private void AddActButton_Click(object sender, RoutedEventArgs e)
        {
            string line = "";
            try
            {
                CheckInput();

                string name = nameTextBox.Text;
                int number = Convert.ToInt32(numberTextBox.Text);
                string startTime = startHourTextBox.Text;
                string endTime = endHourTextBox.Text;
                int[] techSupplies = Array.ConvertAll(technicalTextBox.Text.Split(' '), int.Parse);
                string[] rider = riderTextBox.Text.Split(',');

                if (Convert.ToString(typeCountLabel.Content) == "Members")
                {
                    int members = Convert.ToInt32(typeCountTextBox.Text);
                    line += $"B, {members}, {name}, {number}, {startTime}, {endTime}, {techSupplies[0]}, {techSupplies[1]}";
                    for (int i = 0; i < rider.Length; i++)
                    {
                        line += $", {rider[i]}";
                    }

                    Band band = new Band(name, members, number, startTime, endTime, techSupplies, rider);

                    //aan de lijst met de strings toevoegen voor te saven en aan de lijst met alle performances:
                    performancesStrings.Add(line);
                    performanceList.Add(band);

                }
                else
                {
                    string type = typeCountTextBox.Text;
                    line += $"S, {type}, {name}, {number}, {startTime}, {endTime}, {techSupplies[0]}, {techSupplies[1]}";
                    for (int i = 0; i < rider.Length; i++)
                    {
                        line += $", {rider[i]}";
                    }
                    Solo solo = new Solo(name, type, number, startTime, endTime, techSupplies, rider);
                    performancesStrings.Add(line);
                    performanceList.Add(solo);
                }

                //sorteren:
                performanceList = performanceList.OrderBy(performer => performer.StartTime).ToList();
                performListBox.ItemsSource = performanceList;
                performListBox.Items.Refresh();

            }
            catch (FestivalException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        private void CheckInput()
        {
            if (nameTextBox.Text == "" ||
                typeCountTextBox.Text == "" ||
                numberTextBox.Text == "" ||
                startHourTextBox.Text == "" ||
                endHourTextBox.Text == "" ||
                technicalTextBox.Text == "" ||
                riderTextBox.Text == "")
            {
                throw new FestivalException("Gelieve alle velden in te vullen!");
            }
        }
    }
}
