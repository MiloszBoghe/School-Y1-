namespace PreyPredator
{
    class Louse : Insect, IPrey
    {
        public Louse(int x, int y) : base(x, y)
        {

        }

        public IPrey Breed()
        {
            if (Age % 5 == 0)
            {
                return new Louse(Position.X,Position.Y);
            }
            return null;
        }
    }
}
