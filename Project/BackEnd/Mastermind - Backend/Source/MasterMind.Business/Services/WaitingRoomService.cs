using MasterMind.Business.Models;
using MasterMind.Data.DomainClasses;
using MasterMind.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterMind.Business.Services
{
    public class WaitingRoomService : IWaitingRoomService
    {
        private IWaitingRoomRepository waitingRoomRepository;
        private ICollection<WaitingRoom> waitingRooms;

        public WaitingRoomService(IWaitingRoomRepository waitingRoomRepository)
        {
            this.waitingRoomRepository = waitingRoomRepository;
            waitingRooms = new List<WaitingRoom>();
        }

        public ICollection<WaitingRoom> GetAllAvailableRooms()
        {
            waitingRooms = waitingRoomRepository.GetAll();

            ICollection<WaitingRoom> availableWaitingRooms = new List<WaitingRoom>();

            foreach (WaitingRoom waitingRoom in waitingRooms)
            {
                if (waitingRoom.Users.Count() < WaitingRoom.DefaultMaximumAmountOfUsers)
                {
                    availableWaitingRooms.Add(waitingRoom);
                }
            }
            return availableWaitingRooms;
        }

        public WaitingRoom CreateRoom(WaitingRoomCreationModel roomToCreate, User creator)
        {
            waitingRooms = waitingRoomRepository.GetAll();

            foreach (WaitingRoom room in waitingRooms)
            {
                if (room.Name == roomToCreate.Name)
                {
                    throw new ApplicationException();
                }
            }
            WaitingRoom waitingRoom = new WaitingRoom(roomToCreate.Name, creator, roomToCreate.GameSettings);
            waitingRoomRepository.Add(waitingRoom);
            return waitingRoom;
        }

        public WaitingRoom GetRoomById(Guid id)
        {
            WaitingRoom waitingRoom = waitingRoomRepository.GetById(id);
            return waitingRoom;
        }


        public bool TryJoinRoom(Guid roomId, User user, out string failureReason)
        {
            try
            {
                WaitingRoom waitingRoom = waitingRoomRepository.GetById(roomId);
                IList<Guid> ids = new List<Guid>();
                foreach (User u in waitingRoom.Users)
                {
                    ids.Add(u.Id);
                }

                if (ids.Contains(user.Id))
                {
                    failureReason = "User already in the room.";
                    return false;
                }
                else if (waitingRoom.Users.Count == WaitingRoom.DefaultMaximumAmountOfUsers)
                {
                    failureReason = "Lobby is full.";
                    return false;
                }
                else
                {
                    waitingRoom.Users.Add(user);
                    failureReason = "";
                    return true;
                }
            }
            catch (Exception)
            {
                failureReason = "Lobby does not exist.";
                return false;
            }
        }

        public bool TryLeaveRoom(Guid roomId, User user, out string failureReason)
        {
            try
            {
                WaitingRoom waitingRoom = waitingRoomRepository.GetById(roomId);
                IList<Guid> ids = new List<Guid>();
                foreach (User u in waitingRoom.Users)
                {
                    ids.Add(u.Id);
                }

                if (!(ids.Contains(user.Id)))
                {
                    failureReason = "User isn't linked to this lobby";
                    return false;
                }

                if (waitingRoom.CreatorUserId == user.Id)
                {
                    waitingRoomRepository.DeleteById(roomId);
                    failureReason = "";
                    return true;
                }
                else
                {
                    for (int i = 0; i < waitingRoom.Users.Count; i++)
                    {
                        if (waitingRoom.Users[i].Id == user.Id)
                        {
                            waitingRoom.Users.RemoveAt(i);
                        }
                    }
                    failureReason = "";
                    return true;
                }
            }
            catch (Exception)
            {
                failureReason = "Lobby does not exist.";
                return false;
            }

        }
    }
}