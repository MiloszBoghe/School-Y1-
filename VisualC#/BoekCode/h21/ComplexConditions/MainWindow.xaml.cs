using System;
using System.Windows;

namespace ComplexConditions
{
    enum SearchState
    {
        StillSearching = 0,
        Found = 1,
        NotFound = 2
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Foo1()
        {
            const int MaximumSize = 100;
            int[] table = new int[MaximumSize];

            int wanted = Convert.ToInt32(wantedTextBox.Text);
            int index = 0;
            while ((index < MaximumSize) && (table[index] != wanted))
            {
                index++;
            }

            if (table[index] == wanted)
            {
                resultTextBox.Text = "Found";
            }
            else
            {
                resultTextBox.Text = "Not found";
            }
        }

        private void Foo2()
        {
            const int MaximumSize = 100;
            int[] table = new int[MaximumSize];

            int wanted = Convert.ToInt32(wantedTextBox.Text);

            const int StillSearching = 0;
            const int Found = 1;
            const int NotFound = 2;
            int state = StillSearching;

            int index = 0;
            while (state == StillSearching)
            {
                if (table[index] == wanted)
                {
                    state = Found;
                }
                else if (index + 1 == MaximumSize)
                {
                    state = NotFound;
                }
                index++;
            }

            if (state == Found)
            {
                resultTextBox.Text = "Found";
            }
            else
            {
                resultTextBox.Text = "Not found";
            }
        }

        private void Foo3()
        {
            const int MaximumSize = 100;
            int[] table = new int[MaximumSize];

            int wanted = Convert.ToInt32(wantedTextBox.Text);

            SearchState state = SearchState.StillSearching;
            
            int index = 0;
            while (state == SearchState.StillSearching)
            {
                if (table[index] == wanted)
                {
                    state = SearchState.Found;
                }
                else if (index + 1 == MaximumSize)
                {
                    state = SearchState.NotFound;
                }
                index++;
            }

            if (state == SearchState.Found)
            {
                resultTextBox.Text = "Found";
            }
            else
            {
                resultTextBox.Text = "Not found";
            }
        }

        private void ifs1()
        {
            int number1 = 0, number2 = 0, number3 = 0;
            int largest;

            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    largest = number1;
                }
                else
                {
                    largest = number3;
                }
            }
            else
            {
                if (number2 > number3)
                {
                    largest = number2;
                }
                else
                {
                    largest = number3;
                }
            }
        }

        private void ifs2()
        {
            int number1 = 0, number2 = 0, number3 = 0;
            int largest;

            if ((number1 >= number2) && (number1 >= number3))
            {
                largest = number1;
            }
            else if ((number2 >= number1) && (number2 >= number3))
            {
                largest = number2;
            }
            else
            {
                largest = number3;
            }
        }
    }
}
