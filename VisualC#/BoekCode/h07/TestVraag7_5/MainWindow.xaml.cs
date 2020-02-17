using System;
using System.Windows;

namespace TestVraag7_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int salary = 0;
        private double tax = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            showSalary();
            showTax();
            salarySlider.ValueChanged += salarySlider_ValueChanged;
        }

        private void salarySlider_ValueChanged(object sender,
                                 RoutedPropertyChangedEventArgs<double> e)
        {
            showSalary();
            showTax();
        }

        private void showSalary()
        {
            salary = Convert.ToInt32(salarySlider.Value);
            salaryLabel.Content = $"{0:salary}";
        }

        private void showTax()
        {
            if (salary <= 10000)
            {
                tax = 0;
            }
            if ((salary > 10000) && (salary <= 50000))
            {
                tax = (salary - 10000) * 0.2;
            }
            if (salary > 50000)
            {
                tax = 8000 + ((salary - 50000) * 0.9);
            }

            belastingLabel.Content = $"{0:tax}";
        }
    }
}
