using System;
using System.Windows;

namespace AskFrasier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void askButton_Click(object sender, RoutedEventArgs e)
        {
            replyLabel.Content = GetReply(questionTextBox.Text);
        }

        public string GetReply(string question)
        {
            Random random = new Random();
            int variation = random.Next(0, 3);
            string reply;
            
            if (variation == 0)
            {
                reply = TransformQuestion(question);
            }
            else if (variation == 1)
            {
                reply = "Why do you feel that?";
            }
            else
            {
                reply = "Please be frank!";
            }
            return reply;
        }

        public string TransformQuestion(string question)
        {
            string tempReply;
            question = " " + question + " ";
            if (question.IndexOf(" I ") >= 0)
            {
                tempReply = Change(question, " I ", " you ");
                tempReply = Change(tempReply, " am ", " are ");
                return Change(tempReply, " my ", " your ") + " - why?";
            }
            else if (question.IndexOf(" no ") >= 0)
            {
                return "'no'? - that is negative! Please explain.";
            }
            else
            {
                return "'" + question + "'  - Please explain.";
            }
        }

        private string Change(string original, string fromText, string toText)
        {

            string leftBit, rightBit;
            int startSearch = 0;
            int place = original.IndexOf(fromText);

            if (fromText.Length != 0)
            {
                while (place >= startSearch)
                {
                    leftBit = original.Substring(0, place);
                    rightBit = original.Substring(place + fromText.Length,
                                            original.Length - place - fromText.Length);
                    original = leftBit + toText + rightBit;
                    startSearch = leftBit.Length + toText.Length;
                    place = original.IndexOf(fromText);
                }
            }
            return original;
        }
    }
}
