using System;
using System.Collections.Generic;


namespace PreyPredator
{
    public class LadyBug : Insect, IPredator
    {
        private int _hasNotEaten;
        public LadyBug(int x, int y) : base(x, y)
        {

        }

        public bool IsStarving { get; set; }

        public IPredator Breed()
        {
            if (Age % 6 == 0)
            {
                return new LadyBug(Position.X, Position.Y);
            }
            return null;
        }

        public double CalculateDistanceFrom(IPrey prey)
        {
            return Math.Sqrt(Math.Pow(Position.X - prey.Position.X, 2) + Math.Pow(Position.Y - prey.Position.Y, 2));
        }

        public List<IPrey> Chase(List<IPrey> preys)
        {
            List<IPrey> _preysToBeEaten = new List<IPrey>();
            List<IPrey> tempPrey = new List<IPrey>(preys);
            foreach (Louse prey in tempPrey)
            {
                if (CalculateDistanceFrom(prey) <= 2 && _preysToBeEaten.Count <= 20)
                {
                    preys.Remove(prey);
                    prey.StopDisplaying();
                    _preysToBeEaten.Add(prey);
                }
            }
            return _preysToBeEaten;
        }

        public void Eat(List<IPrey> preys)
        {
            if (preys.Count > 0)
            {
                IsStarving = false;
                _hasNotEaten = 0;
            }
            else
            {
                _hasNotEaten++;
            }
            if (_hasNotEaten == 3)
            {
                IsStarving = true;
            }
            preys.Clear();
        }
    }
}
