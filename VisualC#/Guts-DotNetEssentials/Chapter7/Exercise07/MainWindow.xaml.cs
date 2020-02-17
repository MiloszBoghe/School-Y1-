using System;
using System.Windows;
using System.Windows.Controls;

namespace Exercise07
{
    public partial class MainWindow : Window
    {
        private string _previousOperator = "";
        private int _previousNumber = 0;
        private bool _previousBoolOperator = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (displayTextBlock.Text.Equals("0"))
            {
                displayTextBlock.Text = displayTextBlock.Text.Substring(1);
            }
            if (_previousBoolOperator)
            {
                displayTextBlock.Text = "";
            }
            displayTextBlock.Text += ((Button)sender).Content;  // Object sender si verantwoordelijk voor het terechtkomen in de event -> als we de sender zijn 
            _previousBoolOperator = false;
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            if (_previousOperator == "")
            {
                _previousOperator = Convert.ToString(((Button)sender).Content);  //Altijd leeg bij eerste 
                _previousNumber = Convert.ToInt32(displayTextBlock.Text);
            }
            else
            {
                switch (_previousOperator)
                {
                    case "+":
                        displayTextBlock.Text = Convert.ToString(_previousNumber + Convert.ToInt32(displayTextBlock.Text));  // De werkelijke som
                        _previousOperator = Convert.ToString(((Button)sender).Content);  // Zet de + waarop men geklikt heeft in _previousOperator
                        _previousNumber = Convert.ToInt32(displayTextBlock.Text);        // Zet uitkomst in previousGetal voor een volgende berekening
                        break;
                    case "-":
                        displayTextBlock.Text = Convert.ToString(_previousNumber - Convert.ToInt32(displayTextBlock.Text)); // De werkelijke aftrekking
                        _previousOperator = Convert.ToString(((Button)sender).Content);  // Zet de - waarop men geklikt heeft in _previousOperator
                        _previousNumber = Convert.ToInt32(displayTextBlock.Text);        // Zet uitkomst in previousGetal voor een volgende berekening
                        break;
                }
            }
            if (Convert.ToString(((Button)sender).Content) == "=")
            {
                _previousOperator = "";          // vorige operator wordt gecleared
                _previousNumber = 0;             // vorig number wordt gecleared
                _previousBoolOperator = false;
            }
            _previousBoolOperator = true;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            _previousOperator = "";          // vorige operator wordt gecleared
            _previousNumber = 0;             // vorig number wordt gecleared
            displayTextBlock.Text = "0";    // cleared tekst
            _previousBoolOperator = false;
        }
    }
}