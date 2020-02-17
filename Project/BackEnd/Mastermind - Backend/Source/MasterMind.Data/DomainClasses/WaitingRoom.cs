using System;
using System.Collections.Generic;

namespace MasterMind.Data.DomainClasses
{
    public class WaitingRoom
    {
        public const int DefaultMaximumAmountOfUsers = 4;

        public WaitingRoom(string name, User creator, GameSettings gameSettings)
        {

            GameSettings = gameSettings;
            Name = name;
            CreatorUserId = creator.Id;
            Users = new List<User>
            {
                creator
            };
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public IList<User> Users { get; set; }

        public Guid CreatorUserId { get; }

        public GameSettings GameSettings { get; set; }

        public Guid GameId { get; set; }

        public virtual int MaximumAmountOfUsers => DefaultMaximumAmountOfUsers;

        public bool GameHasStarted => GameId != Guid.Empty;
    }
}