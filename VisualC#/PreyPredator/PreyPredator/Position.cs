namespace PreyPredator
{
    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }


        public void MoveUp()
        {
            Y = Y == 0 ? Y + 1 : Y - 1;
        }
        public void MoveDown()
        {
            Y = Y == 15 ? Y - 1 : Y + 1;
        }
        public void MoveLeft()
        {
            X = X == 0 ? X + 1 : X - 1;
        }
        public void MoveRight()
        {
            X = X == 15 ? X - 1 : X + 1;
        }

    }
}
