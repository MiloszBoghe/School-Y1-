using MasterMind.Data.DomainClasses;
using System;
using System.Linq;
using MasterMind.Data.Repositories;
using System.Collections.Generic;

namespace MasterMind.Business.Services
{
    public class GameService : IGameService
    {
        private IWaitingRoomService _waitingRoomService;
        private IGameRepository _gameRepository;

        public GameService(IWaitingRoomService waitingRoomService, IGameRepository gameRepository)
        {
            _waitingRoomService = waitingRoomService;
            _gameRepository = gameRepository;

        }



        public IGame StartGameForRoom(Guid roomId)
        {
            WaitingRoom waitingRoom = _waitingRoomService.GetRoomById(roomId);

            if (waitingRoom.Users.Count < 2)
            {
                throw new ApplicationException();
            }

            IList<IPlayer> players = new List<IPlayer>();

            for (int i = 0; i < waitingRoom.Users.Count; i++)
            {
                players.Add(waitingRoom.Users[i]);
            }

            IGame game = new Game(waitingRoom.GameSettings, players);
            _gameRepository.Add(game);

            waitingRoom.GameId = game.Id;

            return game;




        }

        public IGame GetGameById(Guid id)
        {

            IGame game = _gameRepository.GetById(id);
            return game;
        }

        public CanGuessResult CanGuessCode(Guid gameId, IPlayer player, int roundNumber)
        {
            IGame game = GetGameById(gameId);
            return game.CanGuessCode(player, roundNumber);
        }

        public GuessResult GuessCode(Guid gameId, string[] colors, IPlayer player)
        {
            IGame game = GetGameById(gameId);
            GuessResult result = new GuessResult(colors);
            if (game.CanGuessCode(player, game.CurrentRound) == CanGuessResult.Ok)
            {
                return game.GuessCode(colors, player);
            }
            else
            {
                throw new ApplicationException("Player can't do guess.");
            }
        }

        public GameStatus GetGameStatus(Guid gameId)
        {
            IGame currentGame = GetGameById(gameId);

            return currentGame.GetStatus();

        }
    }
}