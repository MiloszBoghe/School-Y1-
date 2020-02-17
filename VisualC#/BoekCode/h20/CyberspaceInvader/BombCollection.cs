using System.Collections.Generic;

namespace CyberspaceInvader
{
    public class BombCollection
    {
        private List<Bomb> bombs = new List<Bomb>();

        public void Add(Bomb bomb)
        {
            bombs.Add(bomb);
        }

        public void Remove(Bomb bomb)
        {
            bombs.Remove(bomb);
        }

        public void Move()
        {
            for (var index = 0; index < bombs.Count; index++)
            {
                Bomb bomb = bombs[index];
                bomb.Move();
            }
        }

        public void CheckHit(Player player)
        {
            for (var index = 0; index < bombs.Count; index++)
            {
                Bomb bomb = bombs[index];
                bomb.CheckHit(player);
            }
        }
    }
}
