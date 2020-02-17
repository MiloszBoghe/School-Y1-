using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer
{

    public class Team
    {
        private int _id;
        private string _name;
        private string _location;
        private int _points;
        private List<Player> _players;

        public Team(int id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
            Players = new List<Player>();
            Points = 0;
        }
        public override string ToString()
        {
            return Name;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Location { get => _location; set => _location = value; }
        public List<Player> Players { get => _players; set => _players = value; }
        public int Points { get => _points; set => _points = value; }
    }
}
