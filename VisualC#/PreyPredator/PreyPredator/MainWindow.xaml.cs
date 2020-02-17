using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace PreyPredator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<IPrey> _preys;
        private List<IPredator> _predators;
        private Random random;
        public MainWindow()
        {
            InitializeComponent();
            _preys = new List<IPrey>();
            _predators = new List<IPredator>();
            random = new Random();
            Start();

        }

        private void Start()
        {
            GenerateInsects(4, 100);
            ladyBugLabel.Content = _predators.Count();
            louseLabel.Content = _preys.Count();
            roundLabel.Content = 0;

        }

        private void RoundButton_Click(object sender, RoutedEventArgs e)
        {
            MoveInsects();
            Chase();

            //Verhongerende predators verwijderen:
            List<IPredator> tempList = new List<IPredator>(_predators);
            foreach (LadyBug predator in tempList)
            {
                if (predator.IsStarving)
                {
                    _predators.Remove(predator);
                    predator.StopDisplaying();
                }
            }

            BreedInsects();
            ladyBugLabel.Content = _predators.Count();
            louseLabel.Content = _preys.Count();
            roundLabel.Content = Convert.ToInt32(roundLabel.Content) + 1;

        }

        private void BreedInsects()
        {
            List<IPrey> tempPrey = new List<IPrey>(_preys);
            List<IPredator> tempPredator = new List<IPredator>(_predators);

            foreach (IPrey prey in tempPrey)
            {
                IPrey newPrey = prey.Breed();
                if (newPrey != null)
                {
                    ((Insect)newPrey).DisplayOn(worldCanvas, Colors.Green);
                    _preys.Add(newPrey);
                }
            }

            foreach (IPredator predator in tempPredator)
            {
                IPredator newPredator = predator.Breed();
                if (newPredator != null)
                {
                    ((Insect)newPredator).DisplayOn(worldCanvas, Colors.Red);
                    _predators.Add(newPredator);
                }
            }

        }

        private void MoveInsects()
        {
            foreach (LadyBug predator in _predators)
            {
                int getal = random.Next(1, 5);
                switch (getal)
                {
                    case 1:
                        predator.MoveDown();
                        break;
                    case 2:
                        predator.MoveLeft();
                        break;
                    case 3:
                        predator.MoveUp();
                        break;
                    case 4:
                        predator.MoveRight();
                        break;
                }
                predator.Age++;
                predator.UpdateDisplay();
            }

            foreach (Louse prey in _preys)
            {
                int getal = random.Next(1, 5);
                switch (getal)
                {
                    case 1:
                        prey.MoveDown();
                        break;
                    case 2:
                        prey.MoveLeft();
                        break;
                    case 3:
                        prey.MoveUp();
                        break;
                    case 4:
                        prey.MoveRight();
                        break;
                }
                prey.Age++;
                prey.UpdateDisplay();
            }
        }

        private void Chase()
        {
            foreach (LadyBug predator in _predators)
            {
                predator.Eat(predator.Chase(_preys));
            }
        }

        private void GenerateInsects(int predators, int preys)
        {
            
            for (int i = 0; i < predators; i++)
            {
                int x = random.Next(0, 16);
                int y = random.Next(0, 16);
                _predators.Add(new LadyBug(x, y));
                ((LadyBug)_predators[i]).DisplayOn(worldCanvas, Colors.Red);
            }

            for (int i = 0; i < preys; i++)
            {
                int x = random.Next(0, 16);
                int y = random.Next(0, 16);
                _preys.Add(new Louse(x, y));
                ((Louse)_preys[i]).DisplayOn(worldCanvas, Colors.Green);
            }
        }
    }
}
