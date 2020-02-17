using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer
{
    public enum PlayerFunction
    {
        Goalkeeper = 'G',
        Defender = 'D',
        Midfielder = 'M',
        Forward = 'F'
    }

    public class Player
    {
        private int _id;
        private int _number;
        private string _surname;
        private PlayerFunction _function;
        private string _name;

        public Player(int id, int number, string surname, string name, char function)
        {
            Id = id;
            Number = number;
            Surname = surname;
            Name = name;
            Function = (PlayerFunction) function;
        }

        public int Id { get => _id; set => _id = value; }
        public int Number { get => _number; set => _number = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public PlayerFunction Function { get => _function; set => _function = value; }
        public string Name { get => _name; set => _name = value; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }
}
