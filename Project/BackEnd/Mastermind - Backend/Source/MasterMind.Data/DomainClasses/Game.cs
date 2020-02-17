using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterMind.Data.DomainClasses
{
    public class Game : IGame
    {
        private Random _codeGuesser = new Random();
        private string[] _codeToGuess;
        public Guid Id { get; set; }
        public GameSettings Settings { get; set; }
        public IList<IPlayer> Players { get; }
        public string[] PossibleColors { get; set; }
        public int CurrentRound { get; private set; }
        private GameStatus status;
        public Dictionary<Guid, IList<GuessResult>> PlayerHistory; 


        /// <summary>
        /// Constructs a Game object and generates a code to guess.
        /// </summary>
        public Game(GameSettings settings, IList<IPlayer> players)
        {
            //Initialize a game object => filling in all the properties.
            Settings = settings;
            Players = players;
            CurrentRound = 1;
            Id = Guid.NewGuid();
            PlayerHistory = new Dictionary<Guid, IList<GuessResult>>();
            foreach(IPlayer p in Players)
            {
                IList<GuessResult> guesses = new List<GuessResult>();
                PlayerHistory.Add(p.Id,guesses);
            }
            PossibleColors = new string[] { "000000", "FFFFFF", "FF0000", "FFFF00", "FFA500", "008000", "0000FF", "800080" };
            settings.AmountOfColors = PossibleColors.Length;
            _codeToGuess = new string[settings.CodeLength];
            status = new GameStatus()
            {
                CurrentRoundNumber = 1,
                GameOver = false,
                RoundWinners = new IPlayer[Players.Count]
            };
           

            //Generate a colorCode in the array _codeToGuess.

            int counter = 0;
            IList<string> _possibleColorsList = PossibleColors.ToList();

            while (counter < Settings.CodeLength)
            {
                string color = _possibleColorsList[_codeGuesser.Next(_possibleColorsList.Count)];
                _codeToGuess[counter] = color;
                if (!Settings.DuplicateColorsAllowed)
                {
                    _possibleColorsList.Remove(color);
                }
                counter++;
            }
        }

        /// <summary>
        /// Checks if it is allowed for a player to do a guess for a certain round.
        /// </summary>
        /// <param name="player">
        /// Player that will be making a guess.</param>
        /// <param name="roundNumber">
        /// The round the game is currently on.</param>
        /// <returns></returns>
        public CanGuessResult CanGuessCode(IPlayer player, int roundNumber)
        {


            if (CurrentRound < roundNumber)
            {
                return CanGuessResult.RoundNotStarted;
            }
            else if (PlayerHistory[player.Id].Count == Settings.MaximumAmountOfGuesses)
            {
                return CanGuessResult.MaximumReached;
            }

            else if (CurrentRound > roundNumber)
            {
                return CanGuessResult.NotAllowedDueToGameStatus;
            }
            else
            {
                foreach (IPlayer p in Players)
                {
                    if (PlayerHistory[p.Id].Count < PlayerHistory[player.Id].Count && p != player)
                    {
                        return CanGuessResult.MustWaitOnOthers;
                    }
                }

                return CanGuessResult.Ok;
            }
        }

        /// <summary>
        /// Verifies and registers a guess for a player in the PlayerHistory dictionary.
        /// </summary>
        /// <param name="colors">
        /// Colors that the player guessed.</param>
        /// <param name="player">
        /// Player that made a guess.</param>
        /// <returns></returns>
        public GuessResult GuessCode(string[] colors, IPlayer player)
        {
            GuessResult guess = new GuessResult(colors);
            guess.Verify(_codeToGuess);
            //player.PlayerHistory.Add(Guid.NewGuid(), guess);
            PlayerHistory[player.Id].Add(guess);
            
            if (CurrentRound < Settings.AmountOfRounds)
            {
                if (guess.CorrectColorAndPositionAmount == colors.Length || PlayerHistory[player.Id].Count == Settings.MaximumAmountOfGuesses)
                {
                    CurrentRound++;
                    status.RoundWinners.Append(player);
                }
            }
            else
            {
                if (guess.CorrectColorAndPositionAmount == colors.Length)
                {
                    status.FinalWinner = player;
                    status.GameOver = true;
                }
            }
            return guess;
        }

        /// <summary>
        /// Determines the winner of each round that is over.
        /// Determines the final winner if all rounds are played.
        /// </summary>
        public GameStatus GetStatus()
        {
            return status;
        }
    }
}