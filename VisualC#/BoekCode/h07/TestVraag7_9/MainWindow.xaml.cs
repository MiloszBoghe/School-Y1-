using System;
using System.Windows;

namespace TestVraag7_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            resultLabel.Content = ToSuit(Convert.ToInt32(slider1.Value));
            slider1.ValueChanged += slider1_ValueChanged;
        }

        void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            resultLabel.Content = ToSuit(Convert.ToInt32(slider1.Value));
        }

        private string ToSuit(int suitNumber)
        {
            string suit = "";

            switch (suitNumber)
            {
                case 1:
                    suit = "ruiten";
                    break;
                case 2:
                    suit = "harten";
                    break;
                case 3:
                    suit = "klaveren";
                    break;
                case 4:
                    suit = "schoppen";
                    break;
            }
            return suit;
        }
    }
}
