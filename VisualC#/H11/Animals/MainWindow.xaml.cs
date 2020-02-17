using System.Windows;

namespace Animals
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Animal animal2, animal3;
           // animal1 = new Animal("woefie");
            animal2 = new Dog("Pluto");
            animal3 = new SmallDog("Fifi");
            //PrintAnimal(animal1);
            PrintAnimal(animal2);
            PrintAnimal(animal3);

        }
        
        private void PrintAnimal(Animal animal)
        {
            string line = $"animal ({animal.Name}) sounds as: {animal.Sound()}";
            //MessageBox.Show(line);
            MessageBox.Show(animal.ToString());
        }
    }
}
