using System.Collections.Generic;

namespace CyberspaceInvader
{
    public class LaserCollection
    {
        private List<Laser> lasers = new List<Laser>();

        public void Add(Laser laser)
        {
            lasers.Add(laser);
        }

        public void Remove(Laser laser)
        {
            lasers.Remove(laser);
        }

        public void Move()
        {
            for (var index = 0; index < lasers.Count; index++)
            {
                Laser laser = lasers[index];
                laser.Move();
            }
        }

        public void CheckHit(Alien alien)
        {
            for (var index = 0; index < lasers.Count; index++)
            {
                Laser laser = lasers[index];
                laser.CheckHit(alien);
            }
        }
    }
}
