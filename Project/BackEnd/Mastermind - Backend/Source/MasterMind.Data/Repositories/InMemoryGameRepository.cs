using MasterMind.Data.DomainClasses;
using System;
using System.Collections.Concurrent;

namespace MasterMind.Data.Repositories
{
    public class InMemoryGameRepository : IGameRepository
    {
        //Dictionary aanmaken voor data op te slagen
        private ConcurrentDictionary<Guid, IGame> _gameDictionary;

        public InMemoryGameRepository()
        {
            //Dictionary initialiseren
            _gameDictionary = new ConcurrentDictionary<Guid, IGame>(); ;
        }

        public IGame Add(IGame newGame)
        {
            //Id toekennen aan de gegeven game en opslaan in de dictionary
            newGame.Id = Guid.NewGuid();
            _gameDictionary.TryAdd(newGame.Id, newGame);
            return newGame;
        }

        public IGame GetById(Guid id)
        {
            //Game zoeken in de dictionary a.d.h.v. het ID
            if (_gameDictionary.TryGetValue(id, out IGame game))
            {
                return game;
            }
            else
            {
                throw new DataNotFoundException();
            }
        }

        public void DeleteById(Guid id)
        {
            //Verwijderd game a.d.h.v. het id dat gegeven is
            _gameDictionary.TryRemove(id, out IGame game);
        }
    }
}