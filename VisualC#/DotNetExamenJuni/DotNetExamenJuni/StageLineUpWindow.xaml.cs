using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DotNetExamenJuni
{
    /// <summary>
    /// Interaction logic for StageLineUpWindow.xaml
    /// </summary>
    public partial class StageLineUpWindow : Window
    {
        List<string> lines;
        List<Performer> performances;
        string myFile;
        public StageLineUpWindow()
        {
            InitializeComponent();
            lines = new List<string>();
            performances = new List<Performer>();
        }

        public void DisableEvents()
        {
            removeButton.Click -= RemoveButton_Click;
            addButton.Click -= AddButton_Click;
        }

        private void EnableEvents(object sender, System.ComponentModel.CancelEventArgs e)
        {
            removeButton.Click += RemoveButton_Click;
            addButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DisableEvents();
            NewActWindow window = new NewActWindow(performances, lines, performListBox);
            window.Show();
            window.Closing += EnableEvents;
        }


        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            //Verwijder de lijn uit de lijst van lijnen
            try
            {
                lines.RemoveAt(performListBox.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                System.Windows.MessageBox.Show("Please select an item.");
            }
            //TODO:hier het juist item verwijderen uit de lijst.
            performances.RemoveAt(performListBox.SelectedIndex);
            //tip om de getoonde lijst te updaten.
            performListBox.Items.Refresh();
        }

        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            //Dialoogvenster openen
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.InitialDirectory = startdir;
            openFileDialog.Filter = "Text Files | *.txt| All files | *.*";
            performances.Clear();
            performListBox.Items.Refresh();

            DialogResult result = openFileDialog.ShowDialog();
            //Als je op ok drukt:
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //lezer aanmaken , bestand lezen, etc.
                myFile = openFileDialog.FileName;
                StreamReader inputStream = new StreamReader(myFile,System.Text.Encoding.Default);
                try
                {
                    string line = inputStream.ReadLine();
                    string stageName = myFile.Replace(".txt", "").Split('\\')[4];
                    stageTextBlock.Text = stageName;
                    while (line != null)
                    {
                        //Voeg alle lijnen toe aan een lijst
                        lines.Add(line);
                        //zet de ingelezen lijn in een array , gesplitst op de komma, spaties verwijderd.
                        string[] lineArray = line.Split(',');

                        //alle parameters uit de array halen:
                        string name = lineArray[2].Trim();
                        int reservationNumber = Convert.ToInt32(lineArray[3]);

                        string startTime = lineArray[4];
                        string endTime = lineArray[5];

                        int[] techSupplies = new int[2] { Convert.ToInt32(lineArray[6].Trim()), Convert.ToInt32(lineArray[7].Trim()) };


                        //Rider list maken:
                        IList<string> riderList = new List<string>();
                        for (int index = 8; index < lineArray.Length; index++)
                        {
                            riderList.Add(lineArray[index].Trim());
                        }
                        if (lineArray[0] == "B")
                        {
                            int members = Convert.ToInt32(lineArray[1]);
                            Band band = new Band(name, members, reservationNumber, startTime, endTime, techSupplies, riderList);
                            performances.Add(band);
                        }
                        else
                        {
                            string type = lineArray[1];
                            Solo solo = new Solo(name, type, reservationNumber, startTime, endTime, techSupplies, riderList);
                            performances.Add(solo);
                        }
                        line = inputStream.ReadLine();
                    }
                    removeButton.IsEnabled = true;
                    addButton.IsEnabled = true;
                    performListBox.ItemsSource = performances;
                    performListBox.Items.Refresh();
                }
                catch (FileNotFoundException)
                {
                    System.Windows.MessageBox.Show("Bestand niet gevonden!");
                }
                finally
                {
                    inputStream.Close();
                }
            }
            else if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                Close();
            }
        }

        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            //StreamWriter
            StreamWriter outputStream = new StreamWriter(myFile);

            foreach (string line in lines)
            {
                outputStream.WriteLine(line);
            }
            outputStream.Close();
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
