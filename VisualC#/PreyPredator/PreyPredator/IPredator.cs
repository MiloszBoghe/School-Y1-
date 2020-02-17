using System.Collections.Generic;

namespace PreyPredator
{
    public interface IPredator
    {

        List<IPrey> Chase(List<IPrey> preys);
        void Eat(List<IPrey> preys);
        double CalculateDistanceFrom(IPrey prey);
        IPredator Breed();
        bool IsStarving
        {
            get;
        }

    }
}
