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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oef17_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BankAccount bank;
        public MainWindow()
        {
            InitializeComponent();
            bank = new BankAccount(0,"Satan","0123456789");
        }

        private void Action_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            if (Convert.ToString(((Button)sender).Content) == "Storten")
            {
                bank.Deposit(Convert.ToDouble(amountTextbox.Text));   
            }
            else if (Convert.ToString(((Button)sender).Content) == "Opnemen")
            {
                bank.Withdrawal(Convert.ToDouble(amountTextbox.Text));
            }
            else
            {
                MessageBox.Show("Huidig saldo: " + bank.Saldo);
            }
            }
            catch (InvalidActionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    




    }
}
