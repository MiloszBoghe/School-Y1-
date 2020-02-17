using MasterMind.Data.DomainClasses;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace MasterMind.Data.Repositories
{
    public class InMemoryWaitingRoomRepository : IWaitingRoomRepository
    {
        private ConcurrentDictionary<Guid, WaitingRoom> _waitingRoomDictionary;

        public InMemoryWaitingRoomRepository()
        {
            //Initialize dictionary where all waitingrooms will be saved
            _waitingRoomDictionary = new ConcurrentDictionary<Guid, WaitingRoom>();
        }

        public WaitingRoom Add(WaitingRoom newWaitingRoom)
        {
            //Giving each waitingroom that comes through an ID and adding it to the dictionary.
            newWaitingRoom.Id = Guid.NewGuid();
            _waitingRoomDictionary.TryAdd(newWaitingRoom.Id, newWaitingRoom);
            return newWaitingRoom;
        }

        public WaitingRoom GetById(Guid id)
        {
            //Returns a waitingroom when there is one in the dictionary with the same ID that's given.
            //if there is none it throws a dataNotFoundException().
            if (_waitingRoomDictionary.TryGetValue(id, out WaitingRoom waitingRoom))
            {
                return waitingRoom;
            }
            else
            {
                throw new DataNotFoundException();
            }
        }

        public ICollection<WaitingRoom> GetAll()
        {
            //Puts all waitingrooms from the dictionary in a collection and return that collection.
            ICollection<WaitingRoom> waitingRooms = new List<WaitingRoom>();

            foreach (var waitingRoom in _waitingRoomDictionary)
            {
                waitingRooms.Add(waitingRoom.Value);
            }
            return waitingRooms;

        }

        public void DeleteById(Guid id)
        {
            //Tries to remove the waitingroom with the given ID out of the dictionary.
            _waitingRoomDictionary.TryRemove(id, out WaitingRoom room);
        }
    }
}